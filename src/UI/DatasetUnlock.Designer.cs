namespace TrueNASLocker.UI
{
    partial class DatasetUnlock
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
            _showPasswordCheckBox = new CheckBox();
            _unlockButton = new Button();
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
            _groupBox.Size = new Size(159, 231);
            _groupBox.TabIndex = 1;
            _groupBox.TabStop = false;
            _groupBox.Text = "Dataset Unlock";
            // 
            // _flowLayout
            // 
            _flowLayout.CenterHorizontal = false;
            _flowLayout.CenterVertical = true;
            _flowLayout.Controls.Add(_widthGauge);
            _flowLayout.Controls.Add(_passwordLabel);
            _flowLayout.Controls.Add(_passwordTextBox);
            _flowLayout.Controls.Add(_showPasswordCheckBox);
            _flowLayout.Controls.Add(_unlockButton);
            _flowLayout.Dock = DockStyle.Fill;
            _flowLayout.FlowDirection = FlowDirection.TopDown;
            _flowLayout.Location = new Point(3, 19);
            _flowLayout.Name = "_flowLayout";
            _flowLayout.Padding = new Padding(0, 55, 0, 0);
            _flowLayout.Size = new Size(153, 209);
            _flowLayout.TabIndex = 7;
            // 
            // _widthGauge
            // 
            _widthGauge.Location = new Point(0, 55);
            _widthGauge.Margin = new Padding(0);
            _widthGauge.Name = "_widthGauge";
            _widthGauge.Size = new Size(153, 0);
            _widthGauge.TabIndex = 7;
            _widthGauge.Text = "widthGauge1";
            // 
            // _passwordLabel
            // 
            _passwordLabel.AutoSize = true;
            _passwordLabel.Dock = DockStyle.Fill;
            _passwordLabel.Location = new Point(3, 55);
            _passwordLabel.Name = "_passwordLabel";
            _passwordLabel.Size = new Size(147, 15);
            _passwordLabel.TabIndex = 6;
            _passwordLabel.Text = "Password";
            _passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _passwordTextBox
            // 
            _passwordTextBox.Dock = DockStyle.Fill;
            _passwordTextBox.Location = new Point(3, 73);
            _passwordTextBox.Name = "_passwordTextBox";
            _passwordTextBox.PasswordChar = '*';
            _passwordTextBox.Size = new Size(147, 23);
            _passwordTextBox.TabIndex = 200;
            _passwordTextBox.Tag = "";
            _passwordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // _showPasswordCheckBox
            // 
            _showPasswordCheckBox.Anchor = AnchorStyles.Top;
            _showPasswordCheckBox.AutoSize = true;
            _showPasswordCheckBox.Location = new Point(23, 102);
            _showPasswordCheckBox.Name = "_showPasswordCheckBox";
            _showPasswordCheckBox.Size = new Size(107, 19);
            _showPasswordCheckBox.TabIndex = 210;
            _showPasswordCheckBox.Text = "show password";
            _showPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // _unlockButton
            // 
            _unlockButton.Dock = DockStyle.Fill;
            _unlockButton.Location = new Point(3, 127);
            _unlockButton.Name = "_unlockButton";
            _unlockButton.Size = new Size(147, 23);
            _unlockButton.TabIndex = 220;
            _unlockButton.Text = "Unlock";
            _unlockButton.UseVisualStyleBackColor = true;
            // 
            // DatasetUnlock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_groupBox);
            Name = "DatasetUnlock";
            Size = new Size(159, 231);
            _groupBox.ResumeLayout(false);
            _flowLayout.ResumeLayout(false);
            _flowLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _groupBox;
        private FlowLayoutPanelEx _flowLayout;
        private WidthGauge _widthGauge;
        private Label _passwordLabel;
        private TextBox _passwordTextBox;
        private Button _unlockButton;
        private CheckBox _showPasswordCheckBox;
    }
}
