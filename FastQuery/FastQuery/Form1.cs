using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using System.Threading;

namespace ExtractionTool
{
    public partial class Form1 : Form //XCoolForm.XCoolForm
    {         
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Settings settings = new Settings();

        public Form1()
        {
            InitializeComponent();            
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DBHelper DBHelper = new DBHelper();
            SqlConnection con = DBHelper.OpenConnection();

            if (con.State==ConnectionState.Open)
            {
                btnGetList.Enabled = false; btnGetList.Enabled = false;
                pgBar.Value = 0; pgBar.Maximum = 100; 
                label3.Text = "Query executing...";
                if (txtQueryBox.Text != string.Empty)
                {
                    try
                    {
                        for (int i = 0; i < 80; i = i + 5) { System.Threading.Thread.Sleep(100); pgBar.Value = i; }
                        SqlDataAdapter da = new SqlDataAdapter(txtQueryBox.Text.ToString(), con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        pgBar.Value = 100;
                    }
                    catch (Exception ex)
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Error : "+ex.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pgBar.Value = 0;
                    }
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Please select Query.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Cursor = Cursors.Default;
                label3.Text = "Query completed.";
                lblEntireCount.Text = "Count : " + dataGridView1.Rows.Count;
                btnGetList.Enabled = true;
            }
            else
            {
                frmPreferences preferences = new frmPreferences();
                preferences.ShowDialog();
            } btnGetList.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor; btnExport.Enabled = false;
            try
            {
                pgBar.Value = 0; pgBar.Maximum = dataGridView1.RowCount - 1;
                btnExport.Enabled = false; label3.Text = "Plaease Wait..."; label3.ForeColor = Color.Red;

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.ApplicationClass();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                for (i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dataGridView1[j, i];
                        xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                    pgBar.Value = i;
                }

                xlWorkBook.SaveAs(cboQuery.Text + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                btnExport.Enabled = true; label3.Text = "Completes"; label3.ForeColor = Color.Green;
                this.Cursor = Cursors.Default; btnExport.Enabled = true;
                MessageBox.Show("Excel file created , you can find the file in Documents\\" + cboQuery.Text + ".xls");
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default; btnExport.Enabled = true; label3.Text = "Failed to export."; label3.ForeColor = Color.Red;
                MessageBox.Show("Error : " + ex.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pgBar.Value = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] queries=System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + @"\Queries","*.txt");
            foreach (string q in queries)
            {
                string fname = Path.GetFileNameWithoutExtension(q);
                
                cboQuery.Items.Add(fname);
            }
 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            label4.Text = "Query name"; cboQuery.Focus(); cboQuery.Text = string.Empty;
            if (cboQuery.Text != string.Empty)
            {
                File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + @"\Queries\" + cboQuery.Text + ".txt", txtQueryBox.Text);
            }
            else
            {
                MessageBox.Show("Please enter Query name.");
            }
        }

        private void cboQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboQuery.Text != string.Empty)
            {
                string query = File.ReadAllText(System.IO.Directory.GetCurrentDirectory() + @"\Queries\" + cboQuery.Text+".txt");
                txtQueryBox.Text = query;
            }
        }

        private void btnFields_Click(object sender, EventArgs e)
        {
            frmFields FIELDS = new frmFields();
            FIELDS.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPreferences preferences = new frmPreferences();
            preferences.ShowDialog();
        }
    }
}
