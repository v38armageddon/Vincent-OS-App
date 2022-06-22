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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(paints));
            PictureBox1 = new PictureBox();
            PictureBox1.MouseMove += new MouseEventHandler(PictureBox1_MouseMove);
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            Panel1 = new Panel();
            Panel1.Click += new EventHandler(Panel1_Click);
            Panel2 = new Panel();
            Panel2.Click += new EventHandler(Panel2_Click);
            Panel3 = new Panel();
            Panel3.Click += new EventHandler(Panel3_Click);
            Panel4 = new Panel();
            Panel4.Click += new EventHandler(Panel4_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            Button5 = new Button();
            Button5.Click += new EventHandler(Button5_Click);
            Button6 = new Button();
            Button6.Click += new EventHandler(Button6_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            PictureBox1.BackColor = Color.White;
            PictureBox1.BackgroundImageLayout = ImageLayout.None;
            PictureBox1.Location = new Point(108, 0);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(591, 379);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Red;
            Panel1.Location = new Point(12, 12);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(35, 33);
            Panel1.TabIndex = 1;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.Green;
            Panel2.Location = new Point(55, 12);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(35, 33);
            Panel2.TabIndex = 2;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.Blue;
            Panel3.Location = new Point(12, 51);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(35, 33);
            Panel3.TabIndex = 3;
            // 
            // Panel4
            // 
            Panel4.BackColor = Color.Yellow;
            Panel4.Location = new Point(55, 51);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(35, 33);
            Panel4.TabIndex = 2;
            // 
            // Button1
            // 
            Button1.BackColor = Color.White;
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(12, 90);
            Button1.Name = "Button1";
            Button1.Size = new Size(35, 33);
            Button1.TabIndex = 4;
            Button1.Text = "|";
            Button1.UseVisualStyleBackColor = false;
            // 
            // Button2
            // 
            Button2.BackColor = Color.White;
            Button2.FlatAppearance.BorderSize = 0;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold);
            Button2.Location = new Point(55, 90);
            Button2.Name = "Button2";
            Button2.Size = new Size(35, 33);
            Button2.TabIndex = 5;
            Button2.Text = "|";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Button3
            // 
            Button3.BackColor = Color.White;
            Button3.FlatAppearance.BorderSize = 0;
            Button3.FlatStyle = FlatStyle.Flat;
            Button3.Location = new Point(12, 129);
            Button3.Name = "Button3";
            Button3.Size = new Size(78, 23);
            Button3.TabIndex = 6;
            Button3.Text = "Gomme";
            Button3.UseVisualStyleBackColor = false;
            // 
            // Button4
            // 
            Button4.BackColor = Color.White;
            Button4.FlatAppearance.BorderSize = 0;
            Button4.FlatStyle = FlatStyle.Flat;
            Button4.Location = new Point(12, 158);
            Button4.Name = "Button4";
            Button4.Size = new Size(78, 23);
            Button4.TabIndex = 7;
            Button4.Text = "Pinceau";
            Button4.UseVisualStyleBackColor = false;
            // 
            // Button5
            // 
            Button5.BackColor = Color.White;
            Button5.FlatAppearance.BorderSize = 0;
            Button5.FlatStyle = FlatStyle.Flat;
            Button5.Location = new Point(12, 187);
            Button5.Name = "Button5";
            Button5.Size = new Size(78, 23);
            Button5.TabIndex = 8;
            Button5.Text = "Remplir";
            Button5.UseVisualStyleBackColor = false;
            // 
            // Button6
            // 
            Button6.BackColor = Color.White;
            Button6.FlatAppearance.BorderSize = 0;
            Button6.FlatStyle = FlatStyle.Flat;
            Button6.Location = new Point(12, 216);
            Button6.Name = "Button6";
            Button6.Size = new Size(78, 23);
            Button6.TabIndex = 9;
            Button6.Text = "Supprimer";
            Button6.UseVisualStyleBackColor = false;
            // 
            // paints
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(699, 378);
            Controls.Add(Button6);
            Controls.Add(Button5);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(Panel4);
            Controls.Add(Panel3);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Controls.Add(PictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(715, 412);
            Name = "paints";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(paints_Load);
            FormClosed += new FormClosedEventHandler(paints_FormClosed);
            ResumeLayout(false);

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