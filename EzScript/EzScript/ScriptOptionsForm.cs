using EzScript.Core.Models;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace EzScript
{
    public partial class ScriptOptionsForm : Form
    {
        public string FileLocation { get; set; }

        public bool SingleFilePerObject { get; set; }

        public List<SqlObject> SqlObjects { get; set; }

        public ScriptOptionsForm()
        {
            InitializeComponent();
        }

        static ServerInfo DatabaseServer;

        public ScriptOptionsForm(ServerInfo _objServerInfo, List<SqlObject> _sqlObjects, bool _singleFilePerObject)
            : this()
        {
            DatabaseServer = _objServerInfo;
            SqlObjects = _sqlObjects;
            SingleFilePerObject = _singleFilePerObject;
        }

        void frmScriptOptions_Load(object sender, EventArgs e)
        {
            propertyScriptOptions.SelectedObject = new ScriptingOptions();
        }

        void btnOk_Click(object sender, EventArgs e)
        {
            using (WaitCursor c = new WaitCursor(btnOk))
            {
                var objScriptingOptions = (ScriptingOptions)propertyScriptOptions.SelectedObject;
                string fileLocation = ConfigurationManager.AppSettings["Default_OutputFileLocation"];
                objScriptingOptions.FileName = Path.Combine(fileLocation, "script.sql");
                //if (SQLScript.GenerateSrcipt(objScriptingOptions, objServerInfo, SqlObjects, SingleFilePerObject))
                //{
                //    if (MessageBox.Show("Script file generated. Do you want to open the file location?", "EzScript", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                //    {
                //        OpenFolder(fileLocation);
                //    }
                //    this.Close();
                //}
                PrepareScripts(objScriptingOptions);
                OpenFolder(fileLocation);

                //var conString= SQLHelper.CreateNewConnection(DatabaseServer).ConnectionString;
                //new DatabaseScripter().GenerateScripts(conString, @"E:\ScriptBackup", true, true, false, false, true);
            }
        }

        private void PrepareScripts(ScriptingOptions scriptingOptions)
        {
            try
            {
                List<Action> actions = new List<Action>();
                Server myServer = new Server(DatabaseServer.Server);

                    myServer.ConnectionContext.ConnectionString = SQLHelper.CreateNewConnection(DatabaseServer).ConnectionString;
                    myServer.ConnectionContext.Connect();

                if (myServer.ConnectionContext.IsOpen)
                {
                    Database myDatabase = myServer.Databases[DatabaseServer.Database];

                    Scripter scripter = new Scripter(myServer);

                    ScriptingOptions createOptions = scriptingOptions;
                    ScriptingOptions rollBackOptions = scriptingOptions;
                    rollBackOptions.ScriptDrops = true;

                        string rootDirectory = Path.Combine(Path.GetDirectoryName(createOptions.FileName), myDatabase.Name);

                    string rollbackFileName = string.Format("{0}_Rollback{1}", Path.GetFileNameWithoutExtension(scriptingOptions.FileName), Path.GetExtension(scriptingOptions.FileName));
                    rollBackOptions.FileName = Path.Combine(rootDirectory, rollbackFileName);

                    actions.Clear();
                    foreach (var sqlObject in SqlObjects)
                    {
                        actions.Add(() =>
                        {
                            if (SingleFilePerObject)
                            {
                                string directory = Path.Combine(rootDirectory, sqlObject.Type);
                                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);

                                createOptions.FileName = Path.Combine(
                                    directory,
                                    sqlObject.ToString() + ".sql"
                                    );
                            }

                            createOptions.FileName = createOptions.FileName.NextAvailableFilename();
                            rollBackOptions.FileName = rollBackOptions.FileName.NextAvailableFilename();

                            // Update the status of scripting
                            lblScriptingStatus.SynchronizedInvoke(() =>
                            {
                                lblScriptingStatus.Text = "Scripting : (" + (SqlObjects.IndexOf(sqlObject)+1) + "/" + SqlObjects.Count + ") " + sqlObject.ToString();
                                lblScriptingStatus.Refresh();
                            });

                            //Insert Comments
                            //AppendTextToFile(createOptions.FileName, "-- ***********************");
                            //AppendTextToFile(createOptions.FileName, "-- CREATE Script for : " + sqlObject.ToString());
                            //AppendTextToFile(createOptions.FileName, "-- ***********************");

                            //AppendTextToFile(rollBackOptions.FileName, "-- ***********************");
                            //AppendTextToFile(rollBackOptions.FileName, "-- DROP Script for : " + sqlObject.ToString());
                            //AppendTextToFile(rollBackOptions.FileName, "-- ***********************");

                            switch (sqlObject.Type)
                            {
                                case "TABLEWTIRGGERS":
                                    SQLScript.ScriptTables(myDatabase, createOptions, rollBackOptions, sqlObject.Name, sqlObject.Schema);
                                    SQLScript.ScriptTriggers(myDatabase, createOptions, rollBackOptions, sqlObject.Name, null, sqlObject.Schema);
                                    break;

                                case "USER_TABLE":
                                    SQLScript.ScriptTables(myDatabase, createOptions, rollBackOptions, sqlObject.Name, sqlObject.Schema);
                                    break;

                                case "SQL_TRIGGER":
                                    SQLScript.ScriptTriggers(myDatabase, createOptions, rollBackOptions, sqlObject.Name, sqlObject.Name,
                                                 sqlObject.Schema);
                                    break;

                                case "SQL_STORED_PROCEDURE":
                                    SQLScript.ScriptStoredProcedure(myDatabase, createOptions, rollBackOptions, sqlObject.Name, sqlObject.Schema);
                                    break;

                                case "SQL_TABLE_VALUED_FUNCTION":
                                    SQLScript.ScriptUserDefinedFunctions(myDatabase, createOptions, rollBackOptions, sqlObject.Name, sqlObject.Schema);
                                    break;

                                case "SQL_SCALAR_FUNCTION":
                                    SQLScript.ScriptUserDefinedFunctions(myDatabase, createOptions, rollBackOptions, sqlObject.Name, sqlObject.Schema);
                                    break;
                            }
                        });
                    }
                    actions.Add(() =>
                    {
                        lblScriptingStatus.Text = "Success : Successfully completed scripting.";
                    });
                        ((EzScriptForm)Application.OpenForms["EzScriptForm"]).helper.SetActionsTodo(actions);
                    ((EzScriptForm)Application.OpenForms["EzScriptForm"]).backgroundWorkerExample.RunWorkerAsync();
                }                
            }
            catch (Exception ex)
            {
                lblScriptingStatus.Text = "Error : " + ex.Message;
                lblScriptingStatus.Refresh();
            }
        }

        public void OpenFolder(string filePath)
        {
            System.Diagnostics.Process.Start(filePath);
            //System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filePath));
        }
    }
}