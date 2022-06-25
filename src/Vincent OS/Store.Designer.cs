using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Store : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Button5 = new System.Windows.Forms.Button();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Label13 = new System.Windows.Forms.Label();
            this.Button11 = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.PictureBox11 = new System.Windows.Forms.PictureBox();
            this.PictureBox9 = new System.Windows.Forms.PictureBox();
            this.Button9 = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.VosTéléchargementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 24);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(450, 339);
            this.TabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.Button5);
            this.TabPage1.Controls.Add(this.Label11);
            this.TabPage1.Controls.Add(this.PictureBox11);
            this.TabPage1.Controls.Add(this.Panel5);
            this.TabPage1.Controls.Add(this.PictureBox9);
            this.TabPage1.Controls.Add(this.Button9);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(442, 313);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Applications Vincent OS";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.Green;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Location = new System.Drawing.Point(12, 229);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(96, 23);
            this.Button5.TabIndex = 12;
            this.Button5.Text = "Ajouter";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Panel5
            // 
            this.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel5.BackColor = System.Drawing.Color.Gray;
            this.Panel5.Controls.Add(this.label3);
            this.Panel5.Controls.Add(this.pictureBox5);
            this.Panel5.Controls.Add(this.Label13);
            this.Panel5.Controls.Add(this.Button11);
            this.Panel5.Location = new System.Drawing.Point(6, 6);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(433, 92);
            this.Panel5.TabIndex = 10;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(91, 25);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(342, 36);
            this.Label13.TabIndex = 9;
            this.Label13.Text = "La version système d\'exploitation de Vincent OS\r\nenfin en cours de développement " +
    "!";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Button11
            // 
            this.Button11.BackColor = System.Drawing.Color.Green;
            this.Button11.FlatAppearance.BorderSize = 0;
            this.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button11.ForeColor = System.Drawing.Color.White;
            this.Button11.Location = new System.Drawing.Point(199, 64);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(129, 23);
            this.Button11.TabIndex = 7;
            this.Button11.Text = "En savoir plus";
            this.Button11.UseVisualStyleBackColor = false;
            this.Button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Label11.Location = new System.Drawing.Point(269, 204);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(173, 22);
            this.Label11.TabIndex = 6;
            this.Label11.Text = "Vincent OS Legacy";
            // 
            // PictureBox11
            // 
            this.PictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox11.Image")));
            this.PictureBox11.Location = new System.Drawing.Point(311, 101);
            this.PictureBox11.Name = "PictureBox11";
            this.PictureBox11.Size = new System.Drawing.Size(96, 97);
            this.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox11.TabIndex = 8;
            this.PictureBox11.TabStop = false;
            // 
            // PictureBox9
            // 
            this.PictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox9.Image")));
            this.PictureBox9.Location = new System.Drawing.Point(12, 101);
            this.PictureBox9.Name = "PictureBox9";
            this.PictureBox9.Size = new System.Drawing.Size(96, 97);
            this.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox9.TabIndex = 2;
            this.PictureBox9.TabStop = false;
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.Green;
            this.Button9.FlatAppearance.BorderSize = 0;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.ForeColor = System.Drawing.Color.White;
            this.Button9.Location = new System.Drawing.Point(311, 229);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(96, 23);
            this.Button9.TabIndex = 1;
            this.Button9.Text = "Voir sur GitHub";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Label9.Location = new System.Drawing.Point(23, 204);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(72, 22);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "Chrono";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.Button4);
            this.TabPage2.Controls.Add(this.Button3);
            this.TabPage2.Controls.Add(this.Button2);
            this.TabPage2.Controls.Add(this.Button1);
            this.TabPage2.Controls.Add(this.Label5);
            this.TabPage2.Controls.Add(this.Label4);
            this.TabPage2.Controls.Add(this.Label2);
            this.TabPage2.Controls.Add(this.Label1);
            this.TabPage2.Controls.Add(this.PictureBox4);
            this.TabPage2.Controls.Add(this.PictureBox3);
            this.TabPage2.Controls.Add(this.PictureBox2);
            this.TabPage2.Controls.Add(this.PictureBox1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(442, 313);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Applications sur Internet";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.Green;
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.Location = new System.Drawing.Point(8, 285);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(96, 23);
            this.Button4.TabIndex = 12;
            this.Button4.Text = "Ajouter";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Green;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(329, 131);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(96, 23);
            this.Button3.TabIndex = 11;
            this.Button3.Text = "Ajouter";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Green;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(162, 131);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(96, 23);
            this.Button2.TabIndex = 10;
            this.Button2.Text = "Ajouter";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Green;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(8, 131);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(96, 23);
            this.Button1.TabIndex = 9;
            this.Button1.Text = "Ajouter";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Label5.Location = new System.Drawing.Point(23, 260);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(65, 22);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Steam";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Label4.Location = new System.Drawing.Point(306, 106);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(131, 22);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Mozilla Firefox";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Label2.Location = new System.Drawing.Point(138, 106);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(146, 22);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Google Chrome";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(18, 106);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 22);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Discord";
            // 
            // PictureBox4
            // 
            this.PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox4.Image")));
            this.PictureBox4.Location = new System.Drawing.Point(329, 6);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(96, 97);
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox4.TabIndex = 3;
            this.PictureBox4.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(8, 6);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(96, 97);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 2;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(162, 6);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(96, 97);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 1;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(8, 160);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(96, 97);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VosTéléchargementsToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(450, 24);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // VosTéléchargementsToolStripMenuItem
            // 
            this.VosTéléchargementsToolStripMenuItem.Name = "VosTéléchargementsToolStripMenuItem";
            this.VosTéléchargementsToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.VosTéléchargementsToolStripMenuItem.Text = "Vos téléchargements";
            this.VosTéléchargementsToolStripMenuItem.Click += new System.EventHandler(this.VosTéléchargementsToolStripMenuItem_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(6, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(83, 83);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Êtes vous prêt pour Vincent OS ?";
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 363);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.MenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vincent OS Store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Store_FormClosed);
            this.Load += new System.EventHandler(this.Store_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal TabControl TabControl1;
        internal TabPage TabPage1;
        internal TabPage TabPage2;
        internal Button Button4;
        internal Button Button3;
        internal Button Button2;
        internal Button Button1;
        internal Label Label5;
        internal Label Label4;
        internal Label Label2;
        internal Label Label1;
        internal PictureBox PictureBox4;
        internal PictureBox PictureBox3;
        internal PictureBox PictureBox2;
        internal PictureBox PictureBox1;
        internal Timer Timer1;
        internal PictureBox PictureBox11;
        internal Button Button11;
        internal Label Label11;
        internal PictureBox PictureBox9;
        internal Button Button9;
        internal Label Label9;
        internal Panel Panel5;
        internal Label Label13;
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem VosTéléchargementsToolStripMenuItem;
        internal Button Button5;
        internal PictureBox pictureBox5;
        internal Label label3;
    }
}