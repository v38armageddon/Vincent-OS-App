using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Custom : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Custom));
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.CheckBox11 = new System.Windows.Forms.CheckBox();
            this.CheckBox10 = new System.Windows.Forms.CheckBox();
            this.CheckBox9 = new System.Windows.Forms.CheckBox();
            this.CheckBox8 = new System.Windows.Forms.CheckBox();
            this.CheckBox7 = new System.Windows.Forms.CheckBox();
            this.CheckBox6 = new System.Windows.Forms.CheckBox();
            this.CheckBox5 = new System.Windows.Forms.CheckBox();
            this.CheckBox4 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox14 = new System.Windows.Forms.PictureBox();
            this.PictureBox13 = new System.Windows.Forms.PictureBox();
            this.PictureBox12 = new System.Windows.Forms.PictureBox();
            this.PictureBox11 = new System.Windows.Forms.PictureBox();
            this.PictureBox10 = new System.Windows.Forms.PictureBox();
            this.PictureBox9 = new System.Windows.Forms.PictureBox();
            this.PictureBox8 = new System.Windows.Forms.PictureBox();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.PictureBox6 = new System.Windows.Forms.PictureBox();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.TabControl1.SuspendLayout();
            this.TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.OpenFileDialog1.RestoreDirectory = true;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(605, 325);
            this.TabControl1.TabIndex = 7;
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.Button3);
            this.TabPage4.Controls.Add(this.Button2);
            this.TabPage4.Controls.Add(this.Label1);
            this.TabPage4.Controls.Add(this.PictureBox1);
            this.TabPage4.Controls.Add(this.Button1);
            this.TabPage4.Controls.Add(this.Button4);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(597, 299);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Fond d\'écran";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button3.BackgroundImage")));
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Location = new System.Drawing.Point(218, 212);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(67, 62);
            this.Button3.TabIndex = 34;
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button2.BackgroundImage")));
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Location = new System.Drawing.Point(145, 212);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(67, 62);
            this.Button2.TabIndex = 33;
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(131, 2);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(312, 24);
            this.Label1.TabIndex = 32;
            this.Label1.Text = "Aperçus du fond d\'écran actuelle";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(135, 29);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(308, 177);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 31;
            this.PictureBox1.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(364, 212);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(67, 62);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "+";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Button4
            // 
            this.Button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button4.BackgroundImage")));
            this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Location = new System.Drawing.Point(291, 212);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(67, 62);
            this.Button4.TabIndex = 35;
            this.Button4.Text = "8";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.CheckBox11);
            this.TabPage1.Controls.Add(this.CheckBox10);
            this.TabPage1.Controls.Add(this.CheckBox9);
            this.TabPage1.Controls.Add(this.CheckBox8);
            this.TabPage1.Controls.Add(this.CheckBox7);
            this.TabPage1.Controls.Add(this.CheckBox6);
            this.TabPage1.Controls.Add(this.CheckBox5);
            this.TabPage1.Controls.Add(this.CheckBox4);
            this.TabPage1.Controls.Add(this.CheckBox3);
            this.TabPage1.Controls.Add(this.CheckBox2);
            this.TabPage1.Controls.Add(this.CheckBox1);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.PictureBox14);
            this.TabPage1.Controls.Add(this.PictureBox13);
            this.TabPage1.Controls.Add(this.PictureBox12);
            this.TabPage1.Controls.Add(this.PictureBox11);
            this.TabPage1.Controls.Add(this.PictureBox10);
            this.TabPage1.Controls.Add(this.PictureBox9);
            this.TabPage1.Controls.Add(this.PictureBox8);
            this.TabPage1.Controls.Add(this.PictureBox7);
            this.TabPage1.Controls.Add(this.PictureBox6);
            this.TabPage1.Controls.Add(this.PictureBox5);
            this.TabPage1.Controls.Add(this.PictureBox4);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(597, 299);
            this.TabPage1.TabIndex = 5;
            this.TabPage1.Text = "Icônes";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // CheckBox11
            // 
            this.CheckBox11.AutoSize = true;
            this.CheckBox11.Location = new System.Drawing.Point(321, 188);
            this.CheckBox11.Name = "CheckBox11";
            this.CheckBox11.Size = new System.Drawing.Size(15, 14);
            this.CheckBox11.TabIndex = 22;
            this.CheckBox11.UseVisualStyleBackColor = true;
            this.CheckBox11.CheckedChanged += new System.EventHandler(this.CheckBox11_CheckedChanged);
            // 
            // CheckBox10
            // 
            this.CheckBox10.AutoSize = true;
            this.CheckBox10.Location = new System.Drawing.Point(321, 116);
            this.CheckBox10.Name = "CheckBox10";
            this.CheckBox10.Size = new System.Drawing.Size(15, 14);
            this.CheckBox10.TabIndex = 21;
            this.CheckBox10.UseVisualStyleBackColor = true;
            this.CheckBox10.CheckedChanged += new System.EventHandler(this.CheckBox10_CheckedChanged);
            // 
            // CheckBox9
            // 
            this.CheckBox9.AutoSize = true;
            this.CheckBox9.Location = new System.Drawing.Point(321, 47);
            this.CheckBox9.Name = "CheckBox9";
            this.CheckBox9.Size = new System.Drawing.Size(15, 14);
            this.CheckBox9.TabIndex = 20;
            this.CheckBox9.UseVisualStyleBackColor = true;
            this.CheckBox9.CheckedChanged += new System.EventHandler(this.CheckBox9_CheckedChanged);
            // 
            // CheckBox8
            // 
            this.CheckBox8.AutoSize = true;
            this.CheckBox8.Location = new System.Drawing.Point(207, 258);
            this.CheckBox8.Name = "CheckBox8";
            this.CheckBox8.Size = new System.Drawing.Size(15, 14);
            this.CheckBox8.TabIndex = 19;
            this.CheckBox8.UseVisualStyleBackColor = true;
            this.CheckBox8.CheckedChanged += new System.EventHandler(this.CheckBox8_CheckedChanged);
            // 
            // CheckBox7
            // 
            this.CheckBox7.AutoSize = true;
            this.CheckBox7.Location = new System.Drawing.Point(207, 188);
            this.CheckBox7.Name = "CheckBox7";
            this.CheckBox7.Size = new System.Drawing.Size(15, 14);
            this.CheckBox7.TabIndex = 18;
            this.CheckBox7.UseVisualStyleBackColor = true;
            this.CheckBox7.CheckedChanged += new System.EventHandler(this.CheckBox7_CheckedChanged);
            // 
            // CheckBox6
            // 
            this.CheckBox6.AutoSize = true;
            this.CheckBox6.Location = new System.Drawing.Point(207, 116);
            this.CheckBox6.Name = "CheckBox6";
            this.CheckBox6.Size = new System.Drawing.Size(15, 14);
            this.CheckBox6.TabIndex = 17;
            this.CheckBox6.UseVisualStyleBackColor = true;
            this.CheckBox6.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // CheckBox5
            // 
            this.CheckBox5.AutoSize = true;
            this.CheckBox5.Location = new System.Drawing.Point(207, 47);
            this.CheckBox5.Name = "CheckBox5";
            this.CheckBox5.Size = new System.Drawing.Size(15, 14);
            this.CheckBox5.TabIndex = 16;
            this.CheckBox5.UseVisualStyleBackColor = true;
            this.CheckBox5.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // CheckBox4
            // 
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Location = new System.Drawing.Point(93, 258);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new System.Drawing.Size(15, 14);
            this.CheckBox4.TabIndex = 15;
            this.CheckBox4.UseVisualStyleBackColor = true;
            this.CheckBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new System.Drawing.Point(93, 188);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(15, 14);
            this.CheckBox3.TabIndex = 14;
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(93, 116);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(15, 14);
            this.CheckBox2.TabIndex = 13;
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(93, 47);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(15, 14);
            this.CheckBox1.TabIndex = 12;
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged_1);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 15.75F);
            this.Label3.Location = new System.Drawing.Point(89, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(422, 24);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Ajouter / Supprimer des icônes sur le bureau";
            // 
            // PictureBox14
            // 
            this.PictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox14.Image")));
            this.PictureBox14.Location = new System.Drawing.Point(237, 162);
            this.PictureBox14.Name = "PictureBox14";
            this.PictureBox14.Size = new System.Drawing.Size(64, 64);
            this.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox14.TabIndex = 11;
            this.PictureBox14.TabStop = false;
            // 
            // PictureBox13
            // 
            this.PictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox13.Image")));
            this.PictureBox13.Location = new System.Drawing.Point(237, 92);
            this.PictureBox13.Name = "PictureBox13";
            this.PictureBox13.Size = new System.Drawing.Size(64, 64);
            this.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox13.TabIndex = 10;
            this.PictureBox13.TabStop = false;
            // 
            // PictureBox12
            // 
            this.PictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox12.Image")));
            this.PictureBox12.Location = new System.Drawing.Point(237, 22);
            this.PictureBox12.Name = "PictureBox12";
            this.PictureBox12.Size = new System.Drawing.Size(64, 64);
            this.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox12.TabIndex = 9;
            this.PictureBox12.TabStop = false;
            // 
            // PictureBox11
            // 
            this.PictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox11.Image")));
            this.PictureBox11.Location = new System.Drawing.Point(125, 232);
            this.PictureBox11.Name = "PictureBox11";
            this.PictureBox11.Size = new System.Drawing.Size(64, 64);
            this.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox11.TabIndex = 8;
            this.PictureBox11.TabStop = false;
            // 
            // PictureBox10
            // 
            this.PictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox10.Image")));
            this.PictureBox10.Location = new System.Drawing.Point(125, 162);
            this.PictureBox10.Name = "PictureBox10";
            this.PictureBox10.Size = new System.Drawing.Size(64, 64);
            this.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox10.TabIndex = 7;
            this.PictureBox10.TabStop = false;
            // 
            // PictureBox9
            // 
            this.PictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox9.Image")));
            this.PictureBox9.Location = new System.Drawing.Point(125, 92);
            this.PictureBox9.Name = "PictureBox9";
            this.PictureBox9.Size = new System.Drawing.Size(64, 64);
            this.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox9.TabIndex = 6;
            this.PictureBox9.TabStop = false;
            // 
            // PictureBox8
            // 
            this.PictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox8.Image")));
            this.PictureBox8.Location = new System.Drawing.Point(125, 22);
            this.PictureBox8.Name = "PictureBox8";
            this.PictureBox8.Size = new System.Drawing.Size(64, 64);
            this.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox8.TabIndex = 5;
            this.PictureBox8.TabStop = false;
            // 
            // PictureBox7
            // 
            this.PictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox7.Image")));
            this.PictureBox7.Location = new System.Drawing.Point(6, 232);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new System.Drawing.Size(64, 64);
            this.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox7.TabIndex = 4;
            this.PictureBox7.TabStop = false;
            // 
            // PictureBox6
            // 
            this.PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox6.Image")));
            this.PictureBox6.Location = new System.Drawing.Point(6, 162);
            this.PictureBox6.Name = "PictureBox6";
            this.PictureBox6.Size = new System.Drawing.Size(64, 64);
            this.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox6.TabIndex = 3;
            this.PictureBox6.TabStop = false;
            // 
            // PictureBox5
            // 
            this.PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox5.Image")));
            this.PictureBox5.Location = new System.Drawing.Point(6, 92);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(64, 64);
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox5.TabIndex = 2;
            this.PictureBox5.TabStop = false;
            // 
            // PictureBox4
            // 
            this.PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox4.Image")));
            this.PictureBox4.Location = new System.Drawing.Point(6, 22);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(64, 64);
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox4.TabIndex = 1;
            this.PictureBox4.TabStop = false;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.RadioButton2);
            this.TabPage2.Controls.Add(this.RadioButton1);
            this.TabPage2.Controls.Add(this.Label2);
            this.TabPage2.Controls.Add(this.PictureBox2);
            this.TabPage2.Controls.Add(this.PictureBox3);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(597, 299);
            this.TabPage2.TabIndex = 6;
            this.TabPage2.Text = "Résolution";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.RadioButton2.Location = new System.Drawing.Point(380, 191);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(122, 26);
            this.RadioButton2.TabIndex = 14;
            this.RadioButton2.Text = "Plein écran\r\n";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.RadioButton1.Location = new System.Drawing.Point(93, 191);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(94, 26);
            this.RadioButton1.TabIndex = 13;
            this.RadioButton1.Text = "Fenêtré";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(237, 3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 22);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Résolution";
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(17, 28);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(264, 157);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 15;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(307, 28);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(264, 157);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 16;
            this.PictureBox3.TabStop = false;
            // 
            // Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 325);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Custom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personnalisation";
            this.Load += new System.EventHandler(this.Ecran_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.ResumeLayout(false);

        }
        internal OpenFileDialog OpenFileDialog1;
        internal TabControl TabControl1;
        internal TabPage TabPage4;
        internal TabPage TabPage1;
        internal TabPage TabPage2;
        internal Button Button1;
        internal Button Button3;
        internal Button Button2;
        internal Label Label1;
        internal PictureBox PictureBox1;
        internal Button Button4;
        internal RadioButton RadioButton2;
        internal RadioButton RadioButton1;
        internal Label Label2;
        internal PictureBox PictureBox2;
        internal PictureBox PictureBox3;
        internal Label Label3;
        internal PictureBox PictureBox4;
        internal PictureBox PictureBox14;
        internal PictureBox PictureBox13;
        internal PictureBox PictureBox12;
        internal PictureBox PictureBox11;
        internal PictureBox PictureBox10;
        internal PictureBox PictureBox9;
        internal PictureBox PictureBox8;
        internal PictureBox PictureBox7;
        internal PictureBox PictureBox6;
        internal PictureBox PictureBox5;
        internal CheckBox CheckBox11;
        internal CheckBox CheckBox10;
        internal CheckBox CheckBox9;
        internal CheckBox CheckBox8;
        internal CheckBox CheckBox7;
        internal CheckBox CheckBox6;
        internal CheckBox CheckBox5;
        internal CheckBox CheckBox4;
        internal CheckBox CheckBox3;
        internal CheckBox CheckBox2;
        internal CheckBox CheckBox1;
    }
}