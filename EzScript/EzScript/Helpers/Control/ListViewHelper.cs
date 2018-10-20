using System.Data;
using System.Windows.Forms;

public class ListViewHelper
{
    // Load Data from the DataTable into the ListView
    public void LoadList(ListView control, DataTable data)
    {
        int fc = data.Columns.Count;

        control.Columns.Clear();
        control.Items.Clear();

        foreach (DataColumn c in data.Columns)
        {
            //adding names of columns as Listview columns
            ColumnHeader h = new ColumnHeader();
            h.Text = c.ColumnName;
            control.Columns.Add(h);
        }

        string[] str = new string[data.Columns.Count];
        foreach (DataRow rr in data.Rows)
        {
            for (int col = 0; col <= data.Columns.Count - 1; col++)
            {
                str[col] = rr[col].ToString();
            }
            ListViewItem ii;
            ii = new ListViewItem(str);
            control.Items.Add(ii);
        }

        // Best fit column headers
        control.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        control.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }
}

public static class ListViewExtensions
{
    public static void Bind(this ListView control, DataTable data)
    {
        new ListViewHelper().LoadList(control, data);
    }
}