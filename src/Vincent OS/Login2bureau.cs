using System;

namespace Vincent_OS
{
    public partial class Login2bureau
    {
        public Login2bureau()
        {
            InitializeComponent();
        }

        private void Login2bureau_Load(object sender, EventArgs e)
        {
            Timer1.Stop();
            ProgressBar1.Value = 0;
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Increment(3);
            if (ProgressBar1.Value == 100)
            {
                Timer1.Stop();
                ProgressBar1.Value = 0;
                My.MyProject.Forms.Bureau.Show();
                Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}