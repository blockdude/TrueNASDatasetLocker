using JsonRpcClient.Clients;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Nodes;

namespace TrueNASLocker
{
    public record DatasetItem
    {
        public required string id;
        public required string type;
        public required string name;
        public required string pool;
        public required bool encrypted;
        public required string? encryption_root;
        public required bool? key_loaded;
        public required object[] children;
        public required object user_properties;
        public required bool locked;
        public required object volsize;
        public required object volblocksize;
        public required object key_format;
        public required object encryption_algorithm;
        public required object used;
        public required object usedbychildren;
        public required object usedbydataset;
        public required object usedbyrefreservation;
        public required object usedbysnapshots;
        public required object available;
        public required object pbkdf2iters;

        public string GetUsed()
        {
            JsonNode? node = JsonNode.Parse(used.ToString());
            if (node == null)
                return "";
            return (node["value"] ?? "").ToString();
        }
    }

    public class Client : RpcWsClient, IDisposable
    {
        private bool _connected = false;
        private bool _loggedin = false;

        public bool Connected { get => _connected; }
        public bool Loggedin { get => _loggedin; }

        public static Client? Connect(string uri, int timeout)
        {
            Client client = Task.Run(() => new Client(uri, timeout)).Result;
            return client.Connected ? client : null;
        }

        public static Client? Connect(string uri)
        {
            return Connect(uri, 5000);
        }

        public void Dispose()
        {
            Task.Run(() => Close());
        }

        private Client(string uri, int timeout) : base(uri)
        {
            Task connect = Connect();

            try
            {
                connect.Wait(timeout);
            }
            catch (AggregateException ex)
            {
                Debug.WriteLine(ex);
            }

            _connected = connect.Status == TaskStatus.RanToCompletion;
        }

        public bool Login(string username, string password)
        {
            if (!_connected || _loggedin)
                return false;

            object? result = Task.Run(() => Call("auth.login_ex", new List<Dictionary<string, string>> { new Dictionary<string, string> {
                { "mechanism", "PASSWORD_PLAIN" },
                { "username", username },
                { "password", password }
            } })).Result;

            if (result == null)
                return false;

            JsonNode? json = JsonNode.Parse(result.ToString());
            bool status = json?["response_type"]?.ToString() == "SUCCESS";
            _loggedin = status;
            return status;
        }

        public bool Logout()
        {
            if (!_connected || !_loggedin)
                return false;

            object? result = Task.Run(() => Call("auth.logout", new List<string> { })).Result;

            if (result == null)
                return false;

            bool status = (bool)result;
            _loggedin = !status;
            return status;
        }

        private List<int> JobWait(List<int> jobIds)
        {
            List<int> currentJobs = new List<int>(jobIds);
            List<int> failedJobs = new List<int>();

            // update this so it does not potentially run forever
            while (currentJobs.Count > 0)
            {
                // create filter from currentJobs
                List<object> idFilter = new List<object>();
                currentJobs.ForEach(id => idFilter.Add(new List<object> { "id", "=", id }));
                List<object> filter = new List<object> { new List<object> { "OR", idFilter } };
                object? jobsResponse = Task.Run(() => Call("core.get_jobs", new List<object> { filter })).Result;
                Debug.WriteLine(jobsResponse);

                if (jobsResponse == null)
                {
                    failedJobs.AddRange(currentJobs);
                    break;
                }

                JsonNode? jobList = JsonNode.Parse(jobsResponse.ToString());
                if (jobList == null)
                {
                    failedJobs.AddRange(currentJobs);
                    break;
                }

                foreach (JsonNode? job in jobList.AsArray())
                {
                    if (job == null)
                        continue;

                    string? state = job["state"]?.ToString();
                    string? jobId = job["id"]?.ToString();
                    string? result = job["result"]?.ToString();

                    if (state == null || jobId == null)
                        continue;

                    if (state != "RUNNING" && state != "WAITING")
                    {
                        //Debug.WriteLine("Job " + jobId + " result " + result);
                        currentJobs.Remove(int.Parse(jobId));

                        if (state != "SUCCESS")
                            failedJobs.Add(int.Parse(jobId));
                    }
                }

                Thread.Sleep(100);
            }

            return failedJobs;
        }

        private List<string> RunDatasetJob(List<string> datasets, Func<string, object?> callJob)
        {
            List<string> failed = new List<string>();
            if (!_connected || !_loggedin)
            {
                failed.AddRange(datasets);
                return failed;
            }

            List<int> jobs = new List<int>();
            Dictionary<int, string> datasetMap = new Dictionary<int, string>();
            foreach (string dataset in datasets)
            {
                object? response = callJob.Invoke(dataset);

                if (response == null)
                {
                    failed.Add(dataset);
                    continue;
                }

                int jobId = (int)(Int64)response;
                jobs.Add(jobId);
                datasetMap.Add(jobId, dataset);
            }

            // create list of datasets that failed to lock
            List<int> failedJobs = JobWait(jobs);
            foreach (int jobId in failedJobs)
            {
                string dataset = datasetMap[jobId];
                failed.Add(dataset);
            }

            return failed;
        }

        public List<string> LockDataset(List<string> datasets)
        {
            return RunDatasetJob(datasets, (dataset) =>
            {
                return Task.Run(() => Call("pool.dataset.lock", new List<string> { dataset })).Result;
            });
        }

        public List<string> UnlockDataset(List<string> datasets, string password)
        {
            return RunDatasetJob(datasets, (dataset) =>
            {
                Dictionary<object, object> param = new Dictionary<object, object>
                {
                    {
                        "datasets", new List<Dictionary<string, string>>
                        {
                            new Dictionary<string, string>
                            {
                                { "name", dataset },
                                { "passphrase", password }
                            }
                        }
                    }
                };

                return Task.Run(() => Call("pool.dataset.unlock", new List<object> { dataset, param })).Result;
            });
        }

        public List<string> ChangeDatasetPassword(List<string> datasets, string password)
        {
            return RunDatasetJob(datasets, (dataset) =>
            {
                Dictionary<string, string> param = new Dictionary<string, string>
                {
                    { "passphrase", password }
                };

                return Task.Run(() => Call("pool.dataset.change_key", new List<object> { dataset, param })).Result;
            });
        }

        public List<DatasetItem> QueryDatasets()
        {
            List<DatasetItem> res = new List<DatasetItem>();
            if (!_connected || !_loggedin)
                return res;

            object? response = Task.Run(() => Call("pool.dataset.query", new List<object> { })).Result;

            if (response == null)
                return res;

            JsonNode? items = JsonArray.Parse(response.ToString());

            if (items == null)
                return res;

            foreach (JsonNode? item in items.AsArray())
            {
                if (item == null)
                    continue;

                DatasetItem? dataset = JsonConvert.DeserializeObject<DatasetItem>(item.ToString());

                if (dataset == null)
                    continue;

                res.Add(dataset);
            }

            return res;
        }
    }
}
