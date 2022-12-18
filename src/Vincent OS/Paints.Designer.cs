using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class paints : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paints));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox1.Location = new System.Drawing.Point(126, 0);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(690, 437);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Red;
            this.Panel1.Location = new System.Drawing.Point(14, 14);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(41, 38);
            this.Panel1.TabIndex = 1;
            this.Panel1.Click += new System.EventHandler(this.Panel1_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Green;
            this.Panel2.Location = new System.Drawing.Point(64, 14);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(41, 38);
            this.Panel2.TabIndex = 2;
            this.Panel2.Click += new System.EventHandler(this.Panel2_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Blue;
            this.Panel3.Location = new System.Drawing.Point(14, 59);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(41, 38);
            this.Panel3.TabIndex = 3;
            this.Panel3.Click += new System.EventHandler(this.Panel3_Click);
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Yellow;
            this.Panel4.Location = new System.Drawing.Point(64, 59);
            this.Panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(41, 38);
            this.Panel4.TabIndex = 2;
            this.Panel4.Click += new System.EventHandler(this.Panel4_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Green;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Location = new System.Drawing.Point(14, 104);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(41, 38);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "|";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Green;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.Location = new System.Drawing.Point(64, 104);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(41, 38);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "|";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Green;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Location = new System.Drawing.Point(14, 149);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(91, 27);
            this.Button3.TabIndex = 6;
            this.Button3.Text = "Gomme";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.Green;
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Location = new System.Drawing.Point(14, 182);
            this.Button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(91, 27);
            this.Button4.TabIndex = 7;
            this.Button4.Text = "Pinceau";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.Green;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Location = new System.Drawing.Point(14, 216);
            this.Button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(91, 27);
            this.Button5.TabIndex = 8;
            this.Button5.Text = "Remplir";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.Green;
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Location = new System.Drawing.Point(14, 249);
            this.Button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(91, 27);
            this.Button6.TabIndex = 9;
            this.Button6.Text = "Supprimer";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // paints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(816, 436);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.PictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(832, 469);
            this.Name = "paints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.paints_FormClosed);
            this.Load += new System.EventHandler(this.paints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        internal PictureBox PictureBox1;
        internal Panel Panel1;
        internal Panel Panel2;
        internal Panel Panel3;
        internal Panel Panel4;
        internal Button Button1;
        internal Button Button2;
        internal Button Button3;
        internal Button Button4;
        internal Button Button5;
        internal Button Button6;
    }
}