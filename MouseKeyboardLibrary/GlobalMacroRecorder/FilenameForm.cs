using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GlobalMacroRecorder
{
    public partial class FilenameForm : Form
    {
        public string Filename { get; set; }
        public string Description { get; set; }

        public FilenameForm()
        {
            InitializeComponent();
        }

        public FilenameForm(string filename, string description)
        {
            InitializeComponent();
            txtFilename.Text = filename;
            txtDescription.Text = description;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Filename = txtFilename.Text;
            Description = txtDescription.Text;
            this.Close();
        }

        private void FilenameForm_Load(object sender, EventArgs e)
        {
        }

        private void txtFilename_TextChanged(object sender, EventArgs e)
        {
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}