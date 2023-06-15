using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class exewin
    {
        public exewin()
        {
            InitializeComponent();
        }

        private void exewin_Load(object sender, EventArgs e)
        {
            if (bureau.Visible == true)
            {
                bureau.Button23.Visible = true;
            }
            else if (bureau2.Visible == true)
            {
                bureau2.Button23.Visible = true;
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
            if (bureau.Visible == true)
            {
                bureau.Button23.Visible = false;
            }
            else if (bureau2.Visible == true)
            {
                bureau2.Button23.Visible = false;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void exécution()
        {
            var uri = TextBox1.Text;
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
                    string path = TextBox1.Text;
                    var process = new Process();
                    process.StartInfo.FileName = path;
                    process.StartInfo.WorkingDirectory = Path.GetDirectoryName(path);
                    process.StartInfo.Arguments = "";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    process.Start();
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