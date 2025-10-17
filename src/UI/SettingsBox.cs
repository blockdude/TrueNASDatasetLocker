namespace TrueNASLocker.UI
{
    public partial class SettingsBox : UserControl
    {
        public SettingsBox()
        {
            InitializeComponent();
        }

        public Settings GetSettings()
        {
            Settings settings;
            settings.path = _pathTextBox.Text;
            settings.port = (int)_portNumBox.Value;
            settings.wss = _wssCheckBox.Checked;
            settings.saveHostname = _saveHostCheckBox.Checked;
            settings.saveUsername = _saveUserCheckBox.Checked;
            settings.upstreamURI = "";
            return settings;
        }
    }
}
