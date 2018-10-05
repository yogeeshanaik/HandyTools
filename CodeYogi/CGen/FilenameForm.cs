using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CodeYogi
{
    public enum NameFor
    {
        File,
        Directory
    }

    public partial class FilenameForm : Form
    {
        public List<ListItem> FileExtensionList { get; set; }

        public string Filename { get; set; }
        public string FileExtension { get; set; }
        public string FilenameWithoutExtension { get; set; }

        private NameFor _nameFor { get; set; }

        public FilenameForm()
        {
            InitializeComponent();
            LoadExtensions();
        }

        public FilenameForm(NameFor namefor, string filename)
        {
            InitializeComponent();
            LoadExtensions();

            Filename = Path.GetFileName(filename);
            _nameFor = namefor;

            if (_nameFor == NameFor.Directory)
            {
                lblFilenameFormat.Text = FileExtension = string.Empty;
                cboFileType.Visible = false;
            }
        }

        private void LoadExtensions()
        {
            //Add File extension lst
            FileExtensionList = new List<ListItem>();
            FileExtensionList.Add(new ListItem() { Value = "", Text = "" });
            FileExtensionList.Add(new ListItem() { Value = ".settings", Text = ".settings" });
            FileExtensionList.Add(new ListItem() { Value = ".cst", Text = ".cst" });
            FileExtensionList.Add(new ListItem() { Value = ".xml", Text = ".xml" });
            FileExtensionList.Add(new ListItem() { Value = ".config", Text = ".config" });
            FileExtensionList.Add(new ListItem() { Value = ".cs", Text = ".cs" });
            FileExtensionList.Add(new ListItem() { Value = ".log", Text = ".log" });
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FilenameWithoutExtension = txtFilename.Text;
            FileExtension = (cboFileType.SelectedItem != null) ? (cboFileType.SelectedItem as ListItem).Value.ToString() : string.Empty;
            Filename = string.Format("{0}{1}", txtFilename.Text, FileExtension);
            this.Close();
        }

        private void FilenameForm_Load(object sender, EventArgs e)
        {
            // Bind to combobox
            cboFileType.Items.AddRange(FileExtensionList.ToArray());

            txtFilename.Text = FilenameWithoutExtension = Path.GetFileNameWithoutExtension(Filename);
            FileExtension = Path.GetExtension(Filename);

            if (FileExtension != null && FileExtension.Length > 0)
            {
                if (FileExtensionList.Any(str => str.Text.Contains(FileExtension)))
                    cboFileType.SelectedIndex = cboFileType.FindStringExact(FileExtension);
                else
                    throw new Exception("Invalid file extension!");
            }
        }

        private void txtFilename_TextChanged(object sender, EventArgs e)
        {
            var ext = (cboFileType.SelectedItem != null) ? (cboFileType.SelectedItem as ListItem).Value.ToString() : string.Empty;
            lblFilenameFormat.Text = string.Format("{0}{1}", txtFilename.Text, ext);
        }

        private void cboFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ext = (cboFileType.SelectedItem != null) ? (cboFileType.SelectedItem as ListItem).Value.ToString() : string.Empty;
            lblFilenameFormat.Text = string.Format("{0}{1}", txtFilename.Text, ext);
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
            Filename = string.Empty;
            FilenameWithoutExtension = string.Empty;
            FileExtension = string.Empty;
            this.Close();
        }
    }
}