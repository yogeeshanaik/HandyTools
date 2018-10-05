namespace Xml_Editor
{
    partial class TemplateManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbXmlEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripLabel();
            this.btnRun = new System.Windows.Forms.ToolStripButton();
            this.txtSelectedFilePath = new System.Windows.Forms.ToolStripTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tvFiles = new FileSystemTreeView();
            this.treeviewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNodeFilter = new DelayTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.explorerTree1 = new WindowsExplorer.ExplorerTree();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.lnkExpand = new System.Windows.Forms.LinkLabel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbXmlEditor)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.treeviewContextMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbXmlEditor);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 480);
            this.panel1.TabIndex = 1;
            // 
            // rtbXmlEditor
            // 
            this.rtbXmlEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.rtbXmlEditor.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.rtbXmlEditor.BackBrush = null;
            this.rtbXmlEditor.CharHeight = 14;
            this.rtbXmlEditor.CharWidth = 8;
            this.rtbXmlEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbXmlEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.rtbXmlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbXmlEditor.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.rtbXmlEditor.IsReplaceMode = false;
            this.rtbXmlEditor.Location = new System.Drawing.Point(235, 75);
            this.rtbXmlEditor.Name = "rtbXmlEditor";
            this.rtbXmlEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.rtbXmlEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.rtbXmlEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("rtbXmlEditor.ServiceColors")));
            this.rtbXmlEditor.Size = new System.Drawing.Size(458, 380);
            this.rtbXmlEditor.TabIndex = 4;
            this.rtbXmlEditor.Zoom = 100;
            this.rtbXmlEditor.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.rtbXmlEditor_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(232, 75);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 380);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.btnRun,
            this.txtSelectedFilePath});
            this.toolStrip2.Location = new System.Drawing.Point(232, 455);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(461, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lblStatus
            // 
            this.lblStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(158, 22);
            this.lblStatus.Text = "developed by Yogeesha Naik";
            this.lblStatus.TextChanged += new System.EventHandler(this.lblStatus_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(48, 22);
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtSelectedFilePath
            // 
            this.txtSelectedFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSelectedFilePath.Name = "txtSelectedFilePath";
            this.txtSelectedFilePath.ReadOnly = true;
            this.txtSelectedFilePath.Size = new System.Drawing.Size(100, 25);
            this.txtSelectedFilePath.TextChanged += new System.EventHandler(this.txtSelectedFilePath_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.explorerTree1);
            this.panel3.Controls.Add(this.tvFiles);
            this.panel3.Controls.Add(this.txtNodeFilter);
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.MinimumSize = new System.Drawing.Size(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 405);
            this.panel3.TabIndex = 1;
            // 
            // tvFiles
            // 
            this.tvFiles.AllowDrop = true;
            this.tvFiles.ContextMenuStrip = this.treeviewContextMenu;
            this.tvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFiles.ImageIndex = 0;
            this.tvFiles.Location = new System.Drawing.Point(0, 20);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.SelectedImageIndex = 0;
            this.tvFiles.ShowFiles = true;
            this.tvFiles.Size = new System.Drawing.Size(232, 360);
            this.tvFiles.TabIndex = 3;
            this.tvFiles.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvFiles_BeforeExpand);
            this.tvFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.tvFiles_DragOver);
            this.tvFiles.Validating += new System.ComponentModel.CancelEventHandler(this.tvFiles_Validating);
            // 
            // treeviewContextMenu
            // 
            this.treeviewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLocationToolStripMenuItem,
            this.menuRefresh,
            this.toolStripSeparator2,
            this.menuNew,
            this.menuRename,
            this.toolStripSeparator1,
            this.menuCopy,
            this.menuPaste,
            this.menuDelete});
            this.treeviewContextMenu.Name = "treeviewContextMenu";
            this.treeviewContextMenu.Size = new System.Drawing.Size(142, 170);
            // 
            // openLocationToolStripMenuItem
            // 
            this.openLocationToolStripMenuItem.Image = global::CodeYogi.Properties.Resources.Show;
            this.openLocationToolStripMenuItem.Name = "openLocationToolStripMenuItem";
            this.openLocationToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.openLocationToolStripMenuItem.Text = "Open";
            this.openLocationToolStripMenuItem.Click += new System.EventHandler(this.openLocationToolStripMenuItem_Click);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Image = global::CodeYogi.Properties.Resources.Refresh;
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Size = new System.Drawing.Size(141, 22);
            this.menuRefresh.Text = "Refresh";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // menuNew
            // 
            this.menuNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFolder,
            this.menuFile});
            this.menuNew.Image = global::CodeYogi.Properties.Resources.New_file;
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(141, 22);
            this.menuNew.Text = "New";
            // 
            // menuFolder
            // 
            this.menuFolder.Image = global::CodeYogi.Properties.Resources.Folder;
            this.menuFolder.Name = "menuFolder";
            this.menuFolder.Size = new System.Drawing.Size(107, 22);
            this.menuFolder.Text = "Folder";
            this.menuFolder.Click += new System.EventHandler(this.menuFolder_Click);
            // 
            // menuFile
            // 
            this.menuFile.Image = global::CodeYogi.Properties.Resources.File_exetension;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(107, 22);
            this.menuFile.Text = "File";
            this.menuFile.Click += new System.EventHandler(this.menuFile_Click);
            // 
            // menuRename
            // 
            this.menuRename.Image = global::CodeYogi.Properties.Resources.Rename;
            this.menuRename.Name = "menuRename";
            this.menuRename.Size = new System.Drawing.Size(141, 22);
            this.menuRename.Text = "Rename";
            this.menuRename.Click += new System.EventHandler(this.menuRename_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // menuCopy
            // 
            this.menuCopy.Image = global::CodeYogi.Properties.Resources.Copy;
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.Size = new System.Drawing.Size(141, 22);
            this.menuCopy.Text = "Copy";
            this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
            // 
            // menuPaste
            // 
            this.menuPaste.Image = global::CodeYogi.Properties.Resources.Paste;
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.Size = new System.Drawing.Size(141, 22);
            this.menuPaste.Text = "Paste";
            this.menuPaste.Click += new System.EventHandler(this.menuPaste_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Image = global::CodeYogi.Properties.Resources.Delete;
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(141, 22);
            this.menuDelete.Text = "Delete";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // txtNodeFilter
            // 
            this.txtNodeFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNodeFilter.Location = new System.Drawing.Point(0, 0);
            this.txtNodeFilter.Name = "txtNodeFilter";
            this.txtNodeFilter.Size = new System.Drawing.Size(232, 20);
            this.txtNodeFilter.TabIndex = 7;
            this.txtNodeFilter.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtNodeFilter.WaterMarkText = "Water Mark";
            this.txtNodeFilter.TextChanged += new System.EventHandler(this.txtNodeFilter_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 380);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(232, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(51, 22);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip3);
            this.panel2.Controls.Add(this.lnkExpand);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Controls.Add(this.txtPath);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 75);
            this.panel2.TabIndex = 0;
            // 
            // explorerTree1
            // 
            this.explorerTree1.BackColor = System.Drawing.Color.White;
            this.explorerTree1.Location = new System.Drawing.Point(12, 26);
            this.explorerTree1.Name = "explorerTree1";
            this.explorerTree1.SelectedPath = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Community\\Common7\\IDE";
            this.explorerTree1.ShowAddressbar = true;
            this.explorerTree1.ShowMyDocuments = true;
            this.explorerTree1.ShowMyFavorites = true;
            this.explorerTree1.ShowMyNetwork = true;
            this.explorerTree1.ShowToolbar = true;
            this.explorerTree1.Size = new System.Drawing.Size(240, 336);
            this.explorerTree1.TabIndex = 7;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(693, 25);
            this.toolStrip3.TabIndex = 6;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // lnkExpand
            // 
            this.lnkExpand.AutoSize = true;
            this.lnkExpand.Location = new System.Drawing.Point(12, 59);
            this.lnkExpand.Name = "lnkExpand";
            this.lnkExpand.Size = new System.Drawing.Size(57, 13);
            this.lnkExpand.TabIndex = 4;
            this.lnkExpand.TabStop = true;
            this.lnkExpand.Text = "Expand All";
            this.lnkExpand.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExpand_LinkClicked);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(608, 24);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(64, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(570, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(32, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(77, 26);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(487, 20);
            this.txtPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(693, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Code Gen";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            this.imageList1.Images.SetKeyName(22, "");
            this.imageList1.Images.SetKeyName(23, "");
            this.imageList1.Images.SetKeyName(24, "");
            this.imageList1.Images.SetKeyName(25, "");
            this.imageList1.Images.SetKeyName(26, "");
            this.imageList1.Images.SetKeyName(27, "");
            this.imageList1.Images.SetKeyName(28, "");
            // 
            // TemplateManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TemplateManager";
            this.Text = "CodeYogi 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TemplateManager_FormClosing);
            this.Load += new System.EventHandler(this.XmlEditorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbXmlEditor)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.treeviewContextMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnRun;
        private System.Windows.Forms.Splitter splitter1;
        private FastColoredTextBoxNS.FastColoredTextBox rtbXmlEditor;
        private System.Windows.Forms.ToolStripTextBox txtSelectedFilePath;
        private System.Windows.Forms.ToolStripLabel lblStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip treeviewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuRename;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private FileSystemTreeView tvFiles;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFolder;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.LinkLabel lnkExpand;
        private System.Windows.Forms.ToolStripMenuItem openLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private DelayTextBox txtNodeFilter;
        private System.Windows.Forms.ImageList imageList1;
        private WindowsExplorer.ExplorerTree explorerTree1;
    }
}

