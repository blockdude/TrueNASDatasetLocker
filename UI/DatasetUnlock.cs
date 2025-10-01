namespace TrueNASLocker.UI
{
    public partial class DatasetUnlock : UserControl
    {
        public string Password
        {
            get => _passwordTextBox.Text;
            set => _passwordTextBox.Text = value;
        }

        public event EventHandler? UnlockClick
        {
            add => _unlockButton.Click += value;
            remove => _unlockButton.Click -= value;
        }

        public DatasetUnlock()
        {
            InitializeComponent();
            this._showPasswordCheckBox.CheckedChanged +=
                (object? sender, EventArgs e) =>
                {
                    _passwordTextBox.PasswordChar = _showPasswordCheckBox.Checked ? '\0' : '*';
                };
        }
    }
}
