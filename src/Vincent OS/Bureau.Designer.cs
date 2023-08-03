using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bureau));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.MonthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button9 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.FlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Button15 = new System.Windows.Forms.Button();
            this.Button16 = new System.Windows.Forms.Button();
            this.Button17 = new System.Windows.Forms.Button();
            this.Button19 = new System.Windows.Forms.Button();
            this.Button20 = new System.Windows.Forms.Button();
            this.Button21 = new System.Windows.Forms.Button();
            this.Button22 = new System.Windows.Forms.Button();
            this.Button23 = new System.Windows.Forms.Button();
            this.Button24 = new System.Windows.Forms.Button();
            this.Button26 = new System.Windows.Forms.Button();
            this.Button12 = new System.Windows.Forms.Button();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button14 = new System.Windows.Forms.Button();
            this.Button13 = new System.Windows.Forms.Button();
            this.Button11 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button25 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.PictureBox6 = new System.Windows.Forms.PictureBox();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.FlowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).BeginInit();
            this.FlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MonthCalendar1
            // 
            this.MonthCalendar1.Location = new System.Drawing.Point(5, 57);
            this.MonthCalendar1.Name = "MonthCalendar1";
            this.MonthCalendar1.TabIndex = 3;
            this.MonthCalendar1.Visible = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(17, 3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 20);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "00:00:00";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.Black;
            this.Panel1.Controls.Add(this.Button9);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.PictureBox3);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Location = new System.Drawing.Point(921, 54);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(157, 116);
            this.Panel1.TabIndex = 4;
            this.Panel1.Visible = false;
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.Green;
            this.Button9.FlatAppearance.BorderSize = 0;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button9.ForeColor = System.Drawing.Color.White;
            this.Button9.Location = new System.Drawing.Point(60, 20);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(94, 26);
            this.Button9.TabIndex = 5;
            this.Button9.Text = "Paramètres";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(60, 3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 15);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Superutilisateur";
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(3, 3);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(55, 55);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 1;
            this.PictureBox3.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.DarkRed;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(3, 64);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(151, 44);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Quitter";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(5, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 20);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "00/00/0000";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // FlowLayoutPanel2
            // 
            this.FlowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.FlowLayoutPanel2.Controls.Add(this.Button15);
            this.FlowLayoutPanel2.Controls.Add(this.Button16);
            this.FlowLayoutPanel2.Controls.Add(this.Button17);
            this.FlowLayoutPanel2.Controls.Add(this.Button19);
            this.FlowLayoutPanel2.Controls.Add(this.Button20);
            this.FlowLayoutPanel2.Controls.Add(this.Button21);
            this.FlowLayoutPanel2.Controls.Add(this.Button22);
            this.FlowLayoutPanel2.Controls.Add(this.Button23);
            this.FlowLayoutPanel2.Controls.Add(this.Button24);
            this.FlowLayoutPanel2.Controls.Add(this.Button26);
            this.FlowLayoutPanel2.Location = new System.Drawing.Point(54, 536);
            this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            this.FlowLayoutPanel2.Size = new System.Drawing.Size(970, 48);
            this.FlowLayoutPanel2.TabIndex = 27;
            // 
            // Button15
            // 
            this.Button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button15.BackgroundImage")));
            this.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button15.Location = new System.Drawing.Point(3, 3);
            this.Button15.Name = "Button15";
            this.Button15.Size = new System.Drawing.Size(40, 40);
            this.Button15.TabIndex = 24;
            this.Button15.UseVisualStyleBackColor = true;
            this.Button15.Visible = false;
            this.Button15.Click += new System.EventHandler(this.Button15_Click);
            // 
            // Button16
            // 
            this.Button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button16.BackgroundImage")));
            this.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button16.Location = new System.Drawing.Point(49, 3);
            this.Button16.Name = "Button16";
            this.Button16.Size = new System.Drawing.Size(40, 40);
            this.Button16.TabIndex = 25;
            this.Button16.UseVisualStyleBackColor = true;
            this.Button16.Visible = false;
            this.Button16.Click += new System.EventHandler(this.Button16_Click);
            // 
            // Button17
            // 
            this.Button17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button17.BackgroundImage")));
            this.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button17.Location = new System.Drawing.Point(95, 3);
            this.Button17.Name = "Button17";
            this.Button17.Size = new System.Drawing.Size(40, 40);
            this.Button17.TabIndex = 26;
            this.Button17.UseVisualStyleBackColor = true;
            this.Button17.Visible = false;
            this.Button17.Click += new System.EventHandler(this.Button17_Click);
            // 
            // Button19
            // 
            this.Button19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button19.BackgroundImage")));
            this.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button19.Location = new System.Drawing.Point(141, 3);
            this.Button19.Name = "Button19";
            this.Button19.Size = new System.Drawing.Size(40, 40);
            this.Button19.TabIndex = 28;
            this.Button19.UseVisualStyleBackColor = true;
            this.Button19.Visible = false;
            this.Button19.Click += new System.EventHandler(this.Button19_Click);
            // 
            // Button20
            // 
            this.Button20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button20.BackgroundImage")));
            this.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button20.Location = new System.Drawing.Point(187, 3);
            this.Button20.Name = "Button20";
            this.Button20.Size = new System.Drawing.Size(40, 40);
            this.Button20.TabIndex = 29;
            this.Button20.UseVisualStyleBackColor = true;
            this.Button20.Visible = false;
            this.Button20.Click += new System.EventHandler(this.Button20_Click);
            // 
            // Button21
            // 
            this.Button21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button21.BackgroundImage")));
            this.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button21.Location = new System.Drawing.Point(233, 3);
            this.Button21.Name = "Button21";
            this.Button21.Size = new System.Drawing.Size(40, 40);
            this.Button21.TabIndex = 30;
            this.Button21.UseVisualStyleBackColor = true;
            this.Button21.Visible = false;
            this.Button21.Click += new System.EventHandler(this.Button21_Click);
            // 
            // Button22
            // 
            this.Button22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button22.BackgroundImage")));
            this.Button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button22.Location = new System.Drawing.Point(279, 3);
            this.Button22.Name = "Button22";
            this.Button22.Size = new System.Drawing.Size(40, 40);
            this.Button22.TabIndex = 31;
            this.Button22.UseVisualStyleBackColor = true;
            this.Button22.Visible = false;
            this.Button22.Click += new System.EventHandler(this.Button22_Click);
            // 
            // Button23
            // 
            this.Button23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button23.BackgroundImage")));
            this.Button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button23.Location = new System.Drawing.Point(325, 3);
            this.Button23.Name = "Button23";
            this.Button23.Size = new System.Drawing.Size(40, 40);
            this.Button23.TabIndex = 32;
            this.Button23.UseVisualStyleBackColor = true;
            this.Button23.Visible = false;
            this.Button23.Click += new System.EventHandler(this.Button23_Click);
            // 
            // Button24
            // 
            this.Button24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button24.BackgroundImage")));
            this.Button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button24.Location = new System.Drawing.Point(371, 3);
            this.Button24.Name = "Button24";
            this.Button24.Size = new System.Drawing.Size(40, 40);
            this.Button24.TabIndex = 33;
            this.Button24.UseVisualStyleBackColor = true;
            this.Button24.Visible = false;
            this.Button24.Click += new System.EventHandler(this.Button24_Click);
            // 
            // Button26
            // 
            this.Button26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button26.BackgroundImage")));
            this.Button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button26.Location = new System.Drawing.Point(417, 3);
            this.Button26.Name = "Button26";
            this.Button26.Size = new System.Drawing.Size(40, 40);
            this.Button26.TabIndex = 36;
            this.Button26.UseVisualStyleBackColor = true;
            this.Button26.Visible = false;
            this.Button26.Click += new System.EventHandler(this.Button26_Click);
            // 
            // Button12
            // 
            this.Button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button12.BackColor = System.Drawing.Color.Black;
            this.Button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button12.BackgroundImage")));
            this.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button12.FlatAppearance.BorderSize = 0;
            this.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button12.Location = new System.Drawing.Point(0, 535);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(48, 48);
            this.Button12.TabIndex = 19;
            this.Button12.UseVisualStyleBackColor = false;
            this.Button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // PictureBox4
            // 
            this.PictureBox4.BackColor = System.Drawing.Color.Black;
            this.PictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PictureBox4.Location = new System.Drawing.Point(0, 536);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(1078, 48);
            this.PictureBox4.TabIndex = 22;
            this.PictureBox4.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox2.BackColor = System.Drawing.Color.Gray;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(1030, 0);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(48, 48);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 1;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Black;
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(1078, 48);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Button2
            // 
            this.Button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button2.BackgroundImage")));
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Location = new System.Drawing.Point(3, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(50, 50);
            this.Button2.TabIndex = 5;
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Visible = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button3.BackgroundImage")));
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Location = new System.Drawing.Point(59, 3);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(50, 50);
            this.Button3.TabIndex = 12;
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Visible = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button6
            // 
            this.Button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button6.BackgroundImage")));
            this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Location = new System.Drawing.Point(115, 3);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(50, 50);
            this.Button6.TabIndex = 15;
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Visible = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button4
            // 
            this.Button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button4.BackgroundImage")));
            this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Location = new System.Drawing.Point(171, 3);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(50, 50);
            this.Button4.TabIndex = 13;
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Visible = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button5.BackgroundImage")));
            this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Location = new System.Drawing.Point(227, 3);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(50, 50);
            this.Button5.TabIndex = 14;
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Visible = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button14
            // 
            this.Button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button14.BackgroundImage")));
            this.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button14.Location = new System.Drawing.Point(283, 3);
            this.Button14.Name = "Button14";
            this.Button14.Size = new System.Drawing.Size(50, 50);
            this.Button14.TabIndex = 21;
            this.Button14.UseVisualStyleBackColor = true;
            this.Button14.Visible = false;
            this.Button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // Button13
            // 
            this.Button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button13.BackgroundImage")));
            this.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button13.Location = new System.Drawing.Point(339, 3);
            this.Button13.Name = "Button13";
            this.Button13.Size = new System.Drawing.Size(50, 50);
            this.Button13.TabIndex = 20;
            this.Button13.UseVisualStyleBackColor = true;
            this.Button13.Visible = false;
            this.Button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // Button11
            // 
            this.Button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button11.BackgroundImage")));
            this.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button11.Location = new System.Drawing.Point(395, 3);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(50, 50);
            this.Button11.TabIndex = 18;
            this.Button11.UseVisualStyleBackColor = true;
            this.Button11.Visible = false;
            this.Button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // Button10
            // 
            this.Button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button10.BackgroundImage")));
            this.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button10.Location = new System.Drawing.Point(451, 3);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(50, 50);
            this.Button10.TabIndex = 23;
            this.Button10.UseVisualStyleBackColor = true;
            this.Button10.Visible = false;
            this.Button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // Button25
            // 
            this.Button25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button25.BackgroundImage")));
            this.Button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button25.Location = new System.Drawing.Point(507, 3);
            this.Button25.Name = "Button25";
            this.Button25.Size = new System.Drawing.Size(50, 50);
            this.Button25.TabIndex = 24;
            this.Button25.UseVisualStyleBackColor = true;
            this.Button25.Visible = false;
            this.Button25.Click += new System.EventHandler(this.Button25_Click);
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Green;
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(883, 518);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(195, 15);
            this.Label5.TabIndex = 30;
            this.Label5.Text = "Vous n\'êtes pas connecté à Internet.\r\n";
            this.Label5.Visible = false;
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Green;
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(914, 518);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(164, 15);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "Vous êtes connecté à Internet.\r\n";
            this.Label4.Visible = false;
            // 
            // PictureBox7
            // 
            this.PictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox7.BackColor = System.Drawing.Color.Black;
            this.PictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox7.Image")));
            this.PictureBox7.Location = new System.Drawing.Point(1030, 536);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new System.Drawing.Size(48, 48);
            this.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox7.TabIndex = 29;
            this.PictureBox7.TabStop = false;
            this.PictureBox7.Visible = false;
            this.PictureBox7.MouseLeave += new System.EventHandler(this.PictureBox7_MouseLeave);
            this.PictureBox7.MouseHover += new System.EventHandler(this.PictureBox7_MouseHover);
            // 
            // PictureBox6
            // 
            this.PictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox6.BackColor = System.Drawing.Color.Black;
            this.PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox6.Image")));
            this.PictureBox6.Location = new System.Drawing.Point(1030, 536);
            this.PictureBox6.Name = "PictureBox6";
            this.PictureBox6.Size = new System.Drawing.Size(48, 48);
            this.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox6.TabIndex = 28;
            this.PictureBox6.TabStop = false;
            this.PictureBox6.Visible = false;
            this.PictureBox6.MouseLeave += new System.EventHandler(this.PictureBox6_MouseLeave);
            this.PictureBox6.MouseHover += new System.EventHandler(this.PictureBox6_MouseHover);
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FlowLayoutPanel1.BackgroundImage")));
            this.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlowLayoutPanel1.Controls.Add(this.Button2);
            this.FlowLayoutPanel1.Controls.Add(this.Button3);
            this.FlowLayoutPanel1.Controls.Add(this.Button6);
            this.FlowLayoutPanel1.Controls.Add(this.Button4);
            this.FlowLayoutPanel1.Controls.Add(this.Button5);
            this.FlowLayoutPanel1.Controls.Add(this.Button14);
            this.FlowLayoutPanel1.Controls.Add(this.Button13);
            this.FlowLayoutPanel1.Controls.Add(this.Button11);
            this.FlowLayoutPanel1.Controls.Add(this.Button10);
            this.FlowLayoutPanel1.Controls.Add(this.Button25);
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(1078, 487);
            this.FlowLayoutPanel1.TabIndex = 31;
            this.FlowLayoutPanel1.Click += new System.EventHandler(this.FlowLayoutPanel1_Click_1);
            // 
            // Bureau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1078, 584);
            this.ControlBox = false;
            this.Controls.Add(this.MonthCalendar1);
            this.Controls.Add(this.PictureBox6);
            this.Controls.Add(this.PictureBox7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.FlowLayoutPanel2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Button12);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.FlowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bureau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bureau - Session Superutilisateur";
            this.Load += new System.EventHandler(this.Bureau_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.FlowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).EndInit();
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal PictureBox PictureBox1;
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
        internal PictureBox PictureBox4;
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