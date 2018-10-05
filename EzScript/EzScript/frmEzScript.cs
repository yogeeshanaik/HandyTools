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
using EzScript.Core;
using System.IO;
using System.Xml;

namespace EzScript
{
    public partial class frmEzScript : Form
    {
        public frmEzScript()
        {
            InitializeComponent();

            // Application Name
            string sApplication = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString();
            // Assembly version
            string sAppVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lblDevnfo.Text = sApplication + " " + sAppVersion + " by Yogeesha Naik     ";

            // Bind AuthTypes dropdown
            Enum.GetValues(typeof(AuthTypes)).Cast<AuthTypes>().ForEach((s) => cboAuthTypes.Items.Add(s));
            cboAuthTypes.SelectedIndex = 0;
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

        public string Database
        {
            get { return cboDatabases.Text; }
            set { cboDatabases.Text = value; }
        }

        #endregion

        ServerInfo objServerInfo = null;
        private IDataAccess objIDataAccess;

        private void frmEzScript_Load(object sender, EventArgs e)
        {
            try
            {
                int dropDownButtonWidth = 14;
                txtServer.Bounds = cboServers.Bounds;
                txtServer.Width -= dropDownButtonWidth;
                LoadComboBoxes();
                setUIAccessability("Page_Load");
            }
            catch (Exception ex)
            {
                rtbInfo.Text = "Oops! Error :" + ex.Message;
                Utility.HighlightText(rtbInfo, "Oops! Error :", Color.Red);
            }
        }

        private void btnGetObjectsList_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstObjectTypes.SelectedItems.Count > 0)
                    GetObjectsList();
                setUIAccessability("Objects_Loaded");
            }
            catch (Exception ex)
            {
                rtbInfo.Text = "Oops! Error :" + ex.Message;
                Utility.HighlightText(rtbInfo, "Oops! Error :", Color.Red);
            }
        }

        private void btnGenerateScript_Click(object sender, EventArgs e)
        {
            try
            {
                string filepathSqlObjects = Directory.GetCurrentDirectory() + @"\sqlObjects.dat";
                if (File.Exists(filepathSqlObjects)) File.Delete(filepathSqlObjects);
                lstObjectsList.Items.Cast<string>().ForEach((s) => SQLScript.AppendTextToFile(filepathSqlObjects, s));
                frmScriptOptions objScriptOptions = new frmScriptOptions(objServerInfo);
                objScriptOptions.ShowDialog();
            }
            catch (Exception ex)
            {
                rtbInfo.Text = "Oops! Error :" + ex.Message;
                Utility.HighlightText(rtbInfo, "Oops! Error :", Color.Red);
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.Server) && TestConnection())
                {
                    LoadDatabases();
                    setUIAccessability("DB_Connection_Success");
                }
                else
                    setUIAccessability("DB_Connection_Failure");
            }
            catch (Exception ex)
            {
                rtbInfo.Text = "Oops! Error :" + ex.Message;
                Utility.HighlightText(rtbInfo, "Oops! Error :", Color.Red);
            }
        }

        private void cboDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            objServerInfo = new ServerInfo { AuthType = this.AuthType, Server = this.Server, User = this.UserName, Password = this.Password, Database = this.Database };
            GetObjectTypes();
            setUIAccessability("Database_Changed");
            }
            catch (Exception ex)
            {
                rtbInfo.Text = "Oops! Error :" + ex.Message;
                Utility.HighlightText(rtbInfo, "Oops! Error :", Color.Red);
            }
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnTestConnection_Click(sender, e);
            }
        }

        private void cboServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtServer.Text = cboServers.Text;
        }

        private void cboAuthTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Clear();
            if (cboAuthTypes.Text.Trim() == AuthTypes.Windows.ToString())
                txtUserName.Enabled = txtPassword.Enabled = false;
            else
                txtUserName.Enabled = txtPassword.Enabled = true;
        }

        #region private methods
        private bool TestConnection()
        {
            bool IsPassed = false;
            try
            {
                var version = SQLHelper.ExecuteScalar("SELECT @@version", new ServerInfo { AuthType = this.AuthType, Server = this.Server, User = this.UserName, Password = this.Password, Database = "master" });
                MessageBox.Show("Connection successful.\n" + version, "SQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IsPassed = true;
                SaveHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IsPassed;
        }

        private void LoadDatabases()
        {
            objIDataAccess = new DataAccess(objServerInfo);
            cboDatabases.Items.Clear();
            objIDataAccess.GetDatabasesList(
                new ServerInfo { AuthType = this.AuthType, Server = this.Server, User = this.UserName, Password = this.Password, Database = "master" }
                ).Cast<string>().ForEach((s) => cboDatabases.Items.Add(s));
        }

        private void GetObjectTypes()
        {
            lstObjectTypes.Items.Clear();
            objIDataAccess = new DataAccess(objServerInfo);
            objIDataAccess.GetObjectTypes().Cast<string>().ForEach((s) => lstObjectTypes.Items.Add(s));
        }

        private void GetObjectsList()
        {
            lstObjectsList.Items.Clear();
            objIDataAccess = new DataAccess(objServerInfo);
            objIDataAccess.GetObjectsList(dtpFrom.Value, dtpTo.Value, GetSelectedObjectTypes()).Cast<string>().ForEach((s) => lstObjectsList.Items.Add(s));
            lblModifiedObjectsCount.Text = "Total Objects: " + lstObjectsList.Items.Count.ToString();
        }

        private string GetSelectedObjectTypes()
        {
            return String.Join(", ", lstObjectTypes.SelectedItems.Cast<string>().Select(i => "'" + i.ToString() + "'").ToArray());
        }

        private void setUIAccessability(string action)
        {
            switch (action)
            {
                case "Page_Load":
                    pnlSriptFilters.Enabled = false;
                    pnlobjectsList.Enabled = false;
                    rtbInfo.Text = "Welcome to EzScript!" + Environment.NewLine + Environment.NewLine
                        + "This tool takes in your database details from which the SQL objects needs to be scripted, where the scripted files have to be stored and the list of SQL objects which need to be scripted in a sql file." + Environment.NewLine
                        + "For any kind of support, feel free to mail at yogishdj@live.com" + Environment.NewLine + Environment.NewLine
                        + "Lets start using it:" + Environment.NewLine
                        + "Set the database connection from \"Database Connection\" section." + Environment.NewLine
                        + "Sql authentication is prefered one.";
                    Utility.HighlightText(rtbInfo, "EzScript", Color.Red);
                    Utility.HighlightText(rtbInfo, "yogishdj@live.com", Color.Blue);
                    Utility.HighlightText(rtbInfo, "Database Connection", Color.Green);
                    break;
                case "DB_Connection_Success":
                    pnlSriptFilters.Enabled = true;
                    btnGetObjectsList.Enabled = false;
                    cboDatabases.Select();
                    rtbInfo.Text = "Select database from \"Objects Filters\" section." + Environment.NewLine
                        + "Select objects modified date range." + Environment.NewLine
                        + "Select object type(s).";
                    Utility.HighlightText(rtbInfo, "Objects Filters", Color.Green);
                    break;
                case "DB_Connection_Failure":
                    pnlSriptFilters.Enabled = false;
                    rtbInfo.Text = "Make sure you have entered correct server instance name." + Environment.NewLine
                        + "If you are using SQL authentication, type the user name & password correctly";
                    break;
                case "Database_Changed":
                    if (cboDatabases.SelectedIndex > -1)
                        btnGetObjectsList.Enabled = true;
                    else
                        btnGetObjectsList.Enabled = false;
                    rtbInfo.Text = "Select objects modified date range." + Environment.NewLine
                        + "Select object type(s).";
                    break;
                case "Objects_Loaded":
                    if (lstObjectsList.Items.Count > 0)
                    {
                        pnlobjectsList.Enabled = true;
                        rtbInfo.Text = "Click on 'Script To File' button to generate script for the objects displayed in the \"Modified Objects\" section." + Environment.NewLine
                            + "Before generating scripts you will be redirected to the script options.";
                        Utility.HighlightText(rtbInfo, "Modified Objects", Color.Green);
                    }
                    else
                    {
                        pnlobjectsList.Enabled = false;
                        if (lstObjectTypes.SelectedItems.Count == 0)
                            rtbInfo.Text = "Select object types. You can select multiple items by clicking and holding Ctrl button.";
                        else
                            rtbInfo.Text = "It seems like you didn't modified the selected type(s) of object(s) in selected date range." + Environment.NewLine;
                    }
                    break;
                default:
                    break;
            }
        }

        private string GetAppPath()
        {
            string appPath = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            int pos = appPath.LastIndexOf('\\');
            return appPath.Substring(0, pos + 1);
        }

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

        #endregion
    }

    static class Utility
    {
        public static void HighlightText(this RichTextBox myRtb, string word, Color color)
        {
            int s_start = myRtb.SelectionStart, startIndex = 0, index;

            while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1)
            {
                myRtb.Select(index, word.Length);
                myRtb.SelectionColor = color;

                startIndex = index + word.Length;
            }

            myRtb.SelectionStart = s_start;
            myRtb.SelectionLength = 0;
            myRtb.SelectionColor = Color.Black;
        }
    }
}
