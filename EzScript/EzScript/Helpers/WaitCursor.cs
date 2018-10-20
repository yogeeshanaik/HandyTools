/*
 using (WaitCursor c = new WaitCursor())
{
    await this.PopulateGrid();
}
*/

using System.Windows.Forms;

class WaitCursor : System.IDisposable
{
    object[] Controls;

    public WaitCursor()
    {
        //System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
        Application.UseWaitCursor = true;
    }

    public WaitCursor(params object[] args)
    {
        Application.UseWaitCursor = true;
        try
        {
            Controls = args;
            foreach (var item in Controls)
            {
                Control ctrl = (item as Control);
                if (ctrl.InvokeRequired)
                    ctrl.Invoke(new MethodInvoker(() => { ctrl.Enabled = false; }));
                else ctrl.Enabled = false;
            }
        }
        catch { }
    }

    public void Dispose()
    {
        Application.UseWaitCursor = false;
        try
        {
            foreach (var item in Controls)
            {
                Control ctrl = (item as Control);
                if (ctrl.InvokeRequired)
                    ctrl.Invoke(new MethodInvoker(() => { ctrl.Enabled = true; }));
                else ctrl.Enabled = true;
            }
        }
        catch { }
    }
}