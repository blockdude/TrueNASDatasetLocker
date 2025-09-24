namespace TrueNASLocker.UI
{
    partial class DatasetUnselectedBox
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
            _tableLayoutPanel = new TableLayoutPanel();
            _infoTextBox = new TextBox();
            _groupBox.SuspendLayout();
            _tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // _groupBox
            // 
            _groupBox.Controls.Add(_tableLayoutPanel);
            _groupBox.Dock = DockStyle.Fill;
            _groupBox.Location = new Point(0, 0);
            _groupBox.Name = "_groupBox";
            _groupBox.Size = new Size(115, 206);
            _groupBox.TabIndex = 10;
            _groupBox.TabStop = false;
            _groupBox.Text = "select dataset";
            // 
            // _tableLayoutPanel
            // 
            _tableLayoutPanel.ColumnCount = 3;
            _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            _tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            _tableLayoutPanel.Controls.Add(_infoTextBox, 1, 1);
            _tableLayoutPanel.Dock = DockStyle.Fill;
            _tableLayoutPanel.Location = new Point(3, 19);
            _tableLayoutPanel.Name = "_tableLayoutPanel";
            _tableLayoutPanel.RowCount = 3;
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            _tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            _tableLayoutPanel.Size = new Size(109, 184);
            _tableLayoutPanel.TabIndex = 1;
            // 
            // _infoTextBox
            // 
            _infoTextBox.BorderStyle = BorderStyle.None;
            _infoTextBox.Dock = DockStyle.Fill;
            _infoTextBox.Enabled = false;
            _infoTextBox.Location = new Point(3, 76);
            _infoTextBox.Multiline = true;
            _infoTextBox.Name = "_infoTextBox";
            _infoTextBox.ReadOnly = true;
            _infoTextBox.Size = new Size(102, 31);
            _infoTextBox.TabIndex = 1;
            _infoTextBox.Text = "Select a dataset to get started...";
            _infoTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DatasetUnselectedBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_groupBox);
            Name = "DatasetUnselectedBox";
            Size = new Size(115, 206);
            _groupBox.ResumeLayout(false);
            _tableLayoutPanel.ResumeLayout(false);
            _tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _groupBox;
        private TableLayoutPanel _tableLayoutPanel;
        private TextBox _infoTextBox;
    }
}
