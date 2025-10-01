namespace TrueNASLocker.UI
{
    public partial class DatasetPasswordChange : UserControl
    {
        public string Password
        {
            get => _passwordTextBox.Text;
            set => _passwordTextBox.Text = value;
        }

        public string ConfirmPassword
        {
            get => _confirmTextBox.Text;
            set => _confirmTextBox.Text = value;
        }

        public event EventHandler? ConfirmClick
        {
            add => _confirmButton.Click += value;
            remove => _confirmButton.Click -= value;
        }

        public event EventHandler? CancelClick
        {
            add => _cancelButton.Click += value;
            remove => _cancelButton.Click -= value;
        }

        public new event KeyEventHandler? KeyDown
        {
            add
            {
                _passwordTextBox.KeyDown += value;
                _confirmTextBox.KeyDown += value;
            }

            remove
            {
                _passwordTextBox.KeyDown -= value;
                _confirmTextBox.KeyDown -= value;
            }
        }

        public DatasetPasswordChange()
        {
            InitializeComponent();
            this._showPasswordCheckBox.CheckedChanged +=
                (object? sender, EventArgs e) =>
                {
                    _passwordTextBox.PasswordChar = _showPasswordCheckBox.Checked ? '\0' : '*';
                    _confirmTextBox.PasswordChar = _showPasswordCheckBox.Checked ? '\0' : '*';
                };
        }
    }
}
