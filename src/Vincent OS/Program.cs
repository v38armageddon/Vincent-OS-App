using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Vincent_OS
{
    internal static class Program
    {
        static Custom custom = new Custom();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            // On check l'entrée de la clé "Shell" pour démarrer soit sur l'écran de démarrage, soit sur le bureau du superutilisateur
            RegistryKey rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", false);
            string shell = "Shell";
            Object o = rk.GetValue(shell);
            var main1 = new Démarrage();
            var main2 = new Bureau();
            if ((string)o == "explorer.exe")
            {
                main1.FormClosed += new FormClosedEventHandler(FormClosed);
                main1.Show();
                Application.Run();
                custom.radioButton3.Checked = true;
            }
            else if ((string)o == "C:\\Program Files\\WindowsApps\\34823v38armageddon.VincentOSApp_10.1.0.0_x64__ysx05jt3gv6z0\\Vincent OS\\Vincent OS.exe")
            {
                AdminRelauncher();
                main2.FormClosed += new FormClosedEventHandler(FormClosed);
                main2.Show();
                Application.Run();
                custom.radioButton4.Checked = true;
            }
            else if ((string)o == "C:\\Program Files\\Vincent OS App\\Vincent OS.exe")
            {
                AdminRelauncher();
                main2.FormClosed += new FormClosedEventHandler(FormClosed);
                main2.Show();
                Application.Run();
                custom.radioButton4.Checked = true;
            }
            else
            {
                main1.FormClosed += new FormClosedEventHandler(FormClosed);
                main1.Show();
                Application.Run();
                // L'utilisateur sous un autre OS ne peut pas accéder au Shell, bah oui, c'est réservé à Windows ces trucs.
                custom.TabControl1.TabPages.Remove(custom.TabPage4);
            }
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
                GC.Collect();
            }
            else
            {
                Application.OpenForms[0].FormClosed += FormClosed;
                GC.Collect();
            }
                
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
