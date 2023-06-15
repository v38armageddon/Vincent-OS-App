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
            My.MyProject.Forms.About.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Custom.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Terminal.Show();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.TaskVOS.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.Custom.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Utilisateur.Show();
        }
    }
}