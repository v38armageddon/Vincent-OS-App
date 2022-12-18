using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Windows.System;

namespace Vincent_OS
{
    public partial class alertelog
    {
        public alertelog()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            switch (ComboBox1.SelectedItem)
            {
                case "Arrêter Vincent OS":
                    if (My.MyProject.Forms.Login.Visible == true)
                    {
                        My.MyProject.Forms.Arrêt.Timer1.Start();
                        My.MyProject.Forms.Login.Close();
                        My.MyProject.Forms.Arrêt.Show();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    else if (My.MyProject.Forms.Bureau.Visible == true)
                    {
                        My.MyProject.Forms.Arrêt.Timer1.Start();
                        My.MyProject.Forms.Arrêt.Show();
                        My.MyProject.Forms.Bureau.Close();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    else if (My.MyProject.Forms.Bureau2.Visible == true)
                    {
                        My.MyProject.Forms.Arrêt.Timer1.Start();
                        My.MyProject.Forms.Arrêt.Show();
                        My.MyProject.Forms.Bureau2.Close();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    break;
                case "Redémarrer Vincent OS":
                    if (My.MyProject.Forms.Login.Visible == true)
                    {
                        Restart restart = new Restart();
                        restart.Timer1.Start();
                        My.MyProject.Forms.Login.Close();
                        restart.Show();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    else if (My.MyProject.Forms.Bureau.Visible == true)
                    {
                        Restart restart = new Restart();
                        restart.Timer1.Start();
                        restart.Show();
                        My.MyProject.Forms.Bureau.Close();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    else if (My.MyProject.Forms.Bureau2.Visible == true)
                    {
                        Restart restart = new Restart();
                        restart.Timer1.Start();
                        restart.Show();
                        My.MyProject.Forms.Bureau2.Close();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    break;
                case "Déconnecter de la session Vincent OS":
                    if (My.MyProject.Forms.Bureau.Visible == true)
                    {
                        My.MyProject.Forms.Bureau.Close();
                        My.MyProject.Forms.Login.Show();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    else if (My.MyProject.Forms.Bureau2.Visible == true)
                    {
                        My.MyProject.Forms.Bureau2.Close();
                        My.MyProject.Forms.Login.Show();
                        Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    else if (My.MyProject.Forms.Login.Visible == true)
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