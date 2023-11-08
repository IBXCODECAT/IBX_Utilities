using System.Runtime.InteropServices;

// A native windows alert/Messagebox
/// <see>https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-messagebox</see>

namespace IBX_Utilities.Windows
{
    public static class WindowsAlertBox
    {
        [DllImport("user32.dll")] private static extern IntPtr GetActiveWindow();
        private static IntPtr GetWindowHandle() { return GetActiveWindow(); }

        [DllImport("user32.dll", SetLastError = true)] static extern int MessageBox(IntPtr hwnd, String lpText, String lpCaption, uint uType);

        /// <summary>
        /// Creates a new windows alert box and displays it
        /// </summary>
        /// <param name="title">The window title for the alert box</param>
        /// <param name="content">The content of the alert box</param>
        /// <param name="type">The type of alert box to display</param>
        /// <param name="options">The options on the alert box</param>
        /// <returns>A WindowsAlertResponseCode representing the button the user pressed when closing the alert box</returns>
        public static WindowsAlertResponseCode DisplayAlert(string title, string content, WindowsAlertBoxType type = WindowsAlertBoxType.INFORMATION, WindowsAlertBoxOptions options = WindowsAlertBoxOptions.OK)
        {
            try
            {
                int responseCode = MessageBox(GetWindowHandle(), content, title, (uint)((long)options | (long)type));

                if(Enum.IsDefined(typeof(WindowsAlertResponseCode), responseCode))
                {
                    return (WindowsAlertResponseCode)responseCode;
                }
                else
                {
                    return WindowsAlertResponseCode.NO_RESPONSE;
                }
            }
            catch
            {
                return WindowsAlertResponseCode.NO_RESPONSE;
            }
        }
    }
}