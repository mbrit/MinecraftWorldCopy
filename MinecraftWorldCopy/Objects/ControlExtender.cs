using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftWorldCopy
{
    internal static class ControlExtender
    {
        internal static void ReportException(this Control control, Action callback)
        {
            try
            {
                callback();
            }
            catch (Exception ex)
            {
                Alert.ShowWarning(control, ex);
            }
        }
    }
}
