using CodeYogi;
//using DynamicCompilation;
using FastColoredTextBoxNS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TestNotifyWindow;

namespace Xml_Editor
{
    public partial class TemplateManager : Form
    {
        #region variable declarations

        private FilenameForm objFilename = new FilenameForm();
        private int undoCount = -2;

        private ImageList _imageList = new ImageList();

        #endregion variable declarations

        #region Properties

        public string[] FileExtensions
        {
            get
            {
                return objFilename.FileExtensionList.Select(s => s.Text).ToArray();
            }
        }

        public TreeNode CurrentNode { get; set; }

        public TreeNode LastNode { get; set; }

        public bool FileAutoSave { get; set; }

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

        #endregion Properties

        #region Syntax Highlight

        private string lang = "CSharp (custom highlighter)";

        //styles
        private TextStyle BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);

        private TextStyle BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
        private TextStyle GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
        private TextStyle MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        private TextStyle GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        private TextStyle BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
        private TextStyle MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
        private MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));

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
            if (tvFiles.SelectedNode != null)
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

        #endregion Syntax Highlight

        #region ctor

        public TemplateManager()
        {
            InitializeComponent();

            // set delay on the DelayTextBox control.
            txtNodeFilter.Delay = 50;

            txtNodeFilter.WaterMarkText = "Search nodes by text";

            txtSelectedFilePath.BackColor = this.BackColor;

            // Set the TreeView image list to the system image list.
            //SystemImageList.SetTVImageList(tvFiles.Handle);

            //Right click select on TreeNode
            tvFiles.NodeMouseClick += (sender, args) => tvFiles.SelectedNode = args.Node;

            tvFiles.AfterSelect += tvFiles_AfterSelect;
            tvFiles.DragDrop += tvFiles_DragDrop;
            tvFiles.ItemDrag += tvFiles_ItemDrag;
            tvFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvFiles_DragEnter);
        }

        #endregion ctor

        #region Files Treeview

        private void tvFiles_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
        }

        private TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);

            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));

            foreach (var file in GetFilesByExtensions(directoryInfo, FileExtensions))
            {
                directoryNode.Nodes.Add(file.FullName, file.Name);
            }

            return directoryNode;
        }

        public TreeNode previousSelectedNode = null;

        private void tvFiles_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            tvFiles.SelectedNode.BackColor = SystemColors.Highlight;
            tvFiles.SelectedNode.ForeColor = Color.White;
            previousSelectedNode = tvFiles.SelectedNode;
        }

        private void tvFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LastNode = CurrentNode;
            CurrentNode = e.Node;

            CurrentNode.Name = CurrentNode.FullPath;

            //Prompt user to save file before another file selection
            if (FileHasChange && LastNode != null)
            {
                if (FileAutoSave)
                {
                    SaveFile(LastNode.Name, rtbXmlEditor.Text);
                }
                else
                {
                    string promptMessage = string.Format("File [{0}] has changes. Click Yes to save or No to discard changes?", LastNode.Text);
                    if (DialogResult.Yes == MessageBox.Show(promptMessage, "Save file?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        SaveFile(LastNode.Name, rtbXmlEditor.Text);
                }
            }

            if (File.Exists(CurrentNode.Name))
            {
                // Load file content
                this.rtbXmlEditor.Clear();
                StreamReader reader = new StreamReader(CurrentNode.Name);
                this.rtbXmlEditor.Text = reader.ReadToEnd();
                reader.Close();
                txtSelectedFilePath.Text = CurrentNode.Name;

                //Handle Run button 
                //btnRun.Enabled = CurrentNode.Name.EndsWith(".settings");
            }

            undoCount = 0; // reset undo count as file itself changed.

            if (previousSelectedNode != null)
            {
                previousSelectedNode.BackColor = tvFiles.BackColor;
                previousSelectedNode.ForeColor = tvFiles.ForeColor;
            }
        }

        private void tvFiles_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the drop location.
            Point targetPoint = tvFiles.PointToClient(new Point(e.X, e.Y));

            // Retrieve the node at the drop location.
            TreeNode targetNode = tvFiles.GetNodeAt(targetPoint);

            // Retrieve the node that was dragged.
            //TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(DirectoryNode));
            if (draggedNode == null)
                draggedNode = (TreeNode)e.Data.GetData(typeof(FileNode));

            // Confirm that the node at the drop location is not
            // the dragged node and that target node isn't null
            // (for example if you drag outside the control)
            if (!draggedNode.Equals(targetNode) && targetNode != null)
            {
                // Move directory or files
                bool draggedNodeIsDirectory = draggedNode.GetType() == typeof(DirectoryNode);
                bool targetNodeIsDirectory = targetNode.GetType() == typeof(DirectoryNode);

                //Validate Drag and Drop operations
                if ((draggedNodeIsDirectory && !targetNodeIsDirectory) || (targetNodeIsDirectory && !draggedNodeIsDirectory))
                {
                    Notify("Cannot be dragged folder on file and vice versa!", "Invalid operation");
                    return;
                }

                if (draggedNodeIsDirectory)
                {
                    // Directory move
                    string sourcePath = draggedNode.FullPath;
                    string targetPath = ConstructTargetDirectoryPath(draggedNode, targetNode);

                    Directory.Move(draggedNode.FullPath, targetPath);
                }
                else
                {
                    // File moving
                    string sourcePath = draggedNode.Name;
                    string targetPath = ConstructTargetFilePath(draggedNode, targetNode);
                    if (!File.Exists(targetPath))
                    {
                        File.Copy(sourcePath, targetPath, true);
                        File.Delete(sourcePath);
                    }
                }

                //Reload Files
                //RefreshFiles();

                // Remove the node from its current
                // location and add it to the node at the drop location.
                draggedNode.Remove();
                targetNode.Nodes.Add(draggedNode);

                // Expand the node at the location
                // to show the dropped node.
                targetNode.Expand();
            }
        }

        private void tvFiles_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void tvFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void tvFiles_DragOver(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the mouse position.
            Point targetPoint = tvFiles.PointToClient(new Point(e.X, e.Y));

            // Select the node at the mouse position.
            tvFiles.SelectedNode = tvFiles.GetNodeAt(targetPoint);

            if (LastNode != null)
                LastNode.Collapse();
            CurrentNode.Expand();
        }

        private void RefreshFiles()
        {
            tvFiles.Nodes.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(txtPath.Text);
            if (directoryInfo.Exists)
            {
                /*/ Normal
                tvFiles.Nodes.Add(CreateDirectoryNode(directoryInfo));
                /*/
                // FileSystem
                tvFiles.Load(txtPath.Text);
                //*/

                tvFiles.TopNode.Expand();
            }

            FileHasChange = false;
        }

        #endregion Files Treeview

        #region Form & Control events

        private void btnLoad_Click(object sender, EventArgs e)
        {
            RefreshFiles();
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
            if (CurrentNode == null)
            {
                lblStatus.Text = "Select file location in file listing section.";
                tvFiles.Focus();
                return;
            }

            objFilename = new FilenameForm(NameFor.File, string.Empty);
            objFilename.ShowDialog();

            if (!string.IsNullOrEmpty(objFilename.Filename))
            {
                string filePath = string.Format(@"{0}\{1}", CurrentNode.FullPath, objFilename.Filename);
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

                // reload newly added node
                CurrentNode.Nodes.Clear();
                new LoadChildNode(CurrentNode);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CurrentNode != null)
            {
                string filePath = CurrentNode.Name;
                if (File.Exists(filePath))
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Delete file", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        File.Delete(filePath);
                        lblStatus.ForeColor = Color.Green;
                        lblStatus.Text = string.Format("File [{0}] deleted..", CurrentNode.Text);
                        CurrentNode.Remove();
                    }
                }
                else
                {
                    //Directory
                    if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Delete Directory", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        Directory.Delete(CurrentNode.FullPath, true);
                        lblStatus.ForeColor = Color.Green;
                        lblStatus.Text = string.Format("Directory [{0}] deleted..", CurrentNode.Text);
                        CurrentNode.Remove();
                    }
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
            string path = ConstructDirectoryPath(CurrentNode, string.Empty);

            //Find all settings file
            var files = GetFilesByExtensions(new DirectoryInfo(path), ".settings");

            foreach (FileInfo file in files)
                Program.Run(new string[] { file.FullName });

            // reload newly added node
            CurrentNode = CurrentNode.Parent;
            CurrentNode.Nodes.Clear();
            new LoadChildNode(CurrentNode);
        }

        private void txtSelectedFilePath_TextChanged(object sender, EventArgs e)
        {
            // Make the TextBox fit its new contents.
            AutoSizeTextBox(sender as ToolStripTextBox);
        }

        private void lnkExpand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkExpand.Text == "Expand All")
            {
                lnkExpand.Text = "Collapse All";
                tvFiles.ExpandAll();
            }
            else
            {
                lnkExpand.Text = "Expand All";
                tvFiles.CollapseAll();
            }
        }

        private void TemplateManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {
            var message = (sender as ToolStripLabel).Text;
            if (message.Length > 0)
                //MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Notify(message, "Information");
        }

        private void chkHighlight_CheckedChanged(object sender, EventArgs e)
        {
            //var checkbox = chkHighlight;
            //var selectedItem = lstConfig.SelectedItem;
            //if (checkbox.Checked && selectedItem != null)
            //{
            //    var filepath = (selectedItem as ListItem).Value.ToString();
            //    string text = System.IO.File.ReadAllText(filepath);

            //    //Regex to find file paths
            //    var regex = new Regex(@"(?:[a-zA-Z]\:|\\\\[\w\.]+\\[\w.$]+|[A-Za-z_\-\s0-9\.]+)\\(?:[\w]+\\)*\w([\w.])+");
            //    foreach (var match in regex.Matches(text))
            //    {
            //        for (int i = 0; i < lstConfig.Items.Count; i++)
            //        {
            //            var item = lstConfig.Items[i];
            //            if ((item as ListItem).Value.ToString().Contains(match.ToString()))
            //            {
            //                var newitem = new ListItem() { Value = (item as ListItem).Value, Text = "   >> " + (item as ListItem).Text.Replace("   >> ", string.Empty) };
            //                lstConfig.Items.RemoveAt(i);
            //                lstConfig.Items.Insert(0, newitem);
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    RefreshFiles();
            //    lstConfig.SelectedItem = FilesList.Find(s => s.Value.Equals((selectedItem as ListItem).Value)); ;
            //}
        }

        private void XmlEditorForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txtPath.Text = new FileInfo(Assembly.GetEntryAssembly().Location).Directory.FullName + @"\Templates";
            RefreshFiles();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CurrentNode != null)
            {
                SaveFile(CurrentNode.Name, rtbXmlEditor.Text);
            }
        }

        #endregion Form & Control events

        #region menus

        private void menuRefresh_Click(object sender, EventArgs e)
        {
            RefreshNode(CurrentNode);
            lblStatus.Text = string.Format("Refreshing [{0}]..", CurrentNode.Text);
        }

        private void menuRename_Click(object sender, EventArgs e)
        {
            if (CurrentNode != null)

                if (File.Exists(CurrentNode.Name))
                {
                    //File rename
                    objFilename = new FilenameForm(NameFor.File, CurrentNode.Name);
                    objFilename.ShowDialog();

                    if (!string.IsNullOrEmpty(objFilename.Filename))
                    {
                        string newFilePath = string.Format(@"{0}\{1}", CurrentNode.Name.Replace(Path.GetFileName(CurrentNode.Name), string.Empty), objFilename.Filename);
                        System.IO.File.Copy(CurrentNode.Name, newFilePath, true);
                        if (File.Exists(newFilePath))
                        {
                            System.IO.File.Delete(CurrentNode.Name);
                        }
                        //Update node of treeview
                        CurrentNode.Name = newFilePath;
                        CurrentNode.Text = objFilename.Filename;
                    }
                }
                else if (Directory.Exists(CurrentNode.FullPath))
                {
                    objFilename = new FilenameForm(NameFor.Directory, CurrentNode.Text);
                    //Folder rename
                    objFilename.ShowDialog();

                    string newFolderPath = string.Format(@"{0}\{1}", Directory.GetParent(CurrentNode.FullPath), objFilename.FilenameWithoutExtension);
                    bool pathsEqual = Path.GetFullPath(CurrentNode.FullPath) == newFolderPath;

                    if (!string.IsNullOrEmpty(objFilename.FilenameWithoutExtension) && !pathsEqual)
                    {
                        Directory.Move(CurrentNode.FullPath, newFolderPath);

                        //Update node of treeview
                        CurrentNode.Name = newFolderPath;
                        CurrentNode.Text = objFilename.FilenameWithoutExtension;
                    }
                }
        }

        private void menuCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CurrentNode.Name);
        }

        private void menuPaste_Click(object sender, EventArgs e)
        {
            string objectToCopy = Clipboard.GetText();
            if (objectToCopy.Length > 0)
            {
                if (tvFiles.Focused) // File copy & paste
                {
                    string targetPath = string.Empty;

                    if (IsDirectoryPath(CurrentNode.FullPath)) //MessageBox.Show("Its a directory");
                        targetPath = string.Format(@"{0}\{1}", CurrentNode.FullPath, Path.GetFileName(objectToCopy));
                    else //MessageBox.Show("Its a file");
                        targetPath = string.Format(@"{0}\{1}", CurrentNode.FullPath.Replace(Path.GetFileName(CurrentNode.FullPath), string.Empty), Path.GetFileName(objectToCopy));


                    if (IsDirectoryPath(objectToCopy))
                    {
                        DirectoryCopy(objectToCopy, targetPath, true);
                    }
                    else
                    {
                        if (!File.Exists(targetPath))
                            File.Copy(objectToCopy, targetPath);
                        else
                            lblStatus.Text = "File already exists with the same name!";
                    }

                    RefreshNode(CurrentNode);
                }
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void menuFile_Click(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }

        private void menuFolder_Click(object sender, EventArgs e)
        {
            if (CurrentNode == null)
            {
                lblStatus.Text = "Select floder location in file listing section.";
                tvFiles.Focus();
                return;
            }

            objFilename = new FilenameForm(NameFor.Directory, string.Empty);
            objFilename.ShowDialog();

            if (!string.IsNullOrEmpty(objFilename.Filename))
            {
                string path = ConstructDirectoryPath(CurrentNode, objFilename.Filename);
                Directory.CreateDirectory(path);

                // Reload
                RefreshNode(CurrentNode);
            }
        }

        #endregion menus

        #region private methods

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
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
            else if (keyData == (Keys.Control | Keys.D) || (tvFiles.Focused && keyData == Keys.Delete))
            {
                btnDelete_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.F5))
            {
                btnRun_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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

        public IEnumerable<FileInfo> GetFilesByExtensions(DirectoryInfo dir, params string[] extensions)
        {
            if (extensions == null)
                throw new ArgumentNullException("extensions");
            IEnumerable<FileInfo> files = dir.EnumerateFiles("*.*", SearchOption.AllDirectories);
            return files.Where(f => extensions.Contains(f.Extension));
        }

        private void SaveFile(string filepath, string text)
        {
            File.WriteAllText(filepath, text);
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "File saved..";
            undoCount = 0; // reset undo count as file itself changed.
        }

        private void Notify(string message, string title = "", ToolTipIcon icon = ToolTipIcon.Info)
        {
            NotifyWindow nw = new NotifyWindow(title, message);
            nw.SetDimensions(200, 150);
            nw.Notify();

            //notifyIcon1.ShowBalloonTip(500, title, message, icon);
        }

        private bool IsDirectoryPath(string path)
        {
            // get the file attributes for file or directory
            FileAttributes attr = File.GetAttributes(path);
            return (attr.HasFlag(FileAttributes.Directory));
        }

        /// <summary>
        /// Constructs and returns directory path for target location. Source node should be always directory type.
        /// </summary>
        /// <param name="source">Source Node</param>
        /// <param name="target">Target Node</param>
        /// <returns></returns>
        private string ConstructTargetDirectoryPath(TreeNode source, TreeNode target)
        {
            bool sourceNodeIsDirectory = source.GetType() == typeof(DirectoryNode);
            bool targetNodeIsDirectory = target.GetType() == typeof(DirectoryNode);
            string targetPath = string.Empty;

            if (sourceNodeIsDirectory)
            {
                if (targetNodeIsDirectory)
                {
                    targetPath = string.Format(@"{0}\{1}", target.FullPath, source.Text);
                }
                else
                {
                    targetPath = string.Format(@"{0}\{1}", Directory.GetParent(target.FullPath), source.Text);
                }
            }
            else
                throw new Exception("Source node should be a directory node type!");

            return targetPath;
        }

        /// <summary>
        /// Constructs and returns directory path for current location.
        /// </summary>
        /// <param name="source">Source Node</param>
        /// <returns></returns>
        private string ConstructDirectoryPath(TreeNode source, string directoryName)
        {
            bool sourceNodeIsDirectory = source.GetType() == typeof(DirectoryNode);

            string targetPath = string.Empty;

            if (sourceNodeIsDirectory)
            {
                targetPath = string.Format(@"{0}\{1}", source.FullPath, directoryName);
            }
            else
            {
                targetPath = string.Format(@"{0}\{1}", Directory.GetParent(source.FullPath), directoryName);
            }

            return targetPath;
        }

        /// <summary>
        /// Constructs and returns file path for target location. Source node should be always file type.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private string ConstructTargetFilePath(TreeNode source, TreeNode target)
        {
            bool sourceNodeIsDirectory = source.GetType() == typeof(DirectoryNode);
            bool targetNodeIsDirectory = target.GetType() == typeof(DirectoryNode);
            string targetPath = string.Empty;

            if (!sourceNodeIsDirectory)
            {
                if (targetNodeIsDirectory)
                {
                    targetPath = string.Format(@"{0}\{1}", target.FullPath, Path.GetFileName(source.Name));
                }
                else
                {
                    targetPath = string.Format(@"{0}\{1}", Directory.GetParent(target.FullPath), Path.GetFileName(source.Name));
                }
            }
            else
                throw new Exception("Source node should be a file node type!");

            return targetPath;
        }

        #endregion private methods

        private void MakeReadOnly(string directoryPath)
        {
            var di = new DirectoryInfo(directoryPath);
            foreach (var file in di.GetFiles("*", SearchOption.AllDirectories))
                File.SetAttributes(file.FullName, FileAttributes.ReadOnly);
        }

        private void RemoveReadOnly(string directoryPath)
        {
            var di = new DirectoryInfo(directoryPath);
            foreach (var file in di.GetFiles("*", SearchOption.AllDirectories))
                file.Attributes &= ~FileAttributes.ReadOnly;
        }

        private void RefreshNode(TreeNode node)
        {
            bool currentNodeIsDirectory = node.GetType() == typeof(DirectoryNode);
            if (currentNodeIsDirectory)
            {
                CurrentNode.Nodes.Clear();
                new LoadChildNode(CurrentNode);
            }
            else
            {
                var _node = CurrentNode.Parent;
                _node.Nodes.Clear();
                new LoadChildNode(_node);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = CurrentNode.FullPath;
            Process.Start("explorer.exe", path);
        }

        private void txtNodeFilter_TextChanged(object sender, EventArgs e)
        {   
            int minChar = 2;
            if (txtNodeFilter.Text.Length >= minChar)
                lblStatus.Text = tvFiles.SearchNode(txtNodeFilter.Text) + " nodes found";
            else
                lblStatus.Text = string.Format("Enter minimum {0} letters to search.",minChar);
        }

        IEnumerable<TreeNode> Collect(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                yield return node;

                foreach (var child in Collect(node.Nodes))
                    yield return child;
            }
        }
    }
}