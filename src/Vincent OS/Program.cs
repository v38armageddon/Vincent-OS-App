using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vincent_OS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppCenter.Start("0c52f0f9-8169-4918-a2a3-2641062645d0",
                  typeof(Analytics), typeof(Crashes));
            Application.Run(new Avant());
        }
    }
}
