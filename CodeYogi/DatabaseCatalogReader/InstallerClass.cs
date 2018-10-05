using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;

using System.IO;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace DatabaseCatalogReader
{
	/// <summary>
	/// Summary description for InstallerClass.
	/// </summary>
	[RunInstaller(true)]
	public class InstallerClass : System.Configuration.Install.Installer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public InstallerClass()
		{
			// This call is required by the Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion


        string source = "DatabaseCatalogReader.Install";
        string subKey = @"SOFTWARE\Microsoft\.NETFramework\AssemblyFolders\DatabaseCatalogReader";
        //string interopAssembly = "Interop.oledb32.dll";

        protected override void OnAfterInstall(IDictionary savedState)
        {
            base.OnAfterInstall (savedState);

            StringBuilder sb = new StringBuilder();

            string assemblyName = this.Context.Parameters["assemblypath"];

            // add the assemblies to the 'Add References' dialog box.
            RegistryKey hklm = Registry.LocalMachine;
            using(hklm)
            {
                RegistryKey key = hklm.CreateSubKey(this.subKey);
                using(key) 
                {
                    string directory = Path.GetDirectoryName(assemblyName);
                    key.SetValue("", directory);
                    sb.AppendFormat("{0}={1}\n", this.subKey, directory);
               }
            }

            EventLog.WriteEntry(source, sb.ToString());

        }
        protected override void OnBeforeUninstall(IDictionary savedState)
        {
            base.OnBeforeUninstall (savedState);

            StringBuilder sb = new StringBuilder();


            // remove the assemblies from the 'Add References' dialog box.
            RegistryKey hklm = Registry.LocalMachine;
            using(hklm)
            {
                hklm.DeleteSubKey(this.subKey);
                sb.AppendFormat("RegKey deleted: {0}", this.subKey);
            }

            EventLog.WriteEntry(source, sb.ToString());
        }

	}
}
