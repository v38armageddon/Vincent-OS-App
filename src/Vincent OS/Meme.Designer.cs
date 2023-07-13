using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Meme : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meme));
            TextBox1 = new TextBox();
            WebBrowser1 = new WebBrowser();
            TabControl1 = new TabControl();
            TabPage2 = new TabPage();
            Button2 = new Button();
            Button1 = new Button();
            Label1 = new Label();
            Label2 = new Label();
            PictureBox4 = new PictureBox();
            PictureBox5 = new PictureBox();
            PictureBox6 = new PictureBox();
            PictureBox7 = new PictureBox();
            Button3 = new Button();
            Button4 = new Button();
            Button5 = new Button();
            Button6 = new Button();
            Button7 = new Button();
            PictureBox8 = new PictureBox();
            Button8 = new Button();
            Button9 = new Button();
            TabControl1.SuspendLayout();
            TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox8).BeginInit();
            SuspendLayout();
            // 
            // TextBox1
            // 
            TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox1.Location = new Point(93, 14);
            TextBox1.Margin = new Padding(4, 3, 4, 3);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(788, 23);
            TextBox1.TabIndex = 0;
            TextBox1.Text = "Entrez votre destination (exemple : C:\\(nom de dossier))";
            TextBox1.Click += TextBox1_Click;
            TextBox1.KeyPress += TextBox1_KeyPress;
            // 
            // WebBrowser1
            // 
            WebBrowser1.Dock = DockStyle.Fill;
            WebBrowser1.Location = new Point(4, 3);
            WebBrowser1.Margin = new Padding(4, 3, 4, 3);
            WebBrowser1.MinimumSize = new Size(23, 23);
            WebBrowser1.Name = "WebBrowser1";
            WebBrowser1.Size = new Size(721, 391);
            WebBrowser1.TabIndex = 4;
            WebBrowser1.Url = new Uri("file:///C:/Users", UriKind.Absolute);
            // 
            // TabControl1
            // 
            TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Location = new Point(153, 54);
            TabControl1.Margin = new Padding(4, 3, 4, 3);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(737, 425);
            TabControl1.SizeMode = TabSizeMode.Fixed;
            TabControl1.TabIndex = 11;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(WebBrowser1);
            TabPage2.Location = new Point(4, 24);
            TabPage2.Margin = new Padding(4, 3, 4, 3);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(4, 3, 4, 3);
            TabPage2.Size = new Size(729, 397);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "C:\\Users\\";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button2.BackColor = Color.Green;
            Button2.FlatAppearance.BorderSize = 0;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.ForeColor = Color.White;
            Button2.Location = new Point(834, 53);
            Button2.Margin = new Padding(4, 3, 4, 3);
            Button2.Name = "Button2";
            Button2.Size = new Size(24, 23);
            Button2.TabIndex = 13;
            Button2.Text = "-";
            Button2.UseVisualStyleBackColor = false;
            Button2.Click += Button2_Click;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button1.BackColor = Color.Green;
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(858, 53);
            Button1.Margin = new Padding(4, 3, 4, 3);
            Button1.Name = "Button1";
            Button1.Size = new Size(24, 23);
            Button1.TabIndex = 12;
            Button1.Text = "+";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.Location = new Point(5, 53);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(102, 25);
            Label1.TabIndex = 15;
            Label1.Text = "Raccourcis";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.Location = new Point(5, 224);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(145, 25);
            Label2.TabIndex = 16;
            Label2.Text = "Mon ordinateur";
            // 
            // PictureBox4
            // 
            PictureBox4.Image = (Image)resources.GetObject("PictureBox4.Image");
            PictureBox4.Location = new Point(5, 80);
            PictureBox4.Margin = new Padding(4, 3, 4, 3);
            PictureBox4.Name = "PictureBox4";
            PictureBox4.Size = new Size(27, 27);
            PictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox4.TabIndex = 17;
            PictureBox4.TabStop = false;
            // 
            // PictureBox5
            // 
            PictureBox5.Image = (Image)resources.GetObject("PictureBox5.Image");
            PictureBox5.Location = new Point(5, 113);
            PictureBox5.Margin = new Padding(4, 3, 4, 3);
            PictureBox5.Name = "PictureBox5";
            PictureBox5.Size = new Size(27, 27);
            PictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox5.TabIndex = 18;
            PictureBox5.TabStop = false;
            // 
            // PictureBox6
            // 
            PictureBox6.Image = (Image)resources.GetObject("PictureBox6.Image");
            PictureBox6.Location = new Point(5, 180);
            PictureBox6.Margin = new Padding(4, 3, 4, 3);
            PictureBox6.Name = "PictureBox6";
            PictureBox6.Size = new Size(27, 27);
            PictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox6.TabIndex = 20;
            PictureBox6.TabStop = false;
            // 
            // PictureBox7
            // 
            PictureBox7.Image = (Image)resources.GetObject("PictureBox7.Image");
            PictureBox7.Location = new Point(5, 147);
            PictureBox7.Margin = new Padding(4, 3, 4, 3);
            PictureBox7.Name = "PictureBox7";
            PictureBox7.Size = new Size(27, 27);
            PictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox7.TabIndex = 19;
            PictureBox7.TabStop = false;
            // 
            // Button3
            // 
            Button3.BackColor = Color.Green;
            Button3.FlatAppearance.BorderSize = 0;
            Button3.FlatStyle = FlatStyle.Flat;
            Button3.ForeColor = Color.White;
            Button3.Location = new Point(35, 80);
            Button3.Margin = new Padding(4, 3, 4, 3);
            Button3.Name = "Button3";
            Button3.Size = new Size(88, 27);
            Button3.TabIndex = 5;
            Button3.Text = "Documents";
            Button3.UseVisualStyleBackColor = false;
            Button3.Click += Button3_Click;
            // 
            // Button4
            // 
            Button4.BackColor = Color.Green;
            Button4.FlatAppearance.BorderSize = 0;
            Button4.FlatStyle = FlatStyle.Flat;
            Button4.ForeColor = Color.White;
            Button4.Location = new Point(35, 113);
            Button4.Margin = new Padding(4, 3, 4, 3);
            Button4.Name = "Button4";
            Button4.Size = new Size(88, 27);
            Button4.TabIndex = 21;
            Button4.Text = "Images";
            Button4.UseVisualStyleBackColor = false;
            Button4.Click += Button4_Click;
            // 
            // Button5
            // 
            Button5.BackColor = Color.Green;
            Button5.FlatAppearance.BorderSize = 0;
            Button5.FlatStyle = FlatStyle.Flat;
            Button5.ForeColor = Color.White;
            Button5.Location = new Point(35, 147);
            Button5.Margin = new Padding(4, 3, 4, 3);
            Button5.Name = "Button5";
            Button5.Size = new Size(88, 27);
            Button5.TabIndex = 22;
            Button5.Text = "Musiques";
            Button5.UseVisualStyleBackColor = false;
            Button5.Click += Button5_Click;
            // 
            // Button6
            // 
            Button6.BackColor = Color.Green;
            Button6.FlatAppearance.BorderSize = 0;
            Button6.FlatStyle = FlatStyle.Flat;
            Button6.ForeColor = Color.White;
            Button6.Location = new Point(35, 180);
            Button6.Margin = new Padding(4, 3, 4, 3);
            Button6.Name = "Button6";
            Button6.Size = new Size(88, 27);
            Button6.TabIndex = 23;
            Button6.Text = "Vidéos";
            Button6.UseVisualStyleBackColor = false;
            Button6.Click += Button6_Click;
            // 
            // Button7
            // 
            Button7.BackColor = Color.Green;
            Button7.FlatAppearance.BorderSize = 0;
            Button7.FlatStyle = FlatStyle.Flat;
            Button7.ForeColor = Color.White;
            Button7.Location = new Point(35, 252);
            Button7.Margin = new Padding(4, 3, 4, 3);
            Button7.Name = "Button7";
            Button7.Size = new Size(88, 27);
            Button7.TabIndex = 25;
            Button7.Text = "C:\\";
            Button7.UseVisualStyleBackColor = false;
            Button7.Click += Button7_Click;
            // 
            // PictureBox8
            // 
            PictureBox8.Image = (Image)resources.GetObject("PictureBox8.Image");
            PictureBox8.Location = new Point(5, 252);
            PictureBox8.Margin = new Padding(4, 3, 4, 3);
            PictureBox8.Name = "PictureBox8";
            PictureBox8.Size = new Size(27, 27);
            PictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox8.TabIndex = 24;
            PictureBox8.TabStop = false;
            // 
            // Button8
            // 
            Button8.BackgroundImage = (Image)resources.GetObject("Button8.BackgroundImage");
            Button8.BackgroundImageLayout = ImageLayout.Stretch;
            Button8.FlatAppearance.BorderSize = 0;
            Button8.FlatStyle = FlatStyle.Flat;
            Button8.Location = new Point(5, 6);
            Button8.Margin = new Padding(4, 3, 4, 3);
            Button8.Name = "Button8";
            Button8.Size = new Size(37, 37);
            Button8.TabIndex = 26;
            Button8.UseVisualStyleBackColor = true;
            Button8.Click += Button8_Click;
            // 
            // Button9
            // 
            Button9.BackgroundImage = (Image)resources.GetObject("Button9.BackgroundImage");
            Button9.BackgroundImageLayout = ImageLayout.Stretch;
            Button9.FlatAppearance.BorderSize = 0;
            Button9.FlatStyle = FlatStyle.Flat;
            Button9.Location = new Point(49, 6);
            Button9.Margin = new Padding(4, 3, 4, 3);
            Button9.Name = "Button9";
            Button9.Size = new Size(37, 37);
            Button9.TabIndex = 5;
            Button9.UseVisualStyleBackColor = true;
            Button9.Click += Button9_Click;
            // 
            // meme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(889, 479);
            Controls.Add(Button9);
            Controls.Add(Button8);
            Controls.Add(Button7);
            Controls.Add(PictureBox8);
            Controls.Add(Button6);
            Controls.Add(Button5);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(PictureBox6);
            Controls.Add(PictureBox7);
            Controls.Add(PictureBox5);
            Controls.Add(PictureBox4);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(TextBox1);
            Controls.Add(TabControl1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(905, 512);
            Name = "meme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Explorateur de fichier";
            FormClosed += meme_FormClosed;
            Load += meme_Load;
            TabControl1.ResumeLayout(false);
            TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
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