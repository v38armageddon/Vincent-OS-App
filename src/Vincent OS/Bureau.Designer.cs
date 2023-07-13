using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Bureau : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bureau));
            Timer1 = new Timer(components);
            MonthCalendar1 = new MonthCalendar();
            Label2 = new Label();
            Panel1 = new Panel();
            Button9 = new Button();
            Label3 = new Label();
            PictureBox3 = new PictureBox();
            Button1 = new Button();
            Label1 = new Label();
            FlowLayoutPanel2 = new FlowLayoutPanel();
            Button15 = new Button();
            Button16 = new Button();
            Button17 = new Button();
            Button19 = new Button();
            Button20 = new Button();
            Button21 = new Button();
            Button22 = new Button();
            Button23 = new Button();
            Button24 = new Button();
            Button26 = new Button();
            Button12 = new Button();
            PictureBox2 = new PictureBox();
            Button2 = new Button();
            Button3 = new Button();
            Button6 = new Button();
            Button4 = new Button();
            Button5 = new Button();
            Button14 = new Button();
            Button13 = new Button();
            Button11 = new Button();
            Button10 = new Button();
            Button25 = new Button();
            Label5 = new Label();
            Label4 = new Label();
            PictureBox7 = new PictureBox();
            PictureBox6 = new PictureBox();
            FlowLayoutPanel1 = new FlowLayoutPanel();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            FlowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox6).BeginInit();
            FlowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Timer1
            // 
            Timer1.Tick += Timer1_Tick;
            // 
            // MonthCalendar1
            // 
            MonthCalendar1.Location = new Point(5, 57);
            MonthCalendar1.Name = "MonthCalendar1";
            MonthCalendar1.TabIndex = 3;
            MonthCalendar1.Visible = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Black;
            Label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(17, 3);
            Label2.Name = "Label2";
            Label2.Size = new Size(63, 20);
            Label2.TabIndex = 2;
            Label2.Text = "00:00:00";
            Label2.Click += Label2_Click;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel1.BackColor = Color.Black;
            Panel1.Controls.Add(Button9);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(PictureBox3);
            Panel1.Controls.Add(Button1);
            Panel1.Location = new Point(921, 54);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(157, 116);
            Panel1.TabIndex = 4;
            Panel1.Visible = false;
            // 
            // Button9
            // 
            Button9.BackColor = Color.Green;
            Button9.FlatAppearance.BorderSize = 0;
            Button9.FlatStyle = FlatStyle.Flat;
            Button9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button9.ForeColor = Color.White;
            Button9.Location = new Point(60, 20);
            Button9.Name = "Button9";
            Button9.Size = new Size(94, 26);
            Button9.TabIndex = 5;
            Button9.Text = "Paramètres";
            Button9.UseVisualStyleBackColor = false;
            Button9.Click += Button9_Click;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(60, 3);
            Label3.Name = "Label3";
            Label3.Size = new Size(89, 15);
            Label3.TabIndex = 2;
            Label3.Text = "Superutilisateur";
            // 
            // PictureBox3
            // 
            PictureBox3.Image = (Image)resources.GetObject("PictureBox3.Image");
            PictureBox3.Location = new Point(3, 3);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(55, 55);
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox3.TabIndex = 1;
            PictureBox3.TabStop = false;
            // 
            // Button1
            // 
            Button1.BackColor = Color.DarkRed;
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatStyle = FlatStyle.Popup;
            Button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(3, 64);
            Button1.Name = "Button1";
            Button1.Size = new Size(151, 44);
            Button1.TabIndex = 0;
            Button1.Text = "Quitter";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Black;
            Label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(5, 23);
            Label1.Name = "Label1";
            Label1.Size = new Size(85, 20);
            Label1.TabIndex = 22;
            Label1.Text = "00/00/0000";
            Label1.Click += Label1_Click;
            // 
            // FlowLayoutPanel2
            // 
            FlowLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FlowLayoutPanel2.BackColor = Color.Black;
            FlowLayoutPanel2.Controls.Add(Button15);
            FlowLayoutPanel2.Controls.Add(Button16);
            FlowLayoutPanel2.Controls.Add(Button17);
            FlowLayoutPanel2.Controls.Add(Button19);
            FlowLayoutPanel2.Controls.Add(Button20);
            FlowLayoutPanel2.Controls.Add(Button21);
            FlowLayoutPanel2.Controls.Add(Button22);
            FlowLayoutPanel2.Controls.Add(Button23);
            FlowLayoutPanel2.Controls.Add(Button24);
            FlowLayoutPanel2.Controls.Add(Button26);
            FlowLayoutPanel2.Location = new Point(54, 535);
            FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            FlowLayoutPanel2.Size = new Size(970, 49);
            FlowLayoutPanel2.TabIndex = 27;
            // 
            // Button15
            // 
            Button15.BackgroundImage = (Image)resources.GetObject("Button15.BackgroundImage");
            Button15.BackgroundImageLayout = ImageLayout.Stretch;
            Button15.FlatStyle = FlatStyle.Flat;
            Button15.Location = new Point(3, 3);
            Button15.Name = "Button15";
            Button15.Size = new Size(40, 40);
            Button15.TabIndex = 24;
            Button15.UseVisualStyleBackColor = true;
            Button15.Visible = false;
            Button15.Click += Button15_Click;
            // 
            // Button16
            // 
            Button16.BackgroundImage = (Image)resources.GetObject("Button16.BackgroundImage");
            Button16.BackgroundImageLayout = ImageLayout.Stretch;
            Button16.FlatStyle = FlatStyle.Flat;
            Button16.Location = new Point(49, 3);
            Button16.Name = "Button16";
            Button16.Size = new Size(40, 40);
            Button16.TabIndex = 25;
            Button16.UseVisualStyleBackColor = true;
            Button16.Visible = false;
            Button16.Click += Button16_Click;
            // 
            // Button17
            // 
            Button17.BackgroundImage = (Image)resources.GetObject("Button17.BackgroundImage");
            Button17.BackgroundImageLayout = ImageLayout.Stretch;
            Button17.FlatStyle = FlatStyle.Flat;
            Button17.Location = new Point(95, 3);
            Button17.Name = "Button17";
            Button17.Size = new Size(40, 40);
            Button17.TabIndex = 26;
            Button17.UseVisualStyleBackColor = true;
            Button17.Visible = false;
            Button17.Click += Button17_Click;
            // 
            // Button19
            // 
            Button19.BackgroundImage = (Image)resources.GetObject("Button19.BackgroundImage");
            Button19.BackgroundImageLayout = ImageLayout.Stretch;
            Button19.FlatStyle = FlatStyle.Flat;
            Button19.Location = new Point(141, 3);
            Button19.Name = "Button19";
            Button19.Size = new Size(40, 40);
            Button19.TabIndex = 28;
            Button19.UseVisualStyleBackColor = true;
            Button19.Visible = false;
            Button19.Click += Button19_Click;
            // 
            // Button20
            // 
            Button20.BackgroundImage = (Image)resources.GetObject("Button20.BackgroundImage");
            Button20.BackgroundImageLayout = ImageLayout.Stretch;
            Button20.FlatStyle = FlatStyle.Flat;
            Button20.Location = new Point(187, 3);
            Button20.Name = "Button20";
            Button20.Size = new Size(40, 40);
            Button20.TabIndex = 29;
            Button20.UseVisualStyleBackColor = true;
            Button20.Visible = false;
            Button20.Click += Button20_Click;
            // 
            // Button21
            // 
            Button21.BackgroundImage = (Image)resources.GetObject("Button21.BackgroundImage");
            Button21.BackgroundImageLayout = ImageLayout.Stretch;
            Button21.FlatStyle = FlatStyle.Flat;
            Button21.Location = new Point(233, 3);
            Button21.Name = "Button21";
            Button21.Size = new Size(40, 40);
            Button21.TabIndex = 30;
            Button21.UseVisualStyleBackColor = true;
            Button21.Visible = false;
            Button21.Click += Button21_Click;
            // 
            // Button22
            // 
            Button22.BackgroundImage = (Image)resources.GetObject("Button22.BackgroundImage");
            Button22.BackgroundImageLayout = ImageLayout.Stretch;
            Button22.FlatStyle = FlatStyle.Flat;
            Button22.Location = new Point(279, 3);
            Button22.Name = "Button22";
            Button22.Size = new Size(40, 40);
            Button22.TabIndex = 31;
            Button22.UseVisualStyleBackColor = true;
            Button22.Visible = false;
            Button22.Click += Button22_Click;
            // 
            // Button23
            // 
            Button23.BackgroundImage = (Image)resources.GetObject("Button23.BackgroundImage");
            Button23.BackgroundImageLayout = ImageLayout.Stretch;
            Button23.FlatStyle = FlatStyle.Flat;
            Button23.Location = new Point(325, 3);
            Button23.Name = "Button23";
            Button23.Size = new Size(40, 40);
            Button23.TabIndex = 32;
            Button23.UseVisualStyleBackColor = true;
            Button23.Visible = false;
            Button23.Click += Button23_Click;
            // 
            // Button24
            // 
            Button24.BackgroundImage = (Image)resources.GetObject("Button24.BackgroundImage");
            Button24.BackgroundImageLayout = ImageLayout.Stretch;
            Button24.FlatStyle = FlatStyle.Flat;
            Button24.Location = new Point(371, 3);
            Button24.Name = "Button24";
            Button24.Size = new Size(40, 40);
            Button24.TabIndex = 33;
            Button24.UseVisualStyleBackColor = true;
            Button24.Visible = false;
            Button24.Click += Button24_Click;
            // 
            // Button26
            // 
            Button26.BackgroundImage = (Image)resources.GetObject("Button26.BackgroundImage");
            Button26.BackgroundImageLayout = ImageLayout.Stretch;
            Button26.FlatStyle = FlatStyle.Flat;
            Button26.Location = new Point(417, 3);
            Button26.Name = "Button26";
            Button26.Size = new Size(40, 40);
            Button26.TabIndex = 36;
            Button26.UseVisualStyleBackColor = true;
            Button26.Visible = false;
            Button26.Click += Button26_Click;
            // 
            // Button12
            // 
            Button12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button12.BackColor = Color.Black;
            Button12.BackgroundImage = (Image)resources.GetObject("Button12.BackgroundImage");
            Button12.BackgroundImageLayout = ImageLayout.Stretch;
            Button12.FlatAppearance.BorderSize = 0;
            Button12.FlatStyle = FlatStyle.Flat;
            Button12.Location = new Point(0, 535);
            Button12.Name = "Button12";
            Button12.Size = new Size(48, 48);
            Button12.TabIndex = 19;
            Button12.UseVisualStyleBackColor = false;
            Button12.Click += Button12_Click;
            // 
            // PictureBox2
            // 
            PictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PictureBox2.BackColor = Color.Gray;
            PictureBox2.Image = (Image)resources.GetObject("PictureBox2.Image");
            PictureBox2.Location = new Point(1030, 0);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(47, 47);
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox2.TabIndex = 1;
            PictureBox2.TabStop = false;
            PictureBox2.Click += PictureBox2_Click;
            // 
            // Button2
            // 
            Button2.BackgroundImage = (Image)resources.GetObject("Button2.BackgroundImage");
            Button2.BackgroundImageLayout = ImageLayout.Stretch;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Location = new Point(3, 3);
            Button2.Name = "Button2";
            Button2.Size = new Size(50, 50);
            Button2.TabIndex = 5;
            Button2.UseVisualStyleBackColor = true;
            Button2.Visible = false;
            Button2.Click += Button2_Click;
            // 
            // Button3
            // 
            Button3.BackgroundImage = (Image)resources.GetObject("Button3.BackgroundImage");
            Button3.BackgroundImageLayout = ImageLayout.Stretch;
            Button3.FlatStyle = FlatStyle.Flat;
            Button3.Location = new Point(59, 3);
            Button3.Name = "Button3";
            Button3.Size = new Size(50, 50);
            Button3.TabIndex = 12;
            Button3.UseVisualStyleBackColor = true;
            Button3.Visible = false;
            Button3.Click += Button3_Click;
            // 
            // Button6
            // 
            Button6.BackgroundImage = (Image)resources.GetObject("Button6.BackgroundImage");
            Button6.BackgroundImageLayout = ImageLayout.Stretch;
            Button6.FlatStyle = FlatStyle.Flat;
            Button6.Location = new Point(115, 3);
            Button6.Name = "Button6";
            Button6.Size = new Size(50, 50);
            Button6.TabIndex = 15;
            Button6.UseVisualStyleBackColor = true;
            Button6.Visible = false;
            Button6.Click += Button6_Click;
            // 
            // Button4
            // 
            Button4.BackgroundImage = (Image)resources.GetObject("Button4.BackgroundImage");
            Button4.BackgroundImageLayout = ImageLayout.Stretch;
            Button4.FlatStyle = FlatStyle.Flat;
            Button4.Location = new Point(171, 3);
            Button4.Name = "Button4";
            Button4.Size = new Size(50, 50);
            Button4.TabIndex = 13;
            Button4.UseVisualStyleBackColor = true;
            Button4.Visible = false;
            Button4.Click += Button4_Click;
            // 
            // Button5
            // 
            Button5.BackgroundImage = (Image)resources.GetObject("Button5.BackgroundImage");
            Button5.BackgroundImageLayout = ImageLayout.Stretch;
            Button5.FlatStyle = FlatStyle.Flat;
            Button5.Location = new Point(227, 3);
            Button5.Name = "Button5";
            Button5.Size = new Size(50, 50);
            Button5.TabIndex = 14;
            Button5.UseVisualStyleBackColor = true;
            Button5.Visible = false;
            Button5.Click += Button5_Click;
            // 
            // Button14
            // 
            Button14.BackgroundImage = (Image)resources.GetObject("Button14.BackgroundImage");
            Button14.BackgroundImageLayout = ImageLayout.Stretch;
            Button14.FlatStyle = FlatStyle.Flat;
            Button14.Location = new Point(283, 3);
            Button14.Name = "Button14";
            Button14.Size = new Size(50, 50);
            Button14.TabIndex = 21;
            Button14.UseVisualStyleBackColor = true;
            Button14.Visible = false;
            Button14.Click += Button14_Click;
            // 
            // Button13
            // 
            Button13.BackgroundImage = (Image)resources.GetObject("Button13.BackgroundImage");
            Button13.BackgroundImageLayout = ImageLayout.Stretch;
            Button13.FlatStyle = FlatStyle.Flat;
            Button13.Location = new Point(339, 3);
            Button13.Name = "Button13";
            Button13.Size = new Size(50, 50);
            Button13.TabIndex = 20;
            Button13.UseVisualStyleBackColor = true;
            Button13.Visible = false;
            Button13.Click += Button13_Click;
            // 
            // Button11
            // 
            Button11.BackgroundImage = (Image)resources.GetObject("Button11.BackgroundImage");
            Button11.BackgroundImageLayout = ImageLayout.Stretch;
            Button11.FlatStyle = FlatStyle.Flat;
            Button11.Location = new Point(395, 3);
            Button11.Name = "Button11";
            Button11.Size = new Size(50, 50);
            Button11.TabIndex = 18;
            Button11.UseVisualStyleBackColor = true;
            Button11.Visible = false;
            Button11.Click += Button11_Click;
            // 
            // Button10
            // 
            Button10.BackgroundImage = (Image)resources.GetObject("Button10.BackgroundImage");
            Button10.BackgroundImageLayout = ImageLayout.Stretch;
            Button10.FlatStyle = FlatStyle.Flat;
            Button10.Location = new Point(451, 3);
            Button10.Name = "Button10";
            Button10.Size = new Size(50, 50);
            Button10.TabIndex = 23;
            Button10.UseVisualStyleBackColor = true;
            Button10.Visible = false;
            Button10.Click += Button10_Click;
            // 
            // Button25
            // 
            Button25.BackgroundImage = (Image)resources.GetObject("Button25.BackgroundImage");
            Button25.BackgroundImageLayout = ImageLayout.Stretch;
            Button25.FlatStyle = FlatStyle.Flat;
            Button25.Location = new Point(507, 3);
            Button25.Name = "Button25";
            Button25.Size = new Size(50, 50);
            Button25.TabIndex = 24;
            Button25.UseVisualStyleBackColor = true;
            Button25.Visible = false;
            Button25.Click += Button25_Click;
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Label5.AutoSize = true;
            Label5.BackColor = Color.Green;
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(883, 518);
            Label5.Name = "Label5";
            Label5.Size = new Size(195, 15);
            Label5.TabIndex = 30;
            Label5.Text = "Vous n'êtes pas connecté à Internet.\r\n";
            Label5.Visible = false;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Label4.AutoSize = true;
            Label4.BackColor = Color.Green;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(914, 518);
            Label4.Name = "Label4";
            Label4.Size = new Size(164, 15);
            Label4.TabIndex = 25;
            Label4.Text = "Vous êtes connecté à Internet.\r\n";
            Label4.Visible = false;
            // 
            // PictureBox7
            // 
            PictureBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PictureBox7.BackColor = Color.Black;
            PictureBox7.Image = (Image)resources.GetObject("PictureBox7.Image");
            PictureBox7.Location = new Point(1030, 536);
            PictureBox7.Name = "PictureBox7";
            PictureBox7.Size = new Size(48, 48);
            PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox7.TabIndex = 29;
            PictureBox7.TabStop = false;
            PictureBox7.Visible = false;
            PictureBox7.MouseLeave += PictureBox7_MouseLeave;
            PictureBox7.MouseHover += PictureBox7_MouseHover;
            // 
            // PictureBox6
            // 
            PictureBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PictureBox6.BackColor = Color.Black;
            PictureBox6.Image = (Image)resources.GetObject("PictureBox6.Image");
            PictureBox6.Location = new Point(1030, 536);
            PictureBox6.Name = "PictureBox6";
            PictureBox6.Size = new Size(48, 48);
            PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox6.TabIndex = 28;
            PictureBox6.TabStop = false;
            PictureBox6.Visible = false;
            PictureBox6.MouseLeave += PictureBox6_MouseLeave;
            PictureBox6.MouseHover += PictureBox6_MouseHover;
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FlowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("FlowLayoutPanel1.BackgroundImage");
            FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            FlowLayoutPanel1.Controls.Add(Button2);
            FlowLayoutPanel1.Controls.Add(Button3);
            FlowLayoutPanel1.Controls.Add(Button6);
            FlowLayoutPanel1.Controls.Add(Button4);
            FlowLayoutPanel1.Controls.Add(Button5);
            FlowLayoutPanel1.Controls.Add(Button14);
            FlowLayoutPanel1.Controls.Add(Button13);
            FlowLayoutPanel1.Controls.Add(Button11);
            FlowLayoutPanel1.Controls.Add(Button10);
            FlowLayoutPanel1.Controls.Add(Button25);
            FlowLayoutPanel1.Location = new Point(0, 46);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(1078, 487);
            FlowLayoutPanel1.TabIndex = 31;
            FlowLayoutPanel1.Click += FlowLayoutPanel1_Click_1;
            // 
            // Bureau
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1078, 584);
            ControlBox = false;
            Controls.Add(MonthCalendar1);
            Controls.Add(PictureBox6);
            Controls.Add(PictureBox7);
            Controls.Add(Label4);
            Controls.Add(FlowLayoutPanel2);
            Controls.Add(Label5);
            Controls.Add(Button12);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            Controls.Add(Label2);
            Controls.Add(PictureBox2);
            Controls.Add(FlowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Bureau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bureau - Session Superutilisateur";
            Load += Bureau_Load;
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            FlowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox6).EndInit();
            FlowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        internal PictureBox PictureBox2;
        internal Timer Timer1;
        internal MonthCalendar MonthCalendar1;
        internal Label Label2;
        internal Panel Panel1;
        internal Button Button1;
        internal Label Label3;
        internal PictureBox PictureBox3;
        internal Button Button2;
        internal Button Button3;
        internal Button Button4;
        internal Button Button5;
        internal Button Button6;
        internal Button Button9;
        internal Button Button11;
        internal Button Button12;
        internal Button Button13;
        internal Button Button14;
        internal Label Label1;
        internal Button Button15;
        internal Button Button16;
        internal Button Button17;
        internal FlowLayoutPanel FlowLayoutPanel2;
        internal Button Button19;
        internal Button Button20;
        internal Button Button21;
        internal Button Button22;
        internal Button Button23;
        internal Button Button24;
        internal Button Button10;
        internal Button Button25;
        internal Button Button26;
        internal PictureBox PictureBox7;
        internal Label Label4;
        internal Label Label5;
        internal PictureBox PictureBox6;
        public FlowLayoutPanel FlowLayoutPanel1;
    }
}