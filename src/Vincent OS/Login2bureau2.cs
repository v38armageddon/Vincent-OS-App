using System;

namespace Vincent_OS
{
    public partial class Login2bureau2
    {
        public Login2bureau2()
        {
            InitializeComponent();
        }

        private void Login2bureau2_Load(object sender, EventArgs e)
        {
            Timer1.Stop();
            ProgressBar1.Value = 0;
            Timer1.Start();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Increment(3);
            if (ProgressBar1.Value == 100)
            {
                Timer1.Stop();
                ProgressBar1.Value = 0;
                My.MyProject.Forms.Bureau2.Show();
                Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}