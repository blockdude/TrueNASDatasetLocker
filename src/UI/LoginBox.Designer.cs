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
            _flowLayout = new FlowLayoutPanelEx();
            _widthGauge = new WidthGauge();
            _hostLabel = new Label();
            _hostTextBox = new TextBox();
            _userLabel = new Label();
            _userTextBox = new TextBox();
            _passwordLabel = new Label();
            _passwordTextBox = new TextBox();
            _showPasswordCheckBox = new CheckBox();
            _loginButton = new Button();
            _settingsButton = new Button();
            _groupBox.SuspendLayout();
            _flowLayout.SuspendLayout();
            SuspendLayout();
            // 
            // _groupBox
            // 
            _groupBox.Controls.Add(_flowLayout);
            _groupBox.Dock = DockStyle.Fill;
            _groupBox.Location = new Point(0, 0);
            _groupBox.Margin = new Padding(3, 4, 3, 4);
            _groupBox.Name = "_groupBox";
            _groupBox.Padding = new Padding(3, 4, 3, 4);
            _groupBox.Size = new Size(333, 445);
            _groupBox.TabIndex = 0;
            _groupBox.TabStop = false;
            _groupBox.Text = "Login";
            // 
            // _flowLayout
            // 
            _flowLayout.CenterHorizontal = false;
            _flowLayout.CenterVertical = true;
            _flowLayout.Controls.Add(_widthGauge);
            _flowLayout.Controls.Add(_hostLabel);
            _flowLayout.Controls.Add(_hostTextBox);
            _flowLayout.Controls.Add(_userLabel);
            _flowLayout.Controls.Add(_userTextBox);
            _flowLayout.Controls.Add(_passwordLabel);
            _flowLayout.Controls.Add(_passwordTextBox);
            _flowLayout.Controls.Add(_showPasswordCheckBox);
            _flowLayout.Controls.Add(_loginButton);
            _flowLayout.Controls.Add(_settingsButton);
            _flowLayout.Dock = DockStyle.Fill;
            _flowLayout.FlowDirection = FlowDirection.TopDown;
            _flowLayout.Location = new Point(3, 24);
            _flowLayout.Margin = new Padding(3, 4, 3, 4);
            _flowLayout.Name = "_flowLayout";
            _flowLayout.Padding = new Padding(0, 56, 0, 0);
            _flowLayout.Size = new Size(327, 417);
            _flowLayout.TabIndex = 6;
            // 
            // _widthGauge
            // 
            _widthGauge.Anchor = AnchorStyles.Top;
            _widthGauge.Location = new Point(0, 56);
            _widthGauge.Margin = new Padding(0);
            _widthGauge.Name = "_widthGauge";
            _widthGauge.Size = new Size(327, 0);
            _widthGauge.TabIndex = 14;
            _widthGauge.TabStop = false;
            // 
            // _hostLabel
            // 
            _hostLabel.AutoSize = true;
            _hostLabel.Dock = DockStyle.Fill;
            _hostLabel.Location = new Point(3, 56);
            _hostLabel.Name = "_hostLabel";
            _hostLabel.Size = new Size(321, 20);
            _hostLabel.TabIndex = 6;
            _hostLabel.Text = "Host";
            _hostLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _hostTextBox
            // 
            _hostTextBox.Dock = DockStyle.Fill;
            _hostTextBox.Location = new Point(3, 80);
            _hostTextBox.Margin = new Padding(3, 4, 3, 4);
            _hostTextBox.Name = "_hostTextBox";
            _hostTextBox.Size = new Size(321, 27);
            _hostTextBox.TabIndex = 7;
            _hostTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // _userLabel
            // 
            _userLabel.AutoSize = true;
            _userLabel.Dock = DockStyle.Fill;
            _userLabel.Location = new Point(3, 111);
            _userLabel.Name = "_userLabel";
            _userLabel.Size = new Size(321, 20);
            _userLabel.TabIndex = 8;
            _userLabel.Text = "Username";
            _userLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _userTextBox
            // 
            _userTextBox.Dock = DockStyle.Fill;
            _userTextBox.Location = new Point(3, 135);
            _userTextBox.Margin = new Padding(3, 4, 3, 4);
            _userTextBox.Name = "_userTextBox";
            _userTextBox.Size = new Size(321, 27);
            _userTextBox.TabIndex = 10;
            _userTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // _passwordLabel
            // 
            _passwordLabel.AutoSize = true;
            _passwordLabel.Dock = DockStyle.Fill;
            _passwordLabel.Location = new Point(3, 166);
            _passwordLabel.Name = "_passwordLabel";
            _passwordLabel.Size = new Size(321, 20);
            _passwordLabel.TabIndex = 9;
            _passwordLabel.Text = "Password";
            _passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _passwordTextBox
            // 
            _passwordTextBox.Dock = DockStyle.Fill;
            _passwordTextBox.Location = new Point(3, 190);
            _passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            _passwordTextBox.Name = "_passwordTextBox";
            _passwordTextBox.PasswordChar = '*';
            _passwordTextBox.Size = new Size(321, 27);
            _passwordTextBox.TabIndex = 11;
            _passwordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // _showPasswordCheckBox
            // 
            _showPasswordCheckBox.Anchor = AnchorStyles.Top;
            _showPasswordCheckBox.AutoSize = true;
            _showPasswordCheckBox.Location = new Point(97, 225);
            _showPasswordCheckBox.Margin = new Padding(3, 4, 3, 4);
            _showPasswordCheckBox.Name = "_showPasswordCheckBox";
            _showPasswordCheckBox.Size = new Size(132, 24);
            _showPasswordCheckBox.TabIndex = 12;
            _showPasswordCheckBox.Text = "Show Password";
            _showPasswordCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            _showPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // _loginButton
            // 
            _loginButton.Dock = DockStyle.Fill;
            _loginButton.Location = new Point(3, 257);
            _loginButton.Margin = new Padding(3, 4, 3, 4);
            _loginButton.Name = "_loginButton";
            _loginButton.Size = new Size(321, 31);
            _loginButton.TabIndex = 13;
            _loginButton.Text = "Login";
            _loginButton.UseVisualStyleBackColor = true;
            // 
            // _settingsButton
            // 
            _settingsButton.Dock = DockStyle.Fill;
            _settingsButton.Location = new Point(3, 296);
            _settingsButton.Margin = new Padding(3, 4, 3, 4);
            _settingsButton.Name = "_settingsButton";
            _settingsButton.Size = new Size(321, 31);
            _settingsButton.TabIndex = 14;
            _settingsButton.Text = "Settings";
            _settingsButton.UseVisualStyleBackColor = true;
            // 
            // LoginBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_groupBox);
            Margin = new Padding(0);
            Name = "LoginBox";
            Size = new Size(333, 445);
            _groupBox.ResumeLayout(false);
            _flowLayout.ResumeLayout(false);
            _flowLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _groupBox;
        private FlowLayoutPanelEx _flowLayout;
        private WidthGauge _widthGauge;
        private Label _hostLabel;
        private TextBox _hostTextBox;
        private Label _userLabel;
        private TextBox _userTextBox;
        private Label _passwordLabel;
        private TextBox _passwordTextBox;
        private CheckBox _showPasswordCheckBox;
        private Button _loginButton;
        private Button _settingsButton;
    }
}
