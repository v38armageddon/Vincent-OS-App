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
            Bureau bureau = new Bureau();
            Bureau2 bureau2 = new Bureau2();
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
            exewin exewin = new exewin();
            exewin.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MazeGame mazeGame = new MazeGame();
            mazeGame.Show();
        }

        private void game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Bureau bureau = new Bureau();
            Bureau2 bureau2 = new Bureau2();
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