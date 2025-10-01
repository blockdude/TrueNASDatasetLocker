using System.Diagnostics;
using static System.Windows.Forms.AxHost;

namespace TrueNASLocker.UI
{
    public partial class DatasetViewer : UserControl
    {
        private Client? _client;
        private static readonly string _storageBase = "pool00/shares/";

        private enum State
        {
            INFO,
            UNLOCK,
            LOCK,
            CHGPWD
        }

        private State _istate;
        private State _state
        {
            get => _istate;
            set
            {
                _istate = value;
                _infoBox.Enabled = false;
                _infoBox.Visible = false;
                _unlockBox.Enabled = false;
                _unlockBox.Visible = false;
                _editBox.Enabled = false;
                _editBox.Visible = false;
                _changePasswordBox.Enabled = false;
                _changePasswordBox.Visible = false;
                switch (value)
                {
                    case State.INFO:
                        _infoBox.Enabled = true;
                        _infoBox.Visible = true;
                        break;

                    case State.UNLOCK:
                        _unlockBox.Enabled = true;
                        _unlockBox.Visible = true;
                        break;

                    case State.LOCK:
                        _editBox.Enabled = true;
                        _editBox.Visible = true;
                        break;

                    case State.CHGPWD:
                        _changePasswordBox.Enabled = true;
                        _changePasswordBox.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public event EventHandler? LogoutClick
        {
            add => _userBox.LogoutClick += value;
            remove => _userBox.LogoutClick -= value;
        }

        public DatasetViewer()
        {
            InitializeComponent();
            _state = State.INFO;
            _datasetListView.MouseUp += (sender, e) => ListView_Click();
            _editBox.ChangePasswordClick += (sender, e) => ChangePassword_Click();
            _changePasswordBox.CancelClick += (sender, e) => CancelChangePassword_Click();
            _changePasswordBox.ConfirmClick += (sender, e) => ConfirmChangePassword_Click();
            _unlockBox.UnlockClick += (sender, e) => UnlockDataset_Click();
            _editBox.LockClick += (sender, e) => LockDataset_Click();
        }

        public void SetClient(Client client, string hostname, string username)
        {
            _userBox.Hostname = hostname;
            _userBox.Username = username;
            _client = client;
            RefreshListView();
        }

        private void RefreshListView()
        {
            _datasetListView.Items.Clear();

            if (_client == null)
                return;

            List<DatasetItem> datasets = _client.QueryDatasets();
            foreach (DatasetItem dataset in datasets)
            {
                if (!dataset.id.StartsWith(_storageBase))
                    continue;

                ListViewItem item = new ListViewItem();
                item.Text = dataset.id.Substring(_storageBase.Length);
                item.SubItems.Add(dataset.locked ? "Locked" : "Unlocked");
                _datasetListView.Items.Add(item);
            }
        }

        private void RefreshState()
        {
            State state = State.INFO;

            foreach (ListViewItem item in _datasetListView.SelectedItems)
            {
                if (item.SubItems[1].Text == "Locked")
                {
                    state = State.UNLOCK;
                    break;
                }

                state = State.LOCK;
            }

            _state = state;
        }

        public void Logout()
        {
            if (_client != null && !_client.Logout())
                Debug.WriteLine("Failed to logout from " + _userBox.Hostname);
            _client?.Dispose();

            _client = null;
            _userBox.Hostname = "";
            _userBox.Username = "";
            _unlockBox.Password = "";
            _changePasswordBox.Password = "";
            _changePasswordBox.ConfirmPassword = "";
            _datasetListView.Items.Clear();
        }

        private void ListView_Click()
        {
            if (_client == null)
                return;

            RefreshState();
        }

        private void ChangePassword_Click()
        {
            if (_client == null)
                return;

            _state = State.CHGPWD;
        }

        private void CancelChangePassword_Click()
        {
            if (_client == null)
                return;

            _state = State.LOCK;
        }

        private void ConfirmChangePassword_Click()
        {
            if (_client == null)
                return;

            _state = State.LOCK;
        }

        private void LockDataset_Click()
        {
            if (_client == null)
                return;

            foreach (ListViewItem item in _datasetListView.SelectedItems)
            {
                if (item.SubItems[1].Text == "Locked")
                    continue;

                string dataset = _storageBase + item.SubItems[0].Text;
                _client.LockDataset(dataset);
            }

            // fix Client.LockDataset so i can remove this thread sleep
            Thread.Sleep(1000);
            RefreshListView();
            RefreshState();
        }

        private void UnlockDataset_Click()
        {
            if (_client == null)
                return;

            foreach (ListViewItem item in _datasetListView.SelectedItems)
            {
                if (item.SubItems[1].Text == "Unlocked")
                    continue;

                string dataset = _storageBase + item.SubItems[0].Text;
                string password = _unlockBox.Password;
                _client.UnlockDataset(dataset, password);
            }

            _unlockBox.Password = "";
            Thread.Sleep(1000);
            RefreshListView();
            RefreshState();
        }
    }
}
