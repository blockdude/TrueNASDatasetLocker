namespace TrueNASLocker.UI
{
    public partial class LoginBox : UserControl
    {
        public enum InputType
        {
            HOSTNAME,
            USERNAME,
            PASSWORD
        }

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

        public event EventHandler? SettingsClick
        {
            add => _settingsButton.Click += value;
            remove => _settingsButton.Click -= value;
        }

        public new event KeyEventHandler? KeyDown
        {
            add
            {
                _hostTextBox.KeyDown += value;
                _userTextBox.KeyDown += value;
                _passwordTextBox.KeyDown += value;
            }

            remove
            {
                _hostTextBox.KeyDown -= value;
                _userTextBox.KeyDown -= value;
                _passwordTextBox.KeyDown -= value;
            }
        }

        public void InputFocus(InputType type)
        {
            if (type == InputType.HOSTNAME) _hostTextBox.Select();
            if (type == InputType.USERNAME) _userTextBox.Select();
            if (type == InputType.PASSWORD) _passwordTextBox.Select();
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
