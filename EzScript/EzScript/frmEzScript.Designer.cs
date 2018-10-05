namespace EzScript
{
    partial class frmEzScript
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
            this.cboDatabases = new System.Windows.Forms.ComboBox();
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
            this.lstObjectsList = new System.Windows.Forms.ListBox();
            this.pnlObjectListControls = new System.Windows.Forms.Panel();
            this.lblModifiedObjectsCount = new System.Windows.Forms.Label();
            this.btnGenerateScript = new System.Windows.Forms.Button();
            this.toolStripObjectsList = new System.Windows.Forms.ToolStrip();
            this.lblModifiedObjects = new System.Windows.Forms.ToolStripLabel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.pnlDbConnection = new System.Windows.Forms.Panel();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cboServers = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAuthType = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboAuthTypes = new System.Windows.Forms.ComboBox();
            this.toolStripDbConnection = new System.Windows.Forms.ToolStrip();
            this.lblDbConnection = new System.Windows.Forms.ToolStripLabel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.splitterLeftPanel = new System.Windows.Forms.Splitter();
            this.pnlSriptFilters.SuspendLayout();
            this.toolStripFilters.SuspendLayout();
            this.pnlobjectsList.SuspendLayout();
            this.pnlObjectListControls.SuspendLayout();
            this.toolStripObjectsList.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlDbConnection.SuspendLayout();
            this.toolStripDbConnection.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSriptFilters
            // 
            this.pnlSriptFilters.Controls.Add(this.lblDatabases);
            this.pnlSriptFilters.Controls.Add(this.cboDatabases);
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
            this.pnlSriptFilters.Size = new System.Drawing.Size(664, 227);
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
            // cboDatabases
            // 
            this.cboDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatabases.FormattingEnabled = true;
            this.cboDatabases.Location = new System.Drawing.Point(125, 48);
            this.cboDatabases.Name = "cboDatabases";
            this.cboDatabases.Size = new System.Drawing.Size(151, 21);
            this.cboDatabases.TabIndex = 10;
            this.cboDatabases.SelectedIndexChanged += new System.EventHandler(this.cboDatabase_SelectedIndexChanged);
            // 
            // toolStripFilters
            // 
            this.toolStripFilters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblObjectFilters,
            this.lblDevnfo});
            this.toolStripFilters.Location = new System.Drawing.Point(0, 0);
            this.toolStripFilters.Name = "toolStripFilters";
            this.toolStripFilters.Size = new System.Drawing.Size(664, 25);
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
            this.btnGetObjectsList.Location = new System.Drawing.Point(23, 188);
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
            this.lstObjectTypes.Location = new System.Drawing.Point(314, 51);
            this.lstObjectTypes.Name = "lstObjectTypes";
            this.lstObjectTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstObjectTypes.Size = new System.Drawing.Size(323, 160);
            this.lstObjectTypes.TabIndex = 7;
            // 
            // lblObjectType
            // 
            this.lblObjectType.AutoSize = true;
            this.lblObjectType.Location = new System.Drawing.Point(311, 35);
            this.lblObjectType.Name = "lblObjectType";
            this.lblObjectType.Size = new System.Drawing.Size(65, 13);
            this.lblObjectType.TabIndex = 5;
            this.lblObjectType.Text = "Object Type";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(125, 133);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(151, 20);
            this.dtpTo.TabIndex = 4;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(125, 89);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(151, 20);
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
            this.pnlobjectsList.Controls.Add(this.lstObjectsList);
            this.pnlobjectsList.Controls.Add(this.pnlObjectListControls);
            this.pnlobjectsList.Controls.Add(this.toolStripObjectsList);
            this.pnlobjectsList.Controls.Add(this.splitter2);
            this.pnlobjectsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlobjectsList.Location = new System.Drawing.Point(0, 227);
            this.pnlobjectsList.Name = "pnlobjectsList";
            this.pnlobjectsList.Size = new System.Drawing.Size(664, 249);
            this.pnlobjectsList.TabIndex = 1;
            // 
            // lstObjectsList
            // 
            this.lstObjectsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstObjectsList.FormattingEnabled = true;
            this.lstObjectsList.Location = new System.Drawing.Point(0, 28);
            this.lstObjectsList.Name = "lstObjectsList";
            this.lstObjectsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstObjectsList.Size = new System.Drawing.Size(664, 181);
            this.lstObjectsList.TabIndex = 8;
            // 
            // pnlObjectListControls
            // 
            this.pnlObjectListControls.Controls.Add(this.lblModifiedObjectsCount);
            this.pnlObjectListControls.Controls.Add(this.btnGenerateScript);
            this.pnlObjectListControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlObjectListControls.Location = new System.Drawing.Point(0, 209);
            this.pnlObjectListControls.Name = "pnlObjectListControls";
            this.pnlObjectListControls.Size = new System.Drawing.Size(664, 40);
            this.pnlObjectListControls.TabIndex = 12;
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
            this.lblModifiedObjects});
            this.toolStripObjectsList.Location = new System.Drawing.Point(0, 3);
            this.toolStripObjectsList.Name = "toolStripObjectsList";
            this.toolStripObjectsList.Size = new System.Drawing.Size(664, 25);
            this.toolStripObjectsList.TabIndex = 11;
            this.toolStripObjectsList.Text = "toolStrip3";
            // 
            // lblModifiedObjects
            // 
            this.lblModifiedObjects.Name = "lblModifiedObjects";
            this.lblModifiedObjects.Size = new System.Drawing.Size(98, 22);
            this.lblModifiedObjects.Text = "Modified Objetcs";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(664, 3);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.pnlInfo);
            this.pnlLeft.Controls.Add(this.pnlDbConnection);
            this.pnlLeft.Controls.Add(this.toolStripDbConnection);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.MinimumSize = new System.Drawing.Size(250, 478);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(250, 478);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.rtbInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(0, 282);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(248, 194);
            this.pnlInfo.TabIndex = 20;
            // 
            // rtbInfo
            // 
            this.rtbInfo.BackColor = System.Drawing.SystemColors.Control;
            this.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo.Location = new System.Drawing.Point(0, 0);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(248, 194);
            this.rtbInfo.TabIndex = 1;
            this.rtbInfo.Text = "";
            // 
            // pnlDbConnection
            // 
            this.pnlDbConnection.Controls.Add(this.lblServer);
            this.pnlDbConnection.Controls.Add(this.lblUserName);
            this.pnlDbConnection.Controls.Add(this.txtServer);
            this.pnlDbConnection.Controls.Add(this.btnTestConnection);
            this.pnlDbConnection.Controls.Add(this.txtUserName);
            this.pnlDbConnection.Controls.Add(this.cboServers);
            this.pnlDbConnection.Controls.Add(this.lblPassword);
            this.pnlDbConnection.Controls.Add(this.lblAuthType);
            this.pnlDbConnection.Controls.Add(this.txtPassword);
            this.pnlDbConnection.Controls.Add(this.cboAuthTypes);
            this.pnlDbConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDbConnection.Location = new System.Drawing.Point(0, 25);
            this.pnlDbConnection.Name = "pnlDbConnection";
            this.pnlDbConnection.Size = new System.Drawing.Size(248, 257);
            this.pnlDbConnection.TabIndex = 21;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(20, 10);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 11;
            this.lblServer.Text = "S&erver:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(20, 108);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(32, 13);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "&User:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(20, 28);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 19;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(110, 207);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(121, 23);
            this.btnTestConnection.TabIndex = 1;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(20, 124);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(211, 20);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Text = "sa";
            // 
            // cboServers
            // 
            this.cboServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServers.FormattingEnabled = true;
            this.cboServers.Location = new System.Drawing.Point(20, 28);
            this.cboServers.Name = "cboServers";
            this.cboServers.Size = new System.Drawing.Size(211, 21);
            this.cboServers.TabIndex = 17;
            this.cboServers.SelectedIndexChanged += new System.EventHandler(this.cboServers_SelectedIndexChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 155);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "&Password:";
            // 
            // lblAuthType
            // 
            this.lblAuthType.AutoSize = true;
            this.lblAuthType.Location = new System.Drawing.Point(20, 60);
            this.lblAuthType.Name = "lblAuthType";
            this.lblAuthType.Size = new System.Drawing.Size(32, 13);
            this.lblAuthType.TabIndex = 16;
            this.lblAuthType.Text = "&Auth:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(20, 171);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(211, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // cboAuthTypes
            // 
            this.cboAuthTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthTypes.FormattingEnabled = true;
            this.cboAuthTypes.Location = new System.Drawing.Point(20, 76);
            this.cboAuthTypes.Name = "cboAuthTypes";
            this.cboAuthTypes.Size = new System.Drawing.Size(211, 21);
            this.cboAuthTypes.TabIndex = 15;
            this.cboAuthTypes.SelectedIndexChanged += new System.EventHandler(this.cboAuthTypes_SelectedIndexChanged);
            this.cboAuthTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
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
            // pnlRight
            // 
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.pnlobjectsList);
            this.pnlRight.Controls.Add(this.pnlSriptFilters);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(253, 0);
            this.pnlRight.MinimumSize = new System.Drawing.Size(664, 478);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(666, 478);
            this.pnlRight.TabIndex = 3;
            // 
            // splitterLeftPanel
            // 
            this.splitterLeftPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitterLeftPanel.Location = new System.Drawing.Point(250, 0);
            this.splitterLeftPanel.Name = "splitterLeftPanel";
            this.splitterLeftPanel.Size = new System.Drawing.Size(3, 478);
            this.splitterLeftPanel.TabIndex = 2;
            this.splitterLeftPanel.TabStop = false;
            // 
            // frmEzScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 478);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.splitterLeftPanel);
            this.Controls.Add(this.pnlLeft);
            this.Name = "frmEzScript";
            this.Text = "EzScript";
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
            this.pnlLeft.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlDbConnection.ResumeLayout(false);
            this.pnlDbConnection.PerformLayout();
            this.toolStripDbConnection.ResumeLayout(false);
            this.toolStripDbConnection.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ListBox lstObjectsList;
        private System.Windows.Forms.Button btnGetObjectsList;
        private System.Windows.Forms.Button btnGenerateScript;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.ComboBox cboServers;
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
        private System.Windows.Forms.ComboBox cboDatabases;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Panel pnlObjectListControls;
        private System.Windows.Forms.Panel pnlDbConnection;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.ToolStripLabel lblObjectFilters;
        private System.Windows.Forms.ToolStripLabel lblDbConnection;
        private System.Windows.Forms.ToolStripLabel lblModifiedObjects;
        private System.Windows.Forms.Label lblModifiedObjectsCount;
        private System.Windows.Forms.ToolStripLabel lblDevnfo;
    }
}