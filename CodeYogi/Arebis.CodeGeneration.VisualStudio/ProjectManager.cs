using System;
using System.Collections.Generic;
using System.Text;

namespace Arebis.CodeGeneration.VisualStudio
{
    public class ProjectManager
    {
        public EnvDTE.DTE dte { get; set; }
        public ProjectManager()
        {
            System.Type type = System.Type.GetTypeFromProgID("VisualStudio.DTE.11.0");
            Object obj = System.Activator.CreateInstance(type, true);
            dte = (EnvDTE.DTE)obj;
            dte.MainWindow.Visible = false; // optional if you want to See VS doing its thing
        }


        public void CreateSolutionFile(string solutionDirectory, string solutionName)
        {
            // create a new solution
            dte.Solution.Create(solutionDirectory, solutionName);
            // save and quit
            dte.ExecuteCommand("File.SaveAll");
        }

        public void CreateProjectFile(string templatePath, string projectDirectory, string projectName)
        {
            var solution = dte.Solution;

            solution.AddFromTemplate(templatePath, projectDirectory, projectName);
            // save and quit
            dte.ExecuteCommand("File.SaveAll");
        }
    }
}
