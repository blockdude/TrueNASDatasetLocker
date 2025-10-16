namespace TrueNASLocker.UI
{
    partial class UserAccountBox
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
            _logoutButton = new Button();
            _groupBox.SuspendLayout();
            _flowLayout.SuspendLayout();
            SuspendLayout();
            // 
            // _groupBox
            // 
            _groupBox.Controls.Add(_flowLayout);
            _groupBox.Dock = DockStyle.Fill;
            _groupBox.Location = new Point(0, 0);
            _groupBox.Name = "_groupBox";
            _groupBox.Size = new Size(167, 215);
            _groupBox.TabIndex = 9;
            _groupBox.TabStop = false;
            _groupBox.Text = "User Account";
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
            _flowLayout.Controls.Add(_logoutButton);
            _flowLayout.Dock = DockStyle.Fill;
            _flowLayout.FlowDirection = FlowDirection.TopDown;
            _flowLayout.Location = new Point(3, 19);
            _flowLayout.Name = "_flowLayout";
            _flowLayout.Padding = new Padding(0, 38, 0, 0);
            _flowLayout.Size = new Size(161, 193);
            _flowLayout.TabIndex = 12;
            // 
            // _widthGauge
            // 
            _widthGauge.Location = new Point(0, 38);
            _widthGauge.Margin = new Padding(0);
            _widthGauge.Name = "_widthGauge";
            _widthGauge.Size = new Size(161, 0);
            _widthGauge.TabIndex = 17;
            _widthGauge.Text = "widthGauge1";
            // 
            // _hostLabel
            // 
            _hostLabel.AutoSize = true;
            _hostLabel.Dock = DockStyle.Fill;
            _hostLabel.Location = new Point(3, 38);
            _hostLabel.Name = "_hostLabel";
            _hostLabel.Size = new Size(155, 15);
            _hostLabel.TabIndex = 18;
            _hostLabel.Text = "Host";
            _hostLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _hostTextBox
            // 
            _hostTextBox.Dock = DockStyle.Fill;
            _hostTextBox.Enabled = false;
            _hostTextBox.Location = new Point(3, 56);
            _hostTextBox.Name = "_hostTextBox";
            _hostTextBox.ReadOnly = true;
            _hostTextBox.Size = new Size(155, 23);
            _hostTextBox.TabIndex = 16;
            _hostTextBox.Text = "localhost";
            _hostTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // _userLabel
            // 
            _userLabel.AutoSize = true;
            _userLabel.Dock = DockStyle.Fill;
            _userLabel.Location = new Point(3, 82);
            _userLabel.Name = "_userLabel";
            _userLabel.Size = new Size(155, 15);
            _userLabel.TabIndex = 19;
            _userLabel.Text = "Username";
            _userLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _userTextBox
            // 
            _userTextBox.Dock = DockStyle.Fill;
            _userTextBox.Enabled = false;
            _userTextBox.Location = new Point(3, 100);
            _userTextBox.Name = "_userTextBox";
            _userTextBox.ReadOnly = true;
            _userTextBox.Size = new Size(155, 23);
            _userTextBox.TabIndex = 15;
            _userTextBox.Text = "user";
            _userTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // _logoutButton
            // 
            _logoutButton.Dock = DockStyle.Fill;
            _logoutButton.Location = new Point(3, 129);
            _logoutButton.Name = "_logoutButton";
            _logoutButton.Size = new Size(155, 23);
            _logoutButton.TabIndex = 400;
            _logoutButton.Text = "Logout";
            _logoutButton.UseVisualStyleBackColor = true;
            // 
            // UserAccountBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_groupBox);
            Name = "UserAccountBox";
            Size = new Size(167, 215);
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
        private Button _logoutButton;
    }
}
