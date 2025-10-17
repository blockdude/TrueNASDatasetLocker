namespace TrueNASLocker.UI
{
    public partial class SettingsBox : UserControl
    {
        public Settings Settings
        {
            get => GetSettings();
            set => SetSettings(value);
        }

        public event EventHandler? UpdateClick
        {
            add => _updateButton.Click += value;
            remove => _updateButton.Click -= value;
        }

        public event EventHandler? ApplyClick
        {
            add => _applyButton.Click += value;
            remove => _applyButton.Click -= value;
        }

        public event EventHandler? CancelClick
        {
            add => _cancelButton.Click += value;
            remove => _cancelButton.Click -= value;
        }

        public SettingsBox()
        {
            InitializeComponent();
            SetSettings(Global.Settings);
            _currentVersionTextBox.Text = "v" + Global.Version;
        }

        public void SetSettings(Settings settings)
        {
            _pathTextBox.Text = settings.Path;
            _portNumBox.Value = settings.Port;
            _wssCheckBox.Checked = settings.WSS;
            _saveHostCheckBox.Checked = settings.SaveHostname;
            _saveUserCheckBox.Checked = settings.SaveUsername;
        }

        public Settings GetSettings()
        {
            Settings settings = Global.Settings;
            settings.Path = _pathTextBox.Text;
            settings.Port = (int)_portNumBox.Value;
            settings.WSS = _wssCheckBox.Checked;
            settings.SaveHostname = _saveHostCheckBox.Checked;
            settings.SaveUsername = _saveUserCheckBox.Checked;
            return settings;
        }
    }
}
