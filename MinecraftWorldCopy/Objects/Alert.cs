using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftWorldCopy
{
    internal static class Alert
    {
        private const string Caption = "Minecraft World Copy";

        internal static void ShowWarning(IWin32Window owner, Exception ex)
        {
            ShowWarning(owner, string.Format("An error occurred.\r\n{0}", ex));
        }

        internal static void ShowWarning(IWin32Window owner, string message)
        {
            MessageBox.Show(owner, message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        internal static void ShowInfo(IWin32Window owner, string message)
        {
            MessageBox.Show(owner, message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
