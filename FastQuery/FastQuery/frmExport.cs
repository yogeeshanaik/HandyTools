using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FastQuery;

namespace FastQuery
{
    public partial class frmExport : Form
    {
        public frmExport()
        {
            InitializeComponent();
            Panel objPanel = ((frmMain)Application.OpenForms["frmMain"]).pnlDataGridView;
            // Bind DataSource to export DataGridView
            GetAllControls(objPanel);    
        }

        private List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {
                if (c is DataGridView) { list.Add(c); dataGridView1.DataSource = ((DataGridView)c).DataSource; break; }
                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
            }

            return list;
        }

        private List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }

        #region Export
        private void btnBlueNoCond_Click(object sender, EventArgs e)
        {
            string mode = rCsv.Checked ? "CSV" : "XLS";
            List<MyExcelExport.ColumnConditions> conds =
                new List<MyExcelExport.ColumnConditions>();
            MyExcelExport.ColumnConditions curr = null;

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 2;
            curr.Cond = MyExcelExport.Conditon.CurrencyEuro4;            
            conds.Add(curr);

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 3;
            curr.Cond = MyExcelExport.Conditon.Percentage;
            curr.Alignment = MyExcelExport.Align.Left;
            conds.Add(curr);

            List<MyExcelExport.ColumnRowConditon> rowConds = new List<MyExcelExport.ColumnRowConditon>();
            MyExcelExport.ColumnRowConditon cond = new MyExcelExport.ColumnRowConditon();
            cond.Column = 1;
            cond.ConditionValue = "Total";
            rowConds.Add(cond);
            try
            {
                MyExcelExport.GenericFormattedExcel2003Export gExp =
                    new MyExcelExport.GenericFormattedExcel2003Export(mode, dataGridView1,
                        MyExcelExport.Theme.BlueSky, conds, rowConds, null);                        

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBluCondition_Click(object sender, EventArgs e)
        {
            string mode = rCsv.Checked ? "CSV" : "XLS";
            List<MyExcelExport.ColumnConditions> conds =
                new List<MyExcelExport.ColumnConditions>();
            MyExcelExport.ColumnConditions curr = null;

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 2;
            curr.Cond = MyExcelExport.Conditon.CurrencyEuro;
            conds.Add(curr);

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 3;
            curr.Cond = MyExcelExport.Conditon.Percentage;
            conds.Add(curr);

            List<MyExcelExport.ColumnRowConditon> rowConds = new List<MyExcelExport.ColumnRowConditon>();
            MyExcelExport.ColumnRowConditon row = new MyExcelExport.ColumnRowConditon();
            row.Column = 1;
            row.ConditionValue = "Total";
            rowConds.Add(row);

            try
            {
                MyExcelExport.GenericFormattedExcel2003Export gExp =
                    new MyExcelExport.GenericFormattedExcel2003Export(mode, dataGridView1,
                        MyExcelExport.Theme.ClassicGray, conds, rowConds, null);

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            try
            {
                MyExcelExport.GenericFormattedExcel2003Export gExp =
                    new MyExcelExport.GenericFormattedExcel2003Export("CSV",
                        dataGridView1, MyExcelExport.Theme.CSV, null, null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGrayNoCond_Click(object sender, EventArgs e)
        {
            string mode = rCsv.Checked ? "CSV" : "XLS";
            List<MyExcelExport.ColumnConditions> conds =
                new List<MyExcelExport.ColumnConditions>();
            MyExcelExport.ColumnConditions curr = null;

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 2;
            curr.Cond = MyExcelExport.Conditon.CurrencyEuro;
            conds.Add(curr);

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 3;
            curr.Cond = MyExcelExport.Conditon.Percentage;
            conds.Add(curr);

            List<MyExcelExport.ColumnRowConditon> rowConds = new List<MyExcelExport.ColumnRowConditon>();
            MyExcelExport.ColumnRowConditon row = new MyExcelExport.ColumnRowConditon();
            row.Column = 1;
            row.ConditionValue = "Total";
            rowConds.Add(row);
            
            try
            {
                MyExcelExport.GenericFormattedExcel2003Export gExp =
                    new MyExcelExport.GenericFormattedExcel2003Export(mode, dataGridView1,
                        MyExcelExport.Theme.GreenIsGood, conds, rowConds, null);

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGrayCond_Click(object sender, EventArgs e)
        {
            string mode = rCsv.Checked ? "CSV" : "XLS";
            List<MyExcelExport.ColumnConditions> conds =
                 new List<MyExcelExport.ColumnConditions>();
            MyExcelExport.ColumnConditions curr = null;

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 2;
            curr.Cond = MyExcelExport.Conditon.CurrencyEuro;
            conds.Add(curr);

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 3;
            curr.Cond = MyExcelExport.Conditon.Percentage;
            conds.Add(curr);

            List<MyExcelExport.ColumnRowConditon> rowConds = new List<MyExcelExport.ColumnRowConditon>();
            MyExcelExport.ColumnRowConditon row = new MyExcelExport.ColumnRowConditon();
            row.Column = 1;
            row.ConditionValue = "Total";
            rowConds.Add(row);

            try
            {
                MyExcelExport.GenericFormattedExcel2003Export gExp =
                    new MyExcelExport.GenericFormattedExcel2003Export(mode, dataGridView1,
                        MyExcelExport.Theme.NiceViolet, conds, rowConds, null);

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            string mode = rCsv.Checked ? "CSV" : "XLS";
            List<MyExcelExport.ColumnConditions> conds =
                new List<MyExcelExport.ColumnConditions>();
            MyExcelExport.ColumnConditions curr = null;

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 2;
            curr.Cond = MyExcelExport.Conditon.CurrencyEuro;
            conds.Add(curr);

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 3;
            curr.Cond = MyExcelExport.Conditon.Percentage;
            conds.Add(curr);

            List<MyExcelExport.ColumnRowConditon> rowConds = new List<MyExcelExport.ColumnRowConditon>();
            MyExcelExport.ColumnRowConditon row = new MyExcelExport.ColumnRowConditon();
            row.Column = 1;
            row.ConditionValue = "Total";
            rowConds.Add(row);

            try
            {
                MyExcelExport.GenericFormattedExcel2003Export gExp =
                    new MyExcelExport.GenericFormattedExcel2003Export(mode, dataGridView1,
                        MyExcelExport.Theme.OrangeWorks, conds, rowConds, null);

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mode = rCsv.Checked ? "CSV" : "XLS";
            List<MyExcelExport.ColumnConditions> conds =
                new List<MyExcelExport.ColumnConditions>();
            MyExcelExport.ColumnConditions curr = null;

            //no need to specify alignment
            //only if you wish/needed. It defaults to MyExcelExport.Align.None
            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 2;
            curr.Cond = MyExcelExport.Conditon.CurrencyEuro;
            conds.Add(curr);

            //specify Alignment
            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 3;
            curr.Cond = MyExcelExport.Conditon.Percentage;
            curr.Alignment = MyExcelExport.Align.Right;
            conds.Add(curr);

            List<MyExcelExport.ColumnRowConditon> rowConds = new List<MyExcelExport.ColumnRowConditon>();
            MyExcelExport.ColumnRowConditon row = new MyExcelExport.ColumnRowConditon();
            row.Column = 1;
            row.ConditionValue = "Total";
            rowConds.Add(row);

            try
            {
                MyExcelExport.GenericFormattedExcel2003Export gExp =
                    new MyExcelExport.GenericFormattedExcel2003Export(mode, dataGridView1,
                        MyExcelExport.Theme.SweetPink, conds, rowConds, null);

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mode = rCsv.Checked ? "CSV" : "XLS";
            List<MyExcelExport.ColumnConditions> conds =
                new List<MyExcelExport.ColumnConditions>();
            MyExcelExport.ColumnConditions curr = null;

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 2;
            curr.Cond = MyExcelExport.Conditon.CurrencyEuro;
            conds.Add(curr);

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 3;
            curr.Cond = MyExcelExport.Conditon.Percentage;
            conds.Add(curr);

            List<MyExcelExport.ColumnRowConditon> rowConds = new List<MyExcelExport.ColumnRowConditon>();
            MyExcelExport.ColumnRowConditon row = new MyExcelExport.ColumnRowConditon();
            row.Column = 1;
            row.ConditionValue = "Total";
            rowConds.Add(row);

            try
            {
                MyExcelExport.GenericFormattedExcel2003Export gExp =
                    new MyExcelExport.GenericFormattedExcel2003Export(mode, dataGridView1,
                        MyExcelExport.Theme.LadyInRed, conds, rowConds, null);

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mode = rCsv.Checked ? "CSV" : "XLS";
            List<MyExcelExport.ColumnConditions> conds =
                new List<MyExcelExport.ColumnConditions>();
            MyExcelExport.ColumnConditions curr = null;

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 2;
            curr.Cond = MyExcelExport.Conditon.CurrencyEuro;
            conds.Add(curr);

            curr = new MyExcelExport.ColumnConditions();
            curr.Column = 3;
            curr.Cond = MyExcelExport.Conditon.Percentage;
            conds.Add(curr);

            List<MyExcelExport.ColumnRowConditon> rowConds = new List<MyExcelExport.ColumnRowConditon>();
            MyExcelExport.ColumnRowConditon row = new MyExcelExport.ColumnRowConditon();
            row.Column = 1;
            row.ConditionValue = "Total";
            rowConds.Add(row);

            try
            {
                MyExcelExport.GenericFormattedExcel2003Export gExp =
                    new MyExcelExport.GenericFormattedExcel2003Export(mode, dataGridView1,
                        MyExcelExport.Theme.DarkBlue, conds, rowConds, null);

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
    }
}