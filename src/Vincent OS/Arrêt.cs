using System;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Arrêt
    {
        public Arrêt()
        {
            InitializeComponent();
        }

        private void Arrêt_Load(object sender, EventArgs e)
        {
            var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.shutdownSound);
            backmusic.Play();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Increment(2);
            if (ProgressBar1.Value == 100)
            {
                Timer1.Stop();
                My.MyProject.Forms.Démarrage.Close();
                My.MyProject.Forms.Bureau.Close();
                My.MyProject.Forms.Login.Close();
                My.MyProject.Forms.Bureau2.Close();
                My.MyProject.Forms.alertelog.Close();
                My.MyProject.Forms.Avant.Close();
                My.MyProject.Forms.Login2bureau.Close();
                My.MyProject.Forms.Login2bureau2.Close();
                Close();
                Application.Exit();
            }
        }
    }
}