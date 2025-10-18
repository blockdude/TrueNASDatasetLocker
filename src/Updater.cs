using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Nodes;
using System.Xml.Linq;

namespace TrueNASLocker
{
    public class Updater
    {
        private HttpClient _client;
        private bool _fetched = false;
        private string _latestTag = "";
        private long _latestVersion = 0;

        private long _size = 0;
        private string _fileName = "";
        private string _downloadLink = "";
        private string _digest = "";

        public Updater()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
        }

        public bool FetchUpdateInfo(string uri)
        {
            JsonNode? node = null;

            try
            {
                node = JsonNode.Parse(Task.Run(() => _client.GetStringAsync(uri)).Result);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }

            if (node == null)
                return false;

            string? latestTag = node["tag_name"]?.ToString();
            string? downloadLink = node["assets"]?.AsArray()?[0]?["browser_download_url"]?.ToString();
            string? digest = node["assets"]?.AsArray()?[0]?["digest"]?.ToString();
            string? size = node["assets"]?.AsArray()?[0]?["size"]?.ToString();
            string? fileName = node["assets"]?.AsArray()?[0]?["name"]?.ToString();

            if (latestTag == null || downloadLink == null || digest == null || size == null || fileName == null)
                return false;

            _latestTag = latestTag;
            _downloadLink = downloadLink;
            _latestVersion = long.Parse(latestTag.Remove(0, 1));
            _digest = digest;
            _size = long.Parse(size);
            _fileName = fileName;
            _fetched = true;

            return true;
        }

        public long GetLatestVersion()
        {
            return _latestVersion;
        }

        public string GetDownloadLink()
        {
            return _downloadLink;
        }

        private string HashToString(byte[] hash)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("sha256:");
            foreach (byte b in hash)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        public bool StartUpdate()
        {
            Directory.CreateDirectory("versions");
            string fileName = "versions/" + _fileName;
            string fileDigest = "";

            // download file
            if (!File.Exists(fileName))
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    Stream downloadStream = Task.Run(() => _client.GetStreamAsync(_downloadLink)).Result;
                    downloadStream.CopyTo(fileStream);
                }
            }

            // check sha256 hash
            using (FileStream filestream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                SHA256 sha256 = SHA256.Create();
                byte[] hashRaw = sha256.ComputeHash(filestream);
                fileDigest = HashToString(hashRaw);
            }

            // if hash does not match then just return as failed
            if (fileDigest != _digest)
            {
                File.Delete(fileName);
                return false;
            }

            // extract files into tmp
            Directory.CreateDirectory("tmp");
            System.IO.Compression.ZipFile.ExtractToDirectory(fileName, "tmp");

            // rename move and delete files
            foreach (string newFile in Directory.GetFiles("tmp"))
            {
                string oldFile = newFile.Remove(0, 4);
                File.Move(oldFile, oldFile + ".bak");
                File.Move(newFile, oldFile);
            }

            Directory.Delete("tmp");
            return true;
        }
    }
}
