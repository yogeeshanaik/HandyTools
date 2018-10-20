namespace EzScript
{
    partial class EzScriptForm
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
            this.pnlSriptFilters = new System.Windows.Forms.Panel();
            this.lblDatabases = new System.Windows.Forms.Label();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.toolStripFilters = new System.Windows.Forms.ToolStrip();
            this.lblObjectFilters = new System.Windows.Forms.ToolStripLabel();
            this.lblDevnfo = new System.Windows.Forms.ToolStripLabel();
            this.btnGetObjectsList = new System.Windows.Forms.Button();
            this.lstObjectTypes = new System.Windows.Forms.ListBox();
            this.lblObjectType = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.pnlobjectsList = new System.Windows.Forms.Panel();
            this.lvObjectsList = new System.Windows.Forms.ListView();
            this.pnlObjectListControls = new System.Windows.Forms.Panel();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.chkSingleFilePerObject = new System.Windows.Forms.CheckBox();
            this.lblModifiedObjectsCount = new System.Windows.Forms.Label();
            this.btnGenerateScript = new System.Windows.Forms.Button();
            this.toolStripObjectsList = new System.Windows.Forms.ToolStrip();
            this.lblModifiedObjects = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tscSelectOption = new System.Windows.Forms.ToolStripComboBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlProfiles = new System.Windows.Forms.Panel();
            this.lstProfiles = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pnlDbConnection = new System.Windows.Forms.Panel();
            this.toolStripDbConnection = new System.Windows.Forms.ToolStrip();
            this.lblDbConnection = new System.Windows.Forms.ToolStripLabel();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cboServer = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAuthType = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboAuthTypes = new System.Windows.Forms.ComboBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.splitterLeftPanel = new System.Windows.Forms.Splitter();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarBW = new System.Windows.Forms.ToolStripProgressBar();
            this.labelTimeLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorkerExample = new System.ComponentModel.BackgroundWorker();
            this.pnlSriptFilters.SuspendLayout();
            this.toolStripFilters.SuspendLayout();
            this.pnlobjectsList.SuspendLayout();
            this.pnlObjectListControls.SuspendLayout();
            this.toolStripObjectsList.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlProfiles.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlDbConnection.SuspendLayout();
            this.toolStripDbConnection.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSriptFilters
            // 
            this.pnlSriptFilters.Controls.Add(this.lblDatabases);
            this.pnlSriptFilters.Controls.Add(this.cboDatabase);
            this.pnlSriptFilters.Controls.Add(this.toolStripFilters);
            this.pnlSriptFilters.Controls.Add(this.btnGetObjectsList);
            this.pnlSriptFilters.Controls.Add(this.lstObjectTypes);
            this.pnlSriptFilters.Controls.Add(this.lblObjectType);
            this.pnlSriptFilters.Controls.Add(this.dtpTo);
            this.pnlSriptFilters.Controls.Add(this.dtpFrom);
            this.pnlSriptFilters.Controls.Add(this.lblToDate);
            this.pnlSriptFilters.Controls.Add(this.lblFromDate);
            this.pnlSriptFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSriptFilters.Location = new System.Drawing.Point(0, 0);
            this.pnlSriptFilters.Name = "pnlSriptFilters";
            this.pnlSriptFilters.Size = new System.Drawing.Size(667, 227);
            this.pnlSriptFilters.TabIndex = 0;
            // 
            // lblDatabases
            // 
            this.lblDatabases.AutoSize = true;
            this.lblDatabases.Location = new System.Drawing.Point(20, 51);
            this.lblDatabases.Name = "lblDatabases";
            this.lblDatabases.Size = new System.Drawing.Size(86, 13);
            this.lblDatabases.TabIndex = 11;
            this.lblDatabases.Text = "Select Database";
            // 
            // cboDatabase
            // 
            this.cboDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(125, 48);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(224, 21);
            this.cboDatabase.TabIndex = 10;
            this.cboDatabase.SelectedIndexChanged += new System.EventHandler(this.cboDatabase_SelectedIndexChanged);
            // 
            // toolStripFilters
            // 
            this.toolStripFilters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblObjectFilters,
            this.lblDevnfo});
            this.toolStripFilters.Location = new System.Drawing.Point(0, 0);
            this.toolStripFilters.Name = "toolStripFilters";
            this.toolStripFilters.Size = new System.Drawing.Size(667, 25);
            this.toolStripFilters.TabIndex = 9;
            this.toolStripFilters.Text = "toolStrip1";
            // 
            // lblObjectFilters
            // 
            this.lblObjectFilters.Name = "lblObjectFilters";
            this.lblObjectFilters.Size = new System.Drawing.Size(76, 22);
            this.lblObjectFilters.Text = "Object Filters";
            // 
            // lblDevnfo
            // 
            this.lblDevnfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblDevnfo.Name = "lblDevnfo";
            this.lblDevnfo.Size = new System.Drawing.Size(0, 22);
            // 
            // btnGetObjectsList
            // 
            this.btnGetObjectsList.Location = new System.Drawing.Point(125, 172);
            this.btnGetObjectsList.Name = "btnGetObjectsList";
            this.btnGetObjectsList.Size = new System.Drawing.Size(75, 23);
            this.btnGetObjectsList.TabIndex = 8;
            this.btnGetObjectsList.Text = "Get Objects";
            this.btnGetObjectsList.UseVisualStyleBackColor = true;
            this.btnGetObjectsList.Click += new System.EventHandler(this.btnGetObjectsList_Click);
            // 
            // lstObjectTypes
            // 
            this.lstObjectTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstObjectTypes.FormattingEnabled = true;
            this.lstObjectTypes.Location = new System.Drawing.Point(358, 51);
            this.lstObjectTypes.Name = "lstObjectTypes";
            this.lstObjectTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstObjectTypes.Size = new System.Drawing.Size(298, 160);
            this.lstObjectTypes.TabIndex = 7;
            // 
            // lblObjectType
            // 
            this.lblObjectType.AutoSize = true;
            this.lblObjectType.Location = new System.Drawing.Point(355, 35);
            this.lblObjectType.Name = "lblObjectType";
            this.lblObjectType.Size = new System.Drawing.Size(65, 13);
            this.lblObjectType.TabIndex = 5;
            this.lblObjectType.Text = "Object Type";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "MM/dd/yyyy hh:mm tt dddd";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(125, 133);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(224, 20);
            this.dtpTo.TabIndex = 4;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "MM/dd/yyyy hh:mm tt dddd";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(125, 89);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(224, 20);
            this.dtpFrom.TabIndex = 3;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(20, 139);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(89, 13);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "Modified To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(20, 95);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(99, 13);
            this.lblFromDate.TabIndex = 1;
            this.lblFromDate.Text = "Modified From Date";
            // 
            // pnlobjectsList
            // 
            this.pnlobjectsList.Controls.Add(this.lvObjectsList);
            this.pnlobjectsList.Controls.Add(this.pnlObjectListControls);
            this.pnlobjectsList.Controls.Add(this.toolStripObjectsList);
            this.pnlobjectsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlobjectsList.Location = new System.Drawing.Point(0, 227);
            this.pnlobjectsList.Name = "pnlobjectsList";
            this.pnlobjectsList.Size = new System.Drawing.Size(667, 54);
            this.pnlobjectsList.TabIndex = 1;
            // 
            // lvObjectsList
            // 
            this.lvObjectsList.AllowColumnReorder = true;
            this.lvObjectsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvObjectsList.FullRowSelect = true;
            this.lvObjectsList.GridLines = true;
            this.lvObjectsList.HideSelection = false;
            this.lvObjectsList.Location = new System.Drawing.Point(0, 25);
            this.lvObjectsList.Name = "lvObjectsList";
            this.lvObjectsList.Size = new System.Drawing.Size(667, 0);
            this.lvObjectsList.TabIndex = 13;
            this.lvObjectsList.UseCompatibleStateImageBehavior = false;
            this.lvObjectsList.View = System.Windows.Forms.View.Details;
            // 
            // pnlObjectListControls
            // 
            this.pnlObjectListControls.Controls.Add(this.txtProfileName);
            this.pnlObjectListControls.Controls.Add(this.btnSaveProfile);
            this.pnlObjectListControls.Controls.Add(this.chkSingleFilePerObject);
            this.pnlObjectListControls.Controls.Add(this.lblModifiedObjectsCount);
            this.pnlObjectListControls.Controls.Add(this.btnGenerateScript);
            this.pnlObjectListControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlObjectListControls.Location = new System.Drawing.Point(0, 14);
            this.pnlObjectListControls.Name = "pnlObjectListControls";
            this.pnlObjectListControls.Size = new System.Drawing.Size(667, 40);
            this.pnlObjectListControls.TabIndex = 12;
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(237, 8);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(174, 20);
            this.txtProfileName.TabIndex = 13;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(417, 6);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(78, 23);
            this.btnSaveProfile.TabIndex = 12;
            this.btnSaveProfile.Text = "Save Profile";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // chkSingleFilePerObject
            // 
            this.chkSingleFilePerObject.AutoSize = true;
            this.chkSingleFilePerObject.Location = new System.Drawing.Point(104, 10);
            this.chkSingleFilePerObject.Name = "chkSingleFilePerObject";
            this.chkSingleFilePerObject.Size = new System.Drawing.Size(127, 17);
            this.chkSingleFilePerObject.TabIndex = 11;
            this.chkSingleFilePerObject.Text = "Single file per object?";
            this.chkSingleFilePerObject.UseVisualStyleBackColor = true;
            // 
            // lblModifiedObjectsCount
            // 
            this.lblModifiedObjectsCount.AutoSize = true;
            this.lblModifiedObjectsCount.Location = new System.Drawing.Point(533, 11);
            this.lblModifiedObjectsCount.Name = "lblModifiedObjectsCount";
            this.lblModifiedObjectsCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblModifiedObjectsCount.Size = new System.Drawing.Size(82, 13);
            this.lblModifiedObjectsCount.TabIndex = 10;
            this.lblModifiedObjectsCount.Text = "Total Objects: 0";
            // 
            // btnGenerateScript
            // 
            this.btnGenerateScript.Location = new System.Drawing.Point(20, 6);
            this.btnGenerateScript.Name = "btnGenerateScript";
            this.btnGenerateScript.Size = new System.Drawing.Size(78, 23);
            this.btnGenerateScript.TabIndex = 9;
            this.btnGenerateScript.Text = "Script To File";
            this.btnGenerateScript.UseVisualStyleBackColor = true;
            this.btnGenerateScript.Click += new System.EventHandler(this.btnGenerateScript_Click);
            // 
            // toolStripObjectsList
            // 
            this.toolStripObjectsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblModifiedObjects,
            this.toolStripSeparator1,
            this.tscSelectOption});
            this.toolStripObjectsList.Location = new System.Drawing.Point(0, 0);
            this.toolStripObjectsList.Name = "toolStripObjectsList";
            this.toolStripObjectsList.Size = new System.Drawing.Size(667, 25);
            this.toolStripObjectsList.TabIndex = 11;
            this.toolStripObjectsList.Text = "toolStrip3";
            // 
            // lblModifiedObjects
            // 
            this.lblModifiedObjects.Name = "lblModifiedObjects";
            this.lblModifiedObjects.Size = new System.Drawing.Size(98, 22);
            this.lblModifiedObjects.Text = "Modified Objetcs";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tscSelectOption
            // 
            this.tscSelectOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscSelectOption.Items.AddRange(new object[] {
            "Select All",
            "Deselect All",
            "Invert Selection"});
            this.tscSelectOption.Name = "tscSelectOption";
            this.tscSelectOption.Size = new System.Drawing.Size(121, 25);
            this.tscSelectOption.SelectedIndexChanged += new System.EventHandler(this.tscSelectOption_SelectedIndexChanged);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(250, 280);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(669, 3);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.pnlProfiles);
            this.pnlLeft.Controls.Add(this.pnlDbConnection);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(250, 283);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlProfiles
            // 
            this.pnlProfiles.Controls.Add(this.lstProfiles);
            this.pnlProfiles.Controls.Add(this.toolStrip1);
            this.pnlProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProfiles.Location = new System.Drawing.Point(0, 257);
            this.pnlProfiles.Name = "pnlProfiles";
            this.pnlProfiles.Size = new System.Drawing.Size(248, 24);
            this.pnlProfiles.TabIndex = 22;
            // 
            // lstProfiles
            // 
            this.lstProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProfiles.FormattingEnabled = true;
            this.lstProfiles.Location = new System.Drawing.Point(0, 25);
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.Size = new System.Drawing.Size(248, 0);
            this.lstProfiles.TabIndex = 9;
            this.lstProfiles.DoubleClick += new System.EventHandler(this.lstProfiles_DoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(248, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel1.Text = "Saved Profiles";
            // 
            // pnlDbConnection
            // 
            this.pnlDbConnection.Controls.Add(this.toolStripDbConnection);
            this.pnlDbConnection.Controls.Add(this.lblServer);
            this.pnlDbConnection.Controls.Add(this.lblUserName);
            this.pnlDbConnection.Controls.Add(this.btnTestConnection);
            this.pnlDbConnection.Controls.Add(this.txtUserName);
            this.pnlDbConnection.Controls.Add(this.cboServer);
            this.pnlDbConnection.Controls.Add(this.lblPassword);
            this.pnlDbConnection.Controls.Add(this.lblAuthType);
            this.pnlDbConnection.Controls.Add(this.txtPassword);
            this.pnlDbConnection.Controls.Add(this.cboAuthTypes);
            this.pnlDbConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDbConnection.Location = new System.Drawing.Point(0, 0);
            this.pnlDbConnection.Name = "pnlDbConnection";
            this.pnlDbConnection.Size = new System.Drawing.Size(248, 257);
            this.pnlDbConnection.TabIndex = 21;
            // 
            // toolStripDbConnection
            // 
            this.toolStripDbConnection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDbConnection});
            this.toolStripDbConnection.Location = new System.Drawing.Point(0, 0);
            this.toolStripDbConnection.Name = "toolStripDbConnection";
            this.toolStripDbConnection.Size = new System.Drawing.Size(248, 25);
            this.toolStripDbConnection.TabIndex = 18;
            this.toolStripDbConnection.Text = "toolStrip2";
            // 
            // lblDbConnection
            // 
            this.lblDbConnection.Name = "lblDbConnection";
            this.lblDbConnection.Size = new System.Drawing.Size(120, 22);
            this.lblDbConnection.Text = "Database Connection";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(20, 32);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 11;
            this.lblServer.Text = "S&erver:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(20, 130);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(32, 13);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "&User:";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestConnection.Location = new System.Drawing.Point(110, 229);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(121, 23);
            this.btnTestConnection.TabIndex = 1;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(20, 146);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(211, 20);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Text = "sa";
            // 
            // cboServer
            // 
            this.cboServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboServer.FormattingEnabled = true;
            this.cboServer.Location = new System.Drawing.Point(20, 50);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(211, 21);
            this.cboServer.TabIndex = 17;
            this.cboServer.SelectedIndexChanged += new System.EventHandler(this.cboServers_SelectedIndexChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 177);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "&Password:";
            // 
            // lblAuthType
            // 
            this.lblAuthType.AutoSize = true;
            this.lblAuthType.Location = new System.Drawing.Point(20, 82);
            this.lblAuthType.Name = "lblAuthType";
            this.lblAuthType.Size = new System.Drawing.Size(32, 13);
            this.lblAuthType.TabIndex = 16;
            this.lblAuthType.Text = "&Auth:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(20, 193);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(211, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // cboAuthTypes
            // 
            this.cboAuthTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAuthTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthTypes.FormattingEnabled = true;
            this.cboAuthTypes.Location = new System.Drawing.Point(20, 98);
            this.cboAuthTypes.Name = "cboAuthTypes";
            this.cboAuthTypes.Size = new System.Drawing.Size(211, 21);
            this.cboAuthTypes.TabIndex = 15;
            this.cboAuthTypes.SelectedIndexChanged += new System.EventHandler(this.cboAuthTypes_SelectedIndexChanged);
            this.cboAuthTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.rtbInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfo.Location = new System.Drawing.Point(0, 283);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(919, 173);
            this.pnlInfo.TabIndex = 20;
            // 
            // rtbInfo
            // 
            this.rtbInfo.BackColor = System.Drawing.SystemColors.Window;
            this.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtbInfo.Location = new System.Drawing.Point(0, 0);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(919, 173);
            this.rtbInfo.TabIndex = 1;
            this.rtbInfo.Text = "";
            this.rtbInfo.TextChanged += new System.EventHandler(this.rtbInfo_TextChanged);
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.pnlobjectsList);
            this.pnlRight.Controls.Add(this.pnlSriptFilters);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(250, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(669, 283);
            this.pnlRight.TabIndex = 3;
            // 
            // splitterLeftPanel
            // 
            this.splitterLeftPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitterLeftPanel.Location = new System.Drawing.Point(250, 0);
            this.splitterLeftPanel.Name = "splitterLeftPanel";
            this.splitterLeftPanel.Size = new System.Drawing.Size(3, 280);
            this.splitterLeftPanel.TabIndex = 2;
            this.splitterLeftPanel.TabStop = false;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progressBarBW,
            this.labelTimeLeft});
            this.statusStrip2.Location = new System.Drawing.Point(0, 456);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(919, 22);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // progressBarBW
            // 
            this.progressBarBW.Name = "progressBarBW";
            this.progressBarBW.Size = new System.Drawing.Size(100, 16);
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(57, 17);
            this.labelTimeLeft.Text = "Time Left";
            // 
            // EzScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 478);
            this.Controls.Add(this.splitterLeftPanel);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.statusStrip2);
            this.Name = "EzScriptForm";
            this.Text = "EzScript";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEzScript_Load);
            this.pnlSriptFilters.ResumeLayout(false);
            this.pnlSriptFilters.PerformLayout();
            this.toolStripFilters.ResumeLayout(false);
            this.toolStripFilters.PerformLayout();
            this.pnlobjectsList.ResumeLayout(false);
            this.pnlobjectsList.PerformLayout();
            this.pnlObjectListControls.ResumeLayout(false);
            this.pnlObjectListControls.PerformLayout();
            this.toolStripObjectsList.ResumeLayout(false);
            this.toolStripObjectsList.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlProfiles.ResumeLayout(false);
            this.pnlProfiles.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlDbConnection.ResumeLayout(false);
            this.pnlDbConnection.PerformLayout();
            this.toolStripDbConnection.ResumeLayout(false);
            this.toolStripDbConnection.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSriptFilters;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.ListBox lstObjectTypes;
        private System.Windows.Forms.Panel pnlobjectsList;
        private System.Windows.Forms.Button btnGetObjectsList;
        private System.Windows.Forms.Button btnGenerateScript;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.ComboBox cboServer;
        private System.Windows.Forms.Label lblAuthType;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cboAuthTypes;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitterLeftPanel;
        private System.Windows.Forms.ToolStrip toolStripFilters;
        private System.Windows.Forms.ToolStrip toolStripObjectsList;
        private System.Windows.Forms.ToolStrip toolStripDbConnection;
        private System.Windows.Forms.Label lblDatabases;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Panel pnlObjectListControls;
        private System.Windows.Forms.Panel pnlDbConnection;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.ToolStripLabel lblObjectFilters;
        private System.Windows.Forms.ToolStripLabel lblDbConnection;
        private System.Windows.Forms.ToolStripLabel lblModifiedObjects;
        private System.Windows.Forms.Label lblModifiedObjectsCount;
        private System.Windows.Forms.ToolStripLabel lblDevnfo;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progressBarBW;
        private System.Windows.Forms.ToolStripStatusLabel labelTimeLeft;
        private System.Windows.Forms.CheckBox chkSingleFilePerObject;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Panel pnlProfiles;
        private System.Windows.Forms.ListBox lstProfiles;
        private System.Windows.Forms.ListView lvObjectsList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tscSelectOption;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.ComponentModel.BackgroundWorker backgroundWorkerExample;
    }
}