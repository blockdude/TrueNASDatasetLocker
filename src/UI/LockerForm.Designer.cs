namespace TrueNASLocker.UI
{
    partial class LockerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Settings settings1 = new Settings();
            _loginBox = new LoginBox();
            _settingsBox = new SettingsBox();
            _versionLabel = new Label();
            panel1 = new Panel();
            _datasetViewer = new DatasetViewer();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // _loginBox
            // 
            _loginBox.Hostname = "";
            _loginBox.Location = new Point(52, 46);
            _loginBox.Margin = new Padding(0);
            _loginBox.Name = "_loginBox";
            _loginBox.Password = "";
            _loginBox.Size = new Size(310, 359);
            _loginBox.TabIndex = 1;
            _loginBox.Username = "";
            // 
            // _settingsBox
            // 
            _settingsBox.Location = new Point(52, 49);
            _settingsBox.Name = "_settingsBox";
            settings1.Hostname = null;
            settings1.Path = "";
            settings1.Port = 0;
            settings1.SaveHostname = false;
            settings1.SaveUsername = false;
            settings1.ShowPatchNotes = false;
            settings1.Username = null;
            settings1.WSS = false;
            _settingsBox.Settings = settings1;
            _settingsBox.Size = new Size(310, 356);
            _settingsBox.TabIndex = 2;
            // 
            // _versionLabel
            // 
            _versionLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _versionLabel.AutoSize = true;
            _versionLabel.Location = new Point(12, 434);
            _versionLabel.Name = "_versionLabel";
            _versionLabel.Size = new Size(45, 15);
            _versionLabel.TabIndex = 3;
            _versionLabel.Text = "Version";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(_datasetViewer);
            panel1.Controls.Add(_loginBox);
            panel1.Controls.Add(_settingsBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 419);
            panel1.TabIndex = 4;
            // 
            // _datasetViewer
            // 
            _datasetViewer.Location = new Point(49, 49);
            _datasetViewer.Name = "_datasetViewer";
            _datasetViewer.Padding = new Padding(3);
            _datasetViewer.Size = new Size(313, 356);
            _datasetViewer.TabIndex = 0;
            _datasetViewer.Visible = false;
            // 
            // LockerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 458);
            Controls.Add(panel1);
            Controls.Add(_versionLabel);
            Name = "LockerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrueNAS Dataset Locker";
            FormClosing += LockerForm_Closing;
            Shown += LockerForm_Shown;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LoginBox _loginBox;
        private SettingsBox _settingsBox;
        private Label _versionLabel;
        private Panel panel1;
        private DatasetViewer _datasetViewer;
    }
}
