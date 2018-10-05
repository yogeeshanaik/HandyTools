namespace CodeYogi
{
    partial class frmExplorer
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuSA = new System.Windows.Forms.MenuItem();
            this.mnuST = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnuSMD = new System.Windows.Forms.MenuItem();
            this.mnuSMN = new System.Windows.Forms.MenuItem();
            this.mnuMF = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.explorerTree2 = new WindowsExplorer.ExplorerTree();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lwFilesAndFolders = new System.Windows.Forms.ListView();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.backgroundWorkerExample = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSA,
            this.mnuST,
            this.menuItem4,
            this.mnuSMD,
            this.mnuSMN,
            this.mnuMF,
            this.menuItem2,
            this.menuItem3});
            this.menuItem1.Text = "Options";
            // 
            // mnuSA
            // 
            this.mnuSA.Checked = true;
            this.mnuSA.Index = 0;
            this.mnuSA.Text = "Show Addressbar";
            this.mnuSA.Click += new System.EventHandler(this.mnuSA_Click);
            // 
            // mnuST
            // 
            this.mnuST.Checked = true;
            this.mnuST.Index = 1;
            this.mnuST.Text = "Show Toolbar";
            this.mnuST.Click += new System.EventHandler(this.mnuST_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "-";
            // 
            // mnuSMD
            // 
            this.mnuSMD.Checked = true;
            this.mnuSMD.Index = 3;
            this.mnuSMD.Text = "Show My Documents";
            this.mnuSMD.Click += new System.EventHandler(this.mnuSMD_Click);
            // 
            // mnuSMN
            // 
            this.mnuSMN.Checked = true;
            this.mnuSMN.Index = 4;
            this.mnuSMN.Text = "Show My Networks";
            this.mnuSMN.Click += new System.EventHandler(this.mnuSMN_Click);
            // 
            // mnuMF
            // 
            this.mnuMF.Checked = true;
            this.mnuMF.Index = 5;
            this.mnuMF.Text = "Show My Favorites";
            this.mnuMF.Click += new System.EventHandler(this.mnuMF_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 6;
            this.menuItem2.Text = "-";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 7;
            this.menuItem3.Text = "About";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.explorerTree2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(529, 360);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 1;
            // 
            // explorerTree2
            // 
            this.explorerTree2.BackColor = System.Drawing.Color.White;
            this.explorerTree2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerTree2.Location = new System.Drawing.Point(0, 0);
            this.explorerTree2.Name = "explorerTree2";
            this.explorerTree2.SelectedPath = "D:\\Media";
            this.explorerTree2.ShowAddressbar = true;
            this.explorerTree2.ShowMyDocuments = true;
            this.explorerTree2.ShowMyFavorites = true;
            this.explorerTree2.ShowMyNetwork = true;
            this.explorerTree2.ShowToolbar = true;
            this.explorerTree2.Size = new System.Drawing.Size(145, 360);
            this.explorerTree2.TabIndex = 0;
            this.explorerTree2.PathChanged += new WindowsExplorer.ExplorerTree.PathChangedEventHandler(this.explorerTree2_PathChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lwFilesAndFolders);
            this.splitContainer2.Panel1.Controls.Add(this.cmbSelect);
            this.splitContainer2.Size = new System.Drawing.Size(380, 360);
            this.splitContainer2.SplitterDistance = 123;
            this.splitContainer2.TabIndex = 5;
            // 
            // lwFilesAndFolders
            // 
            this.lwFilesAndFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwFilesAndFolders.Location = new System.Drawing.Point(0, 21);
            this.lwFilesAndFolders.Name = "lwFilesAndFolders";
            this.lwFilesAndFolders.Size = new System.Drawing.Size(123, 339);
            this.lwFilesAndFolders.TabIndex = 4;
            this.lwFilesAndFolders.UseCompatibleStateImageBehavior = false;
            // 
            // cmbSelect
            // 
            this.cmbSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbSelect.Items.AddRange(new object[] {
            "*.bmp;*.jpg;*.jpeg;*.gif",
            "*.doc;*.rtf;*.txt",
            "*.*"});
            this.cmbSelect.Location = new System.Drawing.Point(0, 0);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(123, 21);
            this.cmbSelect.TabIndex = 3;
            this.cmbSelect.Text = "*.*";
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // frmExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 360);
            this.Controls.Add(this.splitContainer1);
            this.Menu = this.mainMenu1;
            this.Name = "frmExplorer";
            this.Text = "frmExplorer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExplorer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem mnuSA;
        private System.Windows.Forms.MenuItem mnuST;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem mnuSMD;
        private System.Windows.Forms.MenuItem mnuSMN;
        private System.Windows.Forms.MenuItem mnuMF;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.ListView lwFilesAndFolders;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private WindowsExplorer.ExplorerTree explorerTree2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerExample;
    }
}