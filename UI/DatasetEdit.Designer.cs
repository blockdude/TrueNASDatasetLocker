namespace TrueNASLocker.UI
{
    partial class DatasetEdit
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
            _lockButton = new Button();
            _changePasswordButton = new Button();
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
            _groupBox.Size = new Size(148, 196);
            _groupBox.TabIndex = 7;
            _groupBox.TabStop = false;
            _groupBox.Text = "Dataset";
            // 
            // _flowLayout
            // 
            _flowLayout.CenterHorizontal = false;
            _flowLayout.CenterVertical = true;
            _flowLayout.Controls.Add(_widthGauge);
            _flowLayout.Controls.Add(_lockButton);
            _flowLayout.Controls.Add(_changePasswordButton);
            _flowLayout.Dock = DockStyle.Fill;
            _flowLayout.FlowDirection = FlowDirection.TopDown;
            _flowLayout.Location = new Point(3, 19);
            _flowLayout.Name = "_flowLayout";
            _flowLayout.Padding = new Padding(0, 58, 0, 0);
            _flowLayout.Size = new Size(142, 174);
            _flowLayout.TabIndex = 7;
            // 
            // _widthGauge
            // 
            _widthGauge.Location = new Point(0, 58);
            _widthGauge.Margin = new Padding(0);
            _widthGauge.Name = "_widthGauge";
            _widthGauge.Size = new Size(142, 0);
            _widthGauge.TabIndex = 7;
            _widthGauge.Text = "widthGauge1";
            // 
            // _lockButton
            // 
            _lockButton.Dock = DockStyle.Fill;
            _lockButton.Location = new Point(3, 61);
            _lockButton.Name = "_lockButton";
            _lockButton.Size = new Size(136, 23);
            _lockButton.TabIndex = 200;
            _lockButton.Text = "Lock";
            _lockButton.UseVisualStyleBackColor = true;
            // 
            // _changePasswordButton
            // 
            _changePasswordButton.Dock = DockStyle.Fill;
            _changePasswordButton.Location = new Point(3, 90);
            _changePasswordButton.Name = "_changePasswordButton";
            _changePasswordButton.Size = new Size(136, 23);
            _changePasswordButton.TabIndex = 210;
            _changePasswordButton.Text = "Change Password";
            _changePasswordButton.UseVisualStyleBackColor = true;
            // 
            // DatasetEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_groupBox);
            Name = "DatasetEdit";
            Size = new Size(148, 196);
            _groupBox.ResumeLayout(false);
            _flowLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _groupBox;
        private Button _changePasswordButton;
        private Button _lockButton;
        private FlowLayoutPanelEx _flowLayout;
        private WidthGauge _widthGauge;
    }
}
