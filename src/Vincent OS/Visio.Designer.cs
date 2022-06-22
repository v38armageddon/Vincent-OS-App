using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Visio : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Visio));
            Panel1 = new Panel();
            PictureBox1 = new PictureBox();
            PictureBox1.DoubleClick += new EventHandler(PictureBox1_DoubleClick);
            ContextMenuStrip1 = new ContextMenuStrip(components);
            OuvrirToolStripMenuItem = new ToolStripMenuItem();
            OuvrirToolStripMenuItem.Click += new EventHandler(OuvrirToolStripMenuItem_Click);
            ToolStripMenuItem1 = new ToolStripSeparator();
            SupprimerToolStripMenuItem = new ToolStripMenuItem();
            SupprimerToolStripMenuItem.Click += new EventHandler(SupprimerToolStripMenuItem_Click);
            ToolStripMenuItem2 = new ToolStripSeparator();
            QuitterToolStripMenuItem = new ToolStripMenuItem();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Panel1.AutoScroll = true;
            Panel1.BackColor = Color.DimGray;
            Panel1.Controls.Add(PictureBox1);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(506, 264);
            Panel1.TabIndex = 0;
            // 
            // PictureBox1
            // 
            PictureBox1.ContextMenuStrip = ContextMenuStrip1;
            PictureBox1.Dock = DockStyle.Fill;
            PictureBox1.Location = new Point(0, 0);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(506, 264);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { OuvrirToolStripMenuItem, ToolStripMenuItem1, SupprimerToolStripMenuItem, ToolStripMenuItem2, QuitterToolStripMenuItem });
            ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip1.Size = new Size(229, 104);
            // 
            // OuvrirToolStripMenuItem
            // 
            OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem";
            OuvrirToolStripMenuItem.Size = new Size(228, 22);
            OuvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // ToolStripMenuItem1
            // 
            ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            ToolStripMenuItem1.Size = new Size(225, 6);
            // 
            // SupprimerToolStripMenuItem
            // 
            SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem";
            SupprimerToolStripMenuItem.Size = new Size(228, 22);
            SupprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // ToolStripMenuItem2
            // 
            ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            ToolStripMenuItem2.Size = new Size(225, 6);
            // 
            // QuitterToolStripMenuItem
            // 
            QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem";
            QuitterToolStripMenuItem.Size = new Size(228, 22);
            QuitterToolStripMenuItem.Text = "Quitter";
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Bottom;
            Button1.BackColor = Color.Cyan;
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(176, 277);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 0;
            Button1.Text = "<<";
            Button1.UseVisualStyleBackColor = false;
            // 
            // Button2
            // 
            Button2.Anchor = AnchorStyles.Bottom;
            Button2.BackColor = Color.Cyan;
            Button2.FlatAppearance.BorderSize = 0;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Location = new Point(257, 277);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 1;
            Button2.Text = ">>";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Visio
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(506, 312);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(Panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(514, 339);
            Name = "Visio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visionneuse d'images";
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ContextMenuStrip1.ResumeLayout(false);
            Load += new EventHandler(Form1_Load);
            Resize += new EventHandler(Form1_Resize);
            FormClosed += new FormClosedEventHandler(Visio_FormClosed);
            ResumeLayout(false);

        }
        internal Panel Panel1;
        internal PictureBox PictureBox1;
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem OuvrirToolStripMenuItem;
        internal ToolStripSeparator ToolStripMenuItem1;
        internal ToolStripMenuItem SupprimerToolStripMenuItem;
        internal ToolStripMenuItem DéfinirEnTantQuarrièrePlanToolStripMenuItem;
        internal ToolStripSeparator ToolStripMenuItem2;
        internal ToolStripMenuItem QuitterToolStripMenuItem;
        internal Button Button1;
        internal Button Button2;

    }
}