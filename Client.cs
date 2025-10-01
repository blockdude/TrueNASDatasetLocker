using JsonRpcClient.Clients;
using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using TrueNASLocker.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
    }

    public class Client : RpcWsClient
    {
        private bool _connected = false;
        private bool _loggedin = false;

        public static Client Connect(string uri)
        {
            return Task.Run(() => new Client(uri)).Result;
        }

        private Client(string uri) : base(uri)
        {
            Connect().Wait();
            _connected = true;
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

        public bool LockDataset(string dataset)
        {
            if (!_connected || !_loggedin)
                return false;

            object? response = Task.Run(() => Call("pool.dataset.lock", new List<string> { dataset })).Result;

            if (response == null)
                return false;

            // note: the response is the id for the job and to get the status and result of the lock job
            // we need to make another call to query the job and get the status.

            return true;
        }

        public bool UnlockDataset(string dataset, string password)
        {
            if (!_connected || !_loggedin)
                return false;

            Dictionary<string, List<Dictionary<string, string>>> unlocklist = new Dictionary<string, List<Dictionary<string, string>>>
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

            object? response = Task.Run(() => Call("pool.dataset.unlock", new List<object> { dataset, unlocklist })).Result;

            if (response == null)
                return false;

            return true;
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

        public bool ChangeDatasetPassword(string dataset, string newPassword)
        {
            return false;
        }
    }
}
