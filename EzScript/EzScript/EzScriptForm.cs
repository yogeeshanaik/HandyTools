using EzScript.Core;
using EzScript.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EzScript
{
    public partial class EzScriptForm : Form
    {
        #region variables declaration

        public BWHelper helper;
        List<Action> actions = new List<Action>();

        #endregion variables declaration

        #region properties declaration

        public ServerInfo DatabaseServer
        {
            get
            {
                return new ServerInfo()
                {
                    Server = Server,
                    AuthType = AuthType,
                    User = UserName,
                    Password = Password,
                    Database = Database
                };
            }
            set
            {
                DatabaseServer = value;
            }
        }

        public IDataAccess DataService
        {
            get
            {
                return new DataAccess(DatabaseServer);
            }
            set
            {
                DataService = value;
            }
        }

        public string ProfilePath
        {
            get
            {
                string profilePath = Path.Combine(Application.StartupPath, "Profiles", txtProfileName.Text + ".xml");
                if (!Directory.Exists(Path.GetDirectoryName(profilePath))) Directory.CreateDirectory(Path.GetDirectoryName(profilePath));
                return profilePath;
            }
        }

        AuthTypes _authType;

        public AuthTypes AuthType
        {
            //get { return (AuthTypes)cboAuthTypes.SelectedItem; }
            //set { cboAuthTypes.SelectedItem = value; }

            get
            {
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(() => { _authType = (AuthTypes)cboAuthTypes.SelectedItem; }));
                else _authType = (AuthTypes)cboAuthTypes.SelectedItem;
                return _authType;
            }

            set
            {
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(() => { cboAuthTypes.SelectedItem = value; }));
                else cboAuthTypes.SelectedItem = value;
            }
        }

        string _server;

        public string Server
        {
            //get { return cboServers.Text; }
            //set { cboServers.Text = value; }

            get
            {
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(() => { _server = cboServer.Text; }));
                else _server = cboServer.Text;
                return _server;
            }

            set
            {
                if (this.InvokeRequired)
                    this.Invoke(new MethodInvoker(() => { cboServer.SelectedItem = value; }));
                else cboServer.SelectedItem = value;
            }
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

        string _database;

        public string Database
        {
            get { cboDatabase.SynchronizedInvoke(() => _database = cboDatabase.Text); return _database; }
            set { cboDatabase.SynchronizedInvoke(() => cboDatabase.Text = value); }
        }

        #endregion properties declaration

        #region ctor

        public EzScriptForm()
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

            #region background worker initialization

            backgroundWorkerExample.ProgressChanged += new ProgressChangedEventHandler(backgroundWorkerExample_ProgressChanged);
            backgroundWorkerExample.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerExample_RunWorkerCompleted);
            helper = new BWHelper(backgroundWorkerExample);
            helper.TimeLeft.ValueChanged += new ValueChangedDelegate<TimeSpan>(TimeLeft_ValueChanged);

            #endregion background worker initialization

            #region Trace Listener Initialization

            TraceListener debugListener = new ControlTraceListener(rtbInfo);
            //Debug.Listeners.Add(debugListener);
            Trace.Listeners.Add(debugListener);

            #endregion Trace Listener Initialization

            dtpFrom.Value = DateTime.Today.AddDays(-1);
        }

        #endregion ctor

        #region background worker events

        void backgroundWorkerExample_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelTimeLeft.Text = "Completed";
            //progressBarBW.Value = 0;
        }

        void backgroundWorkerExample_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarBW.Value = e.ProgressPercentage;
        }

        void TimeLeft_ValueChanged(TimeSpan oldValue, TimeSpan newValue)
        {
            CheckForIllegalCrossThreadCalls = false;//I`m lazy. Should be done more neat here
            labelTimeLeft.Text = string.Format("Time left: {0} seconds", newValue.TotalSeconds);
        }

        #endregion background worker events

        #region private methods

        void MimicFormState()
        {
            //FormSerialisor.Deserialise(this, ProfilePath);
            FormSerialisor.SetControlProperties(ProfilePath, cboServer);
            LoadDatabases();
            FormSerialisor.SetControlProperties(ProfilePath, cboDatabase, lstObjectTypes, dtpFrom, dtpTo);
            BindObjectsList();
            FormSerialisor.SetControlProperties(ProfilePath, lvObjectsList, chkSingleFilePerObject);
        }

        bool TestConnection()
        {
            bool IsPassed = false;
            var version = DataService.GetServerVersion();
            IsPassed = true;
            return IsPassed;
        }

        void LoadDatabases()
        {
            cboDatabase.Items.Clear();
            DataService.GetDatabasesList()
                .Cast<string>().ForEach((s) => cboDatabase.Items.Add(s));
        }

        void GetObjectTypes()
        {
            lstObjectTypes.Items.Clear();
            DataService.GetObjectTypes().Cast<string>().ForEach((s) => lstObjectTypes.Items.Add(s));
        }

        void BindObjectsList()
        {
            var result = DataService.GetObjectsList(dtpFrom.Value, dtpTo.Value, GetSelectedObjectTypes());
            lvObjectsList.Bind(result);
        }

        string GetSelectedObjectTypes()
        {
            return String.Join(", ", lstObjectTypes.SelectedItems.Cast<string>().Select(i => "'" + i.ToString() + "'").ToArray());
        }

        void ShowHelp(string action)
        {
            switch (action)
            {
                case "Page_Load":
                    Trace.TraceInformation("Welcome to EzScript!" + Environment.NewLine + Environment.NewLine
                        + "This tool takes in your database details from which the SQL objects needs to be scripted, where the scripted files have to be stored and the list of SQL objects which need to be scripted in a sql file." + Environment.NewLine
                        + "For any kind of support, feel free to mail at yogishdj@live.com" + Environment.NewLine + Environment.NewLine
                        + "Lets start using it:" + Environment.NewLine
                        + "Set the database connection from \"Database Connection\" section." + Environment.NewLine
                        + "Sql authentication is prefered one.");
                    break;

                case "DB_Connection_Success":
                    Trace.TraceInformation("Select database from \"Objects Filters\" section." + Environment.NewLine
                        + "Select objects modified date range." + Environment.NewLine
                        + "Select object type(s).");
                    break;

                case "DB_Connection_Failure":
                    Trace.TraceWarning("Make sure you have entered correct server instance name." + Environment.NewLine
                        + "If you are using SQL authentication, type the user name & password correctly");
                    break;

                case "Database_Changed":
                    Trace.TraceInformation("Select objects modified date range." + Environment.NewLine
                        + "Select object type(s).");
                    break;

                case "Objects_Loaded":
                    if (lvObjectsList.Items.Count > 0)
                    {
                        Trace.TraceInformation("Click on 'Script To File' button to generate script for the objects displayed in the \"Modified Objects\" section." + Environment.NewLine
                            + "Before generating scripts you will be redirected to the script options.");
                    }
                    else
                    {
                        if (lstObjectTypes.SelectedItems.Count == 0)
                            Trace.TraceInformation("Select object types. You can select multiple items by clicking and holding Ctrl button.");
                        else
                            Trace.TraceWarning("It seems like you didn't modified the selected type(s) of object(s) in selected date range." + Environment.NewLine);
                    }
                    break;
            }
        }

        #region Combobox history

        void LoadProfiles()
        {
            lstProfiles.Items.Clear();
            Directory.GetFiles(Path.GetDirectoryName(ProfilePath), "*.xml")
                .ForEach((s) => lstProfiles.Items.Add(Path.GetFileNameWithoutExtension(s)));
        }

        void LoadServers()
        {
            cboServer.Items.Clear();

            foreach (ConnectionStringSettings item in ConfigHelper.GetConnectionStrings())
            {
                cboServer.Items.Add(item);
                cboServer.DisplayMember = "Name";
                cboServer.ValueMember = "ConnectionString";
            }
        }

        void RefreshServers()
        {
            foreach (ConnectionStringSettings item in ConfigHelper.GetConnectionStrings())
            {
                if (!cboServer.Items.OfType<ConnectionStringSettings>().Any(cbi => cbi.Name.Equals(item.Name)))
                {
                    cboServer.Items.Add(item);
                    cboServer.DisplayMember = "Name";
                    cboServer.ValueMember = "ConnectionString";
                }
            }
        }

        #endregion Combobox history

        #endregion private methods

        #region form and controls event

        void tscSelectOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscSelectOption.Text.Equals("Select All"))
                lvObjectsList.Items.OfType<ListViewItem>().ToList().ForEach(s => s.Selected = true);
            else if (tscSelectOption.Text.Equals("Deselect All"))
                lvObjectsList.Items.OfType<ListViewItem>().ToList().ForEach(s => s.Selected = false);
            else if (tscSelectOption.Text.Equals("Invert Selection"))
                lvObjectsList.Items.OfType<ListViewItem>().ToList().ForEach(s => s.Selected = !s.Selected);
        }

        void lstProfiles_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                using (WaitCursor c = new WaitCursor())
                {
                    txtProfileName.Text = lstProfiles.Text;
                    MimicFormState();
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message, "Error");
            }
        }

        void frmEzScript_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProfiles();
                LoadServers();
                ShowHelp("Page_Load");
            }
            catch (Exception ex)
            {
                Trace.Write(ex.Message, "Error");
            }
        }

        void btnGetObjectsList_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstObjectTypes.SelectedItems.Count > 0)
                {
                    BindObjectsList();
                    lblModifiedObjectsCount.Text = "Total Objects: " + lvObjectsList.Items.Count.ToString();
                    tscSelectOption.SelectedIndex = 0;
                    tscSelectOption_SelectedIndexChanged(null, null);
                    ShowHelp("Objects_Loaded");
                }
            }
            catch (Exception ex)
            {
                Trace.Write(ex.Message, "Error");
            }
        }

        void btnGenerateScript_Click(object sender, EventArgs e)
        {
            try
            {
                List<SqlObject> SqlObjects = new List<SqlObject>();
                SqlObjects.AddRange(
                    lvObjectsList.SelectedItems.Cast<ListViewItem>().Select(s =>
                    new SqlObject()
                    {
                        Type = s.SubItems[0].Text,
                        Schema = s.SubItems[1].Text,
                        Name = s.SubItems[2].Text,
                        Modify_Date = Convert.ToDateTime(s.SubItems[3].Text),
                        Create_Date = Convert.ToDateTime(s.SubItems[4].Text)
                    }
                    ));

                if (SqlObjects.Count > 0)
                {
                    ScriptOptionsForm objScriptOptions = new ScriptOptionsForm(DatabaseServer, SqlObjects, chkSingleFilePerObject.Checked);
                    objScriptOptions.ShowDialog();
                }
                else
                    Trace.TraceInformation("Select objects to generate script!");
            }
            catch (Exception ex)
            {
                Trace.Write(ex.ToString(), "Error");
            }
        }

        void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Server)) return;

            try
            {
                var status = false;
                actions.Clear();
                actions.Add(() =>
                {
                    using (WaitCursor c = new WaitCursor(pnlLeft))
                    {
                        status = TestConnection();

                        if (status)
                        {
                            // Save connection details to config
                            if (ConfigHelper.AddConnectionString(
                                new ConnectionStringSettings()
                                {
                                    ConnectionString = DatabaseServer.ConnectionString,
                                    Name = Server,
                                }
                            ))
                            {
                                if (this.InvokeRequired)
                                    this.Invoke(new MethodInvoker(() => { RefreshServers(); }));
                                else RefreshServers();
                            }

                            this.SynchronizedInvoke(() =>
                            {
                                LoadDatabases();
                                ShowHelp("DB_Connection_Success");
                                //cboDatabase.DroppedDown = true;
                            });

                            //MessageBox.Show("Connection successful.\n" + version, "SQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            ShowHelp("DB_Connection_Failure");
                    }
                });
                helper.SetActionsTodo(actions);
                backgroundWorkerExample.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                Trace.TraceError("Oops! Error :" + ex.Message, "Error");
            }
        }

        void cboDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lvObjectsList.Items.Clear();
                lstObjectTypes.Items.Clear();
                GetObjectTypes();
                ShowHelp("Database_Changed");
            }
            catch (Exception ex)
            {
                Trace.Write(ex.Message, "Error");
            }
        }

        void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnTestConnection_Click(sender, e);
            }
        }

        void cboServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder(cboServer.SelectedItem?.ToString());
            cboAuthTypes.SelectedIndex = builder.IntegratedSecurity == true ? 1 : 0;
            txtUserName.Text = builder.UserID;
            txtPassword.Text = builder.Password;
        }

        void cboAuthTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Clear();
            if (cboAuthTypes.Text.Trim() == AuthTypes.Windows.ToString())
                txtUserName.Enabled = txtPassword.Enabled = false;
            else
                txtUserName.Enabled = txtPassword.Enabled = true;
        }

        void btnSaveProfile_Click(object sender, EventArgs e)
        {
            if (txtProfileName.Text.Length == 0) return;

            if (File.Exists(ProfilePath) && lstProfiles.Text != Path.GetFileNameWithoutExtension(ProfilePath))
                if (DialogResult.No == MessageBox.Show("Profile name already exists. Do you want to overwrite?", "Profile Name", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    return;

            FormSerialisor.Serialise(this, ProfilePath);
            Trace.TraceInformation("Saved");
            LoadProfiles();
        }

        #endregion form and controls event

        void rtbInfo_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            rtbInfo.SelectionStart = rtbInfo.Text.Length;
            // scroll it automatically
            rtbInfo.ScrollToCaret();
        }
    }
}