﻿namespace ps2ls.Forms
{
    partial class AssetBrowser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetBrowser));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.packsListBox = new System.Windows.Forms.ListBox();
            this.packContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.extractPacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addPacksButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.packCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.assetsDataGridView = new System.Windows.Forms.DataGridView();
            this.FileIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LengthInKilobytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchTextTypeToolStripDrownDownButton1 = new ps2ls.Forms.Controls.SearchTextTypeToolStripDrownDownButton();
            this.searchTextBox = new ps2ls.Forms.Controls.SearchToolStripTextBox();
            this.clearSearchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.filesMaxComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.packFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.packOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportAssetFileToCsvSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.packContextMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataGridView)).BeginInit();
            this.assetContextMenuStrip.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.packsListBox);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer2.Panel1.Controls.Add(this.statusStrip2);
            this.splitContainer2.Panel1MinSize = 200;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.assetsDataGridView);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 600);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.TabIndex = 2;
            // 
            // packsListBox
            // 
            this.packsListBox.ContextMenuStrip = this.packContextMenuStrip;
            this.packsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.packsListBox.FormattingEnabled = true;
            this.packsListBox.Location = new System.Drawing.Point(0, 25);
            this.packsListBox.Name = "packsListBox";
            this.packsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.packsListBox.Size = new System.Drawing.Size(200, 553);
            this.packsListBox.TabIndex = 0;
            this.packsListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.packsListBox_DrawItem);
            this.packsListBox.SelectedIndexChanged += new System.EventHandler(this.packsListBox_SelectedIndexChanged);
            this.packsListBox.SelectedValueChanged += new System.EventHandler(this.packsListBox_SelectedValueChanged);
            // 
            // packContextMenuStrip
            // 
            this.packContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractPacksToolStripMenuItem});
            this.packContextMenuStrip.Name = "packContextMenuStrip";
            this.packContextMenuStrip.Size = new System.Drawing.Size(169, 26);
            this.packContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.packContextMenuStrip_Opening);
            // 
            // extractPacksToolStripMenuItem
            // 
            this.extractPacksToolStripMenuItem.Image = global::ps2ls.Properties.Resources.drive_download;
            this.extractPacksToolStripMenuItem.Name = "extractPacksToolStripMenuItem";
            this.extractPacksToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.extractPacksToolStripMenuItem.Text = "Extract 0 Pack(s)...";
            this.extractPacksToolStripMenuItem.Click += new System.EventHandler(this.extractPacksToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPacksButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(200, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addPacksButton
            // 
            this.addPacksButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addPacksButton.Image = global::ps2ls.Properties.Resources.box__plus;
            this.addPacksButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addPacksButton.Name = "addPacksButton";
            this.addPacksButton.Size = new System.Drawing.Size(23, 22);
            this.addPacksButton.Text = "Add Packs...";
            this.addPacksButton.Click += new System.EventHandler(this.addPacksButton_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.packCountLabel});
            this.statusStrip2.Location = new System.Drawing.Point(0, 578);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(200, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 2;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // packCountLabel
            // 
            this.packCountLabel.Image = global::ps2ls.Properties.Resources.box_search_result;
            this.packCountLabel.Name = "packCountLabel";
            this.packCountLabel.Size = new System.Drawing.Size(40, 17);
            this.packCountLabel.Text = "0/0";
            // 
            // assetsDataGridView
            // 
            this.assetsDataGridView.AllowUserToAddRows = false;
            this.assetsDataGridView.AllowUserToDeleteRows = false;
            this.assetsDataGridView.AllowUserToOrderColumns = true;
            this.assetsDataGridView.AllowUserToResizeRows = false;
            this.assetsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.assetsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assetsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.assetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileIcon,
            this.FileName,
            this.FileType,
            this.LengthInKilobytes});
            this.assetsDataGridView.ContextMenuStrip = this.assetContextMenuStrip;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.assetsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.assetsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.assetsDataGridView.Name = "assetsDataGridView";
            this.assetsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assetsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.assetsDataGridView.RowHeadersVisible = false;
            this.assetsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assetsDataGridView.Size = new System.Drawing.Size(596, 553);
            this.assetsDataGridView.TabIndex = 1;
            this.assetsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assetsDataGridView_CellDoubleClick);
            this.assetsDataGridView.SelectionChanged += new System.EventHandler(this.assetsDataGridView_SelectionChanged);
            // 
            // FileIcon
            // 
            this.FileIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FileIcon.FillWeight = 20F;
            this.FileIcon.HeaderText = "";
            this.FileIcon.Name = "FileIcon";
            this.FileIcon.ReadOnly = true;
            this.FileIcon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FileIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FileIcon.Width = 20;
            // 
            // FileName
            // 
            this.FileName.FillWeight = 96.01353F;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // FileType
            // 
            this.FileType.FillWeight = 96.01353F;
            this.FileType.HeaderText = "Type";
            this.FileType.Name = "FileType";
            this.FileType.ReadOnly = true;
            // 
            // LengthInKilobytes
            // 
            this.LengthInKilobytes.FillWeight = 96.01353F;
            this.LengthInKilobytes.HeaderText = "Length (kb)";
            this.LengthInKilobytes.Name = "LengthInKilobytes";
            this.LengthInKilobytes.ReadOnly = true;
            // 
            // assetContextMenuStrip
            // 
            this.assetContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.extractToolStripMenuItem});
            this.assetContextMenuStrip.Name = "assetContextMenuStrip";
            this.assetContextMenuStrip.Size = new System.Drawing.Size(119, 54);
            this.assetContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.assetContextMenuStrip_Opening);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::ps2ls.Properties.Resources.folder_open_document;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.Image = global::ps2ls.Properties.Resources.drive_download;
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.extractToolStripMenuItem.Text = "Extract...";
            this.extractToolStripMenuItem.Click += new System.EventHandler(this.extractToolStripMenuItem_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.searchTextTypeToolStripDrownDownButton1,
            this.searchTextBox,
            this.clearSearchButton,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.filesMaxComboBox});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(596, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Image = global::ps2ls.Properties.Resources.magnifier;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(22, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            this.toolStripLabel1.ToolTipText = "Search";
            // 
            // searchTextTypeToolStripDrownDownButton1
            // 
            this.searchTextTypeToolStripDrownDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchTextTypeToolStripDrownDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("searchTextTypeToolStripDrownDownButton1.Image")));
            this.searchTextTypeToolStripDrownDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchTextTypeToolStripDrownDownButton1.Name = "searchTextTypeToolStripDrownDownButton1";
            this.searchTextTypeToolStripDrownDownButton1.SearchTextType = ps2ls.Forms.Controls.SearchTextTypeToolStripDrownDownButton.SearchTextTypes.Textual;
            this.searchTextTypeToolStripDrownDownButton1.Size = new System.Drawing.Size(29, 22);
            this.searchTextTypeToolStripDrownDownButton1.Text = "Textual";
            this.searchTextTypeToolStripDrownDownButton1.SearchTextTypeChanged += new System.EventHandler(this.searchTextTypeToolStripDrownDownButton1_SearchTextTypeChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.White;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(150, 25);
            this.searchTextBox.CustomTextChanged += new System.EventHandler(this.searchTextBox1_CustomTextChanged);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearSearchButton.Enabled = false;
            this.clearSearchButton.Image = global::ps2ls.Properties.Resources.ui_text_field_clear_button;
            this.clearSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(23, 22);
            this.clearSearchButton.Text = "Clear Search Text";
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel2.Image = global::ps2ls.Properties.Resources.counter;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.toolStripLabel2.Size = new System.Drawing.Size(22, 22);
            this.toolStripLabel2.Text = "File Count Max";
            this.toolStripLabel2.ToolTipText = "File Count Maximum";
            // 
            // filesMaxComboBox
            // 
            this.filesMaxComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filesMaxComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.filesMaxComboBox.Items.AddRange(new object[] {
            "100",
            "1000",
            "10000",
            "∞"});
            this.filesMaxComboBox.Name = "filesMaxComboBox";
            this.filesMaxComboBox.Size = new System.Drawing.Size(75, 25);
            this.filesMaxComboBox.SelectedIndexChanged += new System.EventHandler(this.filesMaxComboBox_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCountLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(596, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fileCountLabel
            // 
            this.fileCountLabel.Image = global::ps2ls.Properties.Resources.document_search_result;
            this.fileCountLabel.Name = "fileCountLabel";
            this.fileCountLabel.Size = new System.Drawing.Size(40, 17);
            this.fileCountLabel.Text = "0/0";
            // 
            // packOpenFileDialog
            // 
            this.packOpenFileDialog.Filter = "PACK files|*.pack|All files|*.*";
            this.packOpenFileDialog.Multiselect = true;
            // 
            // exportAssetFileToCsvSaveFileDialog
            // 
            this.exportAssetFileToCsvSaveFileDialog.DefaultExt = "csv";
            this.exportAssetFileToCsvSaveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files|*.*";
            // 
            // AssetBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "AssetBrowser";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.PackBrowserUserControl_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.packContextMenuStrip.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataGridView)).EndInit();
            this.assetContextMenuStrip.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView assetsDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn FileIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LengthInKilobytes;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton clearSearchButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox filesMaxComboBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel fileCountLabel;
        private System.Windows.Forms.FolderBrowserDialog packFolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog packOpenFileDialog;
        private System.Windows.Forms.ContextMenuStrip packContextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip assetContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem extractPacksToolStripMenuItem;
        private Controls.SearchToolStripTextBox searchTextBox;
        private System.Windows.Forms.ListBox packsListBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addPacksButton;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel packCountLabel;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private Controls.SearchTextTypeToolStripDrownDownButton searchTextTypeToolStripDrownDownButton1;
        private System.Windows.Forms.SaveFileDialog exportAssetFileToCsvSaveFileDialog;
    }
}
