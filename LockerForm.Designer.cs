namespace TrueNASLocker
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
            _datasetViewer = new TrueNASLocker.UI.DatasetViewer();
            _loginBox = new TrueNASLocker.UI.LoginBox();
            SuspendLayout();
            // 
            // _datasetViewer
            // 
            _datasetViewer.Location = new Point(12, 9);
            _datasetViewer.Name = "_datasetViewer";
            _datasetViewer.Padding = new Padding(3);
            _datasetViewer.Size = new Size(182, 360);
            _datasetViewer.TabIndex = 0;
            _datasetViewer.Visible = false;
            // 
            // _loginBox
            // 
            _loginBox.Hostname = "";
            _loginBox.Location = new Point(197, 9);
            _loginBox.Margin = new Padding(0);
            _loginBox.Name = "_loginBox";
            _loginBox.Password = "";
            _loginBox.Size = new Size(128, 363);
            _loginBox.TabIndex = 1;
            _loginBox.Username = "";
            // 
            // LockerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 381);
            Controls.Add(_datasetViewer);
            Controls.Add(_loginBox);
            Name = "LockerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrueNAS Locker";
            Load += LockerForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private UI.DatasetViewer _datasetViewer;
        private UI.LoginBox _loginBox;
    }
}
