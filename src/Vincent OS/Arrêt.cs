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
    public partial class Arrêt : Form
    {
        public Arrêt()
        {
            InitializeComponent();
        }

        private void Arrêt_Load(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.shutdownSound;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
            player.Play();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                Démarrage démarrage = new Démarrage();
                Bureau bureau = new Bureau();
                Login login = new Login();
                Bureau2 bureau2 = new Bureau2();
                Alertelog alertelog = new Alertelog();
                Avant avant = new Avant();
                Login2bureau login2Bureau = new Login2bureau();
                Login2bureau2 login2Bureau2 = new Login2bureau2();
                timer1.Stop();
                démarrage.Close();
                bureau.Close();
                login.Close();
                bureau2.Close();
                alertelog.Close();
                avant.Close();
                login2Bureau.Close();
                login2Bureau2.Close();
                Application.Exit();
            }
        }
    }
}
