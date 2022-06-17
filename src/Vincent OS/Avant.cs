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
    public partial class Avant : Form
    {
        public Avant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Démarrage démarrage = new Démarrage();
            démarrage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arrêt arrêt = new Arrêt();
            Bureau bureau = new Bureau();
            Bureau2 bureau2 = new Bureau2();
            Démarrage démarrage = new Démarrage();
            Login login = new Login();
            Login2bureau login2Bureau = new Login2bureau();
            Login2bureau2 login2Bureau2 = new Login2bureau2();
            démarrage.Show();
            if (démarrage.Visible == true)
            {
                // On change de mode de forme de la fenêtre
                démarrage.FormBorderStyle = FormBorderStyle.None;
                arrêt.FormBorderStyle = FormBorderStyle.None;
                login.FormBorderStyle = FormBorderStyle.None;
                login2Bureau.FormBorderStyle = FormBorderStyle.None;
                login2Bureau2.FormBorderStyle = FormBorderStyle.None;
                bureau.FormBorderStyle = FormBorderStyle.None;
                bureau2.FormBorderStyle = FormBorderStyle.None;
                // On met une nouvelle localisation
                bureau.Width = Screen.PrimaryScreen.Bounds.Width;
                bureau.Height = Screen.PrimaryScreen.Bounds.Height;
                bureau2.Width = Screen.PrimaryScreen.Bounds.Width;
                bureau2.Height = Screen.PrimaryScreen.Bounds.Height;
                arrêt.Width = Screen.PrimaryScreen.Bounds.Width;
                arrêt.Height = Screen.PrimaryScreen.Bounds.Height;
                démarrage.Width = Screen.PrimaryScreen.Bounds.Width;
                démarrage.Height = Screen.PrimaryScreen.Bounds.Height;
                login.Width = Screen.PrimaryScreen.Bounds.Width;
                login.Height = Screen.PrimaryScreen.Bounds.Height;
                login2Bureau.Width = Screen.PrimaryScreen.Bounds.Width;
                login2Bureau.Height = Screen.PrimaryScreen.Bounds.Height;
                login2Bureau2.Width = Screen.PrimaryScreen.Bounds.Width;
                login2Bureau2.Height = Screen.PrimaryScreen.Bounds.Height;
            }
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alertelog alertelog = new Alertelog();
            alertelog.Show();
        }
    }
}
