using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// TraceListener debugListener = new MyTraceListener (theTextBox);
/// Debug.Listeners.Add(debugListener);
/// Trace.Listeners.Add(debugListener);
/// Remember to Trace/Debug.Listeners.Remove(debugListener); when you don't need it anymore.
/// </summary>
public class ControlTraceListener : TraceListener
{
    TextBoxBase output;

    public ControlTraceListener(TextBoxBase output)
    {
        this.Name = "Trace";
        this.output = output;
    }

    public override void Write(string message)
    {
        Action append = delegate ()
        {
            output.AppendText(string.Format("[{0}] ", DateTime.Now.ToString()));
            output.AppendText(message);
            output.AppendText(Environment.NewLine);
        };

        if (output.InvokeRequired)
        {
            output.BeginInvoke(append);
        }
        else
        {
            append();
        }
    }

    public override void WriteLine(string message)
    {
        Write(message + Environment.NewLine);
    }

    public override void Write(string message, string category)
    {
        Action append = delegate ()
        {
            Color color = Color.Black;
            if (category.ToUpper().Equals("ERROR"))
                color = Color.Maroon;
            else if (category.ToUpper().Equals("WARNING"))
                color = Color.LimeGreen;
            output.AppendText(string.Format("[{0}] ", DateTime.Now.ToString()));
            (output as RichTextBox).AppendText(message, color);
        };

        if (output.InvokeRequired)
        {
            output.BeginInvoke(append);
        }
        else
        {
            append();
        }
    }

    public override void WriteLine(string message, string category)
    {
        Write(message + Environment.NewLine, category);
    }
}