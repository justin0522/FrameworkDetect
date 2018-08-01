namespace Campari.Software.InteropServices
{
    #region namespace references
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.Win32.SafeHandles;
    using System.ComponentModel;
    using System.IO;
    #endregion

    #region class SafeNativeMethods
    internal static class SafeNativeMethods
    {
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int GetSystemMetrics(SystemMetric smIndex);
    }
    #endregion
}
