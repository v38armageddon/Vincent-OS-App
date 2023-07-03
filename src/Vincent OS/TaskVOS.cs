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
            Bureau bureau = new Bureau();
            Bureau bureau2 = new Bureau();
            WPF.Bing_Chrome bingChrome = new WPF.Bing_Chrome();
            WPF.Media media = new WPF.Media();
            Applications applications = new Applications();
            Calc calc = new Calc();
            exewin exewin = new exewin();
            game game = new game();
            MazeGame MazeGame = new MazeGame();
            Meme meme = new Meme();
            Notepad Notepad = new Notepad();
            Paramètres Paramètres = new Paramètres();
            Paints paints = new Paints();
            Terminal Terminal = new Terminal();
            Visio Visio = new Visio();
            #region Application
            if (bingChrome.Visibility == System.Windows.Visibility.Visible)
            {
                panel1.Visible = true;
            }
            if (calc.Visible == true)
            {
                panel2.Visible = true;
            }
            if (exewin.Visible == true)
            {
                panel4.Visible = true;
            }
            if (game.Visible == true)
            {
                panel5.Visible = true;
            }
            if (meme.Visible == true)
            {
                panel8.Visible = true;
            }
            if (Notepad.Visible == true)
            {
                panel9.Visible = true;
            }
            if (MazeGame.Visible == true)
            {
                panel6.Visible = true;
            }
            if (media.Visibility == System.Windows.Visibility.Visible)
            {
                panel7.Visible = true;
            }
            if (paints.Visible == true)
            {
                panel10.Visible = true;
            }
            if (Terminal.Visible == true)
            {
                panel12.Visible = true;
            }
            if (Visio.Visible == true)
            {
                panel13.Visible = true;
            }
            #endregion
            #region Services

            if (applications.Visible == true)
            {
                panel14.Visible = true;
            }
            if (bureau.Visible == true)
            {
                panel15.Visible = true;
            }
            if (bureau2.Visible == true)
            {
                panel16.Visible = true;
            }
            if (Paramètres.Visible == true)
            {
                panel17.Visible = true;
            }
            #endregion
            #region Session

            if (bureau.Visible == true)
            {
                PictureBox19.Visible = true;
                RadioButton17.Visible = true;
            }
            if (bureau2.Visible == true)
            {
                PictureBox20.Visible = true;
                RadioButton18.Visible = true;
            }
            #endregion
        }

        #region Applications
        private void Button1_Click(object sender, EventArgs e)
        {
            WPF.Bing_Chrome bingChrome = new WPF.Bing_Chrome();
            WPF.Media media = new WPF.Media();
            exewin exewin = new exewin();
            game game = new game();
            MazeGame MazeGame = new MazeGame();
            Meme meme = new Meme();
            Notepad Notepad = new Notepad();
            Paints paints = new Paints();
            Terminal Terminal = new Terminal();
            Visio Visio = new Visio();
            if (RadioButton2.Checked == true)
            {
                bingChrome.Close();
            }
            else if (RadioButton3.Checked == true)
            {
                meme.Close();
            }
            else if (RadioButton4.Checked == true)
            {
                Notepad.Close();
            }
            else if (RadioButton5.Checked == true)
            {
                media.Close();
            }
            else if (RadioButton6.Checked == true)
            {
                Visio.Close();
            }
            else if (RadioButton7.Checked == true)
            {
                paints.Close();
            }
            else if (RadioButton8.Checked == true)
            {
                game.Close();
            }
            else if (RadioButton9.Checked == true)
            {
                MazeGame.Close();
            }
            else if (RadioButton10.Checked == true)
            {
                exewin.Close();
            }
            else if (RadioButton11.Checked == true)
            {
                Terminal.Close();
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
        #endregion
        #region Session
        private void Button2_Click(object sender, EventArgs e)
        {
            Bureau bureau = new Bureau();
            Bureau bureau2 = new Bureau();
            Login login = new Login();
            if (RadioButton17.Checked == true)
            {
                bureau.Close();
                login.Show();
                Close();
            }
            else if (RadioButton18.Checked == true)
            {
                bureau2.Close();
                login.Show();
                Close();
            }
            else
            {
                var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                backmusic.Play();
                MessageBox.Show("Erreur : Vous avez sélectionné aucun utilisateur à arrêter.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Services
        private void Button3_Click(object sender, EventArgs e)
        {
            Bureau bureau = new Bureau();
            Bureau bureau2 = new Bureau();
            Applications applications = new Applications();
            Paramètres Paramètres = new Paramètres();
            if (RadioButton13.Checked == true)
            {
                bureau.Close();
            }
            else if (RadioButton14.Checked == true)
            {
                bureau2.Close();
            }
            else if (RadioButton15.Checked == true)
            {
                applications.Close();
            }
            else if (RadioButton16.Checked == true)
            {
                Paramètres.Close();
            }
            else
            {
                var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                backmusic.Play();
                MessageBox.Show("Erreur : Vous avez sélectionné aucun service à arrêter.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}