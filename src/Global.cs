using System.Diagnostics;
using System.Text.Json;

namespace TrueNASLocker
{
    public static class Global
    {
        public static readonly long Version = 202510012110;
        public static readonly string Upstream = "https://api.github.com/repos/blockdude/TrueNASDatasetLocker/releases/latest";

        public static Updater Updater = new Updater();
        public static Mutex mutex = new Mutex();
        public static long LatestVersion { get => Updater.GetLatestVersion(); }
        public static Settings Settings { get => _settings; set => SaveSettings(value); }

        private static Settings _settings;
        private static string _settingsPath = "settings.json";

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
            _settings = ReadData(_settingsPath);
        }

        public static void SaveSettings(Settings settings)
        {
            // Make sure we don't accidently save hostname or username if we did not want to
            settings.Hostname = settings.SaveHostname ? settings.Hostname : string.Empty;
            settings.Username = settings.SaveUsername ? settings.Username : string.Empty;
            _settings = WriteData(settings, _settingsPath);
        }
    }
}
