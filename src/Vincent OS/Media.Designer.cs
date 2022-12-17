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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Media));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OuvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VidéoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LectureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrêterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PleinÉcranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OuvrirToolStripMenuItem,
            this.LectureToolStripMenuItem,
            this.AutresToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(546, 24);
            this.MenuStrip1.TabIndex = 7;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // OuvrirToolStripMenuItem
            // 
            this.OuvrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MusiqueToolStripMenuItem,
            this.VidéoToolStripMenuItem});
            this.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem";
            this.OuvrirToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.OuvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // MusiqueToolStripMenuItem
            // 
            this.MusiqueToolStripMenuItem.Name = "MusiqueToolStripMenuItem";
            this.MusiqueToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.MusiqueToolStripMenuItem.Text = "Musique";
            this.MusiqueToolStripMenuItem.Click += new System.EventHandler(this.MusiqueToolStripMenuItem_Click);
            // 
            // VidéoToolStripMenuItem
            // 
            this.VidéoToolStripMenuItem.Name = "VidéoToolStripMenuItem";
            this.VidéoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.VidéoToolStripMenuItem.Text = "Vidéo";
            this.VidéoToolStripMenuItem.Click += new System.EventHandler(this.VidéoToolStripMenuItem_Click);
            // 
            // LectureToolStripMenuItem
            // 
            this.LectureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArrêterToolStripMenuItem,
            this.PleinÉcranToolStripMenuItem});
            this.LectureToolStripMenuItem.Name = "LectureToolStripMenuItem";
            this.LectureToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.LectureToolStripMenuItem.Text = "Lecture";
            // 
            // ArrêterToolStripMenuItem
            // 
            this.ArrêterToolStripMenuItem.Name = "ArrêterToolStripMenuItem";
            this.ArrêterToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ArrêterToolStripMenuItem.Text = "Arrêter";
            this.ArrêterToolStripMenuItem.Click += new System.EventHandler(this.ArrêterToolStripMenuItem_Click);
            // 
            // PleinÉcranToolStripMenuItem
            // 
            this.PleinÉcranToolStripMenuItem.Name = "PleinÉcranToolStripMenuItem";
            this.PleinÉcranToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.PleinÉcranToolStripMenuItem.Text = "Plein écran";
            this.PleinÉcranToolStripMenuItem.Click += new System.EventHandler(this.PleinÉcranToolStripMenuItem_Click);
            // 
            // AutresToolStripMenuItem
            // 
            this.AutresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsToolStripMenuItem,
            this.QuitterToolStripMenuItem});
            this.AutresToolStripMenuItem.Name = "AutresToolStripMenuItem";
            this.AutresToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.AutresToolStripMenuItem.Text = "Autres";
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.OptionsToolStripMenuItem.Text = "Options";
            this.OptionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // QuitterToolStripMenuItem
            // 
            this.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem";
            this.QuitterToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.QuitterToolStripMenuItem.Text = "Quitter";
            this.QuitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // OpenFileDialog2
            // 
            this.OpenFileDialog2.CheckFileExists = false;
            this.OpenFileDialog2.CheckPathExists = false;
            this.OpenFileDialog2.FileName = "OpenFileDialog2";
            this.OpenFileDialog2.RestoreDirectory = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(160, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 228);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Media
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(546, 344);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.MinimumSize = new System.Drawing.Size(562, 360);
            this.Name = "Media";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Media_FormClosed);
            this.Load += new System.EventHandler(this.Media_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Button Button1;
        internal Button Button2;
        internal Button Button3;
        internal CheckBox CheckBox1;
        internal TextBox TextBox1;
        internal OpenFileDialog OpenFileDialog1;
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
        private PictureBox pictureBox1;
    }
}