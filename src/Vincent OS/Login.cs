using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verifylog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login2bureau2 l = new Login2bureau2();
            l.Show();
            this.Hide();
        }
        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Alertelog a = new Alertelog();
            a.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                verifylog();
            }
        }

        // Permet de révéler le mot de passe
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.PasswordChar = '\0';
        }
        
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        // Permet de vérifier le mot de passe
        private void verifylog()
        {
            if (textBox1.Text == "Vincent OS")
            {
                textBox1.Text = "";
                Login2bureau l = new Login2bureau();
                l.Show();
                this.Hide();
            }
            else
            {
                System.IO.Stream str = Properties.Resources.errorSound;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
                player.Play();
                MessageBox.Show("ERREUR : Le mot de passe est incorrecte.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
