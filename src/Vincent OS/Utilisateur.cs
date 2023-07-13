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
            Bureau bureau = new Bureau();
            Bureau2 bureau2 = new Bureau2();
            Login login = new Login();
            if (bureau.Visible == true)
            {
                if (login.Label2.Text == "Superutilisateur")
                {
                    Label2.Text = "Superutilisateur";
                }
                else
                {
                    Label2.Text = login.Label2.Text;
                }
            }
            else if (bureau2.Visible == true)
            {
                if (login.Label3.Text == "Invité")
                {
                    Label2.Text = "Invité";
                }
                else
                {
                    Label2.Text = login.Label3.Text;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Bureau bureau = new Bureau();
            Bureau2 bureau2 = new Bureau2();
            Login login = new Login();
            Login2bureau login2bureau = new Login2bureau();
            Login2bureau2 login2bureau2 = new Login2bureau2();
            Paramètres paramètres = new Paramètres();
            if (bureau.Visible == true)
            {
                login.Label2.Text = TextBox1.Text;
                login2bureau.Text = "Bienvenue sur Vincent OS : " + TextBox1.Text;
                bureau.Text = "Bureau - Session " + TextBox1.Text;
                bureau.Label3.Text = TextBox1.Text;
                paramètres.Label7.Text = "Utilisateur : " + TextBox1.Text;
                Label2.Text = TextBox1.Text;
            }
            else if (bureau2.Visible == true)
            {
                login.Label3.Text = TextBox1.Text;
                login2bureau2.Text = "Bienvenue sur Vincent OS : " + TextBox1.Text;
                bureau2.Text = "Bureau - Session " + TextBox1.Text;
                bureau2.Label3.Text = TextBox1.Text;
                paramètres.Label7.Text = "Utilisateur : " + TextBox1.Text;
                Label2.Text = TextBox1.Text;
            }
        }
    }
}