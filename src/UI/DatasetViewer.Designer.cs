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
            _datasetListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            _controlsTable = new TableLayoutPanel();
            _miscBox = new GroupBox();
            _miscLayout = new FlowLayoutPanelEx();
            _miscWidthGauge = new WidthGauge();
            _refreshButton = new Button();
            _userBox = new UserAccountBox();
            _datasetControlsPanel = new Panel();
            _unlockBox = new DatasetUnlock();
            _editBox = new DatasetEdit();
            _infoBox = new DatasetNone();
            _changePasswordBox = new DatasetPasswordChange();
            ((System.ComponentModel.ISupportInitialize)_datasetView).BeginInit();
            _datasetView.Panel1.SuspendLayout();
            _datasetView.Panel2.SuspendLayout();
            _datasetView.SuspendLayout();
            _controlsTable.SuspendLayout();
            _miscBox.SuspendLayout();
            _miscLayout.SuspendLayout();
            _datasetControlsPanel.SuspendLayout();
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
            _datasetView.Panel1.Controls.Add(_datasetListView);
            // 
            // _datasetView.Panel2
            // 
            _datasetView.Panel2.Controls.Add(_controlsTable);
            _datasetView.Size = new Size(472, 409);
            _datasetView.SplitterDistance = 320;
            _datasetView.TabIndex = 16;
            _datasetView.TabStop = false;
            // 
            // _datasetListView
            // 
            _datasetListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            _datasetListView.Dock = DockStyle.Fill;
            _datasetListView.FullRowSelect = true;
            _datasetListView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            _datasetListView.Location = new Point(0, 0);
            _datasetListView.Name = "_datasetListView";
            _datasetListView.Size = new Size(320, 409);
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
            // columnHeader3
            // 
            columnHeader3.Text = "Used";
            columnHeader3.Width = 68;
            // 
            // _controlsTable
            // 
            _controlsTable.ColumnCount = 1;
            _controlsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _controlsTable.Controls.Add(_miscBox, 0, 1);
            _controlsTable.Controls.Add(_userBox, 0, 2);
            _controlsTable.Controls.Add(_datasetControlsPanel, 0, 0);
            _controlsTable.Dock = DockStyle.Fill;
            _controlsTable.Location = new Point(0, 0);
            _controlsTable.Margin = new Padding(0);
            _controlsTable.Name = "_controlsTable";
            _controlsTable.RowCount = 3;
            _controlsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _controlsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            _controlsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            _controlsTable.Size = new Size(148, 409);
            _controlsTable.TabIndex = 0;
            // 
            // _miscBox
            // 
            _miscBox.Controls.Add(_miscLayout);
            _miscBox.Dock = DockStyle.Fill;
            _miscBox.Location = new Point(0, 204);
            _miscBox.Margin = new Padding(0);
            _miscBox.Name = "_miscBox";
            _miscBox.Size = new Size(148, 60);
            _miscBox.TabIndex = 22;
            _miscBox.TabStop = false;
            _miscBox.Text = "Refresh Datasets";
            // 
            // _miscLayout
            // 
            _miscLayout.CenterHorizontal = false;
            _miscLayout.CenterVertical = true;
            _miscLayout.Controls.Add(_miscWidthGauge);
            _miscLayout.Controls.Add(_refreshButton);
            _miscLayout.Dock = DockStyle.Fill;
            _miscLayout.FlowDirection = FlowDirection.TopDown;
            _miscLayout.Location = new Point(3, 19);
            _miscLayout.Name = "_miscLayout";
            _miscLayout.Padding = new Padding(0, 4, 0, 0);
            _miscLayout.Size = new Size(142, 38);
            _miscLayout.TabIndex = 0;
            // 
            // _miscWidthGauge
            // 
            _miscWidthGauge.Anchor = AnchorStyles.Top;
            _miscWidthGauge.Location = new Point(0, 4);
            _miscWidthGauge.Margin = new Padding(0);
            _miscWidthGauge.Name = "_miscWidthGauge";
            _miscWidthGauge.Size = new Size(142, 0);
            _miscWidthGauge.TabIndex = 31;
            // 
            // _refreshButton
            // 
            _refreshButton.Dock = DockStyle.Fill;
            _refreshButton.Location = new Point(3, 7);
            _refreshButton.Name = "_refreshButton";
            _refreshButton.Size = new Size(136, 23);
            _refreshButton.TabIndex = 30;
            _refreshButton.Text = "Refresh";
            _refreshButton.UseVisualStyleBackColor = true;
            // 
            // _userBox
            // 
            _userBox.Dock = DockStyle.Fill;
            _userBox.Hostname = "localhost";
            _userBox.Location = new Point(0, 264);
            _userBox.Margin = new Padding(0);
            _userBox.Name = "_userBox";
            _userBox.Size = new Size(148, 145);
            _userBox.TabIndex = 20;
            _userBox.Username = "user";
            // 
            // _datasetControlsPanel
            // 
            _datasetControlsPanel.Controls.Add(_unlockBox);
            _datasetControlsPanel.Controls.Add(_editBox);
            _datasetControlsPanel.Controls.Add(_infoBox);
            _datasetControlsPanel.Controls.Add(_changePasswordBox);
            _datasetControlsPanel.Dock = DockStyle.Fill;
            _datasetControlsPanel.Location = new Point(0, 0);
            _datasetControlsPanel.Margin = new Padding(0);
            _datasetControlsPanel.Name = "_datasetControlsPanel";
            _datasetControlsPanel.Size = new Size(148, 204);
            _datasetControlsPanel.TabIndex = 21;
            // 
            // _unlockBox
            // 
            _unlockBox.Dock = DockStyle.Fill;
            _unlockBox.Location = new Point(0, 0);
            _unlockBox.Name = "_unlockBox";
            _unlockBox.Password = "";
            _unlockBox.Size = new Size(148, 204);
            _unlockBox.TabIndex = 10;
            // 
            // _editBox
            // 
            _editBox.Dock = DockStyle.Fill;
            _editBox.Location = new Point(0, 0);
            _editBox.Name = "_editBox";
            _editBox.Size = new Size(148, 204);
            _editBox.TabIndex = 15;
            // 
            // _infoBox
            // 
            _infoBox.Dock = DockStyle.Fill;
            _infoBox.Location = new Point(0, 0);
            _infoBox.Name = "_infoBox";
            _infoBox.Size = new Size(148, 204);
            _infoBox.TabIndex = 12;
            // 
            // _changePasswordBox
            // 
            _changePasswordBox.ConfirmPassword = "";
            _changePasswordBox.Dock = DockStyle.Fill;
            _changePasswordBox.Location = new Point(0, 0);
            _changePasswordBox.Name = "_changePasswordBox";
            _changePasswordBox.Password = "";
            _changePasswordBox.Size = new Size(148, 204);
            _changePasswordBox.TabIndex = 13;
            // 
            // DatasetViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_datasetView);
            Name = "DatasetViewer";
            Padding = new Padding(3);
            Size = new Size(478, 415);
            _datasetView.Panel1.ResumeLayout(false);
            _datasetView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_datasetView).EndInit();
            _datasetView.ResumeLayout(false);
            _controlsTable.ResumeLayout(false);
            _miscBox.ResumeLayout(false);
            _miscLayout.ResumeLayout(false);
            _datasetControlsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private UserAccountBox _userBox;
        private DatasetNone _infoBox;
        private DatasetPasswordChange _changePasswordBox;
        private DatasetUnlock _unlockBox;
        private DatasetEdit _editBox;
        private SplitContainer _datasetView;
        private Button _refreshButton;
        private TableLayoutPanel _controlsTable;
        private Panel _datasetControlsPanel;
        private ListView _datasetListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox _miscBox;
        private FlowLayoutPanelEx _miscLayout;
        private WidthGauge _miscWidthGauge;
    }
}
