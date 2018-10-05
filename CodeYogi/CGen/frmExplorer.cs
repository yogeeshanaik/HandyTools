using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.Collections;
using System.Drawing;
using System.Collections.Generic;

namespace CodeYogi
{
    public partial class frmExplorer : Form
    {
        private BWHelper helper;

        public frmExplorer()
        {
            InitializeComponent();

            helper = new BWHelper(backgroundWorkerExample);

            CreateHeadersAndFillListView();
            this.lwFilesAndFolders.ItemActivate += new System.EventHandler(this.lwFilesAndFolders_ItemActivate);
        }

        private void frmExplorer_Load(object sender, EventArgs e)
        {
            explorerTree2.setCurrentPath(@"E:\Handy Tools\Code Generation\CodeYogi\CGen\bin\Debug\Templates");
            explorerTree2.btnGo_Click(this, e);
            //Application.DoEvents();
            //helper.SetActionsTodo(DoActions(e));
            //backgroundWorkerExample.RunWorkerAsync();
        }

        private List<Action> DoActions(EventArgs e)
        {
            List<Action> actions = new List<Action>();

            #region process word data file

            // Caution: 
            // 1. For parallel taska minimum 2 actions must be required  
            // 2. Do not share same file name for multiple actions

            actions.Add(() =>
            {
                explorerTree2.setCurrentPath(@"E:\Handy Tools\Code Generation\CodeYogi\CGen\bin\Debug\Templates");
                explorerTree2.btnGo_Click(this, e);
            });


            #endregion process word data file

            return actions;
        }


        private void cmbSelect_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            LoadFiles(explorerTree2.SelectedPath, cmbSelect.Text);
        }

        private void explorerTree2_PathChanged(object sender, System.EventArgs e)
        {
            LoadFiles(explorerTree2.SelectedPath, cmbSelect.Text);
        }

