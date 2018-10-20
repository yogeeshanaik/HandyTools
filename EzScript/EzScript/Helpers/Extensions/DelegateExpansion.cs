using System;
using System.ComponentModel;
using System.Windows.Forms;

public static class DelegateExpansion
{
    // Prevent CrossThreadException by invoking delegate through target control's thread.
    public static object CrossInvoke(this Delegate delgt, object sender, EventArgs e)
    {
        if (delgt.Target is Control && ((Control)delgt.Target).InvokeRequired)
        {
            return ((Control)delgt.Target).Invoke(delgt, new object[] { sender, e });
        }
        return delgt.Method.Invoke(delgt.Target, new object[] { sender, e });
    }

    /// <summary> How to use?
    /// private void SetText(string text)
    //{
    //    textBox1.SynchronizedInvoke(() => textBox1.Text = text);
    //}
    /// </summary>
    /// <param name="sync"></param>
    /// <param name="action"></param>
    public static void SynchronizedInvoke(this ISynchronizeInvoke sync, Action action)
    {
        // If the invoke is not required, then invoke here and get out.
        if (!sync.InvokeRequired)
        {
            // Execute action.
            action();

            // Get out.
            return;
        }

        // Marshal to the required context.
        sync.Invoke(action, new object[] { });
    }
}