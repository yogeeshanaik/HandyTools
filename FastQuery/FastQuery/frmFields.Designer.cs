namespace FastQuery
{
    partial class frmFields
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFields));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkFormat = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkAlias = new System.Windows.Forms.CheckBox();
            this.lstFields = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboTables = new System.Windows.Forms.ToolStripComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbPreview = new System.Windows.Forms.RichTextBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lblAliasRightTrim = new System.Windows.Forms.Label();
            this.nudAliasRightTrim = new System.Windows.Forms.NumericUpDown();
            this.lblAliasLeftTrim = new System.Windows.Forms.Label();
            this.nudAliasLeftTrim = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAliasRightTrim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAliasLeftTrim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.chkFormat);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.chkAlias);
            this.panel1.Controls.Add(this.lstFields);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 408);
            this.panel1.TabIndex = 0;
            // 
            // chkFormat
            // 
            this.chkFormat.AutoSize = true;
            this.chkFormat.Location = new System.Drawing.Point(11, 343);
            this.chkFormat.Name = "chkFormat";
            this.chkFormat.Size = new System.Drawing.Size(128, 20);
            this.chkFormat.TabIndex = 6;
            this.chkFormat.Text = "Use smart format";
            this.chkFormat.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(214, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkAlias
            // 
            this.chkAlias.AutoSize = true;
            this.chkAlias.Location = new System.Drawing.Point(11, 317);
            this.chkAlias.Name = "chkAlias";
            this.chkAlias.Size = new System.Drawing.Size(120, 20);
            this.chkAlias.TabIndex = 5;
            this.chkAlias.Text = "Use smart alias";
            this.chkAlias.UseVisualStyleBackColor = true;
            // 
            // lstFields
            // 
            this.lstFields.FormattingEnabled = true;
            this.lstFields.HorizontalScrollbar = true;
            this.lstFields.ItemHeight = 16;
            this.lstFields.Location = new System.Drawing.Point(11, 19);
            this.lstFields.Name = "lstFields";
            this.lstFields.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstFields.Size = new System.Drawing.Size(358, 292);
            this.lstFields.TabIndex = 1;
            this.lstFields.SelectedIndexChanged += new System.EventHandler(this.lstFields_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(292, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 34);
            this.btnAdd.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAdd, "Add");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cboTables});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(200, 408);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(198, 15);
            this.toolStripLabel1.Text = "Table";
            // 
            // cboTables
            // 
            this.cboTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboTables.Name = "cboTables";
            this.cboTables.Size = new System.Drawing.Size(196, 150);
            this.cboTables.SelectedIndexChanged += new System.EventHandler(this.cboTables_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 408);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbPreview);
            this.panel2.Controls.Add(this.lblPreview);
            this.panel2.Controls.Add(this.lblAliasRightTrim);
            this.panel2.Controls.Add(this.nudAliasRightTrim);
            this.panel2.Controls.Add(this.lblAliasLeftTrim);
            this.panel2.Controls.Add(this.nudAliasLeftTrim);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 408);
            this.panel2.TabIndex = 8;
            // 
            // rtbPreview
            // 
            this.rtbPreview.Location = new System.Drawing.Point(12, 327);
            this.rtbPreview.Name = "rtbPreview";
            this.rtbPreview.Size = new System.Drawing.Size(182, 69);
            this.rtbPreview.TabIndex = 13;
            this.rtbPreview.Text = "";
            this.rtbPreview.Click += new System.EventHandler(this.rtbPreview_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(12, 311);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(45, 13);
            this.lblPreview.TabIndex = 12;
            this.lblPreview.Text = "Preview";
            // 
            // lblAliasRightTrim
            // 
            this.lblAliasRightTrim.AutoSize = true;
            this.lblAliasRightTrim.Location = new System.Drawing.Point(30, 234);
            this.lblAliasRightTrim.Name = "lblAliasRightTrim";
            this.lblAliasRightTrim.Size = new System.Drawing.Size(100, 13);
            this.lblAliasRightTrim.TabIndex = 11;
            this.lblAliasRightTrim.Text = "Alias right trim chars";
            // 
            // nudAliasRightTrim
            // 
            this.nudAliasRightTrim.Location = new System.Drawing.Point(143, 232);
            this.nudAliasRightTrim.Name = "nudAliasRightTrim";
            this.nudAliasRightTrim.Size = new System.Drawing.Size(39, 20);
            this.nudAliasRightTrim.TabIndex = 10;
            this.nudAliasRightTrim.ValueChanged += new System.EventHandler(this.lstFields_SelectedIndexChanged);
            // 
            // lblAliasLeftTrim
            // 
            this.lblAliasLeftTrim.AutoSize = true;
            this.lblAliasLeftTrim.Location = new System.Drawing.Point(30, 198);
            this.lblAliasLeftTrim.Name = "lblAliasLeftTrim";
            this.lblAliasLeftTrim.Size = new System.Drawing.Size(94, 13);
            this.lblAliasLeftTrim.TabIndex = 9;
            this.lblAliasLeftTrim.Text = "Alias left trim chars";
            // 
            // nudAliasLeftTrim
            // 
            this.nudAliasLeftTrim.Location = new System.Drawing.Point(143, 196);
            this.nudAliasLeftTrim.Name = "nudAliasLeftTrim";
            this.nudAliasLeftTrim.Size = new System.Drawing.Size(39, 20);
            this.nudAliasLeftTrim.TabIndex = 8;
            this.nudAliasLeftTrim.ValueChanged += new System.EventHandler(this.lstFields_SelectedIndexChanged);
            // 
            // frmFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 408);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(593, 446);
            this.MinimumSize = new System.Drawing.Size(593, 446);
            this.Name = "frmFields";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fields";
            this.Load += new System.EventHandler(this.frmFields_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAliasRightTrim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAliasLeftTrim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstFields;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkFormat;
        private System.Windows.Forms.CheckBox chkAlias;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboTables;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbPreview;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label lblAliasRightTrim;
        private System.Windows.Forms.NumericUpDown nudAliasRightTrim;
        private System.Windows.Forms.Label lblAliasLeftTrim;
        private System.Windows.Forms.NumericUpDown nudAliasLeftTrim;
    }
}