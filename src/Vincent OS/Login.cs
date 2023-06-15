using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Login
    {
        public Login()
        {
            InitializeComponent();
            Panel1.BackColor = Color.FromArgb(170,0,0,0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            verifylog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Login2bureau2.Show();
            Close();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.alertelog.Show();
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar((int)Keys.Enter))
            {
                verifylog();
            }
        }

        // Permet de révéler le mot de passe
        private void Button4_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox2.PasswordChar = char.Parse("");
        }

        private void Button4_MouseUp(object sender, MouseEventArgs e)
        {
            TextBox2.PasswordChar = '•';
        }

        // Permet de vérifier le mot de passe
        private void verifylog()
        {
            if (TextBox2.Text == "Vincent OS")
            {
                TextBox2.Text = "";
                My.MyProject.Forms.Login2bureau.Show();
                Close();
            }
            else
            {
                var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                backmusic.Play();
                MessageBox.Show("ERREUR : Le mot de passe est incorrecte.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}