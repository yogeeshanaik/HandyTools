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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml;

namespace FastQuery
{
    public partial class frmPreferences : Form
    {
        Settings settings = new Settings();
        public frmPreferences()
        {
            InitializeComponent();
            // Bind AuthTypes dropdown
            Enum.GetValues(typeof(AuthTypes)).Cast<AuthTypes>().ForEach((s) => cboAuthTypes.Items.Add(s));
            cboAuthTypes.SelectedIndex = 0;
        }

        public frmPreferences(ServerInfo Info)
            : this()
        {
            if (Info != null)
            {
                AuthType = Info.AuthType;
                Server = Info.Server;
                UserName = Info.User;
                Password = Info.Password;
                AuthType = Info.AuthType;
            }
        }

        #region properties declaration
        public AuthTypes AuthType
        {
            get { return (AuthTypes)cboAuthTypes.SelectedItem; }
            set { cboAuthTypes.SelectedItem = value; }
        }

        public string Server
        {
            get { return txtServer.Text; }
            set { txtServer.Text = value; }
        }

        public string UserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        #endregion

        #region private methods
        private void LoadConnectionDetails()
        {
            settings.Open();
            if (settings.Read("AuthType", "Windows") == "Windows")
            {
                cboAuthTypes.Text=AuthTypes.Windows.ToString();
            }
            else { cboAuthTypes.Text= AuthTypes.SQLServer.ToString(); }

                cboServers.Text = settings.Read("Server", "(local)");
                txtUserName.Text = settings.Read("UserName", "sa");
                txtPassword.Text = settings.Read("Password", "");
        }

        private void BindAppearanceControls()
        {
            settings.Open();
            cbCustom.Checked = settings.Read("Custom", true);
            numTransperency.Value = Convert.ToInt32(settings.Read("Transperency", "100"));
            btnFont.Text = settings.Read("FontStyle", "Tahoma");
            numericUpDown1.Value = settings.Read("FontSize", 8);

            if (settings.Read("SelectionMode", "Checked") == "Checked")
            {
                cbRowSelect.Checked = true;
            }
            else
            {
                cbRowSelect.Checked = false;
            }

            try { btnColHeadFore.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("ColHeadFore", "White")); }
            catch { btnColHeadFore.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("ColHeadFore", "White")); }

