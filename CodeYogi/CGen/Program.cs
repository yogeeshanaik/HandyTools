using Arebis.CodeGeneration.VisualStudio;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Linq;

namespace CodeYogi
{
    //[System.Diagnostics.DebuggerStepThrough]
    public class Program
    {
        public static NameValueCollection settings = new NameValueCollection();

        [STAThread]
        public static void Main(string[] args)
        {
            //new ProjectManager().CreateSolutionFile(@"C:\Users\Yogi\Desktop\Temp","TestSolution");


            //new ProjectManager().CreateProjectFile(@"C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\ProjectTemplatesCache\CSharp\Windows\1033\WindowsApplication\csWindowsApplication.vstemplate", @"C:\Users\Yogi\Desktop\Temp\Project\", "TestProject");

            /*
            DatabaseCatalogReader.SqlTable cat = new DatabaseCatalogReader.SqlTable();
            foreach (DatabaseCatalogReader.SqlTable table in cat.GetSqlTables())
            {

                //string primaryKey = string.Empty;

                //var _field = table.GetFields().ToList().Where(s => s.IsPrimaryKey == true).FirstOrDefault();

                //if (_field != null)
                //    primaryKey = _field.Name;

                foreach (DatabaseCatalogReader.TableField field in table.GetFields())
                {

                    switch (field.Type.ToString())
                    {
                        case "BigInt":
                        case "Int":



                            if (field.IsForiegnKey && field.ReferencedTable.Length > 0)
                            {
                                var referencedTable = new DatabaseCatalogReader.ReferencedTable(field.ReferencedTable, table.ConnectionString).GetSqlTable();
                                var referencedTableFields = referencedTable.GetFields();
                                foreach (DatabaseCatalogReader.TableField field1 in referencedTableFields)
                                {
                                }
                            }
                            break;
                        default: break;
                    }
                }
            }
            //*/
            //System.AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;

            new Xml_Editor.TemplateManager().ShowDialog();
            //new frmExplorer().ShowDialog();
            return;
        }

        public static void Run(string[] args)
        {
            CommandLineInfo cmdlineinfo = new CommandLineInfo(args);
            settings = new NameValueCollection();

            // Show help if requested:
            if (cmdlineinfo.IsHelpRequested)
            {
                string help = CodeYogi.Properties.Resources.HelpText;
                help = help.Replace("{executable}", Assembly.GetEntryAssembly().GetName().Name);
                help = help.Replace("{copyright}", ((AssemblyCopyrightAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false)[0]).Copyright);
                Console.WriteLine(help);
                Environment.Exit(0);
            }

            // Load settings from file (if any):
            if (cmdlineinfo.Arguments.Count > 0)
            {
                try
                {
                    XmlDocument settingsfile = new XmlDocument();
                    settingsfile.Load(cmdlineinfo.Arguments[0]);
                    foreach (XmlNode node in settingsfile.SelectNodes(@"/settings/add"))
                    {
                        settings.Add(node.Attributes["name"].Value, node.Attributes["value"].Value);
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.Error.WriteLine("Settings file '{0}' not found.", cmdlineinfo.Arguments[0]);
                    Environment.Exit(1);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Error reading file '{0}': {1}", cmdlineinfo.Arguments[0], ex.Message);
                    Environment.Exit(1);
                }
            }

            // Add settings from commandline:
            foreach (KeyValuePair<string, string> setting in cmdlineinfo.Settings)
            {
                settings.Remove(setting.Key);
                foreach (string value in setting.Value.Split(';'))
                {
                    settings.Add(setting.Key, value);
                }
            }

            // Add exe directory to referencepath:
            settings.Add("referencepath", new FileInfo(Assembly.GetEntryAssembly().Location).Directory.FullName);

            // Check template is given:
            if (settings["template"] == null)
            {
                Console.WriteLine("No template given. Try /? for help.");
                Environment.Exit(0);
            }

            // Create a generator instance and execute the initial template:
            Generator generator = new Generator();
            generator.Settings = settings;
            generator.TemplateParameters = new object[0];
            int exitcode = generator.ExecuteTemplate();

            // Exit generator:
            //Environment.Exit(exitcode);
        }

        public static void CreateProjectFile()
        {
            ProjectManager projManager = new ProjectManager();

            projManager.CreateSolutionFile(@"C:\CodeYogi\", "CodeYogi");
            projManager.CreateProjectFile(@"C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\ProjectTemplatesCache\CSharp\Windows\1033\WindowsApplication\csWindowsApplication.vstemplate",
                @"C:\CodeYogi\WinFormsApp", "WinFormsApp");
        }

        private static void CreateProjectFile1()
        {
            System.Type type = System.Type.GetTypeFromProgID("VisualStudio.DTE.11.0");
            Object obj = System.Activator.CreateInstance(type, true);
            EnvDTE.DTE dte = (EnvDTE.DTE)obj;
            dte.MainWindow.Visible = true; // optional if you want to See VS doing its thing

            // create a new solution
            dte.Solution.Create(@"C:\NewSolution\", "NewSolution");
            var solution = dte.Solution;

            // create a C# WinForms app
            solution.AddFromTemplate(@"C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\ProjectTemplatesCache\CSharp\Windows\1033\WindowsApplication\csWindowsApplication.vstemplate",
                @"C:\NewSolution\WinFormsApp", "WinFormsApp");

            // create a C# class library
            solution.AddFromTemplate(@"C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\ProjectTemplatesCache\CSharp\Windows\1033\ClassLibrary\csClassLibrary.vstemplate",
                @"C:\NewSolution\ClassLibrary", "ClassLibrary");

            // save and quit
            dte.ExecuteCommand("File.SaveAll");
            dte.Quit();
        }

        private static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}