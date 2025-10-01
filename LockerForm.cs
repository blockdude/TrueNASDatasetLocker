using System.Diagnostics;
using TrueNASLocker.UI;

namespace TrueNASLocker
{
    public partial class LockerForm : Form
    {
        private State _state;

        private enum State
        {
            LOGIN,
            VIEW
        }

        public LockerForm()
        {
            InitializeComponent();
        }

        private void LockerForm_Load(object sender, EventArgs e)
        {
            _datasetViewer.LogoutClick += (sernder, e) => Logout_Click();
            _loginBox.LoginClick += (sender, e) => Login_Click();
            _loginBox.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Login_Click();

                    // stop the ding sound from playing
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };

            _loginBox.BringToFront();
            _loginBox.Dock = DockStyle.Fill;
            _datasetViewer.BringToFront();
            _datasetViewer.Dock = DockStyle.Fill;
            SetState(State.LOGIN);
        }

        private void LockerForm_Closing(object sernder, EventArgs e)
        {
            _datasetViewer.Logout();
        }

        private void Login_Click()
        {
            string hostname = _loginBox.Hostname;
            string username = _loginBox.Username;
            string password = _loginBox.Password;

            _loginBox.Enabled = false;

            Client? client = Client.Connect("ws://" + hostname + "/api/current");

            if (client == null || !client.Login(username, password))
            {
                MessageBoxEx.Show(this, client == null ? "Failed to connect to host" : "Invalid username or password", "Info");
                _loginBox.Enabled = true;
                return;
            }

            _loginBox.Hostname = "";
            _loginBox.Username = "";
            _loginBox.Password = "";
            _datasetViewer.SetClient(client, hostname, username);
            SetState(State.VIEW);
        }

        private void Logout_Click()
        {
            _datasetViewer.Logout();
            SetState(State.LOGIN);
        }

        private void SetState(State state)
        {
            _state = state;
            _loginBox.Visible = false;
            _loginBox.Enabled = false;
            _datasetViewer.Visible = false;
            _datasetViewer.Enabled = false;
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
                default:
                    break;
            }
        }
    }
}
