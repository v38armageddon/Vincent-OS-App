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
                Close();
                Application.Exit();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}