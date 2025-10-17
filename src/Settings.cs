namespace TrueNASLocker
{
    public struct Settings
    {
        public string Path { get; set; }
        public int Port { get; set; }
        public bool WSS { get; set; }
        public bool SaveHostname { get; set; }
        public bool SaveUsername { get; set; }
        public string Hostname { get; set; }
        public string Username { get; set; }

        public Settings()
        {
            Path = "pool00/shares";
            Port = 80;
            WSS = false;
            SaveHostname = true;
            SaveUsername = true;
            Hostname = "";
            Username = "";
        }
    }
}
