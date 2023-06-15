using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class alertelog
    {
        Bureau bureau = new Bureau();
        Bureau2 bureau2 = new Bureau2();
        Login login = new Login();

        public alertelog()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Arrêt arrêt = new Arrêt();
            switch (ComboBox1.SelectedItem)
            {
                case "Arrêter Vincent OS":
                    if (login.Visible == true)
                    {
                        arrêt.Timer1.Start();
                        login.Close();
                        arrêt.Show();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    else if (bureau.Visible == true)
                    {
                        arrêt.Timer1.Start();
                        arrêt.Show();
                        bureau.Close();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    else if (bureau2.Visible == true)
                    {
                        arrêt.Timer1.Start();
                        arrêt.Show();
                        bureau2.Close();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    return;
                case "Redémarrer Vincent OS":
                    if (login.Visible == true)
                    {
                        Restart restart = new Restart();
                        restart.Timer1.Start();
                        login.Close();
                        restart.Show();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    else if (bureau.Visible == true)
                    {
                        Restart restart = new Restart();
                        restart.Timer1.Start();
                        restart.Show();
                        bureau.Close();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    else if (bureau2.Visible == true)
                    {
                        Restart restart = new Restart();
                        restart.Timer1.Start();
                        restart.Show();
                        bureau2.Close();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    break;
                case "Déconnecter de la session Vincent OS":
                    if (bureau.Visible == true)
                    {
                        bureau.Close();
                        login.Show();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    else if (bureau2.Visible == true)
                    {
                        bureau2.Close();
                        login.Show();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    else if (login.Visible == true)
                    {
                        MessageBox.Show("Vous ne pouvez pas vous déconnecter dans l'écran de connexion.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "Arrêter Windows":
                    var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    Process.Start(psi);
                    break;
                case "Redémarrer Windows":
                    var psi2 = new ProcessStartInfo("shutdown", "/r /t 0");
                    psi2.CreateNoWindow = true;
                    psi2.UseShellExecute = false;
                    Process.Start(psi2);
                    break;
                case "Déconnecter la session Windows":
                    var psi3 = new ProcessStartInfo("shutdown", "/l");
                    psi3.CreateNoWindow = true;
                    psi3.UseShellExecute = false;
                    Process.Start(psi3);
                    break;
                default:
                    var backmusic2 = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                    backmusic2.Play();
                    MessageBox.Show("Erreur : Cette option n'est pas reconnu par l'utilitaire des choix de sélections.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}