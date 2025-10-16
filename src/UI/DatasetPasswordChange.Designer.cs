namespace TrueNASLocker.UI
{
    partial class DatasetPasswordChange
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
            _passwordLabel = new Label();
            _passwordTextBox = new TextBox();
            _confirmLabel = new Label();
            _confirmTextBox = new TextBox();
            _showPasswordCheckBox = new CheckBox();
            _confirmButton = new Button();
            _cancelButton = new Button();
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
            _groupBox.Size = new Size(158, 255);
            _groupBox.TabIndex = 8;
            _groupBox.TabStop = false;
            _groupBox.Text = "Change Password";
            // 
            // _flowLayout
            // 
            _flowLayout.CenterHorizontal = false;
            _flowLayout.CenterVertical = true;
            _flowLayout.Controls.Add(_widthGauge);
            _flowLayout.Controls.Add(_passwordLabel);
            _flowLayout.Controls.Add(_passwordTextBox);
            _flowLayout.Controls.Add(_confirmLabel);
            _flowLayout.Controls.Add(_confirmTextBox);
            _flowLayout.Controls.Add(_showPasswordCheckBox);
            _flowLayout.Controls.Add(_confirmButton);
            _flowLayout.Controls.Add(_cancelButton);
            _flowLayout.Dock = DockStyle.Fill;
            _flowLayout.FlowDirection = FlowDirection.TopDown;
            _flowLayout.Location = new Point(3, 19);
            _flowLayout.Name = "_flowLayout";
            _flowLayout.Padding = new Padding(0, 31, 0, 0);
            _flowLayout.Size = new Size(152, 233);
            _flowLayout.TabIndex = 7;
            // 
            // _widthGauge
            // 
            _widthGauge.Location = new Point(0, 31);
            _widthGauge.Margin = new Padding(0);
            _widthGauge.Name = "_widthGauge";
            _widthGauge.Size = new Size(152, 0);
            _widthGauge.TabIndex = 7;
            _widthGauge.Text = "widthGauge1";
            // 
            // _passwordLabel
            // 
            _passwordLabel.AutoSize = true;
            _passwordLabel.Dock = DockStyle.Fill;
            _passwordLabel.Location = new Point(3, 31);
            _passwordLabel.Name = "_passwordLabel";
            _passwordLabel.Size = new Size(146, 15);
            _passwordLabel.TabIndex = 4;
            _passwordLabel.Text = "New Password";
            _passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _passwordTextBox
            // 
            _passwordTextBox.Dock = DockStyle.Fill;
            _passwordTextBox.Location = new Point(3, 49);
            _passwordTextBox.Name = "_passwordTextBox";
            _passwordTextBox.PasswordChar = '*';
            _passwordTextBox.Size = new Size(146, 23);
            _passwordTextBox.TabIndex = 200;
            _passwordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // _confirmLabel
            // 
            _confirmLabel.AutoSize = true;
            _confirmLabel.Dock = DockStyle.Fill;
            _confirmLabel.Location = new Point(3, 75);
            _confirmLabel.Name = "_confirmLabel";
            _confirmLabel.Size = new Size(146, 15);
            _confirmLabel.TabIndex = 5;
            _confirmLabel.Text = "Confirm Password";
            _confirmLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _confirmTextBox
            // 
            _confirmTextBox.Dock = DockStyle.Fill;
            _confirmTextBox.Location = new Point(3, 93);
            _confirmTextBox.Name = "_confirmTextBox";
            _confirmTextBox.PasswordChar = '*';
            _confirmTextBox.Size = new Size(146, 23);
            _confirmTextBox.TabIndex = 210;
            _confirmTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // _showPasswordCheckBox
            // 
            _showPasswordCheckBox.Anchor = AnchorStyles.Top;
            _showPasswordCheckBox.AutoSize = true;
            _showPasswordCheckBox.Location = new Point(22, 122);
            _showPasswordCheckBox.Name = "_showPasswordCheckBox";
            _showPasswordCheckBox.Size = new Size(108, 19);
            _showPasswordCheckBox.TabIndex = 220;
            _showPasswordCheckBox.Text = "Show Password";
            _showPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // _confirmButton
            // 
            _confirmButton.Dock = DockStyle.Fill;
            _confirmButton.Location = new Point(3, 147);
            _confirmButton.Name = "_confirmButton";
            _confirmButton.Size = new Size(146, 23);
            _confirmButton.TabIndex = 230;
            _confirmButton.Text = "Confirm";
            _confirmButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            _cancelButton.Dock = DockStyle.Fill;
            _cancelButton.Location = new Point(3, 176);
            _cancelButton.Name = "_cancelButton";
            _cancelButton.Size = new Size(146, 23);
            _cancelButton.TabIndex = 240;
            _cancelButton.Text = "Cancel";
            _cancelButton.UseVisualStyleBackColor = true;
            // 
            // DatasetPasswordChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_groupBox);
            Name = "DatasetPasswordChange";
            Size = new Size(158, 255);
            _groupBox.ResumeLayout(false);
            _flowLayout.ResumeLayout(false);
            _flowLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _groupBox;
        private CheckBox _showPasswordCheckBox;
        private Label _confirmLabel;
        private Label _passwordLabel;
        private TextBox _confirmTextBox;
        private Button _cancelButton;
        private Button _confirmButton;
        private TextBox _passwordTextBox;
        private FlowLayoutPanelEx _flowLayout;
        private WidthGauge _widthGauge;
    }
}
