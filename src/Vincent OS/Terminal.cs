using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Vincent_OS
{
    public partial class Terminal
    {
        public Terminal()
        {
            InitializeComponent();
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button24.Visible = true;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button24.Visible = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Création d'un Private Sub pour mieux se retrouver
            commande();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Faire en sorte que la touche Entrée puisse marcher
            if (e.KeyChar == Convert.ToChar((int)Keys.Enter))
            {
                commande();
            }
        }

        private void Terminal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button24.Visible = false;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button24.Visible = false;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void commande()
        {
            if (TextBox1.Text == "ver")
            {
                // ATTENTION A BIEN CHANGER LA VERSION CAR JE VAIS SUREMENT OUBLIER A LA PROCHAINE VERSION !!!!!!!!!!!
                RichTextBox1.Text = "Nom du système d'exploitation : Vincent OS\nVersion : 9.0.2\nBranche : Beta";
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "help")
            {
                RichTextBox1.Text = "Bing Chrome        Lance Bing Chrome.\nCalc       Lance la calculatrice\nChrono       Lance le chronomètre\nExewin       Lance l'exécuteur d'application non Vincent OS.\nGame        Lance le gestionnaire de jeux.\nMediaPlayer      Lance le Media Player.\nMeme        Lance l'explorateur de fichiers.\nNotepad        Lance le Bloc Note.\nPaint       Lance Paint.\nTerminal     Lance une autre fenêtre d'un Terminal.\nVisio       Lance la visionneuse d'images.\n\nCertaines commandes sont cachées !";
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Bing Chrome")
            {
                My.MyProject.Forms.Bing_Chrome.Show();
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Calc")
            {
                My.MyProject.Forms.Calc.Show();
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Exewin")
            {
                My.MyProject.Forms.exewin.Show();
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Game")
            {
                My.MyProject.Forms.game.Show();
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "MediaPlayer")
            {
                My.MyProject.Forms.Media.Show();
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Meme")
            {
                My.MyProject.Forms.meme.Show();
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Notepad")
            {
                My.MyProject.Forms.Notepad.Show();
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Paint")
            {
                My.MyProject.Forms.paints.Show();
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Terminal")
            {
                var cp = new Terminal();
                cp.Show();
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Visio")
            {
                My.MyProject.Forms.Visio.Show();
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Chrono")
            {
                My.MyProject.Forms.chrono.Show();
                TextBox1.Text = "";
            }
            // Ici commence les commandes de Debug, à utiliser avec précaution !

            else if (TextBox1.Text == "Debug_Options")
            {
                RichTextBox1.Text = "DEBUG_ERREUR : Veuillez rentrer une sous option\nPour savoir les différentes commandes, tapez : Debug_Options_Help";
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Debug_Options_Custom")
            {
                if (My.MyProject.Forms.Bureau.Visible == true | My.MyProject.Forms.Bureau2.Visible == true)
                {
                    My.MyProject.Forms.Custom.Show();
                }
                else
                {
                    MessageBox.Show("DEBUG_ERREUR : Il n'y a pas d'interface graphique et/ou de bureau d'ouvert", "DEBUG_ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Debug_Options_Help")
            {
                RichTextBox1.Text = "Debug_Options_Custom";
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Debug_AlerteLog_ForceCrash")
            {
                Application.Exit();
            }
            else if (TextBox1.Text == "Debug_AlerteLog")
            {
                My.MyProject.Forms.alertelog.Show();
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Debug_Help")
            {
                RichTextBox1.Text = "Debug_AlerteLog\nDebug_AlerteLog_ForceCrash\nDebug_Options\nDebug_ClearMemory";
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Debug_App_ForceCrash")
            {
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
                TextBox1.Text = "";
            }
            else if (TextBox1.Text == "Debug_ClearMemory")
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                TextBox1.Text = "";
            }
            else
            {
                RichTextBox1.Text = "Commande non reconnu.";
                TextBox1.Text = "";
            }
        }
    }
}