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
using System.Text;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace EzScript.Core
{
    public class ScriptOptions
    {
        bool ansiPadding = true;
        [ReadOnly(false)]
        [Description("Gets or sets a System.Boolean property that specifies whether the generated script contains the Transaction-SQL statements SET ANSI-PADDING ON and SET ANSI-PADDING OFF before and after the CREATE TABLE statements, respectively.")]
        [Category("T-SQL")]
        [DisplayName("ANSI Padding")]
        public bool AnsiPadding
        {
            get { return ansiPadding; }
            set { ansiPadding = value; }
        }

        bool scriptBatchTerminator = true;
        [ReadOnly(false)]
        [Description("Gets or sets the ScriptBatchTerminator property value.")]
        [Category("T-SQL")]
        [DisplayName("Script Batch Terminator")]
        public bool ScriptBatchTerminator
        {
            get { return scriptBatchTerminator; }
            set { scriptBatchTerminator = value; }
        }

        bool driAll = true;
        [ReadOnly(false)]
        [Description("Gets or sets a System.Boolean property value that specifies whether all DRI objects are included in the generated script.")]
        [Category("T-SQL")]
        [DisplayName("Include all DRI")]
        public bool DriAll
        {
            get { return driAll; }
            set { driAll = value; }
        }

        bool toFileOnly = true;
        [ReadOnly(false)]
        [Description("Gets or sets a System.Boolean property value that specifies whether to output to file only or to also generate string output.")]
        [Category("T-SQL")]
        [DisplayName("Output to file only")]
        public bool ToFileOnly
        {
            get { return toFileOnly; }
            set { toFileOnly = value; }
        }

        bool includeDatabaseContext = true;
        [ReadOnly(false)]
        [Description("Gets or sets a System.Boolean property value that specifies whether database content is included in the generated script.")]
        [Category("T-SQL")]
        [DisplayName("Include Database Context")]
        public bool IncludeDatabaseContext
        {
            get { return includeDatabaseContext; }
            set { includeDatabaseContext = value; }
        }

        bool includeIfNotExists = true;
        [ReadOnly(false)]
        [Description("Gets or sets a System.Boolean property value that specifies whether to check the existence of an object before including it in the script.")]
        [Category("T-SQL")]
        [DisplayName("Include If NOT EXISTS")]
        public bool IncludeIfNotExists
        {
            get { return includeIfNotExists; }
            set { includeIfNotExists = value; }
        }

        bool appendToFile = true;
        [ReadOnly(false)]
        [Description("Gets or sets a System.Boolean property value that specifies whether the script is appended to the end of the output file or overwrites it.")]
        [Category("T-SQL")]
        [DisplayName("Append to file")]
        public bool AppendToFile
        {
            get { return appendToFile; }
            set { appendToFile = value; }
        }

        bool ansiFile = true;
        [ReadOnly(false)]
        [Description("Gets or sets a System.Boolean property value that specifies whether the script uses multibyte characters and requires the code page 1252 to evaluate the characters' meaning.")]
        [Category("T-SQL")]
        [DisplayName("ANSI File")]
        public bool AnsiFile
        {
            get { return ansiFile; }
            set { ansiFile = value; }
        }

        bool scriptDrops = true;
        [ReadOnly(false)]
        [Description("Gets or sets a System.Boolean property value that specifies whether the script operation generates a Transaction-SQL script to remove the referenced component.")]
        [Category("T-SQL")]
        [DisplayName("Script Drop")]
        public bool ScriptDrops
        {
            get { return scriptDrops; }
            set { scriptDrops = value; }
        }
        // createOptions.FileName = createPath;   

        private string fileName = System.Configuration.ConfigurationManager.AppSettings["Default_OutputFilePath"];
        [BrowsableAttribute(true)]
        [ReadOnly(false)]
        [Description("Output file path to save generated script")]
        [Category("General")]
        [DisplayName("Script output file path")]
        [EditorAttribute(typeof(SaveFileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

    }

    public class SaveFileNameEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (context == null || context.Instance == null || provider == null)
            {
                return base.EditValue(context, provider, value);
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (value != null)
                {
                    saveFileDialog.FileName = value.ToString();
                }

                saveFileDialog.Title = context.PropertyDescriptor.DisplayName;
                saveFileDialog.Filter = "All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    value = saveFileDialog.FileName;
                }
            }

            return value;
        }
    }
}
