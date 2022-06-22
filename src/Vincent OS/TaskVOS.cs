using System;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class TaskVOS
    {
        public TaskVOS()
        {
            InitializeComponent();
        }

        private void TaskVOS_Load(object sender, EventArgs e)
        {
            // ' Application
            if (My.MyProject.Forms.Bing_Chrome.Visible == true)
            {
                PictureBox1.Visible = true;
                RadioButton2.Visible = true;
            }
            if (My.MyProject.Forms.Calc.Visible == true)
            {
                PictureBox2.Visible = true;
                RadioButton12.Visible = true;
            }
            if (My.MyProject.Forms.chrono.Visible == true)
            {
                PictureBox3.Visible = true;
                RadioButton20.Visible = true;
            }
            if (My.MyProject.Forms.exewin.Visible == true)
            {
                PictureBox4.Visible = true;
                RadioButton10.Visible = true;
            }
            if (My.MyProject.Forms.game.Visible == true)
            {
                PictureBox5.Visible = true;
                RadioButton8.Visible = true;
            }
            if (My.MyProject.Forms.meme.Visible == true)
            {
                PictureBox8.Visible = true;
                RadioButton3.Visible = true;
            }
            if (My.MyProject.Forms.Notepad.Visible == true)
            {
                PictureBox9.Visible = true;
                RadioButton4.Visible = true;
            }
            if (My.MyProject.Forms.MazeGame.Visible == true)
            {
                PictureBox6.Visible = true;
                RadioButton9.Visible = true;
            }
            if (My.MyProject.Forms.Media.Visible == true)
            {
                PictureBox7.Visible = true;
                RadioButton5.Visible = true;
            }
            if (My.MyProject.Forms.paints.Visible == true)
            {
                PictureBox10.Visible = true;
                RadioButton7.Visible = true;
            }
            if (My.MyProject.Forms.Store.Visible == true)
            {
                PictureBox11.Visible = true;
                RadioButton19.Visible = true;
            }
            if (My.MyProject.Forms.Terminal.Visible == true)
            {
                PictureBox13.Visible = true;
                RadioButton11.Visible = true;
            }
            if (My.MyProject.Forms.Visio.Visible == true)
            {
                PictureBox14.Visible = true;
                RadioButton6.Visible = true;
            }

            // ' Service

            if (My.MyProject.Forms.Applications.Visible == true)
            {
                PictureBox15.Visible = true;
                RadioButton15.Visible = true;
            }
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                PictureBox16.Visible = true;
                RadioButton13.Visible = true;
                PictureBox19.Visible = true;
                RadioButton17.Visible = true;
            }
            if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                PictureBox17.Visible = true;
                RadioButton14.Visible = true;
                PictureBox20.Visible = true;
                RadioButton18.Visible = true;
            }
            if (My.MyProject.Forms.Paramètres.Visible == true)
            {
                PictureBox18.Visible = true;
                RadioButton16.Visible = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                My.MyProject.Forms.Bing_Chrome.Close();
            }
            else if (RadioButton3.Checked == true)
            {
                My.MyProject.Forms.meme.Close();
            }
            else if (RadioButton4.Checked == true)
            {
                My.MyProject.Forms.Notepad.Close();
            }
            else if (RadioButton5.Checked == true)
            {
                My.MyProject.Forms.Media.Close();
            }
            else if (RadioButton6.Checked == true)
            {
                My.MyProject.Forms.Visio.Close();
            }
            else if (RadioButton7.Checked == true)
            {
                My.MyProject.Forms.paints.Close();
            }
            else if (RadioButton8.Checked == true)
            {
                My.MyProject.Forms.game.Close();
            }
            else if (RadioButton9.Checked == true)
            {
                My.MyProject.Forms.MazeGame.Close();
            }
            else if (RadioButton10.Checked == true)
            {
                My.MyProject.Forms.exewin.Close();
            }
            else if (RadioButton11.Checked == true)
            {
                My.MyProject.Forms.Terminal.Close();
            }
            else if (RadioButton12.Checked == true)
            {
                My.MyProject.Forms.Calc.Close();
            }
            else if (RadioButton19.Checked == true)
            {
                My.MyProject.Forms.Store.Close();
            }
            else if (RadioButton20.Checked == true)
            {
                My.MyProject.Forms.chrono.Close();
            }
            else
            {
                var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                backmusic.Play();
                MessageBox.Show("Erreur : Vous n'avez sélectionné aucune application à arrêter.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (RadioButton17.Checked == true)
            {
                My.MyProject.Forms.Bureau.Close();
                My.MyProject.Forms.Login.Show();
                Close();
            }
            else if (RadioButton18.Checked == true)
            {
                My.MyProject.Forms.Bureau2.Close();
                My.MyProject.Forms.Login.Show();
                Close();
            }
            else
            {
                var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                backmusic.Play();
                MessageBox.Show("Erreur : Vous avez sélectionné aucun utilisateur à arrêter.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (RadioButton13.Checked == true)
            {
                My.MyProject.Forms.Bureau.Close();
            }
            else if (RadioButton14.Checked == true)
            {
                My.MyProject.Forms.Bureau2.Close();
            }
            else if (RadioButton15.Checked == true)
            {
                My.MyProject.Forms.Applications.Close();
            }
            else if (RadioButton16.Checked == true)
            {
                My.MyProject.Forms.Paramètres.Close();
            }
            else
            {
                var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                backmusic.Play();
                MessageBox.Show("Erreur : Vous avez sélectionné aucun service à arrêter.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}