using System.Diagnostics;
using System.IO;
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
            _datasetViewer.LogoutClick += (sender, e) => Viewer_Logout_Click();
            _settingsBox.UpdateClick += (sender, e) => Settings_Update_Click();
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

            // run background task to check updates and delete old files
            Task.Run(() =>
            {
                foreach (string file in Directory.GetFiles(".", "*.bak"))
                {
                    File.Delete(file);
                }

                Global.Updater.FetchUpdateInfo(Global.Upstream);
                if (Global.Updater.GetLatestVersion() > Global.Version)
                {
                    Invoke(() =>
                    {
                        DialogResult result = MessageBoxEx.Show(this, "Update Available. Update Now?", "", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            Settings_Update_Click();
                        }
                    });
                }
            });
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

        private void Settings_Update_Click()
        {
            if (Global.Updater.GetLatestVersion() <= 0)
            {
                MessageBoxEx.Show(this, "Could get update info.\nMake sure you have internet connection.");
                return;
            }

            if (Global.Version >= Global.Updater.GetLatestVersion())
            {
                MessageBox.Show(this, "Already on latest version");
                return;
            }

            _settingsBox.Enabled = false;
            DialogResult result = MessageBoxEx.Show(this, "Start update?\nv" + Global.Version + " -> v" + Global.Updater.GetLatestVersion(), "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                _settingsBox.Enabled = true;
                return;
            }

            if (!Global.Updater.StartUpdate())
            {
                MessageBoxEx.Show(this, "Failed to update");
                _settingsBox.Enabled = true;
                return;
            }

            MessageBoxEx.Show(this, "Update completed. Restarting Application...");
            Process.Start(Application.ExecutablePath, Environment.GetCommandLineArgs());
            Environment.Exit(0);
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

            if (state == State.LOGIN)
            {
                _loginBox.Visible = true;
                _loginBox.Enabled = true;
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
            else if (state == State.VIEW)
            {
                _datasetViewer.Visible = true;
                _datasetViewer.Enabled = true;
            }
            else if (state == State.SETTINGS)
            {
                _settingsBox.Visible = true;
                _settingsBox.Enabled = true;
                _settingsBox.LatestVersion = Global.LatestVersion;
            }
        }
    }
}
