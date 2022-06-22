using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Media : Form
    {

        // Form remplace la méthode Dispose pour nettoyer la liste des composants.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requise par le Concepteur Windows Form
        private System.ComponentModel.IContainer components;

        // REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
        // Elle peut être modifiée à l'aide du Concepteur Windows Form.  
        // Ne la modifiez pas à l'aide de l'éditeur de code.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Media));
            MenuStrip1 = new MenuStrip();
            OuvrirToolStripMenuItem = new ToolStripMenuItem();
            MusiqueToolStripMenuItem = new ToolStripMenuItem();
            MusiqueToolStripMenuItem.Click += new EventHandler(MusiqueToolStripMenuItem_Click);
            VidéoToolStripMenuItem = new ToolStripMenuItem();
            VidéoToolStripMenuItem.Click += new EventHandler(VidéoToolStripMenuItem_Click);
            LectureToolStripMenuItem = new ToolStripMenuItem();
            ArrêterToolStripMenuItem = new ToolStripMenuItem();
            ArrêterToolStripMenuItem.Click += new EventHandler(ArrêterToolStripMenuItem_Click);
            PleinÉcranToolStripMenuItem = new ToolStripMenuItem();
            PleinÉcranToolStripMenuItem.Click += new EventHandler(PleinÉcranToolStripMenuItem_Click);
            AutresToolStripMenuItem = new ToolStripMenuItem();
            OptionsToolStripMenuItem = new ToolStripMenuItem();
            OptionsToolStripMenuItem.Click += new EventHandler(OptionsToolStripMenuItem_Click);
            QuitterToolStripMenuItem = new ToolStripMenuItem();
            QuitterToolStripMenuItem.Click += new EventHandler(QuitterToolStripMenuItem_Click);
            OpenFileDialog2 = new OpenFileDialog();
            AxWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AxWindowsMediaPlayer3).BeginInit();
            SuspendLayout();
            // 
            // MenuStrip1
            // 
            MenuStrip1.Items.AddRange(new ToolStripItem[] { OuvrirToolStripMenuItem, LectureToolStripMenuItem, AutresToolStripMenuItem });
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(546, 24);
            MenuStrip1.TabIndex = 7;
            MenuStrip1.Text = "MenuStrip1";
            // 
            // OuvrirToolStripMenuItem
            // 
            OuvrirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MusiqueToolStripMenuItem, VidéoToolStripMenuItem });
            OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem";
            OuvrirToolStripMenuItem.Size = new Size(52, 20);
            OuvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // MusiqueToolStripMenuItem
            // 
            MusiqueToolStripMenuItem.Name = "MusiqueToolStripMenuItem";
            MusiqueToolStripMenuItem.Size = new Size(120, 22);
            MusiqueToolStripMenuItem.Text = "Musique";
            // 
            // VidéoToolStripMenuItem
            // 
            VidéoToolStripMenuItem.Name = "VidéoToolStripMenuItem";
            VidéoToolStripMenuItem.Size = new Size(120, 22);
            VidéoToolStripMenuItem.Text = "Vidéo";
            // 
            // LectureToolStripMenuItem
            // 
            LectureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ArrêterToolStripMenuItem, PleinÉcranToolStripMenuItem });
            LectureToolStripMenuItem.Name = "LectureToolStripMenuItem";
            LectureToolStripMenuItem.Size = new Size(58, 20);
            LectureToolStripMenuItem.Text = "Lecture";
            // 
            // ArrêterToolStripMenuItem
            // 
            ArrêterToolStripMenuItem.Name = "ArrêterToolStripMenuItem";
            ArrêterToolStripMenuItem.Size = new Size(132, 22);
            ArrêterToolStripMenuItem.Text = "Arrêter";
            // 
            // PleinÉcranToolStripMenuItem
            // 
            PleinÉcranToolStripMenuItem.Name = "PleinÉcranToolStripMenuItem";
            PleinÉcranToolStripMenuItem.Size = new Size(132, 22);
            PleinÉcranToolStripMenuItem.Text = "Plein écran";
            // 
            // AutresToolStripMenuItem
            // 
            AutresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OptionsToolStripMenuItem, QuitterToolStripMenuItem });
            AutresToolStripMenuItem.Name = "AutresToolStripMenuItem";
            AutresToolStripMenuItem.Size = new Size(53, 20);
            AutresToolStripMenuItem.Text = "Autres";
            // 
            // OptionsToolStripMenuItem
            // 
            OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            OptionsToolStripMenuItem.Size = new Size(116, 22);
            OptionsToolStripMenuItem.Text = "Options";
            // 
            // QuitterToolStripMenuItem
            // 
            QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem";
            QuitterToolStripMenuItem.Size = new Size(116, 22);
            QuitterToolStripMenuItem.Text = "Quitter";
            // 
            // OpenFileDialog2
            // 
            OpenFileDialog2.CheckFileExists = false;
            OpenFileDialog2.CheckPathExists = false;
            OpenFileDialog2.FileName = "OpenFileDialog2";
            OpenFileDialog2.RestoreDirectory = true;
            // 
            // AxWindowsMediaPlayer3
            // 
            AxWindowsMediaPlayer3.Dock = DockStyle.Fill;
            AxWindowsMediaPlayer3.Enabled = true;
            AxWindowsMediaPlayer3.Location = new Point(0, 24);
            AxWindowsMediaPlayer3.Name = "AxWindowsMediaPlayer3";
            AxWindowsMediaPlayer3.OcxState = (AxHost.State)resources.GetObject("AxWindowsMediaPlayer3.OcxState");
            AxWindowsMediaPlayer3.Size = new Size(546, 320);
            AxWindowsMediaPlayer3.TabIndex = 8;
            // 
            // Media
            // 
            BackColor = Color.DimGray;
            ClientSize = new Size(546, 344);
            Controls.Add(AxWindowsMediaPlayer3);
            Controls.Add(MenuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip1;
            MinimumSize = new Size(562, 360);
            Name = "Media";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Player";
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AxWindowsMediaPlayer3).EndInit();
            Load += new EventHandler(Media_Load);
            FormClosed += new FormClosedEventHandler(Media_FormClosed);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Button Button1;
        internal Button Button2;
        internal Button Button3;
        internal CheckBox CheckBox1;
        internal AxWMPLib.AxWindowsMediaPlayer AxWindowsMediaPlayer1;
        internal TextBox TextBox1;
        internal OpenFileDialog OpenFileDialog1;
        internal AxWMPLib.AxWindowsMediaPlayer AxWindowsMediaPlayer2;
        internal MenuStrip MenuStrip1;
        internal OpenFileDialog OpenFileDialog2;
        internal ToolStripMenuItem OuvrirToolStripMenuItem;
        internal ToolStripMenuItem MusiqueToolStripMenuItem;
        internal ToolStripMenuItem VidéoToolStripMenuItem;
        internal ToolStripMenuItem LectureToolStripMenuItem;
        internal ToolStripMenuItem ArrêterToolStripMenuItem;
        internal ToolStripMenuItem PleinÉcranToolStripMenuItem;
        internal ToolStripMenuItem AutresToolStripMenuItem;
        internal ToolStripMenuItem OptionsToolStripMenuItem;
        internal ToolStripMenuItem QuitterToolStripMenuItem;
        internal AxWMPLib.AxWindowsMediaPlayer AxWindowsMediaPlayer3;
    }
}