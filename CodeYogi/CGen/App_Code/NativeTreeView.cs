using System;
using System.Runtime.InteropServices;

public class TreeView : System.Windows.Forms.TreeView
{
    [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
    private extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName,
                                            string pszSubIdList);

    protected override void CreateHandle()
    {
        base.CreateHandle();
        SetWindowTheme(this.Handle, "explorer", null);
    }
}

//public class TreeView : System.Windows.Forms.TreeView
//{
//    protected override void OnHandleCreated(EventArgs e)
//    {
//        base.OnHandleCreated(e);

//        if (!this.DesignMode && Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6)
//            ShellControlsExample.NativeMethods.SetWindowTheme(this.Handle, "explorer", null);
//    }
//}