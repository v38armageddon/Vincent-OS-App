using System;

namespace Vincent_OS
{
    public partial class About
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            var uri = "https://gist.github.com/v38armageddon/6b40e2d71b3262b8d9f4985622d88e18";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri,
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void PictureBox1_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var i = 0;
            i += 1;
            if (i == 5)
            {
                var backmusic = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");
                backmusic.Play();
            }
            if (i == 10)
            {
                var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.startingSound);
                backmusic.Play();
            }
        }
    }
}