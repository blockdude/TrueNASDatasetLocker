namespace TrueNASLocker.UI
{
    public partial class DatasetEdit : UserControl
    {
        public event EventHandler? LockClick
        {
            add => _lockButton.Click += value;
            remove => _lockButton.Click -= value;
        }

        public event EventHandler? ChangePasswordClick
        {
            add => _changePasswordButton.Click += value;
            remove => _changePasswordButton.Click -= value;
        }

        public DatasetEdit()
        {
            InitializeComponent();
        }
    }
}
