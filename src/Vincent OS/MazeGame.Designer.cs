using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MazeGame : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MazeGame));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label67 = new System.Windows.Forms.Label();
            this.Label66 = new System.Windows.Forms.Label();
            this.finishLabel = new System.Windows.Forms.Label();
            this.Label65 = new System.Windows.Forms.Label();
            this.Label64 = new System.Windows.Forms.Label();
            this.Label63 = new System.Windows.Forms.Label();
            this.Label62 = new System.Windows.Forms.Label();
            this.Label61 = new System.Windows.Forms.Label();
            this.Label60 = new System.Windows.Forms.Label();
            this.Label59 = new System.Windows.Forms.Label();
            this.Label58 = new System.Windows.Forms.Label();
            this.Label57 = new System.Windows.Forms.Label();
            this.Label56 = new System.Windows.Forms.Label();
            this.Label55 = new System.Windows.Forms.Label();
            this.Label54 = new System.Windows.Forms.Label();
            this.Label53 = new System.Windows.Forms.Label();
            this.Label52 = new System.Windows.Forms.Label();
            this.Label51 = new System.Windows.Forms.Label();
            this.Label50 = new System.Windows.Forms.Label();
            this.Label48 = new System.Windows.Forms.Label();
            this.Label47 = new System.Windows.Forms.Label();
            this.Label46 = new System.Windows.Forms.Label();
            this.Label45 = new System.Windows.Forms.Label();
            this.Label44 = new System.Windows.Forms.Label();
            this.Label43 = new System.Windows.Forms.Label();
            this.Label42 = new System.Windows.Forms.Label();
            this.Label41 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label39 = new System.Windows.Forms.Label();
            this.Label38 = new System.Windows.Forms.Label();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.Label49 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(610, 590);
            this.Panel1.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.Controls.Add(this.Label67);
            this.Panel2.Controls.Add(this.Label66);
            this.Panel2.Controls.Add(this.finishLabel);
            this.Panel2.Controls.Add(this.Label65);
            this.Panel2.Controls.Add(this.Label64);
            this.Panel2.Controls.Add(this.Label63);
            this.Panel2.Controls.Add(this.Label62);
            this.Panel2.Controls.Add(this.Label61);
            this.Panel2.Controls.Add(this.Label60);
            this.Panel2.Controls.Add(this.Label59);
            this.Panel2.Controls.Add(this.Label58);
            this.Panel2.Controls.Add(this.Label57);
            this.Panel2.Controls.Add(this.Label56);
            this.Panel2.Controls.Add(this.Label55);
            this.Panel2.Controls.Add(this.Label54);
            this.Panel2.Controls.Add(this.Label53);
            this.Panel2.Controls.Add(this.Label52);
            this.Panel2.Controls.Add(this.Label51);
            this.Panel2.Controls.Add(this.Label50);
            this.Panel2.Controls.Add(this.Label48);
            this.Panel2.Controls.Add(this.Label47);
            this.Panel2.Controls.Add(this.Label46);
            this.Panel2.Controls.Add(this.Label45);
            this.Panel2.Controls.Add(this.Label44);
            this.Panel2.Controls.Add(this.Label43);
            this.Panel2.Controls.Add(this.Label42);
            this.Panel2.Controls.Add(this.Label41);
            this.Panel2.Controls.Add(this.Label40);
            this.Panel2.Controls.Add(this.Label39);
            this.Panel2.Controls.Add(this.Label38);
            this.Panel2.Controls.Add(this.Label37);
            this.Panel2.Controls.Add(this.Label36);
            this.Panel2.Controls.Add(this.Label35);
            this.Panel2.Controls.Add(this.Label34);
            this.Panel2.Controls.Add(this.Label33);
            this.Panel2.Controls.Add(this.Label32);
            this.Panel2.Controls.Add(this.Label31);
            this.Panel2.Controls.Add(this.Label30);
            this.Panel2.Controls.Add(this.Label29);
            this.Panel2.Controls.Add(this.Label28);
            this.Panel2.Controls.Add(this.Label27);
            this.Panel2.Controls.Add(this.Label26);
            this.Panel2.Controls.Add(this.Label25);
            this.Panel2.Controls.Add(this.Label24);
            this.Panel2.Controls.Add(this.Label23);
            this.Panel2.Controls.Add(this.Label22);
            this.Panel2.Controls.Add(this.Label21);
            this.Panel2.Controls.Add(this.Label20);
            this.Panel2.Controls.Add(this.Label19);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Controls.Add(this.Label12);
            this.Panel2.Controls.Add(this.Label13);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Controls.Add(this.Label15);
            this.Panel2.Controls.Add(this.Label16);
            this.Panel2.Controls.Add(this.Label17);
            this.Panel2.Controls.Add(this.Label18);
            this.Panel2.Location = new System.Drawing.Point(-2, -2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(610, 590);
            this.Panel2.TabIndex = 10;
            // 
            // Label67
            // 
            this.Label67.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label67.Location = new System.Drawing.Point(433, -5);
            this.Label67.Name = "Label67";
            this.Label67.Size = new System.Drawing.Size(23, 83);
            this.Label67.TabIndex = 58;
            // 
            // Label66
            // 
            this.Label66.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label66.Location = new System.Drawing.Point(557, 83);
            this.Label66.Name = "Label66";
            this.Label66.Size = new System.Drawing.Size(23, 119);
            this.Label66.TabIndex = 57;
            // 
            // finishLabel
            // 
            this.finishLabel.AutoSize = true;
            this.finishLabel.Location = new System.Drawing.Point(587, 547);
            this.finishLabel.Name = "finishLabel";
            this.finishLabel.Size = new System.Drawing.Size(21, 13);
            this.finishLabel.TabIndex = 56;
            this.finishLabel.Text = "Fin";
            this.finishLabel.MouseEnter += new System.EventHandler(this.finishLabel_MouseEnter);
            // 
            // Label65
            // 
            this.Label65.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label65.Location = new System.Drawing.Point(304, 327);
            this.Label65.Name = "Label65";
            this.Label65.Size = new System.Drawing.Size(97, 23);
            this.Label65.TabIndex = 55;
            this.Label65.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label64
            // 
            this.Label64.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label64.Location = new System.Drawing.Point(366, 139);
            this.Label64.Name = "Label64";
            this.Label64.Size = new System.Drawing.Size(23, 63);
            this.Label64.TabIndex = 54;
            this.Label64.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label63
            // 
            this.Label63.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label63.Location = new System.Drawing.Point(483, 435);
            this.Label63.Name = "Label63";
            this.Label63.Size = new System.Drawing.Size(88, 12);
            this.Label63.TabIndex = 53;
            this.Label63.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label62
            // 
            this.Label62.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label62.Location = new System.Drawing.Point(483, 395);
            this.Label62.Name = "Label62";
            this.Label62.Size = new System.Drawing.Size(79, 23);
            this.Label62.TabIndex = 52;
            this.Label62.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label61
            // 
            this.Label61.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label61.Location = new System.Drawing.Point(522, 263);
            this.Label61.Name = "Label61";
            this.Label61.Size = new System.Drawing.Size(17, 52);
            this.Label61.TabIndex = 51;
            this.Label61.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label60
            // 
            this.Label60.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label60.Location = new System.Drawing.Point(483, 338);
            this.Label60.Name = "Label60";
            this.Label60.Size = new System.Drawing.Size(125, 23);
            this.Label60.TabIndex = 50;
            this.Label60.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label59
            // 
            this.Label59.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label59.Location = new System.Drawing.Point(480, 249);
            this.Label59.Name = "Label59";
            this.Label59.Size = new System.Drawing.Size(100, 23);
            this.Label59.TabIndex = 49;
            this.Label59.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label58
            // 
            this.Label58.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label58.Location = new System.Drawing.Point(480, 223);
            this.Label58.Name = "Label58";
            this.Label58.Size = new System.Drawing.Size(23, 96);
            this.Label58.TabIndex = 48;
            this.Label58.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label57
            // 
            this.Label57.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label57.Location = new System.Drawing.Point(557, 395);
            this.Label57.Name = "Label57";
            this.Label57.Size = new System.Drawing.Size(23, 96);
            this.Label57.TabIndex = 47;
            this.Label57.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label56
            // 
            this.Label56.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label56.Location = new System.Drawing.Point(480, 179);
            this.Label56.Name = "Label56";
            this.Label56.Size = new System.Drawing.Size(100, 23);
            this.Label56.TabIndex = 46;
            this.Label56.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label55
            // 
            this.Label55.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label55.Location = new System.Drawing.Point(451, 103);
            this.Label55.Name = "Label55";
            this.Label55.Size = new System.Drawing.Size(129, 23);
            this.Label55.TabIndex = 45;
            this.Label55.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label54
            // 
            this.Label54.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label54.Location = new System.Drawing.Point(557, 263);
            this.Label54.Name = "Label54";
            this.Label54.Size = new System.Drawing.Size(23, 98);
            this.Label54.TabIndex = 44;
            this.Label54.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label53
            // 
            this.Label53.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label53.Location = new System.Drawing.Point(433, 28);
            this.Label53.Name = "Label53";
            this.Label53.Size = new System.Drawing.Size(147, 23);
            this.Label53.TabIndex = 43;
            this.Label53.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label52
            // 
            this.Label52.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label52.Location = new System.Drawing.Point(522, 520);
            this.Label52.Name = "Label52";
            this.Label52.Size = new System.Drawing.Size(100, 23);
            this.Label52.TabIndex = 42;
            this.Label52.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label51
            // 
            this.Label51.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label51.Location = new System.Drawing.Point(480, 468);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(100, 23);
            this.Label51.TabIndex = 41;
            this.Label51.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label50
            // 
            this.Label50.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label50.Location = new System.Drawing.Point(480, 468);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(23, 118);
            this.Label50.TabIndex = 40;
            this.Label50.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label48
            // 
            this.Label48.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label48.Location = new System.Drawing.Point(267, 494);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(145, 23);
            this.Label48.TabIndex = 39;
            this.Label48.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label47
            // 
            this.Label47.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label47.Location = new System.Drawing.Point(250, 537);
            this.Label47.Name = "Label47";
            this.Label47.Size = new System.Drawing.Size(195, 23);
            this.Label47.TabIndex = 38;
            this.Label47.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label46
            // 
            this.Label46.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label46.Location = new System.Drawing.Point(256, 442);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(145, 23);
            this.Label46.TabIndex = 37;
            this.Label46.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label45
            // 
            this.Label45.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label45.Location = new System.Drawing.Point(301, 381);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(100, 23);
            this.Label45.TabIndex = 36;
            this.Label45.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label44
            // 
            this.Label44.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label44.Location = new System.Drawing.Point(251, 442);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(23, 75);
            this.Label44.TabIndex = 35;
            this.Label44.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label43
            // 
            this.Label43.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label43.Location = new System.Drawing.Point(73, 395);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(199, 23);
            this.Label43.TabIndex = 34;
            this.Label43.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label42
            // 
            this.Label42.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label42.Location = new System.Drawing.Point(73, 494);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(100, 23);
            this.Label42.TabIndex = 33;
            this.Label42.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label41
            // 
            this.Label41.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label41.Location = new System.Drawing.Point(73, 395);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(23, 109);
            this.Label41.TabIndex = 32;
            this.Label41.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label40
            // 
            this.Label40.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label40.Location = new System.Drawing.Point(128, 442);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(97, 23);
            this.Label40.TabIndex = 31;
            this.Label40.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label39
            // 
            this.Label39.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label39.Location = new System.Drawing.Point(202, 442);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(23, 118);
            this.Label39.TabIndex = 30;
            this.Label39.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label38
            // 
            this.Label38.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label38.Location = new System.Drawing.Point(26, 537);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(199, 23);
            this.Label38.TabIndex = 29;
            this.Label38.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label37
            // 
            this.Label37.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label37.Location = new System.Drawing.Point(26, 358);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(23, 202);
            this.Label37.TabIndex = 28;
            this.Label37.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label36
            // 
            this.Label36.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label36.Location = new System.Drawing.Point(26, 309);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(152, 23);
            this.Label36.TabIndex = 27;
            this.Label36.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label35
            // 
            this.Label35.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label35.Location = new System.Drawing.Point(26, 358);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(199, 23);
            this.Label35.TabIndex = 26;
            this.Label35.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label34
            // 
            this.Label34.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label34.Location = new System.Drawing.Point(345, 276);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(100, 23);
            this.Label34.TabIndex = 25;
            this.Label34.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label33
            // 
            this.Label33.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label33.Location = new System.Drawing.Point(301, 223);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(100, 23);
            this.Label33.TabIndex = 24;
            this.Label33.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label32
            // 
            this.Label32.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label32.Location = new System.Drawing.Point(433, 103);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(23, 548);
            this.Label32.TabIndex = 23;
            this.Label32.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label31
            // 
            this.Label31.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label31.Location = new System.Drawing.Point(326, 39);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(27, 52);
            this.Label31.TabIndex = 22;
            this.Label31.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label30
            // 
            this.Label30.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label30.Location = new System.Drawing.Point(378, 28);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(23, 63);
            this.Label30.TabIndex = 21;
            this.Label30.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label29
            // 
            this.Label29.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label29.Location = new System.Drawing.Point(277, 28);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(124, 23);
            this.Label29.TabIndex = 20;
            this.Label29.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label28
            // 
            this.Label28.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label28.Location = new System.Drawing.Point(277, 123);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(112, 23);
            this.Label28.TabIndex = 19;
            this.Label28.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label27
            // 
            this.Label27.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label27.Location = new System.Drawing.Point(277, -5);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(23, 151);
            this.Label27.TabIndex = 18;
            this.Label27.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label26
            // 
            this.Label26.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label26.Location = new System.Drawing.Point(301, 179);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(23, 202);
            this.Label26.TabIndex = 17;
            this.Label26.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label25
            // 
            this.Label25.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label25.Location = new System.Drawing.Point(251, 179);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(23, 239);
            this.Label25.TabIndex = 16;
            this.Label25.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label24
            // 
            this.Label24.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label24.Location = new System.Drawing.Point(202, 179);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(23, 56);
            this.Label24.TabIndex = 15;
            this.Label24.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label23
            // 
            this.Label23.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label23.Location = new System.Drawing.Point(202, 263);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(23, 118);
            this.Label23.TabIndex = 14;
            this.Label23.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label22
            // 
            this.Label22.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label22.Location = new System.Drawing.Point(-2, -2);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(187, 23);
            this.Label22.TabIndex = 13;
            this.Label22.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label21
            // 
            this.Label21.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label21.Location = new System.Drawing.Point(179, -2);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(21, 117);
            this.Label21.TabIndex = 12;
            this.Label21.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label20
            // 
            this.Label20.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label20.Location = new System.Drawing.Point(226, 28);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(23, 118);
            this.Label20.TabIndex = 11;
            this.Label20.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label19
            // 
            this.Label19.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label19.Location = new System.Drawing.Point(125, 223);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(139, 23);
            this.Label19.TabIndex = 10;
            this.Label19.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label10.Location = new System.Drawing.Point(23, 134);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(23, 101);
            this.Label10.TabIndex = 9;
            this.Label10.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label11.Location = new System.Drawing.Point(75, 117);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(23, 118);
            this.Label11.TabIndex = 8;
            this.Label11.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label12.Location = new System.Drawing.Point(125, 39);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(23, 118);
            this.Label12.TabIndex = 7;
            this.Label12.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label13.Location = new System.Drawing.Point(-2, 39);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(132, 23);
            this.Label13.TabIndex = 6;
            this.Label13.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label14.Location = new System.Drawing.Point(125, 134);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(124, 23);
            this.Label14.TabIndex = 5;
            this.Label14.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label15.Location = new System.Drawing.Point(23, 212);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(75, 23);
            this.Label15.TabIndex = 4;
            this.Label15.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label16.Location = new System.Drawing.Point(-18, 263);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(243, 23);
            this.Label16.TabIndex = 3;
            this.Label16.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label17.Location = new System.Drawing.Point(125, 179);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(100, 23);
            this.Label17.TabIndex = 2;
            this.Label17.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label18.Location = new System.Drawing.Point(-2, 94);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(100, 23);
            this.Label18.TabIndex = 1;
            this.Label18.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label9.Location = new System.Drawing.Point(23, 134);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(23, 101);
            this.Label9.TabIndex = 9;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label8.Location = new System.Drawing.Point(75, 117);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(23, 118);
            this.Label8.TabIndex = 8;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label7.Location = new System.Drawing.Point(125, 39);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(23, 118);
            this.Label7.TabIndex = 7;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label6.Location = new System.Drawing.Point(-2, 39);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(132, 23);
            this.Label6.TabIndex = 6;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label5.Location = new System.Drawing.Point(125, 134);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 5;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label4.Location = new System.Drawing.Point(23, 212);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(75, 23);
            this.Label4.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label3.Location = new System.Drawing.Point(75, 263);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label2.Location = new System.Drawing.Point(125, 179);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label1.Location = new System.Drawing.Point(-2, 94);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 1;
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox3.Location = new System.Drawing.Point(-1, -25);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(623, 34);
            this.PictureBox3.TabIndex = 61;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.MouseEnter += new System.EventHandler(this.PictureBox3_MouseEnter);
            // 
            // Label49
            // 
            this.Label49.BackColor = System.Drawing.Color.RoyalBlue;
            this.Label49.Location = new System.Drawing.Point(447, 582);
            this.Label49.Name = "Label49";
            this.Label49.Size = new System.Drawing.Size(175, 23);
            this.Label49.TabIndex = 20;
            this.Label49.MouseEnter += new System.EventHandler(this.wall_MouseEnter);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Location = new System.Drawing.Point(617, -3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(47, 608);
            this.PictureBox1.TabIndex = 59;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.Location = new System.Drawing.Point(-41, 53);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(54, 552);
            this.PictureBox2.TabIndex = 60;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.MouseEnter += new System.EventHandler(this.PictureBox2_MouseEnter);
            // 
            // PictureBox4
            // 
            this.PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox4.Location = new System.Drawing.Point(-1, 603);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(665, 27);
            this.PictureBox4.TabIndex = 62;
            this.PictureBox4.TabStop = false;
            this.PictureBox4.MouseEnter += new System.EventHandler(this.PictureBox4_MouseEnter);
            // 
            // MazeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label49);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(644, 644);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(644, 644);
            this.Name = "MazeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labyrinth";
            this.Load += new System.EventHandler(this.MazeGame_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            this.ResumeLayout(false);

        }
        internal Panel Panel1;
        internal Panel Panel2;
        internal Label Label21;
        internal Label Label20;
        internal Label Label19;
        internal Label Label10;
        internal Label Label11;
        internal Label Label12;
        internal Label Label13;
        internal Label Label14;
        internal Label Label15;
        internal Label Label16;
        internal Label Label17;
        internal Label Label18;
        internal Label Label9;
        internal Label Label8;
        internal Label Label7;
        internal Label Label6;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal Label finishLabel;
        internal Label Label65;
        internal Label Label64;
        internal Label Label63;
        internal Label Label62;
        internal Label Label61;
        internal Label Label60;
        internal Label Label59;
        internal Label Label58;
        internal Label Label57;
        internal Label Label56;
        internal Label Label55;
        internal Label Label54;
        internal Label Label53;
        internal Label Label52;
        internal Label Label51;
        internal Label Label50;
        internal Label Label48;
        internal Label Label47;
        internal Label Label46;
        internal Label Label45;
        internal Label Label44;
        internal Label Label43;
        internal Label Label42;
        internal Label Label41;
        internal Label Label40;
        internal Label Label39;
        internal Label Label38;
        internal Label Label37;
        internal Label Label36;
        internal Label Label35;
        internal Label Label34;
        internal Label Label33;
        internal Label Label32;
        internal Label Label31;
        internal Label Label30;
        internal Label Label29;
        internal Label Label28;
        internal Label Label27;
        internal Label Label26;
        internal Label Label25;
        internal Label Label24;
        internal Label Label23;
        internal Label Label22;
        internal Label Label49;
        internal Label Label67;
        internal Label Label66;
        internal PictureBox PictureBox1;
        internal PictureBox PictureBox3;
        internal PictureBox PictureBox2;
        internal PictureBox PictureBox4;
    }
}