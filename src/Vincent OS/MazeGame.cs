using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class MazeGame
    {
        public MazeGame()
        {
            InitializeComponent();
            MoveToStart();
        }

        /// <summary>
        /// Move the mouse pointer to a point 20 pixels down and to the right
        /// of the starting point in the upper-left corner of the maze.
        /// </summary>
        /// <remarks></remarks>
        private void MoveToStart()
        {
            var startingPoint = Panel1.Location;
            startingPoint.Offset(20, 20);
            Cursor.Position = PointToScreen(startingPoint);
        }
        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Félicitation ! Vous avez réussi le labyrinth !");
            Close();
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void MazeGame_Load(object sender, EventArgs e)
        {
            PictureBox1.BackColor = Color.Transparent;
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ArmaAntiCheat();
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            ArmaAntiCheat();
        }

        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            ArmaAntiCheat();
        }

        private void PictureBox4_MouseEnter(object sender, EventArgs e)
        {
            ArmaAntiCheat();
        }

        private void ArmaAntiCheat()
        {
            MoveToStart();
            MessageBox.Show("Tricher, c'est mal.");
        }

        private void MazeGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}