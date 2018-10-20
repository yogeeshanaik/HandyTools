using EzScript.Core.Models;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.IO;

public class SQLScript
{
    public static bool GenerateSrcipt(ScriptingOptions scriptingOptions, ServerInfo serverInfo, List<SqlObject> sqlObjects, bool singleFilePerObject = false)
    {
        bool Success = false;
        try
        {
            Server myServer = new Server(serverInfo.Server);
            myServer.ConnectionContext.ConnectionString = SQLHelper.CreateNewConnection(serverInfo).ConnectionString;
            myServer.ConnectionContext.Connect();

            if (myServer.ConnectionContext.IsOpen)
            {
                Database myDatabase = myServer.Databases[serverInfo.Database];

                Scripter scripter = new Scripter(myServer);

                ScriptingOptions createOptions = scriptingOptions;
                ScriptingOptions rollBackOptions = scriptingOptions.CloneObject() as ScriptingOptions;
                rollBackOptions.ScriptDrops = true;

                string rootDirectory = Path.GetDirectoryName(createOptions.FileName);

                string rollbackFileName = string.Format("{0}_Rollback{1}", Path.GetFileNameWithoutExtension(scriptingOptions.FileName), Path.GetExtension(scriptingOptions.FileName));
                rollBackOptions.FileName = Path.Combine(rootDirectory, rollbackFileName);

                int counter = 0;
                foreach (var sqlObject in sqlObjects)
                {
                    if (singleFilePerObject)
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
                    ((EzScript.ScriptOptionsForm)System.Windows.Forms.Application.OpenForms["frmScriptOptions"]).lblScriptingStatus.Text =
                        "Scripting : (" + (counter + 1) + "/" + sqlObjects.Count + ") " + sqlObject.ToString();
                    ((EzScript.ScriptOptionsForm)System.Windows.Forms.Application.OpenForms["frmScriptOptions"]).lblScriptingStatus.Refresh();
                    // Console.WriteLine("Scripting : " + line);

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
                            ScriptTables(myDatabase, createOptions, rollBackOptions, sqlObject.Name, sqlObject.Schema);
                            ScriptTriggers(myDatabase, createOptions, rollBackOptions, sqlObject.Name, null, sqlObject.Schema);
                            break;

                        case "USER_TABLE":
                            ScriptTables(myDatabase, createOptions, rollBackOptions, sqlObject.Name, sqlObject.Schema);
                            break;

                        case "SQL_TRIGGER":
                            ScriptTriggers(myDatabase, createOptions, rollBackOptions, sqlObject.Name, sqlObject.Name,
                                         sqlObject.Schema);
                            break;

                        case "SQL_STORED_PROCEDURE":
                            ScriptStoredProcedure(myDatabase, createOptions, rollBackOptions, sqlObject.Name, sqlObject.Schema);
                            break;

                        case "SQL_TABLE_VALUED_FUNCTION":
                            ScriptUserDefinedFunctions(myDatabase, createOptions, rollBackOptions, sqlObject.Name, sqlObject.Schema);
                            break;

                        case "SQL_SCALAR_FUNCTION":
                            ScriptUserDefinedFunctions(myDatabase, createOptions, rollBackOptions, sqlObject.Name, sqlObject.Schema);
                            break;

                        default:
                            break;
                    }

                    counter++;
                }
            }
            Success = true;
            ((EzScript.ScriptOptionsForm)System.Windows.Forms.Application.OpenForms["frmScriptOptions"]).lblScriptingStatus.Text = "Success : Successfully completed scripting.";
            ((EzScript.ScriptOptionsForm)System.Windows.Forms.Application.OpenForms["frmScriptOptions"]).lblScriptingStatus.Refresh();
        }
        catch (Exception ex)
        {
            Success = false;
            ((EzScript.ScriptOptionsForm)System.Windows.Forms.Application.OpenForms["frmScriptOptions"]).lblScriptingStatus.Text = "Error : " + ex.Message;
            ((EzScript.ScriptOptionsForm)System.Windows.Forms.Application.OpenForms["frmScriptOptions"]).lblScriptingStatus.Refresh();
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

    public static void ScriptTables(Database sDatabase, ScriptingOptions cOption, ScriptingOptions rOption, string tableName, string schemaName)
    {
        Table table = sDatabase.Tables[tableName, schemaName];
        table.Script(cOption);
        table.Script(rOption);
    }

    public static void ScriptStoredProcedure(Database sDatabase, ScriptingOptions cOption, ScriptingOptions rOption, string procName, string schemaName)
    {
        StoredProcedure storedProcedure = sDatabase.StoredProcedures[procName, schemaName];
        storedProcedure.Script(cOption);
        storedProcedure.Script(rOption);
    }

    public static void ScriptUserDefinedFunctions(Database sDatabase, ScriptingOptions cOption, ScriptingOptions rOption, string funcName, string schemaName)
    {
        UserDefinedFunction userFunction = sDatabase.UserDefinedFunctions[funcName, schemaName];
        userFunction.Script(cOption);
        userFunction.Script(rOption);
    }

    public static void ScriptTriggers(Database sDatabase, ScriptingOptions cOption, ScriptingOptions rOption, string tableName, string trigName, string schemaName)
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