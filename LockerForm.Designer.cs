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
            datasetViewer1 = new TrueNASLocker.UI.DatasetViewer();
            SuspendLayout();
            // 
            // datasetViewer1
            // 
            datasetViewer1.Location = new Point(76, 42);
            datasetViewer1.Name = "datasetViewer1";
            datasetViewer1.Size = new Size(776, 426);
            datasetViewer1.TabIndex = 11;
            // 
            // LockerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 587);
            Controls.Add(datasetViewer1);
            Name = "LockerForm";
            Text = "TrueNAS Locker";
            Load += LockerForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private UI.DatasetViewer datasetViewer1;
    }
}
