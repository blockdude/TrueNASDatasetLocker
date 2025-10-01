namespace TrueNASLocker.UI
{
    public partial class LoginBox : UserControl
    {
        public string Host
        {
            get => _hostTextBox.Text;
        }

        public string Username
        {
            get => _userTextBox.Text;
        }

        public string Password
        {
            get => _passwordTextBox.Text;
        }

        public event EventHandler? LoginClick
        {
            add => _loginButton.Click += value;
            remove => _loginButton.Click -= value;
        }

        public LoginBox()
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
