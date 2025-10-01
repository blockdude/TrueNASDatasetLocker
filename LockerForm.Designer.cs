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
            SuspendLayout();
            // 
            // _datasetViewer
            // 
            _datasetViewer.Dock = DockStyle.Fill;
            _datasetViewer.Location = new Point(0, 0);
            _datasetViewer.Name = "_datasetViewer";
            _datasetViewer.Padding = new Padding(3);
            _datasetViewer.Size = new Size(330, 378);
            _datasetViewer.TabIndex = 0;
            // 
            // LockerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 378);
            Controls.Add(_datasetViewer);
            Name = "LockerForm";
            Text = "TrueNAS Locker";
            Load += LockerForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private UI.DatasetViewer _datasetViewer;
    }
}
