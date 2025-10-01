using System.Diagnostics;

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
            _loginBox.LoginClick += (sender, e) => Login_Click();
            _datasetViewer.LogoutClick += (sernder, e) => Logout_Click();
            _loginBox.BringToFront();
            _loginBox.Dock = DockStyle.Fill;
            _datasetViewer.BringToFront();
            _datasetViewer.Dock = DockStyle.Fill;
            SetState(State.LOGIN);
        }

        private void Login_Click()
        {
            string hostname = _loginBox.Hostname;
            string username = _loginBox.Username;
            string password = _loginBox.Password;

            Client? client = Client.Connect("ws://" + hostname + "/api/current");

            if (client == null)
            {
                Debug.WriteLine("Failed to connect to host");
                return;
            }

            if (!client.Login(username, password))
            {
                Debug.WriteLine("Wrong username or password");
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
