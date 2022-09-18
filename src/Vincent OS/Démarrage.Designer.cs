using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Démarrage : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Démarrage));
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.ProgressBar1.TabIndex = 0;
            this.ProgressBar1.Visible = false;
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
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(472, 375);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(100, 100);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroProgressSpinner1.TabIndex = 4;
            this.metroProgressSpinner1.Text = "metroProgressSpinner1";
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner1.UseCustomForeColor = true;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 10;
            // 
            // Démarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(989, 520);
            this.ControlBox = false;
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.ProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Démarrage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Démarrage en cours...";
            this.Load += new System.EventHandler(this.Démarrage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        internal ProgressBar ProgressBar1;
        internal PictureBox PictureBox1;
        internal Timer Timer1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
    }
}