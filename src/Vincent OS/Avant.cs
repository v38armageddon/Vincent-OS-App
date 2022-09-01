using System;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Avant
    {
        public Avant()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Custom.RadioButton1.Checked = true;
            My.MyProject.Forms.Démarrage.StartPosition = FormStartPosition.CenterScreen;
            My.MyProject.Forms.Démarrage.Show();
            Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Custom.RadioButton2.Checked = true;
            My.MyProject.Forms.Démarrage.Show();
            if (My.MyProject.Forms.Démarrage.Visible == true)
            {
                Restart restart = new Restart();
                // On change de mode de forme de la fenêtre
                My.MyProject.Forms.Démarrage.FormBorderStyle = FormBorderStyle.None;
                My.MyProject.Forms.Arrêt.FormBorderStyle = FormBorderStyle.None;
                My.MyProject.Forms.Login.FormBorderStyle = FormBorderStyle.None;
                My.MyProject.Forms.Login2bureau.FormBorderStyle = FormBorderStyle.None;
                My.MyProject.Forms.Login2bureau2.FormBorderStyle = FormBorderStyle.None;
                My.MyProject.Forms.Bureau.FormBorderStyle = FormBorderStyle.None;
                My.MyProject.Forms.Bureau2.FormBorderStyle = FormBorderStyle.None;
                restart.FormBorderStyle = FormBorderStyle.None;
                // On met une nouvelle localisation
                My.MyProject.Forms.Bureau.Width = My.MyProject.Computer.Screen.Bounds.Width;
                My.MyProject.Forms.Bureau.Height = My.MyProject.Computer.Screen.Bounds.Height;
                My.MyProject.Forms.Bureau2.Width = My.MyProject.Computer.Screen.Bounds.Width;
                My.MyProject.Forms.Bureau2.Height = My.MyProject.Computer.Screen.Bounds.Height;
                My.MyProject.Forms.Arrêt.Width = My.MyProject.Computer.Screen.Bounds.Width;
                My.MyProject.Forms.Arrêt.Height = My.MyProject.Computer.Screen.Bounds.Height;
                My.MyProject.Forms.Démarrage.Width = My.MyProject.Computer.Screen.Bounds.Width;
                My.MyProject.Forms.Démarrage.Height = My.MyProject.Computer.Screen.Bounds.Height;
                My.MyProject.Forms.Login.Width = My.MyProject.Computer.Screen.Bounds.Width;
                My.MyProject.Forms.Login.Height = My.MyProject.Computer.Screen.Bounds.Height;
                My.MyProject.Forms.Login2bureau.Width = My.MyProject.Computer.Screen.Bounds.Width;
                My.MyProject.Forms.Login2bureau.Height = My.MyProject.Computer.Screen.Bounds.Height;
                My.MyProject.Forms.Login2bureau2.Width = My.MyProject.Computer.Screen.Bounds.Width;
                My.MyProject.Forms.Login2bureau2.Height = My.MyProject.Computer.Screen.Bounds.Height;
                restart.Width = My.MyProject.Computer.Screen.Bounds.Width;
                restart.Height = My.MyProject.Computer.Screen.Bounds.Height;
            }
            Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.alertelog.Show();
        }
    }
}