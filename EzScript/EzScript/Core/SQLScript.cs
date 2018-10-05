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
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Smo;
using System.Configuration;

public class SQLScript
{
    public static bool GenerateSrcipt(ScriptingOptions objScriptingOptions, ServerInfo objServerInfo)
    {
        bool Success = false;

        StreamReader file = null;
        try
        {
            Server myServer = new Server(objServerInfo.Server);
            myServer.ConnectionContext.ConnectionString = SQLHelper.CreateNewConnection(objServerInfo).ConnectionString;
            myServer.ConnectionContext.Connect();

            if (myServer.ConnectionContext.IsOpen)
            {
                Database myDatabase = myServer.Databases[objServerInfo.Database];

                string createPath = objScriptingOptions.FileName;
                string rollBackPath = createPath.Replace(createPath.Substring(createPath.LastIndexOf('\\')), "\\rollbackScript.sql");

                if (File.Exists(createPath))
                {
                    File.Delete(createPath);
                }

                if (File.Exists(rollBackPath))
                {
                    File.Delete(rollBackPath);
                }

                Scripter scripter = new Scripter(myServer);

                ScriptingOptions createOptions = new ScriptingOptions()
                {
                    AnsiPadding = objScriptingOptions.AnsiPadding,
                    ScriptBatchTerminator = objScriptingOptions.ScriptBatchTerminator,
                    DriAll = objScriptingOptions.DriAll,
                    ToFileOnly = objScriptingOptions.ToFileOnly,
                    FileName = objScriptingOptions.FileName,
                    IncludeDatabaseContext = objScriptingOptions.IncludeDatabaseContext,
                    IncludeIfNotExists = objScriptingOptions.IncludeIfNotExists,
                    AppendToFile = objScriptingOptions.AppendToFile,
                    AnsiFile = objScriptingOptions.AnsiFile
                };

                ScriptingOptions rollBackOptions = new ScriptingOptions()
                {
                    AnsiPadding = objScriptingOptions.AnsiPadding,
                    ScriptBatchTerminator = objScriptingOptions.ScriptBatchTerminator,
                    DriAll = objScriptingOptions.DriAll,
                    ToFileOnly = objScriptingOptions.ToFileOnly,
                    FileName = rollBackPath,
                    IncludeDatabaseContext = objScriptingOptions.IncludeDatabaseContext,
                    IncludeIfNotExists = objScriptingOptions.IncludeIfNotExists,
                    AppendToFile = objScriptingOptions.AppendToFile,
                    AnsiFile = objScriptingOptions.AnsiFile,
                    ScriptDrops = true
                };

                file = new StreamReader(Directory.GetCurrentDirectory() + @"\sqlObjects.dat");

                string line;
                int counter = 0;
                var lineCount = File.ReadLines(Directory.GetCurrentDirectory() + @"\sqlObjects.dat").Count();

                while ((line = file.ReadLine()) != null)
                {
                    // Update the status of scripting
                    ((EzScript.frmScriptOptions)System.Windows.Forms.Application.OpenForms["frmScriptOptions"]).lblScriptingStatus.Text =
                        "Scripting : (" + (counter+1) + "/" + lineCount + ") " + line;
                    ((EzScript.frmScriptOptions)System.Windows.Forms.Application.OpenForms["frmScriptOptions"]).lblScriptingStatus.Refresh();
                    // Console.WriteLine("Scripting : " + line);

                    //Insert Comments
                    string objectName;
                    #region TABLEWTIRGGERS
                    if (line.Contains("<#TABLEWTIRGGERS#>"))
                    {
                        objectName = line.Replace("<#TABLEWTIRGGERS#>", "");

                        AppendTextToFile(createPath, "-- ***********************");
                        AppendTextToFile(createPath, "-- CREATE Script for : " + objectName);
                        AppendTextToFile(createPath, "-- ***********************");

                        AppendTextToFile(rollBackPath, "-- ***********************");
                        AppendTextToFile(rollBackPath, "-- DROP Script for : " + objectName);
                        AppendTextToFile(rollBackPath, "-- ***********************");

                        //Script tables
                        ScriptTables(myDatabase, createOptions, rollBackOptions, objectName.Split('.')[1], objectName.Split('.')[0]);
                        //Script Tiggers
                        ScriptTriggers(myDatabase, createOptions, rollBackOptions, objectName.Split('.')[1], null,
                                       objectName.Split('.')[0]);
                    }
                    #endregion
                    #region USER_TABLE
                    else if (line.Contains("<#USER_TABLE#>"))
                    {
                        objectName = line.Replace("<#USER_TABLE#>", "");

                        AppendTextToFile(createPath, "-- ***********************");
                        AppendTextToFile(createPath, "-- CREATE Script for : " + objectName);
                        AppendTextToFile(createPath, "-- ***********************");

                        AppendTextToFile(rollBackPath, "-- ***********************");
                        AppendTextToFile(rollBackPath, "-- DROP Script for : " + objectName);
                        AppendTextToFile(rollBackPath, "-- ***********************");

                        //Script tables
                        ScriptTables(myDatabase, createOptions, rollBackOptions, objectName.Split('.')[1], objectName.Split('.')[0]);
                    }
                    #endregion
                    #region SQL_TRIGGER
                    else if (line.Contains("<#SQL_TRIGGER#>"))
                    {
                        objectName = line.Replace("<#SQL_TRIGGER#>", "");
                        string tableName = objectName.Split('|')[0];
                        string trigName = objectName.Split('|')[1];

                        AppendTextToFile(createPath, "-- ***********************");
                        AppendTextToFile(createPath, "-- CREATE Script for : " + objectName);
                        AppendTextToFile(createPath, "-- ***********************");

                        AppendTextToFile(rollBackPath, "-- ***********************");
                        AppendTextToFile(rollBackPath, "-- DROP Script for : " + objectName);
                        AppendTextToFile(rollBackPath, "-- ***********************");

                        //Script Tiggers
                        ScriptTriggers(myDatabase, createOptions, rollBackOptions, tableName.Split('.')[1], trigName,
                                       tableName.Split('.')[0]);
                    }
                    #endregion
                    #region SQL_STORED_PROCEDURE
                    else if (line.Contains("<#SQL_STORED_PROCEDURE#>"))
                    {
                        objectName = line.Replace("<#SQL_STORED_PROCEDURE#>", "");

                        AppendTextToFile(createPath, "-- ***********************");
                        AppendTextToFile(createPath, "-- CREATE Script for : " + objectName);
                        AppendTextToFile(createPath, "-- ***********************");

                        AppendTextToFile(rollBackPath, "-- ***********************");
                        AppendTextToFile(rollBackPath, "-- DROP Script for : " + objectName);
                        AppendTextToFile(rollBackPath, "-- ***********************");

                        //Script Stored Procedures
                        //createOptions.ScriptDrops = true;
                        //ScriptStoredProcedure(myDatabase, createOptions, rollBackOptions, objectName.Split('.')[1], objectName.Split('.')[0]);
                        //createOptions.ScriptDrops = false;
                        ScriptStoredProcedure(myDatabase, createOptions, rollBackOptions, objectName.Split('.')[1], objectName.Split('.')[0]);
                    }
                    #endregion
                    #region SQL_TABLE_VALUED_FUNCTION 
                    else if (line.Contains("<#SQL_TABLE_VALUED_FUNCTION#>"))
                    {
                        objectName = line.Replace("<#SQL_TABLE_VALUED_FUNCTION#>", "");

                        AppendTextToFile(createPath, "-- ***********************");
                        AppendTextToFile(createPath, "-- CREATE Script for : " + objectName);
                        AppendTextToFile(createPath, "-- ***********************");

                        AppendTextToFile(rollBackPath, "-- ***********************");
                        AppendTextToFile(rollBackPath, "-- DROP Script for : " + objectName);
                        AppendTextToFile(rollBackPath, "-- ***********************");

                        //Script User Defined Functions
                        ScriptUserDefinedFunctions(myDatabase, createOptions, rollBackOptions, objectName.Split('.')[1], objectName.Split('.')[0]);
                    }
                    #endregion
                    #region SQL_SCALAR_FUNCTION
                    else if (line.Contains("<#SQL_SCALAR_FUNCTION#>"))
                    {
                        objectName = line.Replace("<#SQL_SCALAR_FUNCTION#>", "");

                        AppendTextToFile(createPath, "-- ***********************");
                        AppendTextToFile(createPath, "-- CREATE Script for : " + objectName);
                        AppendTextToFile(createPath, "-- ***********************");

                        AppendTextToFile(rollBackPath, "-- ***********************");
                        AppendTextToFile(rollBackPath, "-- DROP Script for : " + objectName);
                        AppendTextToFile(rollBackPath, "-- ***********************");

                        //Script User Defined Functions
                        ScriptUserDefinedFunctions(myDatabase, createOptions, rollBackOptions, objectName.Split('.')[1], objectName.Split('.')[0]);
                    }
                    #endregion
                    counter++;
                }
                file.Close();
            }
            Success = true;
            ((EzScript.frmScriptOptions)System.Windows.Forms.Application.OpenForms["frmScriptOptions"]).lblScriptingStatus.Text = "Success : Successfully completed scripting.";
            ((EzScript.frmScriptOptions)System.Windows.Forms.Application.OpenForms["frmScriptOptions"]).lblScriptingStatus.Refresh();
        }
        catch (Exception ex)
        {
            Success = false;
            ((EzScript.frmScriptOptions)System.Windows.Forms.Application.OpenForms["frmScriptOptions"]).lblScriptingStatus.Text = "Error : " + ex.Message;
            ((EzScript.frmScriptOptions)System.Windows.Forms.Application.OpenForms["frmScriptOptions"]).lblScriptingStatus.Refresh();
        }
        finally
        {
            if(file !=null)
            file.Dispose();
        }       
        return Success;
    }

