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
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button22.Visible = true;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button22.Visible = true;
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

        private void Button4_Click(object sender, EventArgs e)
        {
            // Si aucun jeu n'est détecté, commenter
            // Store.Show()
            var errorsound = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
            errorsound.Play();
            MessageBox.Show("ERREUR : Aucun jeu supplémentaire n'as été détecté sur le Store.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void game_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button22.Visible = false;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button22.Visible = false;
            }
        }
    }
}