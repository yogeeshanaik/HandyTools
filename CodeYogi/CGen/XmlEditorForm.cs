using Arebis.CommandLineTools.CodeGenerator;
using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Xml_Editor
{
    public partial class XmlEditorForm : Form
    {
        public bool FileAutoSave { get; set; }

        int undoCount = -2;
        public bool FileHasChange
        {
            get
            {
                return undoCount > 0;
            }
            set
            {
            }
        }

        FilenameForm objFilename = new FilenameForm();
        private List<ListItem> FilesList { get; set; }

        #region Syntax Highlight
        string lang = "CSharp (custom highlighter)";

        //styles
        TextStyle BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        TextStyle BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
        TextStyle GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
        TextStyle MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        TextStyle GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        TextStyle BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
        TextStyle MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
        MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));

        private void CSharpSyntaxHighlight(TextChangedEventArgs e)
        {
            rtbXmlEditor.LeftBracket = '(';
            rtbXmlEditor.RightBracket = ')';
            rtbXmlEditor.LeftBracket2 = '\x0';
            rtbXmlEditor.RightBracket2 = '\x0';
            //clear style of changed range
            e.ChangedRange.ClearStyle(BlueStyle, BoldStyle, GrayStyle, MagentaStyle, GreenStyle, BrownStyle);

            //string highlighting
            e.ChangedRange.SetStyle(BrownStyle, @"""""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'");
            //comment highlighting
            e.ChangedRange.SetStyle(GreenStyle, @"//.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);
            //number highlighting
            e.ChangedRange.SetStyle(MagentaStyle, @"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b");
            //attribute highlighting
            e.ChangedRange.SetStyle(GrayStyle, @"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline);
            //class name highlighting
            e.ChangedRange.SetStyle(BoldStyle, @"\b(class|struct|enum|interface)\s+(?<range>\w+?)\b");
            //keyword highlighting
            e.ChangedRange.SetStyle(BlueStyle, @"\b(abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b");

            //clear folding markers
            e.ChangedRange.ClearFoldingMarkers();

            //set folding markers
            e.ChangedRange.SetFoldingMarkers("{", "}");//allow to collapse brackets block
            e.ChangedRange.SetFoldingMarkers(@"#region\b", @"#endregion\b");//allow to collapse #region blocks
            e.ChangedRange.SetFoldingMarkers(@"/\*", @"\*/");//allow to collapse comment block
        }

        private void InitStylesPriority()
        {
            //add this style explicitly for drawing under other styles
            rtbXmlEditor.AddStyle(SameWordsStyle);
        }

        private void rtbXmlEditor_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            undoCount++;

            switch (lang)
            {
                case "CSharp (custom highlighter)":
                    //For sample, we will highlight the syntax of C# manually, although could use built-in highlighter
                    CSharpSyntaxHighlight(e);//custom highlighting
                    break;
                default:
                    break;//for highlighting of other languages, we using built-in FastColoredTextBox highlighter
            }

            if (rtbXmlEditor.Text.Trim().StartsWith("<?xml"))
            {
                rtbXmlEditor.Language = Language.XML;

                rtbXmlEditor.ClearStylesBuffer();
                rtbXmlEditor.Range.ClearStyle(StyleIndex.All);
                InitStylesPriority();
                rtbXmlEditor.AutoIndentNeeded -= fctb_AutoIndentNeeded;

                rtbXmlEditor.OnSyntaxHighlight(new TextChangedEventArgs(rtbXmlEditor.Range));
            }
        }

        private void fctb_AutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            //block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{.*\}[^""']*$"))
                return;
            //start of block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{"))
            {
                args.ShiftNextLines = args.TabLength;
                return;
            }
            //end of block {}
            if (Regex.IsMatch(args.LineText, @"}[^""']*$"))
            {
                args.Shift = -args.TabLength;
                args.ShiftNextLines = -args.TabLength;
                return;
            }
            //label
            if (Regex.IsMatch(args.LineText, @"^\s*\w+\s*:\s*($|//)") &&
                !Regex.IsMatch(args.LineText, @"^\s*default\s*:"))
            {
                args.Shift = -args.TabLength;
                return;
            }
            //some statements: case, default
            if (Regex.IsMatch(args.LineText, @"^\s*(case|default)\b.*:\s*($|//)"))
            {
                args.Shift = -args.TabLength / 2;
                return;
            }
            //is unclosed operator in previous line ?
            if (Regex.IsMatch(args.PrevLineText, @"^\s*(if|for|foreach|while|[\}\s]*else)\b[^{]*$"))
                if (!Regex.IsMatch(args.PrevLineText, @"(;\s*$)|(;\s*//)"))//operator is unclosed
                {
                    args.Shift = args.TabLength;
                    return;
                }
        }


        #endregion

        public XmlEditorForm()
        {
            InitializeComponent();

            txtSelectedFilePath.BackColor = this.BackColor;

            FilesList = new List<ListItem>();

            this.lstConfig.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.myListBox_DrawItem);
            this.lstConfig.DrawMode = DrawMode.OwnerDrawFixed;
        }

        // Make the TextBox fit its contents.
        private void AutoSizeTextBox(ToolStripTextBox txt)
        {
            const int x_margin = 0;
            const int y_margin = 2;
            Size size = TextRenderer.MeasureText(txt.Text, txt.Font);
            txt.Size =
            new Size(size.Width + x_margin, size.Height + y_margin);
        }

        private void myListBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            ListBox control = sender as ListBox;

            e.DrawBackground();
            Font myFont = e.Font;
            Brush myBrush = Brushes.Black;
            int i = e.Index;

            if (i >= 0)
            {
                if (lstConfig.Items[i].ToString().EndsWith(".settings"))
                {
                    myBrush = Brushes.DarkBlue;
                }
                else if (lstConfig.Items[i].ToString().EndsWith(".xml"))
                {
                    myBrush = Brushes.Maroon;
                }
                else if (lstConfig.Items[i].ToString().EndsWith(".config"))
                {
                    myBrush = Brushes.Black;
                }
                else if (lstConfig.Items[i].ToString().EndsWith(".cs"))
                {
                    myBrush = Brushes.Green;
                }
                else if (lstConfig.Items[i].ToString().EndsWith(".cst"))
                {
                    myBrush = Brushes.Orange;
                }

                //if (e.Index % 2==0)
                //{
                //    myFont = e.Font;
                //    myBrush = Brushes.Black;
                //}
                //else
                //{
                //    myFont = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
                //    myBrush = Brushes.Blue;
                //}

                e.Graphics.DrawString(lstConfig.Items[i].ToString(), myFont, myBrush, e.Bounds, StringFormat.GenericDefault);
            }
        }

        private void XmlEditorForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txtPath.Text = new FileInfo(Assembly.GetEntryAssembly().Location).Directory.FullName;
            RefreshFiles();
        }

        List<int> listBox1_selection = new List<int>();
        private void lstConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = lstConfig.SelectedItem as ListItem;

            //Prompt user to save file before another file selection
            if (FileHasChange)
            {
                // Get last selected item
                var item = lstConfig.Items[listBox1_selection[0]];
                if (FileAutoSave)
                {
                    SaveFile((item as ListItem).Value.ToString(), rtbXmlEditor.Text);
                }
                else
                {
                    string promptMessage = string.Format("File [{0}] has changes. Click Yes to save or No to discard changes?", (item as ListItem).Text);
                    if (DialogResult.Yes == MessageBox.Show(promptMessage, "Save file?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        SaveFile((item as ListItem).Value.ToString(), rtbXmlEditor.Text);
                }
            }

            if (selectedItem != null)
            {
                string text;
                var fileStream = new FileStream(selectedItem.Value.ToString(), FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                }
                rtbXmlEditor.Text = text;
                txtSelectedFilePath.Text = selectedItem.Value.ToString();

                chkHighlight.Checked = false;
            }

            TrackSelectionChange((ListBox)sender, listBox1_selection);
            undoCount = 0; // reset undo count as file itself changed.
        }

        private void TrackSelectionChange(ListBox lb, List<int> selection)
        {
            ListBox.SelectedIndexCollection sic = lb.SelectedIndices;
            foreach (int index in sic)
                if (!selection.Contains(index)) selection.Add(index);

            foreach (int index in new List<int>(selection))
                if (!sic.Contains(index)) selection.Remove(index);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedItem = lstConfig.SelectedItem;
            if (selectedItem != null)
            {
                SaveFile((selectedItem as ListItem).Value.ToString(), rtbXmlEditor.Text);
            }
        }
        void SaveFile(string filepath, string text)
        {
            File.WriteAllText(filepath, text);
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "File saved..";
            undoCount = 0; // reset undo count as file itself changed.
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            RefreshFiles();
        }

        private void RefreshFiles()
        {
            FileHasChange = false;

            string[] extensions = objFilename.FileExtensionList.Select(s => s.Text).ToArray(); //{ ".settings", ".cst", ".xml", ".config" };
            var dInfo = new DirectoryInfo(txtPath.Text);

            rtbXmlEditor.Text = string.Empty;
            lstConfig.Items.Clear();
            FilesList.Clear();

            var files = GetFilesByExtensions(dInfo, extensions).OrderBy(p => Path.GetExtension(p.Name));
            foreach (FileInfo file in files)
            {
                FilesList.Add(new ListItem() { Value = file.FullName, Text = file.Name });
            }
            lstConfig.Items.AddRange(FilesList.ToArray());
        }

        public IEnumerable<FileInfo> GetFilesByExtensions(DirectoryInfo dir, params string[] extensions)
        {
            if (extensions == null)
                throw new ArgumentNullException("extensions");
            IEnumerable<FileInfo> files = dir.EnumerateFiles("*.*", SearchOption.AllDirectories);
            return files.Where(f => extensions.Contains(f.Extension));
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = txtPath.Text;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            objFilename.ShowDialog();

            if (!string.IsNullOrEmpty(objFilename.Filename))
            {
                string filePath = string.Format(@"{0}\{1}", txtPath.Text, objFilename.Filename);
                using (var tw = new StreamWriter(filePath, true))
                {


                    if (objFilename.Filename.Contains(".settings"))
                    {
                        tw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                        tw.WriteLine("<settings>");
                        tw.WriteLine(Environment.NewLine);
                        tw.WriteLine("   <!-- Generator settings -->");
                        tw.WriteLine("   <add name=\"template\" value=\"\" />");
                        tw.WriteLine("   <add name=\"targetdir\" value=\"\" />");
                        tw.WriteLine("   <add name=\"logfile\" value=\"generation.log\" />");
                        tw.WriteLine(Environment.NewLine);
                        tw.WriteLine("   <!-- Project settings: Your custom settings here -->");
                        tw.WriteLine("   <add name=\"namespace\" value=\"YourNamespace\" />");
                        tw.WriteLine(Environment.NewLine);
                        tw.WriteLine("</settings>");
                    }
                    else
                    {
                        tw.WriteLine("//Remove me!");
                    }

                    tw.Close();
                }

                // Reload
                RefreshFiles();
                lstConfig.SelectedItem = FilesList.Find(s => s.Text.Equals(objFilename.Filename));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstConfig.SelectedItem != null)
            {
                string filePath = (lstConfig.SelectedItem as ListItem).Value.ToString();
                if (File.Exists(filePath))
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Delete file", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        File.Delete(filePath);
                        lblStatus.ForeColor = Color.Green;
                        lblStatus.Text = string.Format("File [{0}] deleted..", lstConfig.SelectedItem);
                        //Reload
                        RefreshFiles();
                    }
                }
                else
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "File doesn't exist!";
                }
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Select config file to delete!";
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            var selectedItem = lstConfig.SelectedItem;
            string[] arr = new string[] { selectedItem.ToString() };
            Program.Run(arr);
            RefreshFiles();
            lstConfig.SelectedItem = selectedItem;
        }

        private void txtSelectedFilePath_TextChanged(object sender, EventArgs e)
        {
            // Make the TextBox fit its new contents.
            AutoSizeTextBox(sender as ToolStripTextBox);
        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {
            var message = (sender as ToolStripLabel).Text;
            if (message.Length > 0)
                MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            lblStatus.Text = string.Empty; ;
            if (keyData == (Keys.Control | Keys.S))
            {
                btnSave_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.N))
            {
                btnNew_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D) || (lstConfig.Focused && keyData == Keys.Delete))
            {
                btnDelete_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void chkHighlight_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = chkHighlight;
            var selectedItem = lstConfig.SelectedItem;
            if (checkbox.Checked && selectedItem != null)
            {

                var filepath = (selectedItem as ListItem).Value.ToString();
                string text = System.IO.File.ReadAllText(filepath);

                //Regex to find file paths
                var regex = new Regex(@"(?:[a-zA-Z]\:|\\\\[\w\.]+\\[\w.$]+|[A-Za-z_\-\s0-9\.]+)\\(?:[\w]+\\)*\w([\w.])+");
                foreach (var match in regex.Matches(text))
                {
                    for (int i = 0; i < lstConfig.Items.Count; i++)
                    {
                        var item = lstConfig.Items[i];
                        if ((item as ListItem).Value.ToString().Contains(match.ToString()))
                        {
                            var newitem = new ListItem() { Value = (item as ListItem).Value, Text = "   >> " + (item as ListItem).Text.Replace("   >> ", string.Empty) };
                            lstConfig.Items.RemoveAt(i);
                            lstConfig.Items.Insert(0, newitem);
                        }
                    }
                }
            }
            else
            {
                RefreshFiles();
                lstConfig.SelectedItem = FilesList.Find(s => s.Value.Equals((selectedItem as ListItem).Value)); ;
            }
        }

    }
}