using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vincent_OS
{
    internal static class Program
    {
        static Custom custom = new Custom();

        [STAThread]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Valider la compatibilité de la plateforme", Justification = "<En attente>")]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            // On check l'entrée de la clé "Shell" pour démarrer soit sur l'écran de démarrage, soit sur le bureau du superutilisateur
            RegistryKey rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", false);
            string shell = "Shell";
            Object o = rk.GetValue(shell);
            if ((string)o == "explorer.exe")
            {
                Application.Run(new Démarrage());
                custom.radioButton3.Checked = true;
            }
            else if ((string)o == "C:\\Program Files\\WindowsApps\\34823v38armageddon.VincentOSApp_10.0.0.0_x64__ysx05jt3gv6z0\\Vincent OS\\Vincent OS.exe")
            {
                AdminRelauncher();
                Application.Run(new Bureau());
                custom.radioButton4.Checked = true;
            }
            else if ((string)o == "C:\\Program Files (x86)\\Vincent OS App\\Vincent OS.exe")
            {
                AdminRelauncher();
                Application.Run(new Bureau());
                custom.radioButton4.Checked = true;
            }
            else
            {
                Application.Run(new Démarrage());
                // L'utilisateur sous un autre OS ne peut pas accéder au Shell, bah oui, c'est réservé à Windows ces trucs.
                custom.TabControl1.TabPages.Remove(custom.TabPage4);
            }
            AppCenter.Start("TOKEN",
                  typeof(Analytics), typeof(Crashes));
            // Hérité de Avant.cs
            My.MyProject.Forms.Custom.RadioButton2.Checked = true;
        }

        private static void AdminRelauncher()
        {
            if (!IsRunAsAdmin())
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.WorkingDirectory = Environment.CurrentDirectory;
                proc.FileName = Assembly.GetEntryAssembly().Location;

                proc.Verb = "runas";

                try
                {
                    Process.Start(proc);
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("This program must be run as an administrator! \n\n" + ex.ToString());
                }
            }
        }

        private static bool IsRunAsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
