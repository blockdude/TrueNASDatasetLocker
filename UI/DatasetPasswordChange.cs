namespace TrueNASLocker.UI
{
    public partial class DatasetPasswordChange : UserControl
    {
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
