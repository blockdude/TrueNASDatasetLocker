namespace TrueNASLocker.UI
{
    partial class LoginBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _groupBox = new GroupBox();
            _flowLayout = new FlowLayoutPanel();
            widthGauge1 = new WidthGauge();
            _hostLabel = new Label();
            _hostTextBox = new TextBox();
            _userLabel = new Label();
            _userTextBox = new TextBox();
            passwordLabel = new Label();
            _passwordTextBox = new TextBox();
            _showPasswordCheckBox = new CheckBox();
            _loginButton = new Button();
            _groupBox.SuspendLayout();
            _flowLayout.SuspendLayout();
            SuspendLayout();
            // 
            // _groupBox
            // 
            _groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _groupBox.Controls.Add(_flowLayout);
            _groupBox.Location = new Point(0, 0);
            _groupBox.Name = "_groupBox";
            _groupBox.Size = new Size(219, 265);
            _groupBox.TabIndex = 0;
            _groupBox.TabStop = false;
            _groupBox.Text = "Login";
            // 
            // _flowLayout
            // 
            _flowLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _flowLayout.Controls.Add(widthGauge1);
            _flowLayout.Controls.Add(_hostLabel);
            _flowLayout.Controls.Add(_hostTextBox);
            _flowLayout.Controls.Add(_userLabel);
            _flowLayout.Controls.Add(_userTextBox);
            _flowLayout.Controls.Add(passwordLabel);
            _flowLayout.Controls.Add(_passwordTextBox);
            _flowLayout.Controls.Add(_showPasswordCheckBox);
            _flowLayout.Controls.Add(_loginButton);
            _flowLayout.Dock = DockStyle.Fill;
            _flowLayout.FlowDirection = FlowDirection.TopDown;
            _flowLayout.Location = new Point(3, 19);
            _flowLayout.Name = "_flowLayout";
            _flowLayout.RightToLeft = RightToLeft.No;
            _flowLayout.Size = new Size(213, 243);
            _flowLayout.TabIndex = 0;
            _flowLayout.Paint += _flowLayout_Paint;
            // 
            // widthGauge1
            // 
            widthGauge1.Anchor = AnchorStyles.Top;
            widthGauge1.Location = new Point(3, 3);
            widthGauge1.Name = "widthGauge1";
            widthGauge1.Size = new Size(207, 18);
            widthGauge1.TabIndex = 5;
            widthGauge1.Text = "widthGauge1";
            // 
            // _hostLabel
            // 
            _hostLabel.Anchor = AnchorStyles.Top;
            _hostLabel.AutoSize = true;
            _hostLabel.Location = new Point(90, 24);
            _hostLabel.Name = "_hostLabel";
            _hostLabel.Size = new Size(32, 15);
            _hostLabel.TabIndex = 0;
            _hostLabel.Text = "Host";
            // 
            // _hostTextBox
            // 
            _hostTextBox.Dock = DockStyle.Fill;
            _hostTextBox.Location = new Point(3, 42);
            _hostTextBox.Name = "_hostTextBox";
            _hostTextBox.Size = new Size(207, 23);
            _hostTextBox.TabIndex = 0;
            _hostTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // _userLabel
            // 
            _userLabel.Anchor = AnchorStyles.Top;
            _userLabel.AutoSize = true;
            _userLabel.Location = new Point(76, 68);
            _userLabel.Name = "_userLabel";
            _userLabel.Size = new Size(60, 15);
            _userLabel.TabIndex = 0;
            _userLabel.Text = "Username";
            // 
            // _userTextBox
            // 
            _userTextBox.Dock = DockStyle.Fill;
            _userTextBox.Location = new Point(3, 86);
            _userTextBox.Name = "_userTextBox";
            _userTextBox.Size = new Size(207, 23);
            _userTextBox.TabIndex = 1;
            _userTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(78, 112);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Password";
            // 
            // _passwordTextBox
            // 
            _passwordTextBox.Dock = DockStyle.Fill;
            _passwordTextBox.Location = new Point(3, 130);
            _passwordTextBox.Name = "_passwordTextBox";
            _passwordTextBox.PasswordChar = '*';
            _passwordTextBox.Size = new Size(207, 23);
            _passwordTextBox.TabIndex = 2;
            _passwordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // _showPasswordCheckBox
            // 
            _showPasswordCheckBox.Anchor = AnchorStyles.Top;
            _showPasswordCheckBox.AutoSize = true;
            _showPasswordCheckBox.Location = new Point(52, 159);
            _showPasswordCheckBox.Name = "_showPasswordCheckBox";
            _showPasswordCheckBox.RightToLeft = RightToLeft.No;
            _showPasswordCheckBox.Size = new Size(108, 19);
            _showPasswordCheckBox.TabIndex = 3;
            _showPasswordCheckBox.Text = "Show Password";
            _showPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // _loginButton
            // 
            _loginButton.Dock = DockStyle.Fill;
            _loginButton.Location = new Point(3, 184);
            _loginButton.Name = "_loginButton";
            _loginButton.Size = new Size(207, 23);
            _loginButton.TabIndex = 4;
            _loginButton.Text = "Login";
            _loginButton.UseVisualStyleBackColor = true;
            // 
            // LoginBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_groupBox);
            Margin = new Padding(0);
            Name = "LoginBox";
            Size = new Size(219, 265);
            _groupBox.ResumeLayout(false);
            _flowLayout.ResumeLayout(false);
            _flowLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _groupBox;
        private FlowLayoutPanel _flowLayout;
        private TextBox _userTextBox;
        private TextBox _hostTextBox;
        private TextBox _passwordTextBox;
        private CheckBox _showPasswordCheckBox;
        private Button _loginButton;
        private Label _hostLabel;
        private Label _userLabel;
        private Label passwordLabel;
        private WidthGauge widthGauge1;
    }
}
