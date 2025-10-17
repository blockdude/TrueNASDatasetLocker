namespace TrueNASLocker.UI
{
    partial class SettingsBox
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
            _pathPanel = new Panel();
            _pathTextBox = new TextBox();
            numericUpDown1 = new NumericUpDown();
            _pathLabel = new Label();
            _portPanel = new Panel();
            _portNumBox = new NumericUpDown();
            _portLabel = new Label();
            _wssCheckBox = new CheckBox();
            _saveHostCheckBox = new CheckBox();
            _saveUserCheckBox = new CheckBox();
            _currentVersionLabel = new Label();
            _latestVersionLabel = new Label();
            _updateButton = new Button();
            _applyButton = new Button();
            _cancelButton = new Button();
            _groupBox.SuspendLayout();
            _flowLayout.SuspendLayout();
            _pathPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            _portPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_portNumBox).BeginInit();
            SuspendLayout();
            // 
            // _groupBox
            // 
            _groupBox.Controls.Add(_flowLayout);
            _groupBox.Dock = DockStyle.Fill;
            _groupBox.Location = new Point(0, 0);
            _groupBox.Name = "_groupBox";
            _groupBox.Size = new Size(255, 337);
            _groupBox.TabIndex = 1;
            _groupBox.TabStop = false;
            _groupBox.Text = "Settings";
            // 
            // _flowLayout
            // 
            _flowLayout.CenterHorizontal = false;
            _flowLayout.CenterVertical = true;
            _flowLayout.Controls.Add(_widthGauge);
            _flowLayout.Controls.Add(_pathPanel);
            _flowLayout.Controls.Add(_portPanel);
            _flowLayout.Controls.Add(_wssCheckBox);
            _flowLayout.Controls.Add(_saveHostCheckBox);
            _flowLayout.Controls.Add(_saveUserCheckBox);
            _flowLayout.Controls.Add(_currentVersionLabel);
            _flowLayout.Controls.Add(_latestVersionLabel);
            _flowLayout.Controls.Add(_updateButton);
            _flowLayout.Controls.Add(_applyButton);
            _flowLayout.Controls.Add(_cancelButton);
            _flowLayout.Dock = DockStyle.Fill;
            _flowLayout.FlowDirection = FlowDirection.TopDown;
            _flowLayout.Location = new Point(3, 19);
            _flowLayout.Name = "_flowLayout";
            _flowLayout.Padding = new Padding(0, 32, 0, 0);
            _flowLayout.Size = new Size(249, 315);
            _flowLayout.TabIndex = 6;
            // 
            // _widthGauge
            // 
            _widthGauge.Location = new Point(0, 32);
            _widthGauge.Margin = new Padding(0);
            _widthGauge.Name = "_widthGauge";
            _widthGauge.Size = new Size(249, 0);
            _widthGauge.TabIndex = 14;
            // 
            // _pathPanel
            // 
            _pathPanel.Controls.Add(_pathTextBox);
            _pathPanel.Controls.Add(numericUpDown1);
            _pathPanel.Controls.Add(_pathLabel);
            _pathPanel.Dock = DockStyle.Fill;
            _pathPanel.Location = new Point(0, 35);
            _pathPanel.Margin = new Padding(0, 3, 0, 3);
            _pathPanel.Name = "_pathPanel";
            _pathPanel.Size = new Size(249, 23);
            _pathPanel.TabIndex = 27;
            // 
            // _pathTextBox
            // 
            _pathTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            _pathTextBox.Location = new Point(32, 0);
            _pathTextBox.Name = "_pathTextBox";
            _pathTextBox.Size = new Size(214, 23);
            _pathTextBox.TabIndex = 21;
            _pathTextBox.Text = "pool00/shares";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Location = new Point(32, -39);
            numericUpDown1.Margin = new Padding(0);
            numericUpDown1.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(263, 23);
            numericUpDown1.TabIndex = 20;
            numericUpDown1.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // _pathLabel
            // 
            _pathLabel.AutoSize = true;
            _pathLabel.Location = new Point(0, 3);
            _pathLabel.Margin = new Padding(0);
            _pathLabel.Name = "_pathLabel";
            _pathLabel.Size = new Size(34, 15);
            _pathLabel.TabIndex = 19;
            _pathLabel.Text = "Path:";
            _pathLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _portPanel
            // 
            _portPanel.Controls.Add(_portNumBox);
            _portPanel.Controls.Add(_portLabel);
            _portPanel.Dock = DockStyle.Fill;
            _portPanel.Location = new Point(0, 64);
            _portPanel.Margin = new Padding(0, 3, 0, 3);
            _portPanel.Name = "_portPanel";
            _portPanel.Size = new Size(249, 23);
            _portPanel.TabIndex = 26;
            // 
            // _portNumBox
            // 
            _portNumBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            _portNumBox.Location = new Point(32, 0);
            _portNumBox.Margin = new Padding(0);
            _portNumBox.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            _portNumBox.Name = "_portNumBox";
            _portNumBox.Size = new Size(214, 23);
            _portNumBox.TabIndex = 20;
            _portNumBox.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // _portLabel
            // 
            _portLabel.AutoSize = true;
            _portLabel.Location = new Point(0, 3);
            _portLabel.Margin = new Padding(0);
            _portLabel.Name = "_portLabel";
            _portLabel.Size = new Size(32, 15);
            _portLabel.TabIndex = 19;
            _portLabel.Text = "Port:";
            _portLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _wssCheckBox
            // 
            _wssCheckBox.Dock = DockStyle.Fill;
            _wssCheckBox.Location = new Point(3, 93);
            _wssCheckBox.Name = "_wssCheckBox";
            _wssCheckBox.RightToLeft = RightToLeft.No;
            _wssCheckBox.Size = new Size(243, 19);
            _wssCheckBox.TabIndex = 20;
            _wssCheckBox.Text = "Use Secure WebSocket (wss://)";
            _wssCheckBox.UseVisualStyleBackColor = true;
            // 
            // _saveHostCheckBox
            // 
            _saveHostCheckBox.Dock = DockStyle.Fill;
            _saveHostCheckBox.Location = new Point(3, 118);
            _saveHostCheckBox.Name = "_saveHostCheckBox";
            _saveHostCheckBox.Size = new Size(243, 19);
            _saveHostCheckBox.TabIndex = 19;
            _saveHostCheckBox.Text = "Save Hostname";
            _saveHostCheckBox.UseVisualStyleBackColor = true;
            // 
            // _saveUserCheckBox
            // 
            _saveUserCheckBox.Dock = DockStyle.Fill;
            _saveUserCheckBox.Location = new Point(3, 143);
            _saveUserCheckBox.Name = "_saveUserCheckBox";
            _saveUserCheckBox.Size = new Size(243, 19);
            _saveUserCheckBox.TabIndex = 21;
            _saveUserCheckBox.Text = "Save Username";
            _saveUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // _currentVersionLabel
            // 
            _currentVersionLabel.AutoSize = true;
            _currentVersionLabel.Dock = DockStyle.Fill;
            _currentVersionLabel.Location = new Point(3, 165);
            _currentVersionLabel.Name = "_currentVersionLabel";
            _currentVersionLabel.Size = new Size(243, 15);
            _currentVersionLabel.TabIndex = 24;
            _currentVersionLabel.Text = "Current Version:";
            // 
            // _latestVersionLabel
            // 
            _latestVersionLabel.AutoSize = true;
            _latestVersionLabel.Dock = DockStyle.Fill;
            _latestVersionLabel.Location = new Point(3, 180);
            _latestVersionLabel.Name = "_latestVersionLabel";
            _latestVersionLabel.Size = new Size(243, 15);
            _latestVersionLabel.TabIndex = 25;
            _latestVersionLabel.Text = "Latest Version:";
            // 
            // _updateButton
            // 
            _updateButton.Dock = DockStyle.Fill;
            _updateButton.Location = new Point(3, 198);
            _updateButton.Name = "_updateButton";
            _updateButton.Size = new Size(243, 23);
            _updateButton.TabIndex = 23;
            _updateButton.Text = "Update";
            _updateButton.UseVisualStyleBackColor = true;
            // 
            // _applyButton
            // 
            _applyButton.Dock = DockStyle.Fill;
            _applyButton.Location = new Point(3, 227);
            _applyButton.Name = "_applyButton";
            _applyButton.Size = new Size(243, 23);
            _applyButton.TabIndex = 15;
            _applyButton.Text = "Apply";
            _applyButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            _cancelButton.Dock = DockStyle.Fill;
            _cancelButton.Location = new Point(3, 256);
            _cancelButton.Name = "_cancelButton";
            _cancelButton.Size = new Size(243, 23);
            _cancelButton.TabIndex = 16;
            _cancelButton.Text = "Cancel";
            _cancelButton.UseVisualStyleBackColor = true;
            // 
            // SettingsBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_groupBox);
            Name = "SettingsBox";
            Size = new Size(255, 337);
            _groupBox.ResumeLayout(false);
            _flowLayout.ResumeLayout(false);
            _flowLayout.PerformLayout();
            _pathPanel.ResumeLayout(false);
            _pathPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            _portPanel.ResumeLayout(false);
            _portPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_portNumBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _groupBox;
        private TrueNASLocker.UI.FlowLayoutPanelEx _flowLayout;
        private TrueNASLocker.UI.WidthGauge _widthGauge;
        private Label _currentVersionLabel;
        private Label _latestVersionLabel;
        private Button _updateButton;
        private Button _applyButton;
        private Button _cancelButton;
        private CheckBox _wssCheckBox;
        private CheckBox _saveHostCheckBox;
        private CheckBox _saveUserCheckBox;
        private Panel _portPanel;
        private Label _portLabel;
        private NumericUpDown _portNumBox;
        private Panel _pathPanel;
        private NumericUpDown numericUpDown1;
        private Label _pathLabel;
        private TextBox _pathTextBox;
    }
}
