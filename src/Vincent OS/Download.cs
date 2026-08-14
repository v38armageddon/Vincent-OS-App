using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Download
    {
        public Download()
        {
            InitializeComponent();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            if (Button6.Enabled == false | Button7.Enabled == false | Button8.Enabled == false | Button2.Enabled == false)
            {
                var errorsound = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                errorsound.Play();
                MessageBox.Show("ERREUR : Vous ne pouvez lancer qu'un téléchargement à la fois.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Button5.Text = "Téléchargement...";
                Button5.Enabled = false;
                ProgressBar1.Visible = true;
                Timer1.Start();
            }
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            if (Button5.Enabled == false | Button7.Enabled == false | Button8.Enabled == false | Button2.Enabled == false)
            {
                var errorsound = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                errorsound.Play();
                MessageBox.Show("ERREUR : Vous ne pouvez lancer qu'un téléchargement à la fois.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Button6.Text = "Téléchargement...";
                Button6.Enabled = false;
                ProgressBar2.Visible = true;
                Timer1.Start();
            }
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            if (Button6.Enabled == false | Button5.Enabled == false | Button8.Enabled == false | Button2.Enabled == false)
            {
                var errorsound = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                errorsound.Play();
                MessageBox.Show("ERREUR : Vous ne pouvez lancer qu'un téléchargement à la fois.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Button7.Text = "Téléchargement...";
                Button7.Enabled = false;
                ProgressBar3.Visible = true;
                Timer1.Start();
            }
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            if (Button6.Enabled == false | Button7.Enabled == false | Button5.Enabled == false | Button2.Enabled == false)
            {
                var errorsound = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                errorsound.Play();
                MessageBox.Show("ERREUR : Vous ne pouvez lancer qu'un téléchargement à la fois.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Button8.Text = "Téléchargement...";
                Button8.Enabled = false;
                ProgressBar4.Visible = true;
                Timer1.Start();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Button6.Enabled == false | Button7.Enabled == false | Button5.Enabled == false | Button8.Enabled == false)
            {
                var errorsound = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                errorsound.Play();
                MessageBox.Show("ERREUR : Vous ne pouvez lancer qu'un téléchargement à la fois.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Button2.Text == "Téléchargé !")
            {
                var errorsound = new System.Media.SoundPlayer(My.Resources.Resources.errorSound);
                errorsound.Play();
                MessageBox.Show("ERREUR : Votre logiciel a déjà été téléchargé.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Button2.Text = "Téléchargement...";
                Button2.Enabled = false;
                ProgressBar6.Visible = true;
                Timer1.Start();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Button5.Enabled == false)
            {
                ProgressBar1.Increment((int)Math.Round(0.75));
                if (ProgressBar1.Value == 100)
                {
                    Timer1.Stop();
                    Process.Start("https://discord.com/api/downloads/distributions/app/installers/latest?channel=stable&platform=win&arch=x86");
                    Button5.Text = "Lancer le téléchargement";
                    Button5.Enabled = true;
                    ProgressBar1.Value = 0;
                    ProgressBar1.Visible = false;
                    My.MyProject.Forms.Applications.Button12.Visible = true;
                    My.MyProject.Forms.Applications.Label1.Visible = false;
                }
            }
            else if (Button6.Enabled == false)
            {
                ProgressBar2.Increment((int)Math.Round(0.75));
                if (ProgressBar2.Value == 100)
                {
                    Timer1.Stop();
                    // ' POURQUOI GOOGLE FONT DES LIENS ULTRA LONG SA MERE ???
                    Process.Start("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BC4F38CD2-40DE-EBE5-18B2-99D3A077C899%7D%26lang%3Dfr%26browser%3D2%26usagestats%3D1%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe");
                    Button6.Text = "Lancer le téléchargemnt";
                    Button6.Enabled = true;
                    ProgressBar2.Value = 0;
                    ProgressBar2.Visible = false;
                    My.MyProject.Forms.Applications.Button13.Visible = true;
                    My.MyProject.Forms.Applications.Label1.Visible = false;
                }
            }
            else if (Button7.Enabled == false)
            {
                ProgressBar3.Increment((int)Math.Round(0.75));
                if (ProgressBar3.Value == 100)
                {
                    Timer1.Stop();
                    Process.Start("https://download.mozilla.org/?product=firefox-stub&os=win&lang=fr");
                    Button7.Text = "Lancer le téléchargement";
                    Button7.Enabled = true;
                    ProgressBar3.Value = 0;
                    ProgressBar3.Visible = false;
                    My.MyProject.Forms.Applications.Button15.Visible = true;
                    My.MyProject.Forms.Applications.Label1.Visible = false;
                }
            }
            else if (Button8.Enabled == false)
            {
                ProgressBar4.Increment((int)Math.Round(0.75));
                if (ProgressBar4.Value == 100)
                {
                    Timer1.Stop();
                    Process.Start("https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe");
                    Button8.Text = "Lancer le téléchargement";
                    Button8.Enabled = true;
                    ProgressBar4.Value = 0;
                    ProgressBar4.Visible = false;
                    My.MyProject.Forms.Applications.Button14.Visible = true;
                    My.MyProject.Forms.Applications.Label1.Visible = false;
                }
            }
            else if (Button2.Enabled == false)
            {
                ProgressBar6.Increment((int)Math.Round(0.75));
                if (ProgressBar6.Value == 100)
                {
                    Timer1.Stop();
                    My.MyProject.Forms.Applications.Label1.Visible = false;
                    My.MyProject.Forms.Applications.Button11.Visible = true;
                    Button2.Text = "Téléchargé !";
                    Button2.Enabled = true;
                    ProgressBar6.Value = 0;
                    ProgressBar6.Visible = false;
                    var alertSound = new System.Media.SoundPlayer(My.Resources.Resources.alertSound);
                    alertSound.Play();
                    MessageBox.Show("Votre téléchargement est désormais terminé !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}