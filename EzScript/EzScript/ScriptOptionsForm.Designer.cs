namespace EzScript
{
    partial class ScriptOptionsForm
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
            this.propertyScriptOptions = new System.Windows.Forms.PropertyGrid();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblScriptingStatus = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyScriptOptions
            // 
            this.propertyScriptOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyScriptOptions.Location = new System.Drawing.Point(0, 0);
            this.propertyScriptOptions.Name = "propertyScriptOptions";
            this.propertyScriptOptions.Size = new System.Drawing.Size(427, 381);
            this.propertyScriptOptions.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(175, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Start";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.lblScriptingStatus);
            this.pnlControls.Controls.Add(this.btnOk);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.Location = new System.Drawing.Point(0, 381);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(427, 80);
            this.pnlControls.TabIndex = 2;
            // 
            // lblScriptingStatus
            // 
            this.lblScriptingStatus.AutoSize = true;
            this.lblScriptingStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblScriptingStatus.Location = new System.Drawing.Point(8, 33);
            this.lblScriptingStatus.MaximumSize = new System.Drawing.Size(420, 0);
            this.lblScriptingStatus.Name = "lblScriptingStatus";
            this.lblScriptingStatus.Size = new System.Drawing.Size(0, 13);
            this.lblScriptingStatus.TabIndex = 2;
            // 
            // ScriptOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 461);
            this.Controls.Add(this.propertyScriptOptions);
            this.Controls.Add(this.pnlControls);
            this.MaximumSize = new System.Drawing.Size(443, 500);
            this.MinimumSize = new System.Drawing.Size(443, 500);
            this.Name = "ScriptOptionsForm";
            this.Text = "frmScriptOptions";
            this.Load += new System.EventHandler(this.frmScriptOptions_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyScriptOptions;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnlControls;
        public System.Windows.Forms.Label lblScriptingStatus;
    }
}