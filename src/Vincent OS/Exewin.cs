using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class exewin
    {
        private Process executeur = new Process();

        public exewin()
        {
            InitializeComponent();
        }

        private void exewin_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button23.Visible = true;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button23.Visible = true;
            }
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            exécution();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar((int)Keys.Enter))
            {
                exécution();
            }
        }

        private void exewin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button23.Visible = false;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button23.Visible = false;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void exécution()
        {
            executeur.StartInfo.FileName = TextBox1.Text;
            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                var alertsound = new System.Media.SoundPlayer(My.Resources.Resources.alertSound);
                alertsound.Play();
                MessageBox.Show("ALERTE : Vous n'avez rentré aucune destination.", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (TextBox1.Text.Contains(".exe")) // Regarde si le fichier est un fichier exécutable
            {
                if ((object)false is Exception)
                {
                    executeur.Start();
                }
                else if ((object)true is Exception)
                {
                    var errorsound = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                    errorsound.Play();
                    MessageBox.Show("ERREUR : Le fichier exécutable que vous souhaitez est introuvable.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var errorsound = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                errorsound.Play();
                MessageBox.Show("ERREUR : Le fichier exécutable que vous souhaitez est introuvable.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}