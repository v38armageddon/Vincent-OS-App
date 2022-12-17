using System;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class TaskVOS
    {
        WPF.Bing_Chrome bingChrome = new WPF.Bing_Chrome();

        public TaskVOS()
        {
            InitializeComponent();
        }

        private void TaskVOS_Load(object sender, EventArgs e)
        {
            // Application
            if (bingChrome.Visibility == System.Windows.Visibility.Visible)
            {
                panel1.Visible = true;
            }
            if (My.MyProject.Forms.Calc.Visible == true)
            {
                panel2.Visible = true;
            }
            if (My.MyProject.Forms.exewin.Visible == true)
            {
                panel4.Visible = true;
            }
            if (My.MyProject.Forms.game.Visible == true)
            {
                panel5.Visible = true;
            }
            if (My.MyProject.Forms.meme.Visible == true)
            {
                panel8.Visible = true;
            }
            if (My.MyProject.Forms.Notepad.Visible == true)
            {
                panel9.Visible = true;
            }
            if (My.MyProject.Forms.MazeGame.Visible == true)
            {
                panel6.Visible = true;
            }
            if (My.MyProject.Forms.Media.Visible == true)
            {
                panel7.Visible = true;
            }
            if (My.MyProject.Forms.paints.Visible == true)
            {
                panel10.Visible = true;
            }
            if (My.MyProject.Forms.Terminal.Visible == true)
            {
                panel12.Visible = true;
            }
            if (My.MyProject.Forms.Visio.Visible == true)
            {
                panel13.Visible = true;
            }

            // Service

            if (My.MyProject.Forms.Applications.Visible == true)
            {
                panel14.Visible = true;
            }
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                panel15.Visible = true;
            }
            if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                panel16.Visible = true;
            }
            if (My.MyProject.Forms.Paramètres.Visible == true)
            {
                panel17.Visible = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                bingChrome.Close();
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
            else
            {
                var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                backmusic.Play();
                MessageBox.Show("Erreur : Vous n'avez sélectionné aucune application à arrêter.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
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