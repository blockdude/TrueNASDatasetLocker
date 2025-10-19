namespace TrueNASLocker.UI
{
    partial class DatasetViewer
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
            ListViewItem listViewItem1 = new ListViewItem("cat");
            ListViewItem listViewItem2 = new ListViewItem("cng");
            ListViewItem listViewItem3 = new ListViewItem("jam");
            ListViewItem listViewItem4 = new ListViewItem("jam/cas");
            ListViewItem listViewItem5 = new ListViewItem("jam/drv");
            _datasetView = new SplitContainer();
            _datasetControlsSplit = new SplitContainer();
            _refreshButton = new Button();
            _datasetListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            _infoSplitter = new SplitContainer();
            _unlockBox = new DatasetUnlock();
            _editBox = new DatasetEdit();
            _infoBox = new DatasetNone();
            _changePasswordBox = new DatasetPasswordChange();
            _userBox = new UserAccountBox();
            ((System.ComponentModel.ISupportInitialize)_datasetView).BeginInit();
            _datasetView.Panel1.SuspendLayout();
            _datasetView.Panel2.SuspendLayout();
            _datasetView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_datasetControlsSplit).BeginInit();
            _datasetControlsSplit.Panel1.SuspendLayout();
            _datasetControlsSplit.Panel2.SuspendLayout();
            _datasetControlsSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_infoSplitter).BeginInit();
            _infoSplitter.Panel1.SuspendLayout();
            _infoSplitter.Panel2.SuspendLayout();
            _infoSplitter.SuspendLayout();
            SuspendLayout();
            // 
            // _datasetView
            // 
            _datasetView.Dock = DockStyle.Fill;
            _datasetView.FixedPanel = FixedPanel.Panel2;
            _datasetView.Location = new Point(3, 3);
            _datasetView.Name = "_datasetView";
            // 
            // _datasetView.Panel1
            // 
            _datasetView.Panel1.Controls.Add(_datasetControlsSplit);
            // 
            // _datasetView.Panel2
            // 
            _datasetView.Panel2.Controls.Add(_infoSplitter);
            _datasetView.Size = new Size(400, 409);
            _datasetView.SplitterDistance = 262;
            _datasetView.TabIndex = 16;
            _datasetView.TabStop = false;
            // 
            // _datasetControlsSplit
            // 
            _datasetControlsSplit.Dock = DockStyle.Fill;
            _datasetControlsSplit.FixedPanel = FixedPanel.Panel1;
            _datasetControlsSplit.IsSplitterFixed = true;
            _datasetControlsSplit.Location = new Point(0, 0);
            _datasetControlsSplit.Name = "_datasetControlsSplit";
            _datasetControlsSplit.Orientation = Orientation.Horizontal;
            // 
            // _datasetControlsSplit.Panel1
            // 
            _datasetControlsSplit.Panel1.Controls.Add(_refreshButton);
            // 
            // _datasetControlsSplit.Panel2
            // 
            _datasetControlsSplit.Panel2.Controls.Add(_datasetListView);
            _datasetControlsSplit.Size = new Size(262, 409);
            _datasetControlsSplit.SplitterDistance = 25;
            _datasetControlsSplit.TabIndex = 12;
            _datasetControlsSplit.TabStop = false;
            // 
            // _refreshButton
            // 
            _refreshButton.Dock = DockStyle.Fill;
            _refreshButton.Location = new Point(0, 0);
            _refreshButton.Name = "_refreshButton";
            _refreshButton.Size = new Size(262, 25);
            _refreshButton.TabIndex = 30;
            _refreshButton.Text = "Refresh";
            _refreshButton.UseVisualStyleBackColor = true;
            // 
            // _datasetListView
            // 
            _datasetListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            _datasetListView.Dock = DockStyle.Fill;
            _datasetListView.FullRowSelect = true;
            _datasetListView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            _datasetListView.Location = new Point(0, 0);
            _datasetListView.Name = "_datasetListView";
            _datasetListView.Size = new Size(262, 380);
            _datasetListView.Sorting = SortOrder.Ascending;
            _datasetListView.TabIndex = 10;
            _datasetListView.TabStop = false;
            _datasetListView.UseCompatibleStateImageBehavior = false;
            _datasetListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Dataset";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Status";
            columnHeader2.Width = 80;
            // 
            // _infoSplitter
            // 
            _infoSplitter.Dock = DockStyle.Fill;
            _infoSplitter.FixedPanel = FixedPanel.Panel2;
            _infoSplitter.IsSplitterFixed = true;
            _infoSplitter.Location = new Point(0, 0);
            _infoSplitter.Name = "_infoSplitter";
            _infoSplitter.Orientation = Orientation.Horizontal;
            // 
            // _infoSplitter.Panel1
            // 
            _infoSplitter.Panel1.Controls.Add(_unlockBox);
            _infoSplitter.Panel1.Controls.Add(_editBox);
            _infoSplitter.Panel1.Controls.Add(_infoBox);
            _infoSplitter.Panel1.Controls.Add(_changePasswordBox);
            // 
            // _infoSplitter.Panel2
            // 
            _infoSplitter.Panel2.Controls.Add(_userBox);
            _infoSplitter.Size = new Size(134, 409);
            _infoSplitter.SplitterDistance = 250;
            _infoSplitter.TabIndex = 16;
            _infoSplitter.TabStop = false;
            // 
            // _unlockBox
            // 
            _unlockBox.Dock = DockStyle.Fill;
            _unlockBox.Location = new Point(0, 0);
            _unlockBox.Name = "_unlockBox";
            _unlockBox.Password = "";
            _unlockBox.Size = new Size(134, 250);
            _unlockBox.TabIndex = 10;
            // 
            // _editBox
            // 
            _editBox.Dock = DockStyle.Fill;
            _editBox.Location = new Point(0, 0);
            _editBox.Name = "_editBox";
            _editBox.Size = new Size(134, 250);
            _editBox.TabIndex = 15;
            // 
            // _infoBox
            // 
            _infoBox.Dock = DockStyle.Fill;
            _infoBox.Location = new Point(0, 0);
            _infoBox.Name = "_infoBox";
            _infoBox.Size = new Size(134, 250);
            _infoBox.TabIndex = 12;
            // 
            // _changePasswordBox
            // 
            _changePasswordBox.ConfirmPassword = "";
            _changePasswordBox.Dock = DockStyle.Fill;
            _changePasswordBox.Location = new Point(0, 0);
            _changePasswordBox.Name = "_changePasswordBox";
            _changePasswordBox.Password = "";
            _changePasswordBox.Size = new Size(134, 250);
            _changePasswordBox.TabIndex = 13;
            // 
            // _userBox
            // 
            _userBox.Dock = DockStyle.Fill;
            _userBox.Hostname = "localhost";
            _userBox.Location = new Point(0, 0);
            _userBox.Name = "_userBox";
            _userBox.Size = new Size(134, 155);
            _userBox.TabIndex = 20;
            _userBox.Username = "user";
            // 
            // DatasetViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_datasetView);
            Name = "DatasetViewer";
            Padding = new Padding(3);
            Size = new Size(406, 415);
            _datasetView.Panel1.ResumeLayout(false);
            _datasetView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_datasetView).EndInit();
            _datasetView.ResumeLayout(false);
            _datasetControlsSplit.Panel1.ResumeLayout(false);
            _datasetControlsSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_datasetControlsSplit).EndInit();
            _datasetControlsSplit.ResumeLayout(false);
            _infoSplitter.Panel1.ResumeLayout(false);
            _infoSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_infoSplitter).EndInit();
            _infoSplitter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListView _datasetListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private UserAccountBox _userBox;
        private DatasetNone _infoBox;
        private DatasetPasswordChange _changePasswordBox;
        private DatasetUnlock _unlockBox;
        private DatasetEdit _editBox;
        private SplitContainer _datasetView;
        private SplitContainer _infoSplitter;
        private Button _refreshButton;
        private SplitContainer _datasetControlsSplit;
    }
}
