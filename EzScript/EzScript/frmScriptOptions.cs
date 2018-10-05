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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EzScript.Core;
using Microsoft.SqlServer.Management.Smo;

namespace EzScript
{
    public partial class frmScriptOptions : Form
    {
        public frmScriptOptions()
        {
            InitializeComponent();
        }

        ScriptOptions objScriptOptions = new ScriptOptions();
        static ServerInfo objServerInfo = null;
        public frmScriptOptions(ServerInfo _objServerInfo)
            : this()
        {
            if (_objServerInfo != null)
            {
                objServerInfo = _objServerInfo;
            }
        }

        private void frmScriptOptions_Load(object sender, EventArgs e)
        {            
            propertyScriptOptions.SelectedObject = objScriptOptions;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            if (SQLScript.GenerateSrcipt(GetScriptingOptions(), objServerInfo))
            {
                if (MessageBox.Show("Script file generated. Do you want to open the file location?", "EzScript", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    OpenFolder(objScriptOptions.FileName); 
                }
                this.Close();
            }
            btnOk.Enabled = true;
        }

        public void OpenFolder(string filePath)
        {
            System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filePath));
        }

        private ScriptingOptions GetScriptingOptions()
        {
            return SetScriptingOptionsFromPropertyGrid();
        }

        private ScriptingOptions SetScriptingOptionsFromPropertyGrid()
        {
            ScriptOptions objScriptOptions = (ScriptOptions)propertyScriptOptions.SelectedObject;
            ScriptingOptions objScriptingOptions = new ScriptingOptions()
                {
                    AnsiPadding = objScriptOptions.AnsiPadding,
                    ScriptBatchTerminator = objScriptOptions.ScriptBatchTerminator,
                    DriAll = objScriptOptions.DriAll,
                    ToFileOnly = objScriptOptions.ToFileOnly,
                    FileName = objScriptOptions.FileName,
                    IncludeDatabaseContext = objScriptOptions.IncludeDatabaseContext,
                    ScriptDrops = objScriptOptions.ScriptDrops,
                    IncludeIfNotExists = objScriptOptions.IncludeIfNotExists,
                    AppendToFile = objScriptOptions.AppendToFile,
                    AnsiFile = objScriptOptions.AnsiFile,
                };
            return objScriptingOptions;
        }
    }
}
