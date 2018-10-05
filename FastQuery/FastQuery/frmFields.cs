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
using System.Data.SqlClient;

namespace FastQuery
{
    public partial class frmFields : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Settings settings = new Settings();

        public frmFields()
        {
            InitializeComponent();
        }

        #region private methods

        private void LoadTables()
        {
            Global.ServerInfo = SQLHelper.InitializeServerInfo();
            SqlConnection connection = SQLHelper.CreateNewConnection(Global.ServerInfo);

            using (connection)
            {
                cboTables.Items.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT table_name FROM INFORMATION_SCHEMA.COLUMNS", connection);
                DataSet ds = new DataSet();
                da.Fill(ds);               
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cboTables.Items.Add(row[0].ToString());
                }
            }
        }

        private void LoadColumns()
        {
            Global.ServerInfo = SQLHelper.InitializeServerInfo();
            SqlConnection connection = SQLHelper.CreateNewConnection(Global.ServerInfo);
            using (connection)
            {
                lstFields.Items.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME ='" + cboTables.Text + "'", connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    lstFields.Items.Add(row[0].ToString());
                }
            }
        }

        private void ConstructQuery()
        {
            if (lstFields.SelectedItems.Count > 0)
            {
                string QueryBuilder = string.Empty;
                foreach (string itm in lstFields.SelectedItems)
                {
                    string Alias = AddSpacesToSentence(itm, true);
                    Alias = Alias.Substring((int)nudAliasLeftTrim.Value);
                    Alias = Alias.Substring(0, Alias.Length - (int)nudAliasRightTrim.Value);
                    Alias = "AS [" + Alias + "]";

                    if (chkAlias.Checked && chkFormat.Checked)
                    {
                        QueryBuilder += "," + itm + "\t " + Alias + Environment.NewLine + "\t";
                    }
                    else if (chkAlias.Checked)
                    {
                        QueryBuilder += "," + itm + "\t " + Alias + "\t";
                    }
                    else if (chkFormat.Checked)
                    {
                        QueryBuilder += "," + itm + Environment.NewLine + "\t";
                    }
                    else
                    {
                        QueryBuilder += "," + itm;
                    }
                }
                QueryBuilder = QueryBuilder.TrimStart(',');
                QueryBuilder = QueryBuilder.TrimEnd('\t');
                QueryBuilder = Environment.NewLine + " SELECT " + Environment.NewLine + "\t" +
                    QueryBuilder +
                    " FROM " + Environment.NewLine + "\t" +
                    cboTables.Text + " (NOLOCK)";
                ((frmMain)Application.OpenForms["frmMain"]).rtbQueryBox.Text += QueryBuilder;
            }
            else
            {
                MessageBox.Show("Field(s) not selected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string AddSpacesToSentence(string text, bool preserveAcronyms)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;
            StringBuilder newText = new StringBuilder(text.Length * 2);
            newText.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                    if ((text[i - 1] != ' ' && !char.IsUpper(text[i - 1])) ||
                        (preserveAcronyms && char.IsUpper(text[i - 1]) &&
                         i < text.Length - 1 && !char.IsUpper(text[i + 1])))
                        newText.Append(' ');
                newText.Append(text[i]);
            }
            return newText.ToString();
        }

        #endregion

        private void frmFields_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void cboTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadColumns();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ConstructQuery();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Alias =  AddSpacesToSentence(lstFields.SelectedItem.ToString(), true);
                Alias = Alias.Substring((int)nudAliasLeftTrim.Value);
                Alias = Alias.Substring(0, Alias.Length - (int)nudAliasRightTrim.Value);
                rtbPreview.Text = Alias;
            }
            catch { }
        }

        private void rtbPreview_Click(object sender, EventArgs e)
        {
            lblPreview.Text = "Cursor position " + (rtbPreview.SelectionStart);
        }
    }
}