        private void LoadFiles(string directoryPath, string pattern)
        {
            lwFilesAndFolders.Columns.Clear();
            lwFilesAndFolders.Items.Clear();

            // Set up the ListView control's basic properties.
            // Put it in "Details" mode, create a column so that "Details" mode will work,
            // and set its theme so it will look like the one used by Explorer.
            lwFilesAndFolders.View = View.Details;

            // Obtain a handle to the system image list.
            NativeMethods.SHFILEINFO shfi = new NativeMethods.SHFILEINFO();
            IntPtr hSysImgList = NativeMethods.SHGetFileInfo("",
                                                             0,
                                                             ref shfi,
                                                             (uint)Marshal.SizeOf(shfi),
                                                             NativeMethods.SHGFI_SYSICONINDEX
                                                              | NativeMethods.SHGFI_SMALLICON);
            //Debug.Assert(hSysImgList != IntPtr.Zero);  // cross our fingers and hope to succeed!

            // Set the ListView control to use that image list.
            IntPtr hOldImgList = NativeMethods.SendMessage(lwFilesAndFolders.Handle,
                                                           NativeMethods.LVM_SETIMAGELIST,
                                                           NativeMethods.LVSIL_SMALL,
                                                           hSysImgList);

            // If the ListView control already had an image list, delete the old one.
            if (hOldImgList != IntPtr.Zero)
            {
                NativeMethods.ImageList_Destroy(hOldImgList);
            }

            NativeMethods.SetWindowTheme(lwFilesAndFolders.Handle, "Explorer", null);

            // Get the items from the file system, and add each of them to the ListView,
            // complete with their corresponding name and icon indices.
            //string[] s = Directory.GetFileSystemEntries(directoryPath, pattern);
            var s = new DirectoryInfo(directoryPath).
                GetFilesByExtensions(
                    pattern.Equals("*.*") ? null : pattern.Replace("*", string.Empty).Split(';')
                )
                .Select(f => f.FullName).ToArray();
            foreach (string file in s)
            {
                IntPtr himl = NativeMethods.SHGetFileInfo(file,
                                                          0,
                                                          ref shfi,
                                                          (uint)Marshal.SizeOf(shfi),
                                                          NativeMethods.SHGFI_DISPLAYNAME
                                                            | NativeMethods.SHGFI_SYSICONINDEX
                                                            | NativeMethods.SHGFI_SMALLICON);
                //Debug.Assert(himl == hSysImgList); // should be the same imagelist as the one we set
                lwFilesAndFolders.Items.Add(shfi.szDisplayName, shfi.iIcon).Tag = file;
            }

            // -2 will autosize the column to the length of the text in the column header, -1 will autosize to the longest item in the column.
            lwFilesAndFolders.Columns.Add("Name").Width = -1;
        }

        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Text = "Filename";
            this.lwFilesAndFolders.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Size";
            this.lwFilesAndFolders.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Last accessed";
            this.lwFilesAndFolders.Columns.Add(colHead);
        }

        private void PaintListView(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                //this.lblCurrentPath.Text = root + "    (Double click to display the path name)";

                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(root);

                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();

                this.lwFilesAndFolders.Items.Clear();

                this.lwFilesAndFolders.BeginUpdate();

                foreach (System.IO.DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    //lvi.ImageIndex = 0;
                    lvi.Tag = di.FullName;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = "sub item";
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);

                    this.lwFilesAndFolders.Items.Add(lvi);
                }
                this.lwFilesAndFolders.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

            this.lwFilesAndFolders.View = View.Details;
        }

        private void lwFilesAndFolders_ItemActivate(object sender, System.EventArgs e)
        {
            ListView lw = (ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();

            System.Diagnostics.Process.Start(filename);
        }

        #region Menus

        private void mnuSA_Click(object sender, System.EventArgs e)
        {
            mnuSA.Checked = !(mnuSA.Checked);

            explorerTree2.ShowAddressbar = mnuSA.Checked;
            explorerTree2.refreshView();
        }

        private void mnuST_Click(object sender, System.EventArgs e)
        {
            mnuST.Checked = !(mnuST.Checked);

            explorerTree2.ShowToolbar = mnuST.Checked;
            explorerTree2.refreshView();
        }

        private void mnuSMD_Click(object sender, System.EventArgs e)
        {
            mnuSMD.Checked = !(mnuSMD.Checked);

            explorerTree2.ShowMyDocuments = mnuSMD.Checked;
            explorerTree2.refreshFolders();
        }

        private void mnuSMN_Click(object sender, System.EventArgs e)
        {
            mnuSMN.Checked = !(mnuSMN.Checked);
            explorerTree2.ShowMyNetwork = mnuSMN.Checked;
            explorerTree2.refreshFolders();
        }

        private void mnuMF_Click(object sender, System.EventArgs e)
        {
            mnuMF.Checked = !(mnuMF.Checked);
            explorerTree2.ShowMyFavorites = mnuMF.Checked;
            explorerTree2.refreshFolders();
        }

        private void menuItem3_Click(object sender, System.EventArgs e)
        {
            //explorerTree2.AboutExplorerTree();
        }

        #endregion Menus
    }

    internal static class NativeMethods
    {
        public const uint LVM_FIRST = 0x1000;
        public const uint LVM_GETIMAGELIST = (LVM_FIRST + 2);
        public const uint LVM_SETIMAGELIST = (LVM_FIRST + 3);

        public const uint LVSIL_NORMAL = 0;
        public const uint LVSIL_SMALL = 1;
        public const uint LVSIL_STATE = 2;
        public const uint LVSIL_GROUPHEADER = 3;

        [DllImport("user32")]
        public static extern IntPtr SendMessage(IntPtr hWnd,
                                                uint msg,
                                                uint wParam,
                                                IntPtr lParam);

        [DllImport("comctl32")]
        public static extern bool ImageList_Destroy(IntPtr hImageList);

        public const uint SHGFI_DISPLAYNAME = 0x200;
        public const uint SHGFI_ICON = 0x100;
        public const uint SHGFI_LARGEICON = 0x0;
        public const uint SHGFI_SMALLICON = 0x1;
        public const uint SHGFI_SYSICONINDEX = 0x4000;

        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260 /* MAX_PATH */)]
            public string szDisplayName;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        [DllImport("shell32")]
        public static extern IntPtr SHGetFileInfo(string pszPath,
                                                  uint dwFileAttributes,
                                                  ref SHFILEINFO psfi,
                                                  uint cbSizeFileInfo,
                                                  uint uFlags);

        [DllImport("uxtheme", CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd,
                                                string pszSubAppName,
                                                string pszSubIdList);
    }
}