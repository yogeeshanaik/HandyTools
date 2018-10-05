using System.Windows.Forms;

namespace DatabaseCatalogReader
{
    /// <summary>
    /// Summary description for ProcDlg.
    /// </summary>
    public class ProcDialog : System.Windows.Forms.Form
    {
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioNoQuery;
        private System.Windows.Forms.RadioButton radioScalar;
        private System.Windows.Forms.RadioButton radioReader;
        private System.Windows.Forms.RadioButton radioXmlReader;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInvert;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public System.Windows.Forms.CheckedListBox CheckedListBox
        {
            get { return this.checkedListBox; }
        }

        public ProcDialog()
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
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.radioNoQuery = new System.Windows.Forms.RadioButton();
            this.radioScalar = new System.Windows.Forms.RadioButton();
            this.radioReader = new System.Windows.Forms.RadioButton();
            this.radioXmlReader = new System.Windows.Forms.RadioButton();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // checkedListBox
            //
            this.checkedListBox.HorizontalScrollbar = true;
            this.checkedListBox.Location = new System.Drawing.Point(24, 16);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(312, 319);
            this.checkedListBox.Sorted = true;
            this.checkedListBox.TabIndex = 0;
            this.checkedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_SelectedIndexChanged);
            //
            // buttonOk
            //
            this.buttonOk.Location = new System.Drawing.Point(360, 224);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            //
            // buttonCancel
            //
            this.buttonCancel.Location = new System.Drawing.Point(360, 256);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            //
            // radioNoQuery
            //
            this.radioNoQuery.Checked = true;
            this.radioNoQuery.Location = new System.Drawing.Point(360, 40);
            this.radioNoQuery.Name = "radioNoQuery";
            this.radioNoQuery.Size = new System.Drawing.Size(88, 24);
            this.radioNoQuery.TabIndex = 3;
            this.radioNoQuery.TabStop = true;
            this.radioNoQuery.Text = "NonQuery";
            this.radioNoQuery.CheckedChanged += new System.EventHandler(this.radioNoQuery_CheckedChanged);
            //
            // radioScalar
            //
            this.radioScalar.Location = new System.Drawing.Point(360, 64);
            this.radioScalar.Name = "radioScalar";
            this.radioScalar.Size = new System.Drawing.Size(88, 24);
            this.radioScalar.TabIndex = 4;
            this.radioScalar.Text = "Scalar";
            this.radioScalar.CheckedChanged += new System.EventHandler(this.radioScalar_CheckedChanged);
            //
            // radioReader
            //
            this.radioReader.Location = new System.Drawing.Point(360, 88);
            this.radioReader.Name = "radioReader";
            this.radioReader.Size = new System.Drawing.Size(88, 24);
            this.radioReader.TabIndex = 5;
            this.radioReader.Text = "Reader";
            this.radioReader.CheckedChanged += new System.EventHandler(this.radioReader_CheckedChanged);
            //
            // radioXmlReader
            //
            this.radioXmlReader.Location = new System.Drawing.Point(360, 112);
            this.radioXmlReader.Name = "radioXmlReader";
            this.radioXmlReader.Size = new System.Drawing.Size(88, 24);
            this.radioXmlReader.TabIndex = 6;
            this.radioXmlReader.Text = "XMLReader";
            this.radioXmlReader.CheckedChanged += new System.EventHandler(this.radioXmlReader_CheckedChanged);
            //
            // buttonHelp
            //
            this.buttonHelp.Location = new System.Drawing.Point(360, 312);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(360, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Execute Type:";
            //
            // buttonInvert
            //
            this.buttonInvert.Location = new System.Drawing.Point(360, 152);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.TabIndex = 10;
            this.buttonInvert.Text = "Invert";
            this.buttonInvert.Click += new System.EventHandler(this.buttonInvert_Click);
            //
            // ProcDialog
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(458, 351);
            this.ControlBox = false;
            this.Controls.Add(this.buttonInvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.radioXmlReader);
            this.Controls.Add(this.radioReader);
            this.Controls.Add(this.radioScalar);
            this.Controls.Add(this.radioNoQuery);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.checkedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Catalog Reader";
            this.Load += new System.EventHandler(this.ProcDialog_Load);
            this.ResumeLayout(false);
        }

        #endregion Windows Form Designer generated code

        private void ProcDlg_Load(object sender, System.EventArgs e)
        {
            for (int i = 0; i < this.checkedListBox.Items.Count; i++)
                this.checkedListBox.SetItemChecked(i, true);
            this.checkedListBox.SetSelected(0, true);
        }

        private void checkedListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CheckedListBox lb = sender as CheckedListBox;
            int n = lb.SelectedIndex;
            if (n != -1)
            {
                string item = this.checkedListBox.Items[n] as string;
                string[] split = item.Split(" ".ToCharArray());
                switch (split[1])
                {
                    case "(Non-Query)": this.radioNoQuery.Checked = true; break;
                    case "(Scalar)": this.radioScalar.Checked = true; break;
                    case "(Reader)": this.radioReader.Checked = true; break;
                    case "(XmlReader)": this.radioXmlReader.Checked = true; break;
                }
            }
        }

        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void doRadioButton(object sender, string tag)
        {
            RadioButton btn = sender as RadioButton;
            if (btn.Checked)
            {
                int n = this.checkedListBox.SelectedIndex;
                string item = this.checkedListBox.SelectedItem as string;
                string[] split = item.Split(" ".ToCharArray());
                this.checkedListBox.Items[n] = split[0] + tag;
            }
        }

        private void radioNoQuery_CheckedChanged(object sender, System.EventArgs e)
        {
            doRadioButton(sender, " (Non-Query)");
        }

        private void radioScalar_CheckedChanged(object sender, System.EventArgs e)
        {
            doRadioButton(sender, " (Scalar)");
        }

        private void radioReader_CheckedChanged(object sender, System.EventArgs e)
        {
            doRadioButton(sender, " (Reader)");
        }

        private void radioXmlReader_CheckedChanged(object sender, System.EventArgs e)
        {
            doRadioButton(sender, " (XmlReader)");
        }

        private void buttonHelp_Click(object sender, System.EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void buttonInvert_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < this.checkedListBox.Items.Count; i++)
                this.checkedListBox.SetItemChecked(i,
                    !this.checkedListBox.GetItemChecked(i));
        }

        private void ProcDialog_Load(object sender, System.EventArgs e)
        {
            for (int i = 0; i < this.checkedListBox.Items.Count; i++)
                this.checkedListBox.SetItemChecked(i, true);
        }
    }
}