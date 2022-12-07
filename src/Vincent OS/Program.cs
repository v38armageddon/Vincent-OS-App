using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vincent_OS.Units.Tests;

namespace Vincent_OS
{
    internal static class Program
    {
        [STAThread]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Valider la compatibilité de la plateforme", Justification = "<En attente>")]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            RegistryKey rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", false);
            string shell = "Shell";
            Object o = rk.GetValue(shell);
            if ((string)o == "explorer.exe")
            {
                Application.Run(new Démarrage());
            }
            else if ((string)o == "C:\\Program Files\\WindowsApps\\34823v38armageddon.VincentOSApp_10.0.0.0_x86__ysx05jt3gv6z0\\Vincent OS\\Vincent OS.exe")
            {
                Application.Run(new Bureau());
            }
            else if ((string)o == "C:\\Program Files (x86)\\Vincent OS App\\Vincent OS.exe")
            {
                Application.Run(new Bureau());
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
            AppCenter.Start("TOKEN",
                  typeof(Analytics), typeof(Crashes));
            // Hérité de Avant.cs
            My.MyProject.Forms.Custom.RadioButton2.Checked = true;
        }
    }
}
