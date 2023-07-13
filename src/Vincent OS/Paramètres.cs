using System;

namespace Vincent_OS
{
    public partial class Paramètres
    {
        public Paramètres()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            Bureau bureau = new Bureau();
            Bureau2 bureau2 = new Bureau2();
            if (bureau.Visible == true)
            {
                PictureBox1.Visible = true;
                Label7.Text = "Utilisateur : Superutilisateur";
            }
            else if (bureau2.Visible == true)
            {
                PictureBox2.Visible = true;
                Label7.Text = "Utilisateur : Invité";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Custom custom = new Custom();
            custom.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Terminal terminal = new Terminal();
            terminal.Show();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            TaskVOS taskVOS = new TaskVOS();
            taskVOS.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Custom custom = new Custom();
            custom.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = new Utilisateur();
            utilisateur.Show();
        }
    }
}