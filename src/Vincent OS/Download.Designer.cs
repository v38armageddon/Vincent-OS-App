using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Download : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Download));
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.ProgressBar6 = new System.Windows.Forms.ProgressBar();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Button5 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ProgressBar2 = new System.Windows.Forms.ProgressBar();
            this.Button6 = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.PictureBox6 = new System.Windows.Forms.PictureBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.ProgressBar3 = new System.Windows.Forms.ProgressBar();
            this.Button7 = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.ProgressBar4 = new System.Windows.Forms.ProgressBar();
            this.Button8 = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.PictureBox8 = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.FlowLayoutPanel1.SuspendLayout();
            this.Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).BeginInit();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).BeginInit();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.FlowLayoutPanel1.Controls.Add(this.Panel6);
            this.FlowLayoutPanel1.Controls.Add(this.Panel1);
            this.FlowLayoutPanel1.Controls.Add(this.Panel2);
            this.FlowLayoutPanel1.Controls.Add(this.Panel3);
            this.FlowLayoutPanel1.Controls.Add(this.Panel4);
            this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(444, 385);
            this.FlowLayoutPanel1.TabIndex = 0;
            // 
            // Panel6
            // 
            this.Panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel6.Controls.Add(this.ProgressBar6);
            this.Panel6.Controls.Add(this.Button2);
            this.Panel6.Controls.Add(this.Label2);
            this.Panel6.Controls.Add(this.PictureBox2);
            this.Panel6.Location = new System.Drawing.Point(3, 3);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(434, 70);
            this.Panel6.TabIndex = 12;
            this.Panel6.Visible = false;
            // 
            // ProgressBar6
            // 
            this.ProgressBar6.Location = new System.Drawing.Point(76, 44);
            this.ProgressBar6.Name = "ProgressBar6";
            this.ProgressBar6.Size = new System.Drawing.Size(353, 23);
            this.ProgressBar6.TabIndex = 9;
            this.ProgressBar6.Visible = false;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Green;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(291, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(138, 23);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Lancer le téléchargement";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Label2.Location = new System.Drawing.Point(76, 3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 22);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Chrono";
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(5, 3);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(65, 64);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 3;
            this.PictureBox2.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.Controls.Add(this.ProgressBar1);
            this.Panel1.Controls.Add(this.Button5);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.PictureBox5);
            this.Panel1.Location = new System.Drawing.Point(3, 79);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(434, 70);
            this.Panel1.TabIndex = 7;
            this.Panel1.Visible = false;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(76, 44);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(353, 23);
            this.ProgressBar1.TabIndex = 6;
            this.ProgressBar1.Visible = false;
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.Green;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Location = new System.Drawing.Point(291, 5);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(138, 23);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "Lancer le téléchargement";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click_1);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Label3.Location = new System.Drawing.Point(76, 3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(76, 22);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Discord";
            // 
            // PictureBox5
            // 
            this.PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox5.Image")));
            this.PictureBox5.Location = new System.Drawing.Point(5, 3);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(65, 64);
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox5.TabIndex = 3;
            this.PictureBox5.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.Controls.Add(this.ProgressBar2);
            this.Panel2.Controls.Add(this.Button6);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.PictureBox6);
            this.Panel2.Location = new System.Drawing.Point(3, 155);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(434, 70);
            this.Panel2.TabIndex = 8;
            this.Panel2.Visible = false;
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.Location = new System.Drawing.Point(76, 44);
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.Size = new System.Drawing.Size(353, 23);
            this.ProgressBar2.TabIndex = 7;
            this.ProgressBar2.Visible = false;
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.Green;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Location = new System.Drawing.Point(291, 5);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(138, 23);
            this.Button6.TabIndex = 5;
            this.Button6.Text = "Lancer le téléchargement";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click_1);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Label6.Location = new System.Drawing.Point(76, 3);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(146, 22);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Google Chrome";
            // 
            // PictureBox6
            // 
            this.PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox6.Image")));
            this.PictureBox6.Location = new System.Drawing.Point(5, 3);
            this.PictureBox6.Name = "PictureBox6";
            this.PictureBox6.Size = new System.Drawing.Size(65, 64);
            this.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox6.TabIndex = 3;
            this.PictureBox6.TabStop = false;
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.Controls.Add(this.ProgressBar3);
            this.Panel3.Controls.Add(this.Button7);
            this.Panel3.Controls.Add(this.Label7);
            this.Panel3.Controls.Add(this.PictureBox7);
            this.Panel3.Location = new System.Drawing.Point(3, 231);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(434, 70);
            this.Panel3.TabIndex = 9;
            this.Panel3.Visible = false;
            // 
            // ProgressBar3
            // 
            this.ProgressBar3.Location = new System.Drawing.Point(76, 44);
            this.ProgressBar3.Name = "ProgressBar3";
            this.ProgressBar3.Size = new System.Drawing.Size(353, 23);
            this.ProgressBar3.TabIndex = 8;
            this.ProgressBar3.Visible = false;
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.Green;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.ForeColor = System.Drawing.Color.White;
            this.Button7.Location = new System.Drawing.Point(291, 5);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(138, 23);
            this.Button7.TabIndex = 5;
            this.Button7.Text = "Lancer le téléchargement";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click_1);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Label7.Location = new System.Drawing.Point(76, 3);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(131, 22);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Mozilla Firefox";
            // 
            // PictureBox7
            // 
            this.PictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox7.Image")));
            this.PictureBox7.Location = new System.Drawing.Point(5, 3);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new System.Drawing.Size(65, 64);
            this.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox7.TabIndex = 3;
            this.PictureBox7.TabStop = false;
            // 
            // Panel4
            // 
            this.Panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel4.Controls.Add(this.ProgressBar4);
            this.Panel4.Controls.Add(this.Button8);
            this.Panel4.Controls.Add(this.Label8);
            this.Panel4.Controls.Add(this.PictureBox8);
            this.Panel4.Location = new System.Drawing.Point(3, 307);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(434, 70);
            this.Panel4.TabIndex = 10;
            this.Panel4.Visible = false;
            // 
            // ProgressBar4
            // 
            this.ProgressBar4.Location = new System.Drawing.Point(76, 44);
            this.ProgressBar4.Name = "ProgressBar4";
            this.ProgressBar4.Size = new System.Drawing.Size(353, 23);
            this.ProgressBar4.TabIndex = 9;
            this.ProgressBar4.Visible = false;
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.Green;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.ForeColor = System.Drawing.Color.White;
            this.Button8.Location = new System.Drawing.Point(291, 5);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(138, 23);
            this.Button8.TabIndex = 5;
            this.Button8.Text = "Lancer le téléchargement";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.Button8_Click_1);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Label8.Location = new System.Drawing.Point(76, 3);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(65, 22);
            this.Label8.TabIndex = 4;
            this.Label8.Text = "Steam";
            // 
            // PictureBox8
            // 
            this.PictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox8.Image")));
            this.PictureBox8.Location = new System.Drawing.Point(5, 3);
            this.PictureBox8.Name = "PictureBox8";
            this.PictureBox8.Size = new System.Drawing.Size(65, 64);
            this.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox8.TabIndex = 3;
            this.PictureBox8.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 385);
            this.Controls.Add(this.FlowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(448, 412);
            this.Name = "Download";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vos téléchargements";
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox8)).EndInit();
            this.ResumeLayout(false);

        }
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Panel Panel1;
        internal ProgressBar ProgressBar1;
        internal Button Button5;
        internal Label Label3;
        internal PictureBox PictureBox5;
        internal Panel Panel4;
        internal ProgressBar ProgressBar4;
        internal Button Button8;
        internal Label Label8;
        internal PictureBox PictureBox8;
        internal Panel Panel3;
        internal ProgressBar ProgressBar3;
        internal Button Button7;
        internal Label Label7;
        internal PictureBox PictureBox7;
        internal Panel Panel2;
        internal ProgressBar ProgressBar2;
        internal Button Button6;
        internal Label Label6;
        internal PictureBox PictureBox6;
        internal Timer Timer1;
        internal Panel Panel6;
        internal ProgressBar ProgressBar6;
        internal Button Button2;
        internal Label Label2;
        internal PictureBox PictureBox2;
    }
}