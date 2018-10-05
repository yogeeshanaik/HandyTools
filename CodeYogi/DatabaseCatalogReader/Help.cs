namespace DatabaseCatalogReader
{
    /// <summary>
    /// Summary description for Help.
    /// </summary>
    public class Help : System.Windows.Forms.Form
    {
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Help()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // richTextBox
            //
            this.richTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.richTextBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox.ShowSelectionMargin = true;
            this.richTextBox.Size = new System.Drawing.Size(504, 247);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "richTextBox1";
            this.richTextBox.ZoomFactor = 1.249638F;
            //
            // panel1
            //
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 40);
            this.panel1.TabIndex = 1;
            //
            // buttonClose
            //
            this.buttonClose.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonClose.Location = new System.Drawing.Point(216, 8);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            //
            // Help
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(504, 247);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion Windows Form Designer generated code

        private void buttonClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Help_Load(object sender, System.EventArgs e)
        {
            this.richTextBox.Text = @"
Just check the stored procedures of interest to you.

Also, you need to indicate whether the stored procedure executes a non-query, returns a scalar, a record set, or an xml formatted document.

First select a stored procedure and then, using the radio buttons, choose the execute type.

The default assumption is that all stored procedures execute a non-query.";
        }
    }
}