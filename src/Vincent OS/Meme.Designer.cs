using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class meme : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(meme));
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.PictureBox6 = new System.Windows.Forms.PictureBox();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.PictureBox8 = new System.Windows.Forms.PictureBox();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox1.Location = new System.Drawing.Point(93, 14);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(788, 23);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.Text = "Entrez votre destination (exemple : C:\\(nom de dossier))";
            this.TextBox1.Click += new System.EventHandler(this.TextBox1_Click);
            this.TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser1.Location = new System.Drawing.Point(4, 3);
            this.WebBrowser1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WebBrowser1.MinimumSize = new System.Drawing.Size(23, 23);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.Size = new System.Drawing.Size(721, 391);
            this.WebBrowser1.TabIndex = 4;
            this.WebBrowser1.Url = new System.Uri("file:///C:/Users", System.UriKind.Absolute);
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(153, 54);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(737, 425);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.TabIndex = 11;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.WebBrowser1);
            this.TabPage2.Location = new System.Drawing.Point(4, 24);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPage2.Size = new System.Drawing.Size(729, 397);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "C:\\Users\\";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.BackColor = System.Drawing.Color.Green;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(834, 53);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(24, 23);
            this.Button2.TabIndex = 13;
            this.Button2.Text = "-";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.BackColor = System.Drawing.Color.Green;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(858, 53);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(24, 23);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "+";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(5, 53);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(102, 25);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Raccourcis";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(5, 224);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(145, 25);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Mon ordinateur";
            // 
            // PictureBox4
            // 
            this.PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox4.Image")));
            this.PictureBox4.Location = new System.Drawing.Point(5, 80);
            this.PictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(27, 27);
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox4.TabIndex = 17;
            this.PictureBox4.TabStop = false;
            // 
            // PictureBox5
            // 
            this.PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox5.Image")));
            this.PictureBox5.Location = new System.Drawing.Point(5, 113);
            this.PictureBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(27, 27);
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox5.TabIndex = 18;
            this.PictureBox5.TabStop = false;
            // 
            // PictureBox6
            // 
            this.PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox6.Image")));
            this.PictureBox6.Location = new System.Drawing.Point(5, 180);
            this.PictureBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PictureBox6.Name = "PictureBox6";
            this.PictureBox6.Size = new System.Drawing.Size(27, 27);
            this.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox6.TabIndex = 20;
            this.PictureBox6.TabStop = false;
            // 
            // PictureBox7
            // 
            this.PictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox7.Image")));
            this.PictureBox7.Location = new System.Drawing.Point(5, 147);
            this.PictureBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new System.Drawing.Size(27, 27);
            this.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox7.TabIndex = 19;
            this.PictureBox7.TabStop = false;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Green;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(35, 80);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(88, 27);
            this.Button3.TabIndex = 5;
            this.Button3.Text = "Documents";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.Green;
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.Location = new System.Drawing.Point(35, 113);
            this.Button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(88, 27);
            this.Button4.TabIndex = 21;
            this.Button4.Text = "Images";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.Green;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Location = new System.Drawing.Point(35, 147);
            this.Button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(88, 27);
            this.Button5.TabIndex = 22;
            this.Button5.Text = "Musiques";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.Green;
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Location = new System.Drawing.Point(35, 180);
            this.Button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(88, 27);
            this.Button6.TabIndex = 23;
            this.Button6.Text = "Vidéos";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.Green;
            this.Button7.FlatAppearance.BorderSize = 0;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.ForeColor = System.Drawing.Color.White;
            this.Button7.Location = new System.Drawing.Point(35, 252);
            this.Button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(88, 27);
            this.Button7.TabIndex = 25;
            this.Button7.Text = "C:\\";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // PictureBox8
            // 
            this.PictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox8.Image")));
            this.PictureBox8.Location = new System.Drawing.Point(5, 252);
            this.PictureBox8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PictureBox8.Name = "PictureBox8";
            this.PictureBox8.Size = new System.Drawing.Size(27, 27);
            this.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox8.TabIndex = 24;
            this.PictureBox8.TabStop = false;
            // 
            // Button8
            // 
            this.Button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button8.BackgroundImage")));
            this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button8.FlatAppearance.BorderSize = 0;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.Location = new System.Drawing.Point(5, 6);
            this.Button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(37, 37);
            this.Button8.TabIndex = 26;
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button9
            // 
            this.Button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button9.BackgroundImage")));
            this.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button9.FlatAppearance.BorderSize = 0;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Location = new System.Drawing.Point(49, 6);
            this.Button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(37, 37);
            this.Button9.TabIndex = 5;
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // meme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(889, 479);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.PictureBox8);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.PictureBox6);
            this.Controls.Add(this.PictureBox7);
            this.Controls.Add(this.PictureBox5);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.TabControl1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(905, 512);
            this.Name = "meme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorateur de fichier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.meme_FormClosed);
            this.Load += new System.EventHandler(this.meme_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal TextBox TextBox1;
        internal WebBrowser WebBrowser1;
        internal TabControl TabControl1;
        internal TabPage TabPage2;
        internal Button Button2;
        internal Button Button1;
        internal Label Label1;
        internal Label Label2;
        internal PictureBox PictureBox4;
        internal PictureBox PictureBox5;
        internal PictureBox PictureBox6;
        internal PictureBox PictureBox7;
        internal Button Button3;
        internal Button Button4;
        internal Button Button5;
        internal Button Button6;
        internal Button Button7;
        internal PictureBox PictureBox8;
        internal Button Button8;
        internal Button Button9;
    }
}