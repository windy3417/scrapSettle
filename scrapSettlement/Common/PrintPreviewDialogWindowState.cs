using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ScrapSettlement.Common
{
    class PrintPreviewDialogWindowState
    {
        public static void MakePrintPreviewDialogMaximized(PrintPreviewDialog ppd)
        {
            System.Reflection.PropertyInfo[] pis = ppd.GetType().GetProperties();
            for (int i = 0; i < pis.Length; i++)
            {
                if (pis[i].Name == "WindowState")
                {
                    pis[i].SetValue(ppd, FormWindowState.Maximized, null);
                    break;
                }
            }
        }
    }
}
