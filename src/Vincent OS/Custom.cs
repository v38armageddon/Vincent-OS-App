using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Windows.Forms;
using Vincent_OS_Registry;

namespace Vincent_OS
{
    public partial class Custom
    {
        Registry registry = new Registry();
        WindowsIdentity identity = WindowsIdentity.GetCurrent();
        Bureau bureau = new Bureau();
        Bureau2 bureau2 = new Bureau2();

        public Custom()
        {
            InitializeComponent();
        }

        private void Ecran_Load(object sender, EventArgs e)
        {
            if (bureau.Visible == true)
            {
                PictureBox1.Image = bureau.FlowLayoutPanel1.BackgroundImage;
            }
            else if (bureau2.Visible == true)
            {
                PictureBox1.Image = bureau2.FlowLayoutPanel1.BackgroundImage;
            }
        }
        #region Fond d'écran
        private void Button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog1.Filter = "Images|*.jpeg;*.jpg;*.png;*.bmp;"; // Peut être rajouter d'autres types d'images ?
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (bureau.Visible == true)
                {
                    bureau.FlowLayoutPanel1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName);
                    PictureBox1.Image = bureau.FlowLayoutPanel1.BackgroundImage;
                }
                else if (bureau2.Visible == true)
                {
                    bureau2.FlowLayoutPanel1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName);
                    PictureBox1.Image = bureau2.FlowLayoutPanel1.BackgroundImage;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (bureau.Visible == true)
            {
                bureau.FlowLayoutPanel1.BackgroundImage = Button2.BackgroundImage;
                PictureBox1.Image = bureau.FlowLayoutPanel1.BackgroundImage;
            }
            else if (bureau2.Visible == true)
            {
                bureau2.FlowLayoutPanel1.BackgroundImage = Button2.BackgroundImage;
                PictureBox1.Image = bureau2.FlowLayoutPanel1.BackgroundImage;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (bureau.Visible == true)
            {
                bureau.FlowLayoutPanel1.BackgroundImage = Button3.BackgroundImage;
                PictureBox1.Image = bureau.FlowLayoutPanel1.BackgroundImage;
            }
            else if (bureau2.Visible == true)
            {
                bureau2.FlowLayoutPanel1.BackgroundImage = Button3.BackgroundImage;
                PictureBox1.Image = bureau2.FlowLayoutPanel1.BackgroundImage;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (bureau.Visible == true)
            {
                bureau.FlowLayoutPanel1.BackgroundImage = Button4.BackgroundImage;
                PictureBox1.Image = bureau.FlowLayoutPanel1.BackgroundImage;
            }
            else if (bureau2.Visible == true)
            {
                bureau2.FlowLayoutPanel1.BackgroundImage = Button4.BackgroundImage;
                PictureBox1.Image = bureau2.FlowLayoutPanel1.BackgroundImage;
            }
        }
        #endregion
        #region Icônes
        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button2.Visible = true;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button2.Visible = true;
                }
            }
            else if (CheckBox1.Checked == false)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button2.Visible = false;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button2.Visible = false;
                }
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox5.Checked == true)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button14.Visible = true;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button14.Visible = true;
                }
            }
            else if (CheckBox5.Checked == false)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button14.Visible = false;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button14.Visible = false;
                }
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button6.Visible = true;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button6.Visible = true;
                }
            }
            else if (CheckBox2.Checked == false)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button6.Visible = false;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button6.Visible = false;
                }
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox6.Checked == true)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button5.Visible = true;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button5.Visible = true;
                }
            }
            else if (CheckBox6.Checked == false)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button5.Visible = false;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button5.Visible = false;
                }
            }
        }

        private void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox10.Checked == true)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button10.Visible = true;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button10.Visible = true;
                }
            }
            else if (CheckBox10.Checked == false)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button10.Visible = false;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button10.Visible = false;
                }
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == true)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button3.Visible = true;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button3.Visible = true;
                }
            }
            else if (CheckBox3.Checked == false)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button3.Visible = false;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button3.Visible = false;
                }
            }
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox7.Checked == true)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button11.Visible = true;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button9.Visible = true;
                }
            }
            else if (CheckBox7.Checked == false)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button11.Visible = false;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button9.Visible = false;
                }
            }
        }

        private void CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox11.Checked == true)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button25.Visible = true;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button25.Visible = true;
                }
            }
            else if (CheckBox11.Checked == false)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button25.Visible = false;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button25.Visible = false;
                }
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox4.Checked == true)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button4.Visible = true;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button4.Visible = true;
                }
            }
            else if (CheckBox4.Checked == false)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button4.Visible = false;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button4.Visible = false;
                }
            }
        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox8.Checked == true)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button13.Visible = true;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button13.Visible = true;
                }
            }
            else if (CheckBox8.Checked == false)
            {
                if (bureau.Visible == true)
                {
                    bureau.Button13.Visible = false;
                }
                if (bureau2.Visible == true)
                {
                    bureau2.Button13.Visible = false;
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
            button6.Visible = true;
            button5.Visible = false;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            if (radioButton3.Checked)
            {
                if (principal.IsInRole(WindowsBuiltInRole.Administrator))
                {
                    registry.ToExplorer();
                    DialogResult result = MessageBox.Show("Pour pouvoir appliquer les changements et en profiter, vous devez redémarrer votre système. Souhaitez vous que Vincent OS App le fasse pour vous ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        var psi = new ProcessStartInfo("shutdown", "/r /t 0");
                        psi.CreateNoWindow = true;
                        psi.UseShellExecute = false;
                        Process.Start(psi);
                    }
                }
                else
                {
                    var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                    backmusic.Play();
                    MessageBox.Show("ERREUR : Vous n'avez pas lancé en mode Administrateur, veuillez le relancer en mode administrateur pour pouvoir changer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (radioButton4.Checked)
            {
                if (principal.IsInRole(WindowsBuiltInRole.Administrator))
                {
                    registry.ToVinDesk();
                    DialogResult result = MessageBox.Show("Pour pouvoir appliquer les changements et en profiter, vous devez redémarrer votre système. Souhaitez vous que Vincent OS App le fasse pour vous ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        var psi = new ProcessStartInfo("shutdown", "/r /t 0");
                        psi.CreateNoWindow = true;
                        psi.UseShellExecute = false;
                        Process.Start(psi);
                    }
                }
                else
                {
                    var backmusic = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                    backmusic.Play();
                    MessageBox.Show("ERREUR : Vous n'avez pas lancé en mode Administrateur, veuillez le relancer en mode administrateur pour pouvoir changer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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