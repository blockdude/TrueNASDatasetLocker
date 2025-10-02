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
            _refreshButton.Click += (sender, e) => Refresh_Click();

            _unlockBox.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    UnlockDataset_Click();

                    // stop the ding sound from playing
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };

            _changePasswordBox.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ConfirmChangePassword_Click();

                    // stop the ding sound from playing
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };
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

        private void Refresh_Click()
        {
            if (_client == null)
                return;

            this.Enabled = false;
            RefreshListView();
            RefreshState();
            this.Enabled = true;
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

            _changePasswordBox.Password = "";
            _changePasswordBox.ConfirmPassword = "";
            _state = State.LOCK;
        }

        private void DatasetWork(string filter, string message, Func<List<string>, List<string>> callWork)
        {
            this.Enabled = false;

            List<string> datasets = new List<string>();
            foreach (ListViewItem item in _datasetListView.SelectedItems)
            {
                if (item.SubItems[1].Text == filter)
                    continue;

                string dataset = _storageBase + item.SubItems[0].Text;
                datasets.Add(dataset);
            }

            List<string> failed = callWork.Invoke(datasets);
            if (failed.Count > 0)
            {
                string failedMessage = "";
                failed.ForEach(dataset => failedMessage += "\n" + dataset);
                MessageBoxEx.Show(this, message + failedMessage, "Warning");
            }

            RefreshListView();
            RefreshState();
            this.Enabled = true;
        }

        private void ConfirmChangePassword_Click()
        {
            if (_client == null)
                return;

            string passwordA = _changePasswordBox.Password;
            string passwordB = _changePasswordBox.ConfirmPassword;

            this.Enabled = false;
            if (passwordA != passwordB)
            {
                MessageBoxEx.Show(this, "Passwords do not match", "Invalid");
                this.Enabled = true;
                return;
            }

            if (passwordA.Length < 8)
            {
                MessageBoxEx.Show(this, "Password must be 8 characters or more", "Invalid");
                this.Enabled = true;
                return;
            }

            DatasetWork("Locked", "Failed to change password for:", (datasets) =>
            {
                return _client.ChangeDatasetPassword(datasets, passwordA);
            });

            _changePasswordBox.Password = "";
            _changePasswordBox.ConfirmPassword = "";
            _state = State.LOCK;
            this.Enabled = true;
        }

        private void LockDataset_Click()
        {
            if (_client == null)
                return;

            DatasetWork("Locked", "Failed to lock dataset for:", (datasets) =>
            {
                return _client.LockDataset(datasets);
            });
        }

        private void UnlockDataset_Click()
        {
            if (_client == null)
                return;

            DatasetWork("Unlocked", "Failed to unlock dataset for:", (datasets) =>
            {
                return _client.UnlockDataset(datasets, _unlockBox.Password);
            });

            _unlockBox.Password = "";
        }
    }
}
