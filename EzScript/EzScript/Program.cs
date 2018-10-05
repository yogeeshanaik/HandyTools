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
using System.Linq;
using System.Windows.Forms;
using System.Security.Principal;

namespace EzScript
{
    static class Program
    {
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
                if (!Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["RunAsAdministrator"]))
                    Application.Run(new frmEzScript());
                else
                {
                    if (IsUserAdministrator())
                        Application.Run(new frmEzScript());
                    else
                        MessageBox.Show("You do not have administrator previllages. Please Run as Administrator.", "Run as Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                Application.Run(new frmEzScript());
            }
        }

        public static bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException ex)
            {
                isAdmin = false;
            }
            catch (Exception ex)
            {
                isAdmin = false;
            }
            return isAdmin;
        }
    }
}
