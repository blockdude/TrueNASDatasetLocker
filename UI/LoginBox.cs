namespace TrueNASLocker.UI
{
    public partial class LoginBox : UserControl
    {
        public string Hostname
        {
            get => _hostTextBox.Text;
            set => _hostTextBox.Text = value;
        }

        public string Username
        {
            get => _userTextBox.Text;
            set => _userTextBox.Text = value;
        }

        public string Password
        {
            get => _passwordTextBox.Text;
            set => _passwordTextBox.Text = value;
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
