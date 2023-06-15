using System;

namespace Vincent_OS
{
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            InitializeComponent();
        }

        private void Utilisateur_Load(object sender, EventArgs e)
        {
            if (bureau.Visible == true)
            {
                if (My.MyProject.Forms.Login.Label2.Text == "Superutilisateur")
                {
                    Label2.Text = "Superutilisateur";
                }
                else
                {
                    Label2.Text = My.MyProject.Forms.Login.Label2.Text;
                }
            }
            else if (bureau2.Visible == true)
            {
                if (My.MyProject.Forms.Login.Label3.Text == "Invité")
                {
                    Label2.Text = "Invité";
                }
                else
                {
                    Label2.Text = My.MyProject.Forms.Login.Label3.Text;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (bureau.Visible == true)
            {
                My.MyProject.Forms.Login.Label2.Text = TextBox1.Text;
                My.MyProject.Forms.Login2bureau.Text = "Bienvenue sur Vincent OS : " + TextBox1.Text;
                bureau.Text = "Bureau - Session " + TextBox1.Text;
                bureau.Label3.Text = TextBox1.Text;
                My.MyProject.Forms.Paramètres.Label7.Text = "Utilisateur : " + TextBox1.Text;
                Label2.Text = TextBox1.Text;
            }
            else if (bureau2.Visible == true)
            {
                My.MyProject.Forms.Login.Label3.Text = TextBox1.Text;
                My.MyProject.Forms.Login2bureau2.Text = "Bienvenue sur Vincent OS : " + TextBox1.Text;
                bureau2.Text = "Bureau - Session " + TextBox1.Text;
                bureau2.Label3.Text = TextBox1.Text;
                My.MyProject.Forms.Paramètres.Label7.Text = "Utilisateur : " + TextBox1.Text;
                Label2.Text = TextBox1.Text;
            }
        }
    }
}