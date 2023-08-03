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
            if (My.MyProject.Forms.Bureau.Visible == true)
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
            else if (My.MyProject.Forms.Bureau2.Visible == true)
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
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Login.Label2.Text = TextBox1.Text;
                My.MyProject.Forms.Login2bureau.Text = "Bienvenue sur Vincent OS : " + TextBox1.Text;
                My.MyProject.Forms.Bureau.Text = "Bureau - Session " + TextBox1.Text;
                My.MyProject.Forms.Bureau.Label3.Text = TextBox1.Text;
                My.MyProject.Forms.Paramètres.Label7.Text = "Utilisateur : " + TextBox1.Text;
                Label2.Text = TextBox1.Text;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Login.Label3.Text = TextBox1.Text;
                My.MyProject.Forms.Login2bureau2.Text = "Bienvenue sur Vincent OS : " + TextBox1.Text;
                My.MyProject.Forms.Bureau2.Text = "Bureau - Session " + TextBox1.Text;
                My.MyProject.Forms.Bureau2.Label3.Text = TextBox1.Text;
                My.MyProject.Forms.Paramètres.Label7.Text = "Utilisateur : " + TextBox1.Text;
                Label2.Text = TextBox1.Text;
            }
        }
    }
}