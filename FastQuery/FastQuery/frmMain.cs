/****************** Request to the Developers *****************

You are free to use, modify and distribute any portion of this code. 
The only requirement to do that, you need to keep the developer name, as provided below to recognize and encourage original work:
Thank you..
 
=======================================================
   
Architecture Designed and Implemented By:
Yogeesha Naik
Twitter: http://facebook.com/yogeesha.thangode | Mail: yogishdj@live.com
   
*******************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using FastQuery.Data;
using System.Text.RegularExpressions;

namespace FastQuery
{
    public partial class frmMain : Form
    {
        #region objects
        Keyword keyword = new Keyword();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Settings settings = new Settings();
        #endregion

        public frmMain()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(600, 400);

            // Application Name
            string sApplication = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString();
            // Assembly version
            string sAppVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            lblAppInfo.Text = sApplication + " " + sAppVersion + " by Yogeesha Naik     ";
        }

        #region Page events

        private void frmMain_Load(object sender, EventArgs e)
        {
            // load saved queries from file system
            LoadQueryList();
            // Load databases names
            LoadDatabases();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            ExecuteQuery();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            frmExport export = new frmExport();
            export.Show();
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            frmPreferences preferences = new frmPreferences();
            preferences.ShowDialog();
            // Set default database
            cboDatabase.Text = "master";
        }

        private void cboQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboQuery.Text.Trim().Length > 0)
                {
                    string query = File.ReadAllText(Global.queryFolderPath + @"\" + cboQuery.Text + "." + Global.queryFileExtension);
                    rtbQueryBox.Text = query;
                }
                pgBar.Value = 0; lblStatus.Text = "Click on Execute button or press F5 to execute query.";
            }
            catch
            {
                LoadQueryList();
            }
        }

        private void btnFields_Click(object sender, EventArgs e)
        {
            frmFields fields = new frmFields();
            fields.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboQuery.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Query name!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboQuery.Focus();
            }
            else if (rtbQueryBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Query window is empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rtbQueryBox.Focus();
            }
            else
            {
                string query = rtbQueryBox.Text;
                File.WriteAllText(Global.queryFolderPath + @"\" + cboQuery.Text.ToUpperInvariant() + "." + Global.queryFileExtension, query);
                MessageBox.Show("Query saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadQueryList();
            }
        }

        private void btnOpenQueryFolder_Click(object sender, EventArgs e)
        {
            string foderPath = Global.queryFolderPath;
            System.Diagnostics.Process proc = System.Diagnostics.Process.Start(foderPath);
        }

        private void btnSSMS_Click(object sender, EventArgs e)
        {
            /*
             * Command Line Switch  Description
             * -------------------  --------------------------------------------------------------
                S                   The name of the SQL Server instance to connect to.
                d                   The name of the SQL Server database to connect to.
                U                   The name of the SQL Server login to connect with.
                P                   The password associated with the login.
                E                   Use Windows Authentication to login to SQL Server.
                noSplash            Suppress splash screen.
                ?                   Displays this usage information.
                file_name           File to load upon startup. Good for loading a .SQL file directly.
            */
            string FilePath = Global.queryFolderPath + @"\" + cboQuery.Text + "." + Global.queryFileExtension;
            if (File.Exists(FilePath))
            {
                System.Diagnostics.Process proc = System.Diagnostics.Process.Start(FilePath);
            }

        }

        private void rtbQueryBox_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {            
            // Change the string color like SQL syntax color
            rtbQueryBox.Language = FastColoredTextBoxNS.Language.SQL;
        }

        private void cboDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            string database = cboDatabase.Text;
            if (cboDatabase.Text.Trim().Length > 0)
                settings.Write("Database", database);
            settings.Save();
            settings.Open();
        }

        #endregion

        #region private methods

        /// <summary>
        /// Loads saved query file names from physical path
        /// </summary>
        private void LoadQueryList()
        {
            if (!Directory.Exists(Global.queryFolderPath))
                Directory.CreateDirectory(Global.queryFolderPath);
            cboQuery.Items.Clear();
            string[] queryFiles = System.IO.Directory.GetFiles(Global.queryFolderPath, "*." + Global.queryFileExtension);
            queryFiles.ForEach((s) => cboQuery.Items.Add(s.ToLowerInvariant()));
        }

        /*
        private void KeywordColoring()
        {

            FastColoredTextBoxNS.FastColoredTextBox rtQueryBox = rtbQueryBox;
            int pos = rtQueryBox.SelectionStart;

            Regex r = new Regex("([ \\t{}():;])");

            //String[] keywords =
            //{
            //    "select", "from" , "where", "join"  , "and"  , "or"   , "union",
            //    "left" , "right", "rtrim", "ltrim", "case", "when",
            //    "order" , "group", "by"   , "having", "inner", "outer", "between",
            //    "rownum", "count", "sum"
            //};

            String[] keywords = keyword.KeywordsBlue;

            string[] text;
            text = rtQueryBox.Lines;
            rtQueryBox.Clear();

            foreach (string line in text)
            {
                String[] tokens = r.Split(line);

                foreach (string token in tokens)
                {
                    // Set the tokens default color and font.
                    rtQueryBox.SelectionColor = Color.Black;
                    rtQueryBox.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);

                    // Check whether the token is a keyword.		    
                    for (int i = 0; i < keywords.Length; i++)
                    {
                        if (keywords[i].ToUpper().Trim() == token.ToUpper().Trim())
                        {
                            // Apply alternative color and font to highlight keyword.
                            rtQueryBox.SelectionColor = Color.Blue;
                            rtQueryBox.SelectionFont = new Font("Courier New", 10, FontStyle.Bold);
                            break;
                        }

                        if (Regex.IsMatch(token, @"##[\w\s\d]{1,}##"))
                        {
                            rtQueryBox.SelectionColor = Color.Red;
                            rtQueryBox.SelectionFont = new Font("Courier New", 10, FontStyle.Bold);
                        }
                    }

                    rtQueryBox.SelectedText = token;
                }

                // rtQueryBox.SelectedText = "\r\n";  
                rtQueryBox.SelectionStart = pos;
                rtQueryBox.SelectionLength = 0;
            }
        }
        */
        private void LoadDatabases()
        {
            Global.ServerInfo = SQLHelper.InitializeServerInfo();
            SqlConnection connection = SQLHelper.CreateNewConnection(Global.ServerInfo);
            using (connection)
            {
                try
                {
                    connection.Open();
                    var data = connection.GetSchema("Databases");
                    cboDatabase.Items.Clear();
                    var databases = SQLHelper.QuerySet("SELECT * FROM sys.databases", Global.ServerInfo);
                    data.AsEnumerable().OrderBy(r => r.Field<string>("database_name")).ForEach((d) =>
                    {
                        var name = d["database_name"].ToString();
                        cboDatabase.Items.Add(name);
                    });
                    connection.Close();
                    settings.Open();
                    cboDatabase.Text = settings.Read("Database", "master");
                }
                catch
                {
                    frmPreferences preferences = new frmPreferences();
                    preferences.ShowDialog();
                    LoadDatabases();
                    cboDatabase.Text = "master";
                }
            }
        }

        private void ExecuteQuery()
        {
            string query = string.Empty;

            this.Cursor = Cursors.WaitCursor;

            if (rtbQueryBox.SelectedText.Trim().Length > 0)
            {
                // Only selected query
                query = rtbQueryBox.SelectedText.Trim();
            }
            else if (rtbQueryBox.Text.Trim().Length > 0)
            {
                // All queries
                query = rtbQueryBox.Text.Trim();
            }
            else
            {
                // Nothing
                this.Cursor = Cursors.Default;
                return;
            }

            Global.ServerInfo = SQLHelper.InitializeServerInfo();
            SqlConnection connection = SQLHelper.CreateNewConnection(Global.ServerInfo);

            using (connection)
            {
                lblStatus.Text = string.Empty;
                btnExecute.Enabled = false;
                pgBar.Value = 0;
                pgBar.Maximum = 100;

                if (query.Trim().Length > 0)
                {
                    if (ValidateQuery(query))
                    {
                        SqlDataAdapter da = null;
                        try
                        {
                            // Currently progressbar not syncronized with query execution, just visualization for user
                            for (int i = 0; i < 80; i = i + 5) { System.Threading.Thread.Sleep(10); pgBar.Value = i; }
                            da = new SqlDataAdapter(query, connection);
                            ds = new DataSet();
                            da.Fill(ds);
                            BindDataToGrids(ref ds);
                            // Open ressult panel if it is hidden(minimized)
                            pnlDataGridView.Height = Global.resultPanelHeight;
                            pgBar.Value = 100;
                        }
                        catch (Exception ex)
                        {
                            pnlDataGridView.Controls.Clear(); lblEntireCount.Text = "Count : 0"; 
                            this.Cursor = Cursors.Default;
                            MessageBox.Show(ex.Message.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            pgBar.Value = 0;
                        }
                        finally
                        {
                            da.Dispose();
                            ds.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Only data select queries are allowed." + Environment.NewLine + Environment.NewLine +
                        "Data modification keyword detected! Please remove and try again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    this.Cursor = Cursors.Default;
                }
                this.Cursor = Cursors.Default;
                lblStatus.Text += " Query execution completed.";
                btnExecute.Enabled = true;
            }
            btnExecute.Enabled = true;
        }

        /// <summary>
        ///  Validate query not to have data modification or schema change keywords.
        ///  And query should start with 'Select' keyword
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns> 
        private bool ValidateQuery(string query)
        {
            bool IsValidated = true;
            Regex r = new Regex("([ \\t{}():;])");

            // Check query contains "SELECT "
            if (!query.ToUpper().Contains("SELECT ")) { IsValidated = false; return IsValidated; }

            String[] tokens = r.Split(query);

            foreach (string token in tokens)
            {
                //if (!token.Contains("--")) { break; } // Skipping commented line
                for (int i = 0; i < keyword.BlockKeywords.Length; i++)
                {
                    if (keyword.BlockKeywords[i].ToUpper().Trim() == token.ToUpper().Trim())
                    {
                        IsValidated = false;
                        return IsValidated;
                    }
                }
                if (Regex.IsMatch(token, @"##[\w\s\d]{1,}##"))
                {
                }
            }
            return IsValidated;
        }

        /// <summary>
        /// Creates DataGridView based on dataset's tables count and binds data accordingly
        /// </summary>
        /// <param name="ds"></param>
        private void BindDataToGrids(ref DataSet ds)
        {
            pnlDataGridView.Controls.Clear();
            //pnlDataGridView.Controls.Add(tsQueryResults);

            if (ds != null)
            {
                int ResultSetCount = ds.Tables.Count;
                for (int i = ResultSetCount - 1; i >= 0; i--)
                {
                    Splitter objSplitter = new Splitter();
                    DataGridView objDGV = new DataGridView();
                    ToolStrip objToolStrip = new ToolStrip(); ToolStripLabel objTSL = new ToolStripLabel();
                    objDGV.Name = "DGV" + i.ToString();
                    objSplitter.Name = "Splitter" + i.ToString();
                    objToolStrip.Name = "ToolStrip" + i.ToString();
                    objTSL.Name = "ToolStripLabel" + i.ToString();
                    objTSL.Text = "Query Result " + (i + 1).ToString();
                    pnlDataGridView.Controls.Add(objDGV);
                    // pnlDataGridView.Controls.Add(objSplitter);
                    objToolStrip.Items.Add(objTSL);
                    pnlDataGridView.Controls.Add(objToolStrip);
                    objSplitter.Dock = DockStyle.Bottom;
                    objDGV.ReadOnly = true;
                    objDGV.BorderStyle = BorderStyle.None;
                    objDGV.AllowUserToAddRows = false;
                    objDGV.AllowUserToResizeRows = false;
                    objDGV.DataSource = ds.Tables[i];
                    if (ResultSetCount == 1 )
                        objDGV.Dock = DockStyle.Fill;
                    else
                        objDGV.Dock = DockStyle.Top;
                    gridAppearance(ref objDGV);

                    objDGV.Click += Grid_Click;
                }
                if (ResultSetCount >0)
                lblEntireCount.Text = "Count : " + ds.Tables[0].Rows.Count;
            }
            tsQueryResults.SendToBack();
        }

        private void gridAppearance(ref DataGridView dataGridView1)
        {
            try
            {
                settings.Open();
                this.Opacity = (double)(Convert.ToInt32(settings.Read("Transperency", 100)) / 100m);

                //Set font style & size               
                int i = settings.Read("FontSize", 8);
                dataGridView1.DefaultCellStyle.Font = new Font(settings.Read("FontStyle", "Tahoma"), i);

                if (settings.Read("DatagridViewStyle", "Fill") == "Fill")
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else if (settings.Read("DatagridViewStyle", "AutoWidth") == "AutoWidth")
                { dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; }

                if (settings.Read("SelectionMode", "Checked") == "Checked")
                {
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                else
                {
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                }

                try { dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("ColHeadFore", "Black")); }
                catch { dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("ColHeadFore", "Black")); }

                try { dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("ColHeadBack", "ButtonFace")); }
                catch { dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("ColHeadBack", "ButtonFace")); }

                try { dataGridView1.RowHeadersDefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("RowHeadFore", "Black")); }
                catch { dataGridView1.RowHeadersDefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("RowHeadFore", "Black")); }

                try { dataGridView1.RowHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("RowHeadBack", "#0000FF")); }
                catch { dataGridView1.RowHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("RowHeadBack", "#0000FF")); }

                try { dataGridView1.RowsDefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("RowFore", "#0000FF")); }
                catch { dataGridView1.RowsDefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("RowFore", "#0000FF")); }

                try { dataGridView1.RowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("RowBack", "#0000FF")); }
                catch { dataGridView1.RowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("RowBack", "#0000FF")); }

                try { dataGridView1.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("SelRowBack", "#0000FF")); }
                catch { dataGridView1.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("SelRowBack", "#0000FF")); }

                try { dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("AltRowBack", "#0000FF")); }
                catch { dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("AltRowBack", "#0000FF")); }

                try { dataGridView1.GridColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("Grid", "#0000FF")); }
                catch { dataGridView1.GridColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("Grid", "#0000FF")); }

                try { dataGridView1.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("DataGridBackground", "#0000FF")); }
                catch { dataGridView1.BackgroundColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("DataGridBackground", "#0000FF")); }
            }
            catch(Exception ex)
            {
                lblStatus.Text +=ex.Message;
            }
        }

        private void Grid_Click(object sender, EventArgs e)
        {
            DataGridView objDGV = (DataGridView)sender;
            lblEntireCount.Text = "Count : " + objDGV.Rows.Count;
        }

        #endregion

        #region overrided methods

        protected override CreateParams CreateParams  // code to avoid flickering
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.D))
            {
                rtbQueryBox.Clear();
                return true;
            }
            if (keyData == (Keys.Control | Keys.A))
            {
                rtbQueryBox.SelectAll();
                return true;
            }
            if (keyData == (Keys.Control | Keys.Z))
            {
                rtbQueryBox.Undo();
                return true;
            }
            if (keyData == (Keys.Control | Keys.R))
            {
                // Minimize result pane
                if (pnlDataGridView.Height != 25)
                    pnlDataGridView.Height = 25;
                else
                    pnlDataGridView.Height = Global.resultPanelHeight;

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

    }
}
