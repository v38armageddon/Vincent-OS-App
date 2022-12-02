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
    }
}