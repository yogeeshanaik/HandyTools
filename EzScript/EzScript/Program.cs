using System;
using System.Configuration;
using System.Security.Principal;
using System.Windows.Forms;

namespace EzScript
{
    static class Program
    {
        static bool RunAsAdministrator
        {
            get
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings["RunAsAdministrator"]);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                if (RunAsAdministrator && !IsUserAdministrator())
                    MessageBox.Show("You do not have administrator previllages. Please Run as Administrator.", "Run as Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    Application.Run(new EzScriptForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EzScript", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }
    }
}