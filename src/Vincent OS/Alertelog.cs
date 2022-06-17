using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Alertelog : Form
    {
        public Alertelog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Bureau bureau = new Bureau();
            Bureau2 bureau2 = new Bureau2();
            Avant avant = new Avant();
            Arrêt arrêt = new Arrêt();
            if (comboBox1.SelectedItem == "Arrêter")
            {
                if (login.Visible == true)
                {
                    login.Hide();
                    arrêt.Show();
                    this.Close();
                }
                else if (bureau.Visible == true)
                {
                    arrêt.Show();
                    bureau.Close();
                    this.Close();
                }
                else if (bureau2.Visible == true)
                {
                    arrêt.Show();
                    bureau2.Close();
                    this.Close();
                }
                else if (avant.Visible == true)
                {
                    avant.Close();
                    this.Close();
                    Application.Exit();
                }
            }
            else if (comboBox1.SelectedItem =="Déconnecter")
            {
                if (login.Visible == true)
                {
                    MessageBox.Show("Vous ne pouvez pas vous déconnecter dans l'écran de connexion.");
                }
                else if (bureau.Visible == true)
                {
                    bureau.Close();
                    login.Show();
                    this.Close();
                }
                else if (bureau2.Visible == true)
                {
                    bureau2.Close();
                    login.Show();
                    this.Close();
                }
                else if (avant.Visible == true)
                {
                    MessageBox.Show("Vous ne pouvez pas vous déconnecter dans les paramètres d'affichages.");
                }
            }
            else if (comboBox1.Text == "Debug.Terminal")
            {
                System.IO.Stream str = Properties.Resources.alertSound;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
                player.Play();
                MessageBox.Show("Vous entrez dans un Terminal, certains commandes et certaines fonctionnalités peuvent ne pas fonctionner comme prévu!", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                System.IO.Stream str = Properties.Resources.errorSound;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
                player.Play();
                MessageBox.Show("ERREUR : Cette option n'est pas reconnu par l'utilitaire des choix de sélections.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
