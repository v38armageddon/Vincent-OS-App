using System;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class game
    {
        public game()
        {
            InitializeComponent();
        }

        private void game_Load(object sender, EventArgs e)
        {
            if (bureau.Visible == true)
            {
                bureau.Button22.Visible = true;
            }
            else if (bureau2.Visible == true)
            {
                bureau2.Button22.Visible = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.exewin.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.MazeGame.Show();
        }

        private void game_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (bureau.Visible == true)
            {
                bureau.Button22.Visible = false;
            }
            else if (bureau2.Visible == true)
            {
                bureau2.Button22.Visible = false;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}