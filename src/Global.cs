using System.Text.Json;

namespace TrueNASLocker
{
    public static class Global
    {
        public static readonly long Version = 202510172210;
        public static readonly string Upstream = "https://api.github.com/repos/blockdude/TrueNASDatasetLocker/releases/latest";
        public static readonly string SettingsPath = "Settings.json";
        public static readonly string PatchNotesPath = "PatchNotes.txt";

        public static Updater Updater = new Updater();
        public static long LatestVersion { get => Updater.GetLatestVersion(); }
        public static Settings Settings { get => _settings; set => SaveSettings(value); }
        public static string PatchNotes { get => _patchNotes; }

        private static Settings _settings;
        private static string _patchNotes = "";

        private static Settings WriteData(Settings settings, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                writer.Write(JsonSerializer.Serialize(settings, options));
            }

            return settings;
        }

        private static Settings ReadData(string path)
        {
            if (!File.Exists(path))
            {
                return new Settings();
            }

            using (StreamReader reader = new StreamReader(path))
            {
                return JsonSerializer.Deserialize<Settings>(reader.ReadToEnd());
            }
        }

        public static void LoadSettings()
        {
            if (File.Exists(PatchNotesPath))
            {
                using (StreamReader reader = new StreamReader(PatchNotesPath))
                {
                    _patchNotes = reader.ReadToEnd();
                }
            }

            _settings = ReadData(SettingsPath);
        }

        public static void SaveSettings(Settings settings)
        {
            // Make sure we don't accidently save hostname or username if we did not want to
            settings.Hostname = settings.SaveHostname ? settings.Hostname : string.Empty;
            settings.Username = settings.SaveUsername ? settings.Username : string.Empty;
            _settings = WriteData(settings, SettingsPath);
        }
    }
}
