namespace FastQuery
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEntireCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlQueryBox = new System.Windows.Forms.Panel();
            this.rtbQueryBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmsQueryBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.tsQueryResults = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblDatabase = new System.Windows.Forms.ToolStripLabel();
            this.cboDatabase = new System.Windows.Forms.ToolStripComboBox();
            this.btnFields = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.ToolStripLabel();
            this.cboQuery = new System.Windows.Forms.ToolStripComboBox();
            this.btnExecute = new System.Windows.Forms.ToolStripButton();
            this.btnSaveQuery = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfigure = new System.Windows.Forms.ToolStripButton();
            this.lblAppInfo = new System.Windows.Forms.ToolStripLabel();
            this.btnOpenQueryFolder = new System.Windows.Forms.ToolStripButton();
            this.btnSSMS = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFields = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResult = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.pnlQueryBox.SuspendLayout();
            this.cmsQueryBox.SuspendLayout();
            this.pnlDataGridView.SuspendLayout();
            this.tsQueryResults.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEntireCount
            // 
            this.lblEntireCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntireCount.AutoSize = true;
            this.lblEntireCount.Location = new System.Drawing.Point(824, 9);
            this.lblEntireCount.Name = "lblEntireCount";
            this.lblEntireCount.Size = new System.Drawing.Size(50, 13);
            this.lblEntireCount.TabIndex = 7;
            this.lblEntireCount.Text = "Count : 0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlQueryBox);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.pnlDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 476);
            this.panel1.TabIndex = 9;
            // 
            // pnlQueryBox
            // 
            this.pnlQueryBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlQueryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQueryBox.Controls.Add(this.rtbQueryBox);
            this.pnlQueryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQueryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlQueryBox.Location = new System.Drawing.Point(0, 0);
            this.pnlQueryBox.Name = "pnlQueryBox";
            this.pnlQueryBox.Size = new System.Drawing.Size(964, 239);
            this.pnlQueryBox.TabIndex = 17;
            // 
            // rtbQueryBox
            // 
            this.rtbQueryBox.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.rtbQueryBox.CommentPrefix = "--";
            this.rtbQueryBox.ContextMenuStrip = this.cmsQueryBox;
            this.rtbQueryBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbQueryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbQueryBox.LeftBracket = '(';
            this.rtbQueryBox.Location = new System.Drawing.Point(0, 0);
            this.rtbQueryBox.Name = "rtbQueryBox";
            this.rtbQueryBox.PreferredLineWidth = 0;
            this.rtbQueryBox.RightBracket = ')';
            this.rtbQueryBox.Size = new System.Drawing.Size(962, 237);
            this.rtbQueryBox.TabIndex = 4;
            this.rtbQueryBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.rtbQueryBox_TextChanged);
            // 
            // cmsQueryBox
            // 
            this.cmsQueryBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fieldsToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1});
            this.cmsQueryBox.Name = "cmsQueryBox";
            this.cmsQueryBox.Size = new System.Drawing.Size(115, 104);
            // 
            // fieldsToolStripMenuItem
            // 
            this.fieldsToolStripMenuItem.Image = global::FastQuery.Properties.Resources.property;
            this.fieldsToolStripMenuItem.Name = "fieldsToolStripMenuItem";
            this.fieldsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.fieldsToolStripMenuItem.Text = "Fields";
            this.fieldsToolStripMenuItem.Click += new System.EventHandler(this.btnFields_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Image = global::FastQuery.Properties.Resources.hourglass;
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(111, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::FastQuery.Properties.Resources.save_accept4;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::FastQuery.Properties.Resources.document_excel;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 239);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(964, 5);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.AutoScroll = true;
            this.pnlDataGridView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlDataGridView.Controls.Add(this.tsQueryResults);
            this.pnlDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDataGridView.Location = new System.Drawing.Point(0, 244);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(964, 230);
            this.pnlDataGridView.TabIndex = 18;
            // 
            // tsQueryResults
            // 
            this.tsQueryResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.tsQueryResults.Location = new System.Drawing.Point(0, 0);
            this.tsQueryResults.Name = "tsQueryResults";
            this.tsQueryResults.Size = new System.Drawing.Size(964, 25);
            this.tsQueryResults.TabIndex = 2;
            this.tsQueryResults.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(82, 22);
            this.toolStripLabel1.Text = "Query Results:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(8, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(117, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "select query to execute";
            // 
            // pgBar
            // 
            this.pgBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pgBar.Location = new System.Drawing.Point(11, 27);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(944, 23);
            this.pgBar.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDatabase,
            this.cboDatabase,
            this.btnFields,
            this.label4,
            this.cboQuery,
            this.btnExecute,
            this.btnSaveQuery,
            this.btnExport,
            this.toolStripSeparator2,
            this.btnConfigure,
            this.lblAppInfo,
            this.btnOpenQueryFolder,
            this.btnSSMS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(966, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblDatabase
            // 
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(55, 22);
            this.lblDatabase.Text = "Database";
            // 
            // cboDatabase
            // 
            this.cboDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboDatabase.DropDownWidth = 150;
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(121, 25);
            this.cboDatabase.Sorted = true;
            this.cboDatabase.SelectedIndexChanged += new System.EventHandler(this.cboDatabase_SelectedIndexChanged);
            // 
            // btnFields
            // 
            this.btnFields.Image = global::FastQuery.Properties.Resources.property;
            this.btnFields.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFields.Name = "btnFields";
            this.btnFields.Size = new System.Drawing.Size(57, 22);
            this.btnFields.Text = "Fields";
            this.btnFields.ToolTipText = "Select fields for query generation";
            this.btnFields.Click += new System.EventHandler(this.btnFields_Click);
            // 
            // label4
            // 
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 22);
            this.label4.Text = "Query";
            // 
            // cboQuery
            // 
            this.cboQuery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboQuery.DropDownWidth = 150;
            this.cboQuery.Name = "cboQuery";
            this.cboQuery.Size = new System.Drawing.Size(121, 25);
            this.cboQuery.Sorted = true;
            this.cboQuery.SelectedIndexChanged += new System.EventHandler(this.cboQuery_SelectedIndexChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Image = global::FastQuery.Properties.Resources.hourglass;
            this.btnExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(67, 22);
            this.btnExecute.Text = "Execute";
            this.btnExecute.ToolTipText = "Execute query";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnSaveQuery
            // 
            this.btnSaveQuery.Image = global::FastQuery.Properties.Resources.save_accept4;
            this.btnSaveQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveQuery.Name = "btnSaveQuery";
            this.btnSaveQuery.Size = new System.Drawing.Size(51, 22);
            this.btnSaveQuery.Text = "Save";
            this.btnSaveQuery.ToolTipText = "Save query";
            this.btnSaveQuery.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::FastQuery.Properties.Resources.document_excel;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(60, 22);
            this.btnExport.Text = "Export";
            this.btnExport.ToolTipText = "Export to Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnConfigure
            // 
            this.btnConfigure.Image = global::FastQuery.Properties.Resources.advancedsettings;
            this.btnConfigure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(80, 22);
            this.btnConfigure.Text = "Configure";
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // lblAppInfo
            // 
            this.lblAppInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblAppInfo.Name = "lblAppInfo";
            this.lblAppInfo.Size = new System.Drawing.Size(101, 22);
            this.lblAppInfo.Text = "by Yogeesha Naik";
            // 
            // btnOpenQueryFolder
            // 
            this.btnOpenQueryFolder.Image = global::FastQuery.Properties.Resources.folder_horizontal_open;
            this.btnOpenQueryFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenQueryFolder.Name = "btnOpenQueryFolder";
            this.btnOpenQueryFolder.Size = new System.Drawing.Size(56, 22);
            this.btnOpenQueryFolder.Text = "&Open";
            this.btnOpenQueryFolder.ToolTipText = "Open query containing folder";
            this.btnOpenQueryFolder.Click += new System.EventHandler(this.btnOpenQueryFolder_Click);
            // 
            // btnSSMS
            // 
            this.btnSSMS.Image = global::FastQuery.Properties.Resources.database__arrow;
            this.btnSSMS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSSMS.Name = "btnSSMS";
            this.btnSSMS.Size = new System.Drawing.Size(56, 22);
            this.btnSSMS.Text = "SSMS";
            this.btnSSMS.Click += new System.EventHandler(this.btnSSMS_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.pgBar);
            this.panel2.Controls.Add(this.lblEntireCount);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 57);
            this.panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuery,
            this.menuResult,
            this.menuConfiguration});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuQuery
            // 
            this.menuQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFields,
            this.menuExecute,
            this.menuSaveQuery});
            this.menuQuery.Name = "menuQuery";
            this.menuQuery.Size = new System.Drawing.Size(51, 20);
            this.menuQuery.Text = "&Query";
            // 
            // menuFields
            // 
            this.menuFields.Image = global::FastQuery.Properties.Resources.property;
            this.menuFields.Name = "menuFields";
            this.menuFields.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuFields.Size = new System.Drawing.Size(144, 22);
            this.menuFields.Text = "&Fields";
            this.menuFields.Click += new System.EventHandler(this.btnFields_Click);
            // 
            // menuExecute
            // 
            this.menuExecute.Image = global::FastQuery.Properties.Resources.hourglass;
            this.menuExecute.Name = "menuExecute";
            this.menuExecute.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuExecute.Size = new System.Drawing.Size(144, 22);
            this.menuExecute.Text = "Execute";
            this.menuExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // menuSaveQuery
            // 
            this.menuSaveQuery.Image = global::FastQuery.Properties.Resources.save_accept4;
            this.menuSaveQuery.Name = "menuSaveQuery";
            this.menuSaveQuery.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSaveQuery.Size = new System.Drawing.Size(144, 22);
            this.menuSaveQuery.Text = "&Save";
            this.menuSaveQuery.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // menuResult
            // 
            this.menuResult.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExport});
            this.menuResult.Name = "menuResult";
            this.menuResult.Size = new System.Drawing.Size(51, 20);
            this.menuResult.Text = "&Result";
            // 
            // menuExport
            // 
            this.menuExport.Image = global::FastQuery.Properties.Resources.document_excel;
            this.menuExport.Name = "menuExport";
            this.menuExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuExport.Size = new System.Drawing.Size(147, 22);
            this.menuExport.Text = "&Export";
            this.menuExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // menuConfiguration
            // 
            this.menuConfiguration.Name = "menuConfiguration";
            this.menuConfiguration.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.C)));
            this.menuConfiguration.Size = new System.Drawing.Size(93, 20);
            this.menuConfiguration.Text = "&Configuration";
            this.menuConfiguration.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(966, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Query";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.pnlQueryBox.ResumeLayout(false);
            this.cmsQueryBox.ResumeLayout(false);
            this.pnlDataGridView.ResumeLayout(false);
            this.pnlDataGridView.PerformLayout();
            this.tsQueryResults.ResumeLayout(false);
            this.tsQueryResults.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntireCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlQueryBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton btnFields;
        private System.Windows.Forms.ToolStripButton btnExecute;
        private System.Windows.Forms.ToolStripButton btnSaveQuery;
        private System.Windows.Forms.ToolStripComboBox cboQuery;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnConfigure;
        private System.Windows.Forms.ToolStripLabel label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblAppInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQuery;
        private System.Windows.Forms.ToolStripMenuItem menuExecute;
        private System.Windows.Forms.ToolStripMenuItem menuFields;
        private System.Windows.Forms.ToolStripMenuItem menuResult;
        private System.Windows.Forms.ToolStripMenuItem menuExport;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguration;
        private System.Windows.Forms.ToolStrip tsQueryResults;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem menuSaveQuery;
        private System.Windows.Forms.ToolStripButton btnOpenQueryFolder;
        private System.Windows.Forms.ToolStripButton btnSSMS;
        private System.Windows.Forms.ToolStripLabel lblDatabase;
        private System.Windows.Forms.ToolStripComboBox cboDatabase;
        public FastColoredTextBoxNS.FastColoredTextBox rtbQueryBox;
        private System.Windows.Forms.ContextMenuStrip cmsQueryBox;
        private System.Windows.Forms.ToolStripMenuItem fieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

