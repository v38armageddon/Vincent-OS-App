using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Applications
    {
        private Process execute = new Process();

        public Applications()
        {
            InitializeComponent();
        }

        private void Applications_Load(object sender, EventArgs e)
        {
            if (Button11.Visible == true | Button12.Visible == true | Button13.Visible == true | Button14.Visible == true | Button15.Visible == true)
            {
                Label1.Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Bing_Chrome.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Notepad.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.meme.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Media.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Visio.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.exewin.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.paints.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.game.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Terminal.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Store.Show();
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.UAC.Text = "Bureau2.SerVOS a besoin de votre autorisation !";
                My.MyProject.Forms.UAC.Show();
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Calc.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.chrono.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if ((object)true is Exception)
            {
                var errorsound = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                errorsound.Play();
                MessageBox.Show("ERREUR : Cette application n'existe pas, il se peut qu'il se situe dans un autre emplacement que prévu, dans ce cas Vincent OS ne prends pas en charge l'exécution du fichier, si tel est le cas, veuillez signaler cette erreur.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((object)false is Exception)
            {
                // /!\ Bien regarder si des changements de versions ont lieu pour mettre à jour la localisation du fichier ! /!\
                Process.Start(@"C:\Users\%Username%\AppData\Local\Discord\app-1.0.9005\Discord.exe");
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if ((object)true is Exception)
            {
                var errorsound = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                errorsound.Play();
                MessageBox.Show("ERREUR : Cette application n'existe pas, il se peut qu'il se situe dans un autre emplacement que prévu, dans ce cas Vincent OS ne prends pas en charge l'exécution du fichier, si tel est le cas, veuillez signaler cette erreur.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start("firefox.exe");
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if ((object)true is Exception)
            {
                var errorsound = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                errorsound.Play();
                MessageBox.Show("ERREUR : Cette application n'existe pas, il se peut qu'il se situe dans un autre emplacement que prévu, dans ce cas Vincent OS ne prends pas en charge l'exécution du fichier, si tel est le cas, veuillez signaler cette erreur.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start("chrome.exe");
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if ((object)true is Exception)
            {
                var errorsound = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                errorsound.Play();
                MessageBox.Show("ERREUR : Cette application n'existe pas, il se peut qu'il se situe dans un autre emplacement que prévu, dans ce cas Vincent OS ne prends pas en charge l'exécution du fichier, si tel est le cas, veuillez signaler cette erreur.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(@"C:\Program Files (x86)\Steam\Steam.exe");
            }
        }
    }
}