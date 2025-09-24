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
            ListViewItem listViewItem6 = new ListViewItem("jam");
            ListViewItem listViewItem7 = new ListViewItem("jam/cas");
            ListViewItem listViewItem8 = new ListViewItem("jam/drv");
            ListViewItem listViewItem9 = new ListViewItem("cat");
            ListViewItem listViewItem10 = new ListViewItem("cng");
            dataset_form = new Panel();
            _mainSplitter = new SplitContainer();
            _datasetListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            _infoSplitter = new SplitContainer();
            _editBox = new DatasetEdit();
            _infoBox = new DatasetNone();
            _changePasswordBox = new DatasetPasswordChange();
            _unlockBox = new DatasetUnlock();
            _userBox = new UserAccountBox();
            dataset_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_mainSplitter).BeginInit();
            _mainSplitter.Panel1.SuspendLayout();
            _mainSplitter.Panel2.SuspendLayout();
            _mainSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_infoSplitter).BeginInit();
            _infoSplitter.Panel1.SuspendLayout();
            _infoSplitter.Panel2.SuspendLayout();
            _infoSplitter.SuspendLayout();
            SuspendLayout();
            // 
            // dataset_form
            // 
            dataset_form.Controls.Add(_mainSplitter);
            dataset_form.Dock = DockStyle.Fill;
            dataset_form.Location = new Point(0, 0);
            dataset_form.Name = "dataset_form";
            dataset_form.Size = new Size(278, 372);
            dataset_form.TabIndex = 8;
            // 
            // _mainSplitter
            // 
            _mainSplitter.Dock = DockStyle.Fill;
            _mainSplitter.FixedPanel = FixedPanel.Panel2;
            _mainSplitter.Location = new Point(0, 0);
            _mainSplitter.Name = "_mainSplitter";
            // 
            // _mainSplitter.Panel1
            // 
            _mainSplitter.Panel1.Controls.Add(_datasetListView);
            // 
            // _mainSplitter.Panel2
            // 
            _mainSplitter.Panel2.Controls.Add(_infoSplitter);
            _mainSplitter.Size = new Size(278, 372);
            _mainSplitter.SplitterDistance = 141;
            _mainSplitter.TabIndex = 16;
            // 
            // _datasetListView
            // 
            _datasetListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            _datasetListView.Dock = DockStyle.Fill;
            _datasetListView.FullRowSelect = true;
            _datasetListView.Items.AddRange(new ListViewItem[] { listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10 });
            _datasetListView.Location = new Point(0, 0);
            _datasetListView.Name = "_datasetListView";
            _datasetListView.Size = new Size(141, 372);
            _datasetListView.TabIndex = 10;
            _datasetListView.UseCompatibleStateImageBehavior = false;
            _datasetListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Dataset";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Status";
            // 
            // _infoSplitter
            // 
            _infoSplitter.Dock = DockStyle.Fill;
            _infoSplitter.FixedPanel = FixedPanel.Panel2;
            _infoSplitter.Location = new Point(0, 0);
            _infoSplitter.Name = "_infoSplitter";
            _infoSplitter.Orientation = Orientation.Horizontal;
            // 
            // _infoSplitter.Panel1
            // 
            _infoSplitter.Panel1.Controls.Add(_editBox);
            _infoSplitter.Panel1.Controls.Add(_infoBox);
            _infoSplitter.Panel1.Controls.Add(_changePasswordBox);
            _infoSplitter.Panel1.Controls.Add(_unlockBox);
            // 
            // _infoSplitter.Panel2
            // 
            _infoSplitter.Panel2.Controls.Add(_userBox);
            _infoSplitter.Size = new Size(133, 372);
            _infoSplitter.SplitterDistance = 221;
            _infoSplitter.TabIndex = 16;
            // 
            // _editBox
            // 
            _editBox.Dock = DockStyle.Fill;
            _editBox.Location = new Point(0, 0);
            _editBox.Name = "_editBox";
            _editBox.Size = new Size(133, 221);
            _editBox.TabIndex = 15;
            // 
            // _infoBox
            // 
            _infoBox.Dock = DockStyle.Fill;
            _infoBox.Location = new Point(0, 0);
            _infoBox.Name = "_infoBox";
            _infoBox.Size = new Size(133, 221);
            _infoBox.TabIndex = 12;
            // 
            // _changePasswordBox
            // 
            _changePasswordBox.Dock = DockStyle.Fill;
            _changePasswordBox.Location = new Point(0, 0);
            _changePasswordBox.Name = "_changePasswordBox";
            _changePasswordBox.Size = new Size(133, 221);
            _changePasswordBox.TabIndex = 13;
            // 
            // _unlockBox
            // 
            _unlockBox.Dock = DockStyle.Fill;
            _unlockBox.Location = new Point(0, 0);
            _unlockBox.Name = "_unlockBox";
            _unlockBox.Size = new Size(133, 221);
            _unlockBox.TabIndex = 14;
            // 
            // _userBox
            // 
            _userBox.Dock = DockStyle.Fill;
            _userBox.Host = "localhost";
            _userBox.Location = new Point(0, 0);
            _userBox.Name = "_userBox";
            _userBox.Size = new Size(133, 147);
            _userBox.TabIndex = 11;
            _userBox.Username = "user";
            // 
            // DatasetViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataset_form);
            Name = "DatasetViewer";
            Size = new Size(278, 372);
            dataset_form.ResumeLayout(false);
            _mainSplitter.Panel1.ResumeLayout(false);
            _mainSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_mainSplitter).EndInit();
            _mainSplitter.ResumeLayout(false);
            _infoSplitter.Panel1.ResumeLayout(false);
            _infoSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_infoSplitter).EndInit();
            _infoSplitter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel dataset_form;
        private ListView _datasetListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private UserAccountBox _userBox;
        private DatasetNone _infoBox;
        private DatasetPasswordChange _changePasswordBox;
        private DatasetUnlock _unlockBox;
        private DatasetEdit _editBox;
        private SplitContainer _mainSplitter;
        private SplitContainer _infoSplitter;
    }
}
