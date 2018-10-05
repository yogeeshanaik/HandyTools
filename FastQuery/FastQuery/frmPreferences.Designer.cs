namespace FastQuery
{
    partial class frmPreferences
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
            this.pnlResultAppearance = new System.Windows.Forms.Panel();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Displayed = new System.Windows.Forms.RadioButton();
            this.cbRowSelect = new System.Windows.Forms.CheckBox();
            this.Fill = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboGridStyles = new System.Windows.Forms.ComboBox();
            this.numTransperency = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDataGridBackground = new System.Windows.Forms.Button();
            this.btnAltRowBack = new System.Windows.Forms.Button();
            this.btnSelRowBack = new System.Windows.Forms.Button();
            this.btnRowBack = new System.Windows.Forms.Button();
            this.btnRowFore = new System.Windows.Forms.Button();
            this.btnRowHeadBack = new System.Windows.Forms.Button();
            this.btnRowHeadFore = new System.Windows.Forms.Button();
            this.btnColHeadBack = new System.Windows.Forms.Button();
            this.btnGrid = new System.Windows.Forms.Button();
            this.btnColHeadFore = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnFont = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbCustom = new System.Windows.Forms.CheckBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.cdGrid = new System.Windows.Forms.ColorDialog();
            this.tabConfigurations = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboServers = new System.Windows.Forms.ComboBox();
            this.lblAuthType = new System.Windows.Forms.Label();
            this.cboAuthTypes = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.pnlResultAppearance.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransperency)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabConfigurations.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlResultAppearance
            // 
            this.pnlResultAppearance.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnlResultAppearance.Controls.Add(this.btnDefault);
            this.pnlResultAppearance.Controls.Add(this.btnOk);
            this.pnlResultAppearance.Controls.Add(this.btnCancel);
            this.pnlResultAppearance.Controls.Add(this.btnApply);
            this.pnlResultAppearance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlResultAppearance.Location = new System.Drawing.Point(0, 427);
            this.pnlResultAppearance.Name = "pnlResultAppearance";
            this.pnlResultAppearance.Size = new System.Drawing.Size(729, 55);
            this.pnlResultAppearance.TabIndex = 0;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(387, 12);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 8;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(202, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(295, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(479, 12);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Displayed);
            this.groupBox1.Controls.Add(this.cbRowSelect);
            this.groupBox1.Controls.Add(this.Fill);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cboGridStyles);
            this.groupBox1.Controls.Add(this.numTransperency);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.cbCustom);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 380);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result Appearence";
            // 
            // Displayed
            // 
            this.Displayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Displayed.AutoSize = true;
            this.Displayed.Location = new System.Drawing.Point(477, 345);
            this.Displayed.Name = "Displayed";
            this.Displayed.Size = new System.Drawing.Size(75, 17);
            this.Displayed.TabIndex = 22;
            this.Displayed.TabStop = true;
            this.Displayed.Text = "AutoWidth";
            this.Displayed.UseVisualStyleBackColor = true;
            this.Displayed.CheckedChanged += new System.EventHandler(this.Displayed_CheckedChanged);
            // 
            // cbRowSelect
            // 
            this.cbRowSelect.AutoSize = true;
            this.cbRowSelect.Location = new System.Drawing.Point(41, 345);
            this.cbRowSelect.Name = "cbRowSelect";
            this.cbRowSelect.Size = new System.Drawing.Size(93, 17);
            this.cbRowSelect.TabIndex = 23;
            this.cbRowSelect.Text = "Full row select";
            this.cbRowSelect.UseVisualStyleBackColor = true;
            this.cbRowSelect.CheckedChanged += new System.EventHandler(this.cbRowSelect_CheckedChanged);
            // 
            // Fill
            // 
            this.Fill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fill.AutoSize = true;
            this.Fill.Location = new System.Drawing.Point(412, 344);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(37, 17);
            this.Fill.TabIndex = 21;
            this.Fill.TabStop = true;
            this.Fill.Text = "Fill";
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.CheckedChanged += new System.EventHandler(this.Fill_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(38, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Transparency";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label14.Location = new System.Drawing.Point(477, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Appearence";
            // 
            // cboGridStyles
            // 
            this.cboGridStyles.Enabled = false;
            this.cboGridStyles.FormattingEnabled = true;
            this.cboGridStyles.Items.AddRange(new object[] {
            "Default",
            "GunMetal",
            "Night Vision",
            "Radium Rush",
            "Transparent"});
            this.cboGridStyles.Location = new System.Drawing.Point(553, 17);
            this.cboGridStyles.Name = "cboGridStyles";
            this.cboGridStyles.Size = new System.Drawing.Size(121, 21);
            this.cboGridStyles.TabIndex = 16;
            this.cboGridStyles.Text = "           - select -";
            this.cboGridStyles.SelectedIndexChanged += new System.EventHandler(this.cboGridStyles_SelectedIndexChanged);
            // 
            // numTransperency
            // 
            this.numTransperency.Location = new System.Drawing.Point(180, 18);
            this.numTransperency.Name = "numTransperency";
            this.numTransperency.Size = new System.Drawing.Size(85, 20);
            this.numTransperency.TabIndex = 0;
            this.numTransperency.ValueChanged += new System.EventHandler(this.numTransperency_ValueChanged_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDataGridBackground);
            this.panel2.Controls.Add(this.btnAltRowBack);
            this.panel2.Controls.Add(this.btnSelRowBack);
            this.panel2.Controls.Add(this.btnRowBack);
            this.panel2.Controls.Add(this.btnRowFore);
            this.panel2.Controls.Add(this.btnRowHeadBack);
            this.panel2.Controls.Add(this.btnRowHeadFore);
            this.panel2.Controls.Add(this.btnColHeadBack);
            this.panel2.Controls.Add(this.btnGrid);
            this.panel2.Controls.Add(this.btnColHeadFore);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(8, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 285);
            this.panel2.TabIndex = 15;
            // 
            // btnDataGridBackground
            // 
            this.btnDataGridBackground.ForeColor = System.Drawing.Color.Black;
            this.btnDataGridBackground.Location = new System.Drawing.Point(545, 237);
            this.btnDataGridBackground.Name = "btnDataGridBackground";
            this.btnDataGridBackground.Size = new System.Drawing.Size(85, 23);
            this.btnDataGridBackground.TabIndex = 23;
            this.btnDataGridBackground.Text = "^";
            this.btnDataGridBackground.UseVisualStyleBackColor = true;
            this.btnDataGridBackground.Click += new System.EventHandler(this.btnDataGridBackground_Click);
            // 
            // btnAltRowBack
            // 
            this.btnAltRowBack.ForeColor = System.Drawing.Color.Black;
            this.btnAltRowBack.Location = new System.Drawing.Point(545, 194);
            this.btnAltRowBack.Name = "btnAltRowBack";
            this.btnAltRowBack.Size = new System.Drawing.Size(85, 23);
            this.btnAltRowBack.TabIndex = 21;
            this.btnAltRowBack.Text = "^";
            this.btnAltRowBack.UseVisualStyleBackColor = true;
            this.btnAltRowBack.Click += new System.EventHandler(this.btnAltRowBack_Click);
            // 
            // btnSelRowBack
            // 
            this.btnSelRowBack.ForeColor = System.Drawing.Color.Black;
            this.btnSelRowBack.Location = new System.Drawing.Point(172, 194);
            this.btnSelRowBack.Name = "btnSelRowBack";
            this.btnSelRowBack.Size = new System.Drawing.Size(85, 23);
            this.btnSelRowBack.TabIndex = 20;
            this.btnSelRowBack.Text = "^";
            this.btnSelRowBack.UseVisualStyleBackColor = true;
            this.btnSelRowBack.Click += new System.EventHandler(this.btnSelRowBack_Click);
            // 
            // btnRowBack
            // 
            this.btnRowBack.ForeColor = System.Drawing.Color.Black;
            this.btnRowBack.Location = new System.Drawing.Point(545, 149);
            this.btnRowBack.Name = "btnRowBack";
            this.btnRowBack.Size = new System.Drawing.Size(85, 23);
            this.btnRowBack.TabIndex = 19;
            this.btnRowBack.Text = "^";
            this.btnRowBack.UseVisualStyleBackColor = true;
            this.btnRowBack.Click += new System.EventHandler(this.btnRowBack_Click);
            // 
            // btnRowFore
            // 
            this.btnRowFore.ForeColor = System.Drawing.Color.Black;
            this.btnRowFore.Location = new System.Drawing.Point(172, 149);
            this.btnRowFore.Name = "btnRowFore";
            this.btnRowFore.Size = new System.Drawing.Size(85, 23);
            this.btnRowFore.TabIndex = 18;
            this.btnRowFore.Text = "^";
            this.btnRowFore.UseVisualStyleBackColor = true;
            this.btnRowFore.Click += new System.EventHandler(this.btnRowFore_Click);
            // 
            // btnRowHeadBack
            // 
            this.btnRowHeadBack.ForeColor = System.Drawing.Color.Black;
            this.btnRowHeadBack.Location = new System.Drawing.Point(545, 106);
            this.btnRowHeadBack.Name = "btnRowHeadBack";
            this.btnRowHeadBack.Size = new System.Drawing.Size(85, 23);
            this.btnRowHeadBack.TabIndex = 17;
            this.btnRowHeadBack.Text = "^";
            this.btnRowHeadBack.UseVisualStyleBackColor = true;
            this.btnRowHeadBack.Click += new System.EventHandler(this.btnRowHeadBack_Click);
            // 
            // btnRowHeadFore
            // 
            this.btnRowHeadFore.ForeColor = System.Drawing.Color.Black;
            this.btnRowHeadFore.Location = new System.Drawing.Point(172, 106);
            this.btnRowHeadFore.Name = "btnRowHeadFore";
            this.btnRowHeadFore.Size = new System.Drawing.Size(85, 23);
            this.btnRowHeadFore.TabIndex = 16;
            this.btnRowHeadFore.Text = "^";
            this.btnRowHeadFore.UseVisualStyleBackColor = true;
            this.btnRowHeadFore.Click += new System.EventHandler(this.btnRowHeadFore_Click);
            // 
            // btnColHeadBack
            // 
            this.btnColHeadBack.ForeColor = System.Drawing.Color.Black;
            this.btnColHeadBack.Location = new System.Drawing.Point(545, 66);
            this.btnColHeadBack.Name = "btnColHeadBack";
            this.btnColHeadBack.Size = new System.Drawing.Size(85, 23);
            this.btnColHeadBack.TabIndex = 15;
            this.btnColHeadBack.Text = "^";
            this.btnColHeadBack.UseVisualStyleBackColor = true;
            this.btnColHeadBack.Click += new System.EventHandler(this.btnColHeadBack_Click);
            // 
            // btnGrid
            // 
            this.btnGrid.ForeColor = System.Drawing.Color.Black;
            this.btnGrid.Location = new System.Drawing.Point(172, 237);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(85, 23);
            this.btnGrid.TabIndex = 14;
            this.btnGrid.Text = "^";
            this.btnGrid.UseVisualStyleBackColor = true;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // btnColHeadFore
            // 
            this.btnColHeadFore.ForeColor = System.Drawing.Color.Black;
            this.btnColHeadFore.Location = new System.Drawing.Point(172, 66);
            this.btnColHeadFore.Name = "btnColHeadFore";
            this.btnColHeadFore.Size = new System.Drawing.Size(85, 23);
            this.btnColHeadFore.TabIndex = 13;
            this.btnColHeadFore.Text = "^";
            this.btnColHeadFore.UseVisualStyleBackColor = true;
            this.btnColHeadFore.Click += new System.EventHandler(this.btnColHeadFore_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(401, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Grid Background Color";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(401, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Rows BackColor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(30, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Rows ForeColor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(30, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Column Headers ForeColor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(401, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Column Headers BackColor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(30, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Row Headers fore color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(401, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Alternate Rows BackColor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(30, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Grid Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(401, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Row Headers back color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(30, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selected Rows BackColor";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.btnFont);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label15);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(-1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 38);
            this.panel3.TabIndex = 22;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(546, 10);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btnFont
            // 
            this.btnFont.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFont.AutoSize = true;
            this.btnFont.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFont.ForeColor = System.Drawing.Color.Black;
            this.btnFont.Location = new System.Drawing.Point(172, 7);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(147, 23);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "Microsoft Sans Serif, 8.25pt";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(402, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result table font size";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label15.Location = new System.Drawing.Point(31, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Result table font style";
            // 
            // cbCustom
            // 
            this.cbCustom.AutoSize = true;
            this.cbCustom.Checked = true;
            this.cbCustom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCustom.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbCustom.Location = new System.Drawing.Point(412, 20);
            this.cbCustom.Name = "cbCustom";
            this.cbCustom.Size = new System.Drawing.Size(61, 17);
            this.cbCustom.TabIndex = 14;
            this.cbCustom.Text = "Custom";
            this.cbCustom.UseVisualStyleBackColor = true;
            this.cbCustom.CheckedChanged += new System.EventHandler(this.cbCustom_CheckedChanged);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
            // 
            // tabConfigurations
            // 
            this.tabConfigurations.Controls.Add(this.tabPage2);
            this.tabConfigurations.Controls.Add(this.tabPage1);
            this.tabConfigurations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConfigurations.Location = new System.Drawing.Point(0, 0);
            this.tabConfigurations.Name = "tabConfigurations";
            this.tabConfigurations.SelectedIndex = 0;
            this.tabConfigurations.Size = new System.Drawing.Size(729, 427);
            this.tabConfigurations.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(721, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtServer);
            this.groupBox2.Controls.Add(this.cboServers);
            this.groupBox2.Controls.Add(this.lblAuthType);
            this.groupBox2.Controls.Add(this.cboAuthTypes);
            this.groupBox2.Controls.Add(this.lblPassword);
            this.groupBox2.Controls.Add(this.btnTestConnection);
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Controls.Add(this.lblServer);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 380);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection String";
            // 
            // cboServers
            // 
            this.cboServers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboServers.FormattingEnabled = true;
            this.cboServers.Location = new System.Drawing.Point(280, 71);
            this.cboServers.Name = "cboServers";
            this.cboServers.Size = new System.Drawing.Size(211, 21);
            this.cboServers.TabIndex = 17;
            this.cboServers.SelectedIndexChanged += new System.EventHandler(this.cboServers_SelectedIndexChanged);
            // 
            // lblAuthType
            // 
            this.lblAuthType.AutoSize = true;
            this.lblAuthType.Location = new System.Drawing.Point(193, 122);
            this.lblAuthType.Name = "lblAuthType";
            this.lblAuthType.Size = new System.Drawing.Size(32, 13);
            this.lblAuthType.TabIndex = 16;
            this.lblAuthType.Text = "&Auth:";
            // 
            // cboAuthTypes
            // 
            this.cboAuthTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthTypes.FormattingEnabled = true;
            this.cboAuthTypes.Location = new System.Drawing.Point(280, 119);
            this.cboAuthTypes.Name = "cboAuthTypes";
            this.cboAuthTypes.Size = new System.Drawing.Size(211, 21);
            this.cboAuthTypes.TabIndex = 15;
            this.cboAuthTypes.SelectedIndexChanged += new System.EventHandler(this.cboAuthTypes_SelectedIndexChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(193, 217);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "&Password:";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(370, 261);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(121, 23);
            this.btnTestConnection.TabIndex = 1;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(193, 170);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(32, 13);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "&User:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(193, 74);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 11;
            this.lblServer.Text = "S&erver:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(280, 167);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(211, 20);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Text = "sa";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(280, 214);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(211, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appearance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(280, 45);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(211, 20);
            this.txtServer.TabIndex = 18;
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 482);
            this.Controls.Add(this.tabConfigurations);
            this.Controls.Add(this.pnlResultAppearance);
            this.Name = "frmPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurations";
            this.Load += new System.EventHandler(this.frmPreferences_Load);
            this.pnlResultAppearance.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransperency)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabConfigurations.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlResultAppearance;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboGridStyles;
        private System.Windows.Forms.NumericUpDown numTransperency;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDataGridBackground;
        private System.Windows.Forms.Button btnAltRowBack;
        private System.Windows.Forms.Button btnSelRowBack;
        private System.Windows.Forms.Button btnRowBack;
        private System.Windows.Forms.Button btnRowFore;
        private System.Windows.Forms.Button btnRowHeadBack;
        private System.Windows.Forms.Button btnRowHeadFore;
        private System.Windows.Forms.Button btnColHeadBack;
        private System.Windows.Forms.Button btnGrid;
        private System.Windows.Forms.Button btnColHeadFore;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cbCustom;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog cdGrid;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.TabControl tabConfigurations;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblAuthType;
        private System.Windows.Forms.ComboBox cboAuthTypes;
        private System.Windows.Forms.ComboBox cboServers;
        private System.Windows.Forms.RadioButton Displayed;
        private System.Windows.Forms.CheckBox cbRowSelect;
        private System.Windows.Forms.RadioButton Fill;
        private System.Windows.Forms.TextBox txtServer;
    }
}