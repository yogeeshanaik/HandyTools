namespace FastQuery
{
    partial class frmExport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBlueNoCond = new System.Windows.Forms.Button();
            this.btnBluCondition = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnGrayCond = new System.Windows.Forms.Button();
            this.btnGrayNoCond = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rExcel = new System.Windows.Forms.RadioButton();
            this.rCsv = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBlueNoCond
            // 
            this.btnBlueNoCond.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnBlueNoCond.Location = new System.Drawing.Point(12, 12);
            this.btnBlueNoCond.Name = "btnBlueNoCond";
            this.btnBlueNoCond.Size = new System.Drawing.Size(120, 23);
            this.btnBlueNoCond.TabIndex = 1;
            this.btnBlueNoCond.Text = "Blue Sky";
            this.btnBlueNoCond.UseVisualStyleBackColor = true;
            this.btnBlueNoCond.Click += new System.EventHandler(this.btnBlueNoCond_Click);
            // 
            // btnBluCondition
            // 
            this.btnBluCondition.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnBluCondition.Location = new System.Drawing.Point(138, 12);
            this.btnBluCondition.Name = "btnBluCondition";
            this.btnBluCondition.Size = new System.Drawing.Size(136, 23);
            this.btnBluCondition.TabIndex = 2;
            this.btnBluCondition.Text = "Classic Gray";
            this.btnBluCondition.UseVisualStyleBackColor = true;
            this.btnBluCondition.Click += new System.EventHandler(this.btnBluCondition_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(290, 101);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(110, 23);
            this.btnCSV.TabIndex = 3;
            this.btnCSV.Text = "CSV -> NoTheme";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // btnGrayCond
            // 
            this.btnGrayCond.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnGrayCond.Location = new System.Drawing.Point(138, 42);
            this.btnGrayCond.Name = "btnGrayCond";
            this.btnGrayCond.Size = new System.Drawing.Size(136, 23);
            this.btnGrayCond.TabIndex = 5;
            this.btnGrayCond.Text = "NiceViolet";
            this.btnGrayCond.UseVisualStyleBackColor = true;
            this.btnGrayCond.Click += new System.EventHandler(this.btnGrayCond_Click);
            // 
            // btnGrayNoCond
            // 
            this.btnGrayNoCond.ForeColor = System.Drawing.Color.Green;
            this.btnGrayNoCond.Location = new System.Drawing.Point(12, 42);
            this.btnGrayNoCond.Name = "btnGrayNoCond";
            this.btnGrayNoCond.Size = new System.Drawing.Size(120, 23);
            this.btnGrayNoCond.TabIndex = 4;
            this.btnGrayNoCond.Text = "GreenIsGood";
            this.btnGrayNoCond.UseVisualStyleBackColor = true;
            this.btnGrayNoCond.Click += new System.EventHandler(this.btnGrayNoCond_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.button1.Location = new System.Drawing.Point(138, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "SweetPink";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(12, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "LadyInRed";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(138, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Dark Blue";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.DarkOrange;
            this.button4.Location = new System.Drawing.Point(12, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "OrankeWorks";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rExcel);
            this.groupBox1.Controls.Add(this.rCsv);
            this.groupBox1.Location = new System.Drawing.Point(290, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 73);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ExportType";
            // 
            // rExcel
            // 
            this.rExcel.AutoSize = true;
            this.rExcel.Checked = true;
            this.rExcel.Location = new System.Drawing.Point(17, 45);
            this.rExcel.Name = "rExcel";
            this.rExcel.Size = new System.Drawing.Size(78, 17);
            this.rExcel.TabIndex = 0;
            this.rExcel.TabStop = true;
            this.rExcel.Text = "Excel 2003";
            this.rExcel.UseVisualStyleBackColor = true;
            // 
            // rCsv
            // 
            this.rCsv.AutoSize = true;
            this.rCsv.Location = new System.Drawing.Point(17, 20);
            this.rCsv.Name = "rCsv";
            this.rCsv.Size = new System.Drawing.Size(46, 17);
            this.rCsv.TabIndex = 0;
            this.rCsv.Text = "CSV";
            this.rCsv.UseVisualStyleBackColor = true;
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnGrayCond);
            this.Controls.Add(this.btnGrayNoCond);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.btnBluCondition);
            this.Controls.Add(this.btnBlueNoCond);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(429, 391);
            this.Name = "frmExport";
            this.Text = "FastQuery";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBlueNoCond;
        private System.Windows.Forms.Button btnBluCondition;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnGrayCond;
        private System.Windows.Forms.Button btnGrayNoCond;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rExcel;
        private System.Windows.Forms.RadioButton rCsv;
    }
}

