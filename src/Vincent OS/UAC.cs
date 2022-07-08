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
        // (!) Vérification du mot de passe (!)
        private void verifylog()
        {
            if (TextBox1.Text == "Vincent OS")
            {
                TextBox1.Text = "";
                // /!\ Faire attention aux potentiels changements dans le futur ! /!\
                if (My.MyProject.Forms.Applications.Visible == true)
                {
                    My.MyProject.Forms.Store.Show();
                    Close();
                }
                else if (My.MyProject.Forms.Bureau2.Panel1.Visible == true)
                {
                    My.MyProject.Forms.Paramètres.Show();
                    Close();
                }
                else if (My.MyProject.Forms.Bureau2.Button11.Visible == true)
                {
                    My.MyProject.Forms.Store.Show();
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
            My.MyProject.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation);
        }
    }
}