using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Vincent_OS_Registry;

namespace Vincent_OS
{
    public partial class Custom
    {
        Registry registry = new Registry();

        public Custom()
        {
            InitializeComponent();
        }

        private void Ecran_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                PictureBox1.Image = My.MyProject.Forms.Bureau.FlowLayoutPanel1.BackgroundImage;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                PictureBox1.Image = My.MyProject.Forms.Bureau2.FlowLayoutPanel1.BackgroundImage;
            }
        }
        #region Fond d'écran
        private void Button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog1.Filter = "Images|*.jpeg;*.jpg;*.png;*.bmp;"; // Peut être rajouter d'autres types d'images ?
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.FlowLayoutPanel1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName);
                    PictureBox1.Image = My.MyProject.Forms.Bureau.FlowLayoutPanel1.BackgroundImage;
                }
                else if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.FlowLayoutPanel1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName);
                    PictureBox1.Image = My.MyProject.Forms.Bureau2.FlowLayoutPanel1.BackgroundImage;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.FlowLayoutPanel1.BackgroundImage = Button2.BackgroundImage;
                PictureBox1.Image = My.MyProject.Forms.Bureau.FlowLayoutPanel1.BackgroundImage;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.FlowLayoutPanel1.BackgroundImage = Button2.BackgroundImage;
                PictureBox1.Image = My.MyProject.Forms.Bureau2.FlowLayoutPanel1.BackgroundImage;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.FlowLayoutPanel1.BackgroundImage = Button3.BackgroundImage;
                PictureBox1.Image = My.MyProject.Forms.Bureau.FlowLayoutPanel1.BackgroundImage;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.FlowLayoutPanel1.BackgroundImage = Button3.BackgroundImage;
                PictureBox1.Image = My.MyProject.Forms.Bureau2.FlowLayoutPanel1.BackgroundImage;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.FlowLayoutPanel1.BackgroundImage = Button4.BackgroundImage;
                PictureBox1.Image = My.MyProject.Forms.Bureau.FlowLayoutPanel1.BackgroundImage;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.FlowLayoutPanel1.BackgroundImage = Button4.BackgroundImage;
                PictureBox1.Image = My.MyProject.Forms.Bureau2.FlowLayoutPanel1.BackgroundImage;
            }
        }
        #endregion
        #region Icônes
        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button2.Visible = true;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button2.Visible = true;
                }
            }
            else if (CheckBox1.Checked == false)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button2.Visible = false;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button2.Visible = false;
                }
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox5.Checked == true)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button14.Visible = true;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button14.Visible = true;
                }
            }
            else if (CheckBox5.Checked == false)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button14.Visible = false;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button14.Visible = false;
                }
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button6.Visible = true;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button6.Visible = true;
                }
            }
            else if (CheckBox2.Checked == false)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button6.Visible = false;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button6.Visible = false;
                }
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox6.Checked == true)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button5.Visible = true;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button5.Visible = true;
                }
            }
            else if (CheckBox6.Checked == false)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button5.Visible = false;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button5.Visible = false;
                }
            }
        }

        private void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox10.Checked == true)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button10.Visible = true;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button10.Visible = true;
                }
            }
            else if (CheckBox10.Checked == false)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button10.Visible = false;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button10.Visible = false;
                }
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == true)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button3.Visible = true;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button3.Visible = true;
                }
            }
            else if (CheckBox3.Checked == false)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button3.Visible = false;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button3.Visible = false;
                }
            }
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox7.Checked == true)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button11.Visible = true;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button9.Visible = true;
                }
            }
            else if (CheckBox7.Checked == false)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button11.Visible = false;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button9.Visible = false;
                }
            }
        }

        private void CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox11.Checked == true)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button25.Visible = true;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button25.Visible = true;
                }
            }
            else if (CheckBox11.Checked == false)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button25.Visible = false;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button25.Visible = false;
                }
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox4.Checked == true)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button4.Visible = true;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button4.Visible = true;
                }
            }
            else if (CheckBox4.Checked == false)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button4.Visible = false;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button4.Visible = false;
                }
            }
        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox8.Checked == true)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button13.Visible = true;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button13.Visible = true;
                }
            }
            else if (CheckBox8.Checked == false)
            {
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    My.MyProject.Forms.Bureau.Button13.Visible = false;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Bureau2.Button13.Visible = false;
                }
            }
        }
        #endregion
        #region Résolution
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                Restart restart = new Restart();
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    // On change de mode de forme de la fenêtre
                    My.MyProject.Forms.Bureau.FormBorderStyle = FormBorderStyle.FixedSingle;
                    My.MyProject.Forms.Démarrage.FormBorderStyle = FormBorderStyle.FixedSingle;
                    My.MyProject.Forms.Arrêt.FormBorderStyle = FormBorderStyle.FixedSingle;
                    My.MyProject.Forms.Login.FormBorderStyle = FormBorderStyle.FixedSingle;
                    My.MyProject.Forms.Login2bureau.FormBorderStyle = FormBorderStyle.FixedSingle;
                    restart.FormBorderStyle = FormBorderStyle.FixedSingle;
                    // On met une nouvelle localisation
                    My.MyProject.Forms.Bureau.Location = new Point(480, 300);
                    My.MyProject.Forms.Login.Location = new Point(480, 300);
                    My.MyProject.Forms.Login2bureau.Location = new Point(480, 300);
                    restart.Location = new Point(480, 300);
                    // On met la position au milieu de l'écran
                    // Bien qu'à revérifier si cela peut fonctionner sans ou non
                    My.MyProject.Forms.Bureau.StartPosition = FormStartPosition.CenterScreen;
                    My.MyProject.Forms.Démarrage.StartPosition = FormStartPosition.CenterScreen;
                    My.MyProject.Forms.Login.StartPosition = FormStartPosition.CenterScreen;
                    My.MyProject.Forms.Arrêt.StartPosition = FormStartPosition.CenterScreen;
                    My.MyProject.Forms.Login2bureau.StartPosition = FormStartPosition.CenterScreen;
                    restart.StartPosition = FormStartPosition.CenterScreen;
                    // On change la taille
                    My.MyProject.Forms.Bureau.Width = 854;
                    My.MyProject.Forms.Bureau.Height = 480;
                    My.MyProject.Forms.Arrêt.Width = 854;
                    My.MyProject.Forms.Arrêt.Height = 480;
                    My.MyProject.Forms.Démarrage.Width = 854;
                    My.MyProject.Forms.Démarrage.Height = 480;
                    My.MyProject.Forms.Login.Width = 854;
                    My.MyProject.Forms.Login.Height = 480;
                    My.MyProject.Forms.Login2bureau.Width = 854;
                    My.MyProject.Forms.Login2bureau.Height = 480;
                    restart.Width = 854;
                    restart.Height = 480;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    // On change de mode de forme de la fenêtre
                    My.MyProject.Forms.Bureau2.FormBorderStyle = FormBorderStyle.FixedSingle;
                    My.MyProject.Forms.Démarrage.FormBorderStyle = FormBorderStyle.FixedSingle;
                    My.MyProject.Forms.Arrêt.FormBorderStyle = FormBorderStyle.FixedSingle;
                    My.MyProject.Forms.Login.FormBorderStyle = FormBorderStyle.FixedSingle;
                    My.MyProject.Forms.Login2bureau2.FormBorderStyle = FormBorderStyle.FixedSingle;
                    // On met une nouvelle localisation
                    My.MyProject.Forms.Bureau2.Location = new Point(480, 300);
                    My.MyProject.Forms.Login.Location = new Point(480, 300);
                    My.MyProject.Forms.Login2bureau2.Location = new Point(480, 300);
                    // On met la position au milieu de l'écran
                    // Bien qu'à revérifier si cela peut fonctionner sans ou non
                    My.MyProject.Forms.Bureau2.StartPosition = FormStartPosition.CenterScreen;
                    My.MyProject.Forms.Démarrage.StartPosition = FormStartPosition.CenterScreen;
                    My.MyProject.Forms.Login.StartPosition = FormStartPosition.CenterScreen;
                    My.MyProject.Forms.Arrêt.StartPosition = FormStartPosition.CenterScreen;
                    My.MyProject.Forms.Login2bureau2.StartPosition = FormStartPosition.CenterScreen;
                    // On change la taille
                    My.MyProject.Forms.Bureau2.Width = 854;
                    My.MyProject.Forms.Bureau2.Height = 480;
                    My.MyProject.Forms.Arrêt.Width = 854;
                    My.MyProject.Forms.Arrêt.Height = 480;
                    My.MyProject.Forms.Démarrage.Width = 854;
                    My.MyProject.Forms.Démarrage.Height = 480;
                    My.MyProject.Forms.Login.Width = 854;
                    My.MyProject.Forms.Login.Height = 480;
                    My.MyProject.Forms.Login2bureau2.Width = 854;
                    My.MyProject.Forms.Login2bureau2.Height = 480;
                }
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                Restart restart = new Restart();
                if (My.MyProject.Forms.Bureau.Visible == true)
                {
                    // On change de mode de forme de la fenêtre
                    My.MyProject.Forms.Bureau.FormBorderStyle = FormBorderStyle.None;
                    My.MyProject.Forms.Démarrage.FormBorderStyle = FormBorderStyle.None;
                    My.MyProject.Forms.Arrêt.FormBorderStyle = FormBorderStyle.None;
                    My.MyProject.Forms.Login.FormBorderStyle = FormBorderStyle.None;
                    My.MyProject.Forms.Login2bureau.FormBorderStyle = FormBorderStyle.None;
                    My.MyProject.Forms.Bureau.Location = new Point(0, 0);
                    My.MyProject.Forms.Login.Location = new Point(0, 0);
                    My.MyProject.Forms.Login2bureau.Location = new Point(0, 0);
                    restart.Location = new Point(0, 0);
                    My.MyProject.Forms.Bureau.StartPosition = FormStartPosition.Manual;
                    My.MyProject.Forms.Démarrage.StartPosition = FormStartPosition.Manual;
                    My.MyProject.Forms.Login.StartPosition = FormStartPosition.Manual;
                    My.MyProject.Forms.Arrêt.StartPosition = FormStartPosition.Manual;
                    My.MyProject.Forms.Login2bureau.StartPosition = FormStartPosition.Manual;
                    restart.StartPosition = FormStartPosition.Manual;
                    // On change la taille en fonction de la taille de l'écran de l'utilisateur
                    My.MyProject.Forms.Bureau.Width = My.MyProject.Computer.Screen.Bounds.Width;
                    My.MyProject.Forms.Bureau.Height = My.MyProject.Computer.Screen.Bounds.Height;
                    My.MyProject.Forms.Arrêt.Width = My.MyProject.Computer.Screen.Bounds.Width;
                    My.MyProject.Forms.Arrêt.Height = My.MyProject.Computer.Screen.Bounds.Height;
                    My.MyProject.Forms.Démarrage.Width = My.MyProject.Computer.Screen.Bounds.Width;
                    My.MyProject.Forms.Démarrage.Height = My.MyProject.Computer.Screen.Bounds.Height;
                    My.MyProject.Forms.Login.Width = My.MyProject.Computer.Screen.Bounds.Width;
                    My.MyProject.Forms.Login.Height = My.MyProject.Computer.Screen.Bounds.Height;
                    My.MyProject.Forms.Login2bureau.Width = My.MyProject.Computer.Screen.Bounds.Width;
                    My.MyProject.Forms.Login2bureau.Height = My.MyProject.Computer.Screen.Bounds.Height;
                    restart.Width = My.MyProject.Computer.Screen.Bounds.Width;
                    restart.Height = My.MyProject.Computer.Screen.Bounds.Height;
                }
                if (My.MyProject.Forms.Bureau2.Visible == true)
                {
                    // On change de mode de forme de la fenêtre
                    My.MyProject.Forms.Bureau2.FormBorderStyle = FormBorderStyle.None;
                    My.MyProject.Forms.Démarrage.FormBorderStyle = FormBorderStyle.None;
                    My.MyProject.Forms.Arrêt.FormBorderStyle = FormBorderStyle.None;
                    My.MyProject.Forms.Login.FormBorderStyle = FormBorderStyle.None;
                    My.MyProject.Forms.Login2bureau2.FormBorderStyle = FormBorderStyle.None;
                    // On met une nouvelle localisation
                    My.MyProject.Forms.Bureau2.Location = new Point(0, 0);
                    My.MyProject.Forms.Login.Location = new Point(0, 0);
                    My.MyProject.Forms.Login2bureau2.Location = new Point(0, 0);
                    restart.Location = new Point(0, 0);
                    // On met la position au milieu de l'écran
                    // Bien qu'à revérifier si cela peut fonctionner sans ou non
                    My.MyProject.Forms.Bureau2.StartPosition = FormStartPosition.Manual;
                    My.MyProject.Forms.Démarrage.StartPosition = FormStartPosition.Manual;
                    My.MyProject.Forms.Login.StartPosition = FormStartPosition.Manual;
                    My.MyProject.Forms.Arrêt.StartPosition = FormStartPosition.Manual;
                    My.MyProject.Forms.Login2bureau2.StartPosition = FormStartPosition.Manual;
                    restart.StartPosition = FormStartPosition.Manual;
                    // On change la taille en fonction de la taille de l'écran de l'utilisateur
                    My.MyProject.Forms.Bureau2.Width = My.MyProject.Computer.Screen.Bounds.Width;
                    My.MyProject.Forms.Bureau2.Height = My.MyProject.Computer.Screen.Bounds.Height;
                    My.MyProject.Forms.Arrêt.Width = My.MyProject.Computer.Screen.Bounds.Width;
                    My.MyProject.Forms.Arrêt.Height = My.MyProject.Computer.Screen.Bounds.Height;
                    My.MyProject.Forms.Démarrage.Width = My.MyProject.Computer.Screen.Bounds.Width;
                    My.MyProject.Forms.Démarrage.Height = My.MyProject.Computer.Screen.Bounds.Height;
                    My.MyProject.Forms.Login.Width = My.MyProject.Computer.Screen.Bounds.Width;
                    My.MyProject.Forms.Login.Height = My.MyProject.Computer.Screen.Bounds.Height;
                    My.MyProject.Forms.Login2bureau2.Width = My.MyProject.Computer.Screen.Bounds.Width;
                    My.MyProject.Forms.Login2bureau2.Height = My.MyProject.Computer.Screen.Bounds.Height;
                    restart.Width = My.MyProject.Computer.Screen.Bounds.Width;
                    restart.Height = My.MyProject.Computer.Screen.Bounds.Height;
                }
            }
        }
        #endregion
        #region Shell
        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = true;
            pictureBox15.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            button5.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                //registry.ToExplorer();

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                //registry.ToVinDesk();
            }
        }
        #endregion
        private void Custom_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}