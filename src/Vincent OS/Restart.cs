using System;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Restart
    {
        public Restart()
        {
            InitializeComponent();
        }

        private void Arrêt_Load(object sender, EventArgs e)
        {
            var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.shutdownSound);
            backmusic.Play();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Increment(2);
            if (ProgressBar1.Value == 100)
            {
                Timer1.Stop();
                ProgressBar1.Value = 0;
                Close();
                Application.Restart();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}