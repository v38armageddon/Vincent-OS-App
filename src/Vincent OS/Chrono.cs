using System;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class chrono
    {
        public chrono()
        {
            InitializeComponent();
        }

        private void chrono_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button18.Visible = true;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button18.Visible = true;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Timer1.Stop();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Timer1.Stop();
            ProgressBar1.Value = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Increment(2);
            if (ProgressBar1.Value == 100)
            {
                ProgressBar1.Value = 0;
            }
        }

        private void chrono_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button18.Visible = false;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button18.Visible = true;
            }
        }
    }
}