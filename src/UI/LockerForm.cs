using System.Diagnostics;
namespace TrueNASLocker.UI
{
    public partial class LockerForm : Form
    {
        private State _state;

        private enum State
        {
            LOGIN,
            VIEW,
            SETTINGS
        }

        public LockerForm()
        {
            InitializeComponent();
        }

        private void LockerForm_Load(object sender, EventArgs e)
        {
            _datasetViewer.LogoutClick += (sender, e) => Viewer_Logout_Click();
            _settingsBox.CancelClick += (sender, e) => Settings_Cancel_Click();
            _settingsBox.ApplyClick += (sender, e) => Settings_Apply_Click();
            _loginBox.LoginClick += (sender, e) => Login_Login_Click();
            _loginBox.SettingsClick += (sender, e) => Login_Settings_Click();
            _loginBox.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Login_Login_Click();

                    // stop the ding sound from playing
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };

            _loginBox.BringToFront();
            _loginBox.Dock = DockStyle.Fill;
            _datasetViewer.BringToFront();
            _datasetViewer.Dock = DockStyle.Fill;
            _settingsBox.BringToFront();
            _settingsBox.Dock = DockStyle.Fill;
            _versionLabel.BringToFront();
            _versionLabel.Text = "v" + Global.Version;
            SetState(State.LOGIN);
        }

        private void LockerForm_Closing(object sernder, EventArgs e)
        {
            _datasetViewer.Logout();
        }

        private void Login_Login_Click()
        {
            string hostname = _loginBox.Hostname;
            string username = _loginBox.Username;
            string password = _loginBox.Password;

            _loginBox.Enabled = false;

            string WS = Global.Settings.WSS ? "wss://" : "ws://";
            Client? client = Client.Connect(WS + hostname + ":" + Global.Settings.Port + "/api/current");

            if (client == null || !client.Login(username, password))
            {
                MessageBoxEx.Show(this, client == null ? "Failed to connect to host" : "Invalid username or password", "Info");
                _loginBox.Enabled = true;
                return;
            }

            // save hostname and username
            Settings settings = Global.Settings;
            settings.Hostname = settings.SaveHostname ? hostname : string.Empty;
            settings.Username = settings.SaveUsername ? username : string.Empty;
            Global.Settings = settings;

            _loginBox.Hostname = "";
            _loginBox.Username = "";
            _loginBox.Password = "";
            _datasetViewer.SetClient(client, hostname, username, Global.Settings.Path);
            SetState(State.VIEW);
        }

        private void Viewer_Logout_Click()
        {
            _datasetViewer.Logout();
            SetState(State.LOGIN);
        }

        private void Login_Settings_Click()
        {
            _settingsBox.Settings = Global.Settings;
            SetState(State.SETTINGS);
        }

        private void Settings_Cancel_Click()
        {
            SetState(State.LOGIN);
        }

        private void Settings_Apply_Click()
        {
            Global.Settings = _settingsBox.Settings;
            SetState(State.LOGIN);
        }

        private void SetState(State state)
        {
            _state = state;
            _loginBox.Visible = false;
            _loginBox.Enabled = false;
            _datasetViewer.Visible = false;
            _datasetViewer.Enabled = false;
            _settingsBox.Visible = false;
            _settingsBox.Enabled = false;

            switch (state)
            {
                case State.LOGIN:
                    _loginBox.Visible = true;
                    _loginBox.Enabled = true;
                    break;
                case State.VIEW:
                    _datasetViewer.Visible = true;
                    _datasetViewer.Enabled = true;
                    break;
                case State.SETTINGS:
                    _settingsBox.Visible = true;
                    _settingsBox.Enabled = true;
                    break;
                default:
                    break;
            }

            if (state == State.LOGIN)
            {
                _loginBox.Focus();
                _loginBox.Hostname = Global.Settings.Hostname;
                _loginBox.Username = Global.Settings.Username;
                LoginBox.InputType inputType =
                    Global.Settings.Hostname.Length > 0 ?
                        Global.Settings.Username.Length > 0 ?
                            LoginBox.InputType.PASSWORD :
                            LoginBox.InputType.USERNAME :
                        LoginBox.InputType.HOSTNAME;
                _loginBox.InputFocus(inputType);
            }
        }
    }
}