            try { btnColHeadBack.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("ColHeadBack", "Black")); }
            catch { btnColHeadBack.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("ColHeadBack", "Black")); }

            try { btnRowHeadFore.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("RowHeadFore", "White")); }
            catch { btnRowHeadFore.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("RowHeadFore", "White")); }

            try { btnRowHeadBack.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("RowHeadBack", "Black")); }
            catch { btnRowHeadBack.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("RowHeadBack", "Black")); }

            try { btnRowFore.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("RowFore", "Black")); }
            catch { btnRowFore.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("RowFore", "Black")); }

            try { btnRowBack.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("RowBack", "White")); }
            catch { btnRowBack.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("RowBack", "White")); }

            try { btnSelRowBack.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("SelRowBack", "#FF48A4FF")); }
            catch { btnSelRowBack.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("SelRowBack", "#FF48A4FF")); }

            try { btnAltRowBack.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("AltRowBack", "White")); }
            catch { btnAltRowBack.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("AltRowBack", "White")); }

            try { btnGrid.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("Grid", "Black")); }
            catch { btnGrid.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("Grid", "Black")); }

            try { btnDataGridBackground.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + settings.Read("DataGridBackground", "White")); }
            catch { btnDataGridBackground.BackColor = System.Drawing.ColorTranslator.FromHtml(settings.Read("DataGridBackground", "White")); }
        }

        private void TestConnection(bool FromPageLoad=false)
        {
            try
            {
                tabConfigurations.SelectedIndex = 1;
                var version = SQLHelper.ExecuteScalar("SELECT @@version", new ServerInfo { AuthType = this.AuthType, Server = this.Server, User = this.UserName, Password = this.Password, Database = "master" });
                SaveHistory();
                if (!FromPageLoad)
                    MessageBox.Show("Connection successful.\n" + version, "SQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                tabConfigurations.SelectedIndex = 0;
                MessageBox.Show(ex.Message, "SQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetAppPath()
        {
            string appPath = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            int pos = appPath.LastIndexOf('\\');
            return appPath.Substring(0, pos + 1);
        }
        #endregion

        #region page events
        private void frmPreferences_Load(object sender, EventArgs e)
        {
            int dropDownButtonWidth = 14;
            txtServer.Bounds = cboServers.Bounds;
            txtServer.Width -= dropDownButtonWidth;
            LoadComboBoxes();

            LoadConnectionDetails();
            BindAppearanceControls();
            TestConnection(true);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            btnApply.Enabled = false; this.Cursor = Cursors.WaitCursor;

            settings.Write("AuthType", this.AuthType.ToString());
            settings.Write("Server", this.Server.ToString());
            settings.Write("UserName", this.UserName.ToString());
            settings.Write("Password", this.Password.ToString());
            settings.Write("Database", "master");

            //------------------------------------------------------------------------------------
            settings.Write("Custom", Convert.ToBoolean(cbCustom.CheckState));
            settings.Write("Transperency", "" + numTransperency.Value);
            settings.Write("FontStyle", "" + btnFont.Text);
            settings.Write("FontSize", Convert.ToInt16(numericUpDown1.Value));
            //------------------------------------------------------------------------------------
            settings.Write("ColHeadFore", "" + btnColHeadFore.BackColor.Name);

            settings.Write("ColHeadBack", "" + btnColHeadBack.BackColor.Name);

            settings.Write("RowHeadFore", "" + btnRowHeadFore.BackColor.Name);

            settings.Write("RowHeadBack", "" + btnRowHeadBack.BackColor.Name);

            settings.Write("RowFore", "" + btnRowFore.BackColor.Name);

            settings.Write("RowBack", "" + btnRowBack.BackColor.Name);

            settings.Write("SelRowBack", "" + btnSelRowBack.BackColor.Name);

            settings.Write("AltRowBack", "" + btnAltRowBack.BackColor.Name);

            settings.Write("Grid", "" + btnGrid.BackColor.Name);

            settings.Write("DataGridBackground", "" + btnDataGridBackground.BackColor.Name);

            settings.Save();

            btnApply.Enabled = true; this.Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            btnApply_Click(null, null);
            this.Dispose();
        }

        private void numTransperency_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (double)(numTransperency.Value / 100m);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(numericUpDown1.Value);
                btnFont.Font = new Font(btnFont.Text, i);
            }
            catch { }
        }

        private void cboGridStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                #region Default
                if (cboGridStyles.Text == "Default")
                {
                    btnColHeadFore.BackColor = Color.White;
                    btnColHeadBack.BackColor = Color.Black;

                    btnRowHeadFore.BackColor = Color.White;
                    btnRowHeadBack.BackColor = Color.Black;

                    btnRowFore.BackColor = Color.Black;
                    btnRowBack.BackColor = Color.White;

                    btnSelRowBack.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff48a4ff");

                    btnAltRowBack.BackColor = Color.White;
                    btnGrid.BackColor = Color.FromArgb(80, 90, 90);
                }
                #endregion

                #region GunMetal
                else if (cboGridStyles.Text == "GunMetal")
                {
                    btnColHeadFore.BackColor = Color.White;
                    btnColHeadBack.BackColor = Color.Black;

                    btnRowHeadFore.BackColor = Color.White;
                    btnRowHeadBack.BackColor = Color.Black;

                    btnRowFore.BackColor = Color.Black;
                    btnRowBack.BackColor = Color.LightGray;

                    btnSelRowBack.BackColor = Color.Black;

                    btnAltRowBack.BackColor = Color.DarkGray;
                    btnGrid.BackColor = Color.FromArgb(80, 90, 90);
                }
                #endregion

                #region Night Vision
                else if (cboGridStyles.Text == "Night Vision")
                {
                    btnColHeadFore.BackColor = Color.White;
                    btnColHeadBack.BackColor = Color.Black;
                    btnRowHeadFore.BackColor = Color.White;
                    btnRowHeadBack.BackColor = Color.Black;
                    btnRowFore.BackColor = Color.White;
                    btnRowBack.BackColor = Color.FromArgb(27, 30, 30);
                    btnSelRowBack.BackColor = Color.FromArgb(98, 110, 110);
                    btnAltRowBack.BackColor = Color.Black;
                    btnGrid.BackColor = Color.FromArgb(80, 90, 90);
                }
                #endregion

                #region radium rush
                else if (cboGridStyles.Text == "Radium Rush")
                {
                    btnColHeadFore.BackColor = Color.White;
                    btnColHeadBack.BackColor = Color.Black;
                    btnRowHeadFore.BackColor = Color.White;
                    btnRowHeadBack.BackColor = Color.Black;

                    btnRowFore.BackColor = Color.White;
                    btnRowBack.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF000B");
                    btnSelRowBack.BackColor = System.Drawing.ColorTranslator.FromHtml("#A86400");
                    btnAltRowBack.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFA8AC");
                    btnGrid.BackColor = Color.FromArgb(80, 90, 90);
                }
                #endregion

                #region Transparent
                else if (cboGridStyles.Text == "Transparent")
                {
                    btnColHeadFore.BackColor = Color.White;
                    btnColHeadBack.BackColor = Color.Black;
                    btnRowHeadFore.BackColor = Color.White;
                    btnRowHeadBack.BackColor = Color.Black;

                    btnRowFore.BackColor = Color.Black;
                    btnRowBack.BackColor = Color.White;
                    btnSelRowBack.BackColor = Color.BlueViolet;
                    btnAltRowBack.BackColor = Color.White;
                    btnGrid.BackColor = Color.FromArgb(80, 90, 90);
                }
                #endregion
            }
            catch (Exception ex) { MessageBox.Show("Error : " + ex); }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnColHeadFore_Click(object sender, EventArgs e)
        {
            if (cdGrid.ShowDialog() == DialogResult.OK) { btnColHeadFore.BackColor = cdGrid.Color; }
        }

        private void btnRowHeadFore_Click(object sender, EventArgs e)
        {
            if (cdGrid.ShowDialog() == DialogResult.OK) { btnRowHeadFore.BackColor = cdGrid.Color; }
        }

        private void btnRowFore_Click(object sender, EventArgs e)
        {
            if (cdGrid.ShowDialog() == DialogResult.OK) { btnRowFore.BackColor = cdGrid.Color; }
        }

        private void btnSelRowBack_Click(object sender, EventArgs e)
        {
            if (cdGrid.ShowDialog() == DialogResult.OK) { btnSelRowBack.BackColor = cdGrid.Color; }
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            if (cdGrid.ShowDialog() == DialogResult.OK) { btnGrid.BackColor = cdGrid.Color; }
        }

        private void btnColHeadBack_Click(object sender, EventArgs e)
        {
            if (cdGrid.ShowDialog() == DialogResult.OK) { btnColHeadBack.BackColor = cdGrid.Color; }
        }

        private void btnRowHeadBack_Click(object sender, EventArgs e)
        {
            if (cdGrid.ShowDialog() == DialogResult.OK) { btnRowHeadBack.BackColor = cdGrid.Color; }
        }

        private void btnRowBack_Click(object sender, EventArgs e)
        {
            if (cdGrid.ShowDialog() == DialogResult.OK) { btnRowBack.BackColor = cdGrid.Color; }
        }

        private void btnAltRowBack_Click(object sender, EventArgs e)
        {
            if (cdGrid.ShowDialog() == DialogResult.OK) { btnAltRowBack.BackColor = cdGrid.Color; }
        }

        private void btnDataGridBackground_Click(object sender, EventArgs e)
        {
            if (cdGrid.ShowDialog() == DialogResult.OK) { btnDataGridBackground.BackColor = cdGrid.Color; }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            cboGridStyles.Text = "Default";
            cbCustom.Checked = false;
            numTransperency.Value = 100;
            btnFont.Text = "Tahoma";
            numericUpDown1.Value = 9;

            #region Default
            if (cboGridStyles.Text == "Default")
            {
                btnColHeadFore.BackColor = Color.White;
                btnColHeadBack.BackColor = Color.Black;

                btnRowHeadFore.BackColor = Color.White;
                btnRowHeadBack.BackColor = Color.Black;

                btnRowFore.BackColor = Color.Black;
                btnRowBack.BackColor = Color.White;

                btnSelRowBack.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff48a4ff");

                btnAltRowBack.BackColor = Color.White;
                btnGrid.BackColor = Color.FromArgb(80, 90, 90);
            }
            #endregion
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                btnFont.Text = "" + fontDialog1.Font.Name;
                numericUpDown1.Value = Convert.ToDecimal(fontDialog1.Font.Size);
            }
        }

        private void numTransperency_ValueChanged_1(object sender, EventArgs e)
        {
            this.Opacity = (double)(numTransperency.Value / 100m);
        }

        private void cbCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCustom.Checked == true) { panel2.Enabled = true; cboGridStyles.Enabled = false; }
            else { panel2.Enabled = false; cboGridStyles.Enabled = true; }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void cboAuthTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Clear();
            if (cboAuthTypes.Text.Trim() == AuthTypes.Windows.ToString())
                txtUserName.Enabled = txtPassword.Enabled = false;
            else
                txtUserName.Enabled = txtPassword.Enabled = true;
        }

        private void Fill_CheckedChanged(object sender, EventArgs e)
        {
            settings.Write("DatagridViewStyle", "Fill"); settings.Save();
        }

        private void Displayed_CheckedChanged(object sender, EventArgs e)
        {
            settings.Write("DatagridViewStyle", "AutoWidth"); settings.Save();
        }

        private void cbRowSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRowSelect.Checked == true)
            {
                settings.Write("SelectionMode", "" + cbRowSelect.CheckState);
                settings.Save();
            }
            else
            {
                settings.Write("SelectionMode", "" + cbRowSelect.CheckState);
                settings.Save();
            }
        }

        private void cboServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtServer.Text = cboServers.Text;
        }
        #endregion

        #region Combobox history
        private void LoadComboBoxes()
        {
            cboServers.Items.Clear();

            txtServer.Text = string.Empty;

            XmlDocument xdoc = new XmlDocument();
            string comboBoxPath = GetAppPath() + "comboboxes.xml";
            if (File.Exists(comboBoxPath))
            {
                xdoc.Load(comboBoxPath);
                XmlElement root = xdoc.DocumentElement;
                XmlNodeList nodeList = root.ChildNodes;
                ComboBox cboHistory;

                // Determine the control we are working with.
                for (int i = 0; i < nodeList.Count; ++i)
                {
                    switch (nodeList.Item(i).Attributes["name"].Value)
                    {
                        case "cboServers":
                            cboHistory = cboServers;
                            break;
                        default:
                            throw new Exception("Unknown control passed from comboboxes.xml");
                    }

                    // Add items from the xml file to the combobox.
                    for (int j = 0; j < nodeList.Item(i).ChildNodes.Count; ++j)
                    {
                        cboHistory.Items.Add(nodeList.Item(i).ChildNodes.Item(j).InnerText);
                    }
                }
            }
        }

        private void SaveHistory()
        {
            string filepath = GetAppPath() + "comboboxes.xml";
            if (File.Exists(filepath) && (File.GetAttributes(filepath) & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                File.SetAttributes(filepath, FileAttributes.Normal);
            }
            // Save the combox
            XmlTextWriter tw = new XmlTextWriter(filepath, System.Text.Encoding.UTF8);

            tw.WriteStartDocument();
            tw.WriteStartElement("comboboxes");
            WriteComboBoxEntries(cboServers, "cboServers", txtServer.Text, tw);
            tw.WriteEndElement();
            tw.Flush();
            tw.Close();

            if ((File.GetAttributes(filepath) & FileAttributes.Hidden) != FileAttributes.Hidden)
            {
                // Hide file
                File.SetAttributes(filepath, FileAttributes.Hidden);
            }
            // LoadComboBoxes();
        }

        private void WriteComboBoxEntries(ComboBox cboBox, string cboBoxName, string txtBoxText, XmlTextWriter tw)
        {
            int maxEntriesToStore = 10;

            tw.WriteStartElement("combobox");
            tw.WriteStartAttribute("name", string.Empty);
            tw.WriteString(cboBoxName);
            tw.WriteEndAttribute();

            // Write the item from the text box first.
            if (txtBoxText.Length != 0)
            {
                tw.WriteStartElement("entry");
                tw.WriteString(txtBoxText);
                tw.WriteEndElement();
                maxEntriesToStore -= 1;
            }

            // Write the rest of the entries (up to 10).
            for (int i = 0; i < cboBox.Items.Count && i < maxEntriesToStore; ++i)
            {
                if (txtBoxText != cboBox.Items[i].ToString())
                {
                    tw.WriteStartElement("entry");
                    tw.WriteString(cboBox.Items[i].ToString());
                    tw.WriteEndElement();
                }
            }

            tw.WriteEndElement();
        }

        #endregion
    }
}
