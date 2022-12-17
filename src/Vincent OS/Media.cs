using System;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Media
    {
        public Media()
        {
            InitializeComponent();
        }

        private void Media_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button19.Visible = true;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button19.Visible = true;
            }
            WPF.Media media = new WPF.Media();
            media.Show();
        }

        private void ArrêterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AxWindowsMediaPlayer3.URL = "";
        }

        private void PleinÉcranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(AxWindowsMediaPlayer3.URL))
            //{
            //    var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
            //    backmusic.Play();
            //    MessageBox.Show("Veuillez d'abord lancer un média...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    AxWindowsMediaPlayer3.fullScreen = true;
            //}
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AxWindowsMediaPlayer3.ShowPropertyPages();
        }

        private void MusiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog2.Filter = "Musique|*.mp3;*.wav;*.midi;*.wma";
            OpenFileDialog2.RestoreDirectory = true;
            if (OpenFileDialog2.ShowDialog() == DialogResult.OK)
            {
                //AxWindowsMediaPlayer3.URL = OpenFileDialog2.FileName;
            }
        }

        private void VidéoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog2.Filter = "Vidéos|*.mp4;*.mkv;*.wmv;*.avi";
            OpenFileDialog2.RestoreDirectory = true;
            if (OpenFileDialog2.ShowDialog() == DialogResult.OK)
            {
                //AxWindowsMediaPlayer3.URL = OpenFileDialog2.FileName;
            }
        }

        private void Media_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button19.Visible = false;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button19.Visible = false;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}