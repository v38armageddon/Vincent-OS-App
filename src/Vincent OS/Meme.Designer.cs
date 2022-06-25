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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(meme));
            TextBox1 = new TextBox();
            TextBox1.Click += new EventHandler(TextBox1_Click);
            TextBox1.KeyPress += new KeyPressEventHandler(TextBox1_KeyPress);
            WebBrowser1 = new WebBrowser();
            TabControl1 = new TabControl();
            TabPage2 = new TabPage();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Label1 = new Label();
            Label2 = new Label();
            PictureBox4 = new PictureBox();
            PictureBox5 = new PictureBox();
            PictureBox6 = new PictureBox();
            PictureBox7 = new PictureBox();
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            Button5 = new Button();
            Button5.Click += new EventHandler(Button5_Click);
            Button6 = new Button();
            Button6.Click += new EventHandler(Button6_Click);
            Button7 = new Button();
            Button7.Click += new EventHandler(Button7_Click);
            PictureBox8 = new PictureBox();
            Button8 = new Button();
            Button8.Click += new EventHandler(Button8_Click);
            Button9 = new Button();
            Button9.Click += new EventHandler(Button9_Click);
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
            TextBox1.Location = new Point(80, 12);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(676, 20);
            TextBox1.TabIndex = 0;
            TextBox1.Text = @"Entrez votre destination (exemple : C:\(nom de dossier))";
            // 
            // WebBrowser1
            // 
            WebBrowser1.Dock = DockStyle.Fill;
            WebBrowser1.Location = new Point(3, 3);
            WebBrowser1.MinimumSize = new Size(20, 20);
            WebBrowser1.Name = "WebBrowser1";
            WebBrowser1.Size = new Size(608, 336);
            WebBrowser1.TabIndex = 4;
            WebBrowser1.Url = new Uri(@"C:\Users\", UriKind.Absolute);
            // 
            // TabControl1
            // 
            TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TabControl1.Controls.Add(TabPage2);
            TabControl1.Location = new Point(141, 47);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(622, 368);
            TabControl1.TabIndex = 11;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(WebBrowser1);
            TabPage2.Location = new Point(4, 22);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(614, 342);
            TabPage2.TabIndex = 1;
            TabPage2.Text = @"C:\Users\";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button2.BackColor = Color.Green;
            Button2.FlatAppearance.BorderSize = 0;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.ForeColor = Color.White;
            Button2.Location = new Point(715, 46);
            Button2.Name = "Button2";
            Button2.Size = new Size(21, 20);
            Button2.TabIndex = 13;
            Button2.Text = "-";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button1.BackColor = Color.Green;
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(735, 46);
            Button1.Name = "Button1";
            Button1.Size = new Size(21, 20);
            Button1.TabIndex = 12;
            Button1.Text = "+";
            Button1.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(0, 45);
            Label1.Name = "Label1";
            Label1.Size = new Size(105, 22);
            Label1.TabIndex = 15;
            Label1.Text = "Raccourcis";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Arial", 14.25f);
            Label2.Location = new Point(0, 193);
            Label2.Name = "Label2";
            Label2.Size = new Size(135, 22);
            Label2.TabIndex = 16;
            Label2.Text = "Mon ordinateur";
            // 
            // PictureBox4
            // 
            PictureBox4.Image = (Image)resources.GetObject("PictureBox4.Image");
            PictureBox4.Location = new Point(4, 69);
            PictureBox4.Name = "PictureBox4";
            PictureBox4.Size = new Size(23, 23);
            PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox4.TabIndex = 17;
            PictureBox4.TabStop = false;
            // 
            // PictureBox5
            // 
            PictureBox5.Image = (Image)resources.GetObject("PictureBox5.Image");
            PictureBox5.Location = new Point(4, 98);
            PictureBox5.Name = "PictureBox5";
            PictureBox5.Size = new Size(23, 23);
            PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox5.TabIndex = 18;
            PictureBox5.TabStop = false;
            // 
            // PictureBox6
            // 
            PictureBox6.Image = (Image)resources.GetObject("PictureBox6.Image");
            PictureBox6.Location = new Point(4, 156);
            PictureBox6.Name = "PictureBox6";
            PictureBox6.Size = new Size(23, 23);
            PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox6.TabIndex = 20;
            PictureBox6.TabStop = false;
            // 
            // PictureBox7
            // 
            PictureBox7.Image = (Image)resources.GetObject("PictureBox7.Image");
            PictureBox7.Location = new Point(4, 127);
            PictureBox7.Name = "PictureBox7";
            PictureBox7.Size = new Size(23, 23);
            PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox7.TabIndex = 19;
            PictureBox7.TabStop = false;
            // 
            // Button3
            // 
            Button3.BackColor = Color.Green;
            Button3.FlatAppearance.BorderSize = 0;
            Button3.FlatStyle = FlatStyle.Flat;
            Button3.ForeColor = Color.White;
            Button3.Location = new Point(30, 69);
            Button3.Name = "Button3";
            Button3.Size = new Size(75, 23);
            Button3.TabIndex = 5;
            Button3.Text = "Documents";
            Button3.UseVisualStyleBackColor = false;
            // 
            // Button4
            // 
            Button4.BackColor = Color.Green;
            Button4.FlatAppearance.BorderSize = 0;
            Button4.FlatStyle = FlatStyle.Flat;
            Button4.ForeColor = Color.White;
            Button4.Location = new Point(30, 98);
            Button4.Name = "Button4";
            Button4.Size = new Size(75, 23);
            Button4.TabIndex = 21;
            Button4.Text = "Images";
            Button4.UseVisualStyleBackColor = false;
            // 
            // Button5
            // 
            Button5.BackColor = Color.Green;
            Button5.FlatAppearance.BorderSize = 0;
            Button5.FlatStyle = FlatStyle.Flat;
            Button5.ForeColor = Color.White;
            Button5.Location = new Point(30, 127);
            Button5.Name = "Button5";
            Button5.Size = new Size(75, 23);
            Button5.TabIndex = 22;
            Button5.Text = "Musiques";
            Button5.UseVisualStyleBackColor = false;
            // 
            // Button6
            // 
            Button6.BackColor = Color.Green;
            Button6.FlatAppearance.BorderSize = 0;
            Button6.FlatStyle = FlatStyle.Flat;
            Button6.ForeColor = Color.White;
            Button6.Location = new Point(30, 156);
            Button6.Name = "Button6";
            Button6.Size = new Size(75, 23);
            Button6.TabIndex = 23;
            Button6.Text = "Vidéos";
            Button6.UseVisualStyleBackColor = false;
            // 
            // Button7
            // 
            Button7.BackColor = Color.Green;
            Button7.FlatAppearance.BorderSize = 0;
            Button7.FlatStyle = FlatStyle.Flat;
            Button7.ForeColor = Color.White;
            Button7.Location = new Point(30, 218);
            Button7.Name = "Button7";
            Button7.Size = new Size(75, 23);
            Button7.TabIndex = 25;
            Button7.Text = @"C:\";
            Button7.UseVisualStyleBackColor = false;
            // 
            // PictureBox8
            // 
            PictureBox8.Image = (Image)resources.GetObject("PictureBox8.Image");
            PictureBox8.Location = new Point(4, 218);
            PictureBox8.Name = "PictureBox8";
            PictureBox8.Size = new Size(23, 23);
            PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox8.TabIndex = 24;
            PictureBox8.TabStop = false;
            // 
            // Button8
            // 
            Button8.BackgroundImage = (Image)resources.GetObject("Button8.BackgroundImage");
            Button8.BackgroundImageLayout = ImageLayout.Stretch;
            Button8.FlatAppearance.BorderSize = 0;
            Button8.FlatStyle = FlatStyle.Flat;
            Button8.Location = new Point(4, 5);
            Button8.Name = "Button8";
            Button8.Size = new Size(32, 32);
            Button8.TabIndex = 26;
            Button8.UseVisualStyleBackColor = true;
            // 
            // Button9
            // 
            Button9.BackgroundImage = (Image)resources.GetObject("Button9.BackgroundImage");
            Button9.BackgroundImageLayout = ImageLayout.Stretch;
            Button9.FlatAppearance.BorderSize = 0;
            Button9.FlatStyle = FlatStyle.Flat;
            Button9.Location = new Point(42, 5);
            Button9.Name = "Button9";
            Button9.Size = new Size(32, 32);
            Button9.TabIndex = 5;
            Button9.UseVisualStyleBackColor = true;
            // 
            // meme
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(762, 415);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(778, 449);
            Name = "meme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Explorateur de fichier";
            TabControl1.ResumeLayout(false);
            TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox8).EndInit();
            Load += new EventHandler(meme_Load);
            FormClosed += new FormClosedEventHandler(meme_FormClosed);
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