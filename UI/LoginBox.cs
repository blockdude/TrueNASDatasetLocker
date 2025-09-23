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
    public partial class LoginBox : UserControl
    {
        public LoginBox()
        {
            InitializeComponent();
            this.Resize += OnResize;
            this._showPasswordCheckBox.CheckedChanged += OnPasswordCheckChange;
        }

        private void OnResize(object? sender, EventArgs e)
        {
        }

        private void OnPasswordCheckChange(object? sender, EventArgs e)
        {
            _passwordTextBox.PasswordChar = _showPasswordCheckBox.Checked ? '\0' : '*';
        }

        private void OnLoginButtonPress(object? sender, EventArgs e)
        {
        }

        private void _flowLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