    public static void AppendTextToFile(string path, string text)
    {
        // This text is added only once to the file. 
        if (!File.Exists(path))
        {
            // Create a file to write to. 
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(text);
            }
        }
        else
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(text);
            }
        }
    }

    private static void ScriptTables(Database sDatabase, ScriptingOptions cOption, ScriptingOptions rOption, string tableName, string schemaName)
    {
        Table table = sDatabase.Tables[tableName, schemaName];
        table.Script(cOption);
        table.Script(rOption);
    }

    private static void ScriptStoredProcedure(Database sDatabase, ScriptingOptions cOption, ScriptingOptions rOption, string procName, string schemaName)
    {
        StoredProcedure storedProcedure = sDatabase.StoredProcedures[procName, schemaName];
        storedProcedure.Script(cOption);
        storedProcedure.Script(rOption);
    }

    private static void ScriptUserDefinedFunctions(Database sDatabase, ScriptingOptions cOption, ScriptingOptions rOption, string funcName, string schemaName)
    {
        UserDefinedFunction userFunction = sDatabase.UserDefinedFunctions[funcName, schemaName];
        userFunction.Script(cOption);
        userFunction.Script(rOption);
    }

    private static void ScriptTriggers(Database sDatabase, ScriptingOptions cOption, ScriptingOptions rOption, string tableName, string trigName, string schemaName)
    {
        Table table = sDatabase.Tables[tableName, schemaName];
        foreach (Trigger trig in table.Triggers)
        {
            if (trigName == null)
            {
                trig.Script(cOption);
                trig.Script(rOption);
            }
            else if (trigName == trig.Name)
            {
                trig.Script(cOption);
                trig.Script(rOption);
            }
        }
    }
}
