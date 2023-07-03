using System;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class UAC
    {
        public UAC()
        {
            InitializeComponent();
        }
        // /!\ Vérification du mot de passe /!\
        private void verifylog()
        {
            Bureau2 bureau2 = new Bureau2();
            if (TextBox1.Text == "Vincent OS")
            {
                TextBox1.Text = "";
                // /!\ Faire attention aux potentiels changements dans le futur ! /!\
                if (bureau2.Panel1.Visible == true)
                {
                    Paramètres paramètres = new Paramètres();
                    paramètres.Show();
                    Close();
                }
            }
            else
            {
                var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                backmusic.Play();
                MessageBox.Show("ERREUR : Le mot de passe est incorrecte.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            verifylog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar((int)Keys.Enter))
            {
                verifylog();
            }
        }

        private void UAC_Load(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
        }
    }
}