using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueNASLocker.UI
{
    public partial class UserAccountBox : UserControl
    {
        public string Host
        {
            get => _hostTextBox.Text;
            set => _hostTextBox.Text = value;
        }

        public string Username
        {
            get => _userTextBox.Text;
            set => _userTextBox.Text = value;
        }

        public event EventHandler? LogoutClick
        {
            add => _logoutButton.Click += value;
            remove => _logoutButton.Click -= value;
        }

        public UserAccountBox()
        {
            InitializeComponent();
        }
    }
}
