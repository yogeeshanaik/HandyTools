using Microsoft.Win32;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace DatabaseCatalogReader
{
    /// <summary>
    /// Summary description for Installer.
    /// </summary>
    [RunInstaller(true)]
    public class Installer : System.Configuration.Install.Installer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Installer()
        {
            // This call is required by the Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        }

        #endregion Component Designer generated code

        private string source = "DatabaseCatalogReader.Install";
        private string subKey = @"SOFTWARE\Microsoft\.NETFramework\AssemblyFolders\DatabaseCatalogReader";
        private string interopAssembly = "Interop.oledb32.dll";

        protected override void OnAfterInstall(IDictionary savedState)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string assemblyName = this.Context.Parameters["assemblypath"];
                int result = InstallAssembly(assemblyName);
                if (result != 0)
                {
                    sb.AppendFormat("Failed to install assembly: {0}", assemblyName);
                    Rollback(savedState);
                    return;
                }

                sb.AppendFormat("Assembly installed: {0}\n", assemblyName);

                assemblyName = Path.GetDirectoryName(assemblyName);
                assemblyName = Path.Combine(assemblyName, this.interopAssembly);
                result = InstallAssembly(assemblyName);
                if (result != 0)
                {
                    sb.AppendFormat("Failed to install assembly: {0}", assemblyName);
                    UninstallAssembly(this.Context.Parameters["assemblypath"]);
                    Rollback(savedState);
                    return;
                }
                sb.AppendFormat("Assembly installed: {0}\n", assemblyName);

                // add the assemblies to the 'Add References' dialog box.
                RegistryKey hklm = Registry.LocalMachine;
                using (hklm)
                {
                    RegistryKey key = hklm.CreateSubKey(this.subKey);
                    using (key)
                    {
                        string directory = Path.GetDirectoryName(assemblyName);
                        key.SetValue("", directory);
                        sb.AppendFormat("{0}={1}\n", this.subKey, directory);
                    }
                }
            }
            finally
            {
                string msg = sb.ToString();
                this.Context.LogMessage(msg);
                EventLog.WriteEntry(source, msg);

                base.OnAfterInstall(savedState);
            }
        }

        public override void Uninstall(IDictionary savedState)
        {
            //base.OnBeforeUninstall (savedState);

            StringBuilder sb = new StringBuilder();

            string assemblyName = this.Context.Parameters["assemblypath"];
            int result = UninstallAssembly(assemblyName);
            if (result != 0)
                sb.AppendFormat("Failed to remove assembly: {0}\n", assemblyName);
            else
                sb.AppendFormat("Assembly removed: {0}\n", assemblyName);

            assemblyName = Path.GetDirectoryName(assemblyName);
            assemblyName = Path.Combine(assemblyName, this.interopAssembly);
            result = UninstallAssembly(assemblyName);
            if (result != 0)
                sb.AppendFormat("Failed to remove assembly: {0}\n", assemblyName);
            else
                sb.AppendFormat("Assembly removed: {0}\n", assemblyName);

            // remove the assemblies from the 'Add References' dialog box.
            RegistryKey hklm = Registry.LocalMachine;
            using (hklm)
            {
                hklm.DeleteSubKey(this.subKey);
                sb.AppendFormat("RegKey deleted: {0}", this.subKey);
            }

            string msg = sb.ToString();
            this.Context.LogMessage(msg);
            EventLog.WriteEntry(source, msg);

            base.Uninstall(savedState);
        }

        #region GAC install

        [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("e707dcde-d1cd-11d2-bab9-00c04f8eceae")]
        internal interface IAssemblyCache
        {
            [PreserveSig()]
            int UninstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pvReserved, out uint pulDisposition);

            [PreserveSig()]
            int QueryAssemblyInfo(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pAsmInfo);

            [PreserveSig()]
            int CreateAssemblyCacheItem(uint dwFlags, IntPtr pvReserved, out /*IAssemblyCacheItem*/IntPtr ppAsmItem, [MarshalAs(UnmanagedType.LPWStr)] String pszAssemblyName);

            [PreserveSig()]
            int CreateAssemblyScavenger(out object ppAsmScavenger);

            [PreserveSig()]
            int InstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszManifestFilePath, IntPtr pvReserved);
        }// IAssemblyCache

        [DllImport("Fusion.dll", CharSet = CharSet.Auto)]
        internal static extern int CreateAssemblyCache(out IAssemblyCache ppAsmCache, uint dwReserved);

        static internal int InstallAssembly(string assembly)
        {
            IAssemblyCache gac = null;
            int hr = CreateAssemblyCache(out gac, 0);
            return (hr != 0) ? hr : gac.InstallAssembly(0, assembly, (IntPtr)0);
        }

        static internal int UninstallAssembly(string assembly)
        {
            assembly = System.Reflection.Assembly.LoadFrom(Path.GetFullPath(assembly)).FullName;
            uint n;
            IAssemblyCache gac = null;
            int hr = CreateAssemblyCache(out gac, 0);
            return (hr != 0) ? hr : gac.UninstallAssembly(0, assembly, (IntPtr)0, out n);
        }

        #endregion GAC install
    }
}