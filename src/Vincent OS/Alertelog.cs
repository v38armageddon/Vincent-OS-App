using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

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
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ComboBox1.SelectedItem, "Arrêter", false)))
            {
                if (My.MyProject.Forms.Login.Visible == true)
                {
                    My.MyProject.Forms.Arrêt.Timer1.Start();
                    My.MyProject.Forms.Login.Hide();
                    My.MyProject.Forms.Arrêt.Show();
                    Close();
                }
                else if (My.MyProject.Forms.Avant.Visible == true)
                {
                    My.MyProject.Forms.Avant.Close();
                    Close();
                    Application.Exit();
                }
                else if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Arrêt.Timer1.Start();
                    My.MyProject.Forms.Arrêt.Show();
                    My.MyProject.Forms.Bureau.Hide();
                    Close();
                }
                else if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Arrêt.Timer1.Start();
                    My.MyProject.Forms.Arrêt.Show();
                    My.MyProject.Forms.Bureau2.Hide();
                    Close();
                }
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ComboBox1.SelectedItem, "Déconnecter", false)))
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Close();
                    My.MyProject.Forms.Login.Show();
                    Close();
                }
                else if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Close();
                    My.MyProject.Forms.Login.Show();
                    Close();
                }
                else if (My.MyProject.Forms.Login.Visible == true)
                {
                    MessageBox.Show("Vous ne pouvez pas vous déconnecter dans l'écran de connexion.");
                }
                else if (My.MyProject.Forms.Avant.Visible == true)
                {
                    MessageBox.Show("Vous ne pouvez pas vous déconnecter dans les paramètres d'affichages.");
                }
            }
            else if (ComboBox1.Text == "Debug.Terminal")
            {
                var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.alertSound);
                backmusic.Play();
                MessageBox.Show("Vous entrez dans un Terminal, certains commandes et certaines fonctionnalités peuvent ne pas fonctionner comme prévu !", "Alerte");
                My.MyProject.Forms.Terminal.Show();
            }
            else
            {
                var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                backmusic.Play();
                MessageBox.Show("Erreur : Cette option n'est pas reconnu par l'utilitaire des choix de sélections.", "Erreur");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}