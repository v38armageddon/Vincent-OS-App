using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Arrêt : Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arrêt));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(343, 18);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(357, 347);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ProgressBar1.Location = new System.Drawing.Point(14, 479);
            this.ProgressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProgressBar1.RightToLeftLayout = true;
            this.ProgressBar1.Size = new System.Drawing.Size(961, 28);
            this.ProgressBar1.TabIndex = 4;
            this.ProgressBar1.Visible = false;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(426, 373);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(184, 102);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 5;
            this.PictureBox2.TabStop = false;
            // 
            // Arrêt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(989, 520);
            this.ControlBox = false;
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Arrêt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrêt en cours...";
            this.Load += new System.EventHandler(this.Arrêt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }
        internal PictureBox PictureBox1;
        internal ProgressBar ProgressBar1;
        internal Timer Timer1;
        internal PictureBox PictureBox2;
    }
}