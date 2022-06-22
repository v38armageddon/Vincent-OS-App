using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Calc : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
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
            Button7 = new Button();
            Button7.Click += new EventHandler(Button7_Click);
            Button8 = new Button();
            Button8.Click += new EventHandler(Button8_Click);
            Button9 = new Button();
            Button9.Click += new EventHandler(Button9_Click);
            Button10 = new Button();
            Button10.Click += new EventHandler(Button10_Click);
            Button11 = new Button();
            Button11.Click += new EventHandler(Button11_Click);
            Button12 = new Button();
            Button12.Click += new EventHandler(Button12_Click);
            TextBox1 = new TextBox();
            Button13 = new Button();
            Button13.Click += new EventHandler(Button13_Click);
            Button14 = new Button();
            Button14.Click += new EventHandler(Button14_Click);
            Button15 = new Button();
            Button15.Click += new EventHandler(Button15_Click);
            Button16 = new Button();
            Button16.Click += new EventHandler(Button16_Click);
            Button17 = new Button();
            Button17.Click += new EventHandler(Button17_Click);
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.AutoSize = true;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.Location = new Point(13, 38);
            Button1.Name = "Button1";
            Button1.Size = new Size(29, 27);
            Button1.TabIndex = 0;
            Button1.Text = "1";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.AutoSize = true;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button2.Location = new Point(48, 38);
            Button2.Name = "Button2";
            Button2.Size = new Size(29, 27);
            Button2.TabIndex = 1;
            Button2.Text = "2";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button3.AutoSize = true;
            Button3.FlatStyle = FlatStyle.Flat;
            Button3.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button3.Location = new Point(83, 38);
            Button3.Name = "Button3";
            Button3.Size = new Size(29, 27);
            Button3.TabIndex = 2;
            Button3.Text = "3";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            Button4.AutoSize = true;
            Button4.FlatStyle = FlatStyle.Flat;
            Button4.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button4.Location = new Point(13, 67);
            Button4.Name = "Button4";
            Button4.Size = new Size(29, 27);
            Button4.TabIndex = 3;
            Button4.Text = "4";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Button5
            // 
            Button5.AutoSize = true;
            Button5.FlatStyle = FlatStyle.Flat;
            Button5.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button5.Location = new Point(48, 67);
            Button5.Name = "Button5";
            Button5.Size = new Size(29, 27);
            Button5.TabIndex = 4;
            Button5.Text = "5";
            Button5.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            Button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button6.AutoSize = true;
            Button6.FlatStyle = FlatStyle.Flat;
            Button6.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button6.Location = new Point(83, 67);
            Button6.Name = "Button6";
            Button6.Size = new Size(29, 27);
            Button6.TabIndex = 5;
            Button6.Text = "6";
            Button6.UseVisualStyleBackColor = true;
            // 
            // Button7
            // 
            Button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button7.AutoSize = true;
            Button7.FlatStyle = FlatStyle.Flat;
            Button7.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button7.Location = new Point(13, 96);
            Button7.Name = "Button7";
            Button7.Size = new Size(29, 27);
            Button7.TabIndex = 6;
            Button7.Text = "7";
            Button7.UseVisualStyleBackColor = true;
            // 
            // Button8
            // 
            Button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button8.AutoSize = true;
            Button8.FlatStyle = FlatStyle.Flat;
            Button8.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button8.Location = new Point(48, 96);
            Button8.Name = "Button8";
            Button8.Size = new Size(29, 27);
            Button8.TabIndex = 7;
            Button8.Text = "8";
            Button8.UseVisualStyleBackColor = true;
            // 
            // Button9
            // 
            Button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button9.AutoSize = true;
            Button9.FlatStyle = FlatStyle.Flat;
            Button9.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button9.Location = new Point(83, 96);
            Button9.Name = "Button9";
            Button9.Size = new Size(29, 27);
            Button9.TabIndex = 8;
            Button9.Text = "9";
            Button9.UseVisualStyleBackColor = true;
            // 
            // Button10
            // 
            Button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button10.AutoSize = true;
            Button10.FlatStyle = FlatStyle.Flat;
            Button10.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button10.Location = new Point(13, 125);
            Button10.Name = "Button10";
            Button10.Size = new Size(29, 27);
            Button10.TabIndex = 9;
            Button10.Text = ",";
            Button10.UseVisualStyleBackColor = true;
            // 
            // Button11
            // 
            Button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button11.AutoSize = true;
            Button11.FlatStyle = FlatStyle.Flat;
            Button11.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button11.Location = new Point(48, 125);
            Button11.Name = "Button11";
            Button11.Size = new Size(29, 27);
            Button11.TabIndex = 10;
            Button11.Text = "0";
            Button11.UseVisualStyleBackColor = true;
            // 
            // Button12
            // 
            Button12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button12.AutoSize = true;
            Button12.FlatStyle = FlatStyle.Flat;
            Button12.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button12.Location = new Point(83, 125);
            Button12.Name = "Button12";
            Button12.Size = new Size(29, 27);
            Button12.TabIndex = 11;
            Button12.Text = "=";
            Button12.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox1.BackColor = Color.White;
            TextBox1.Location = new Point(12, 12);
            TextBox1.Name = "TextBox1";
            TextBox1.ReadOnly = true;
            TextBox1.Size = new Size(100, 20);
            TextBox1.TabIndex = 12;
            TextBox1.Text = "0";
            // 
            // Button13
            // 
            Button13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button13.AutoSize = true;
            Button13.FlatStyle = FlatStyle.Flat;
            Button13.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button13.Location = new Point(118, 38);
            Button13.Name = "Button13";
            Button13.Size = new Size(29, 27);
            Button13.TabIndex = 13;
            Button13.Text = "+";
            Button13.UseVisualStyleBackColor = true;
            // 
            // Button14
            // 
            Button14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button14.AutoSize = true;
            Button14.FlatStyle = FlatStyle.Flat;
            Button14.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button14.Location = new Point(118, 67);
            Button14.Name = "Button14";
            Button14.Size = new Size(29, 27);
            Button14.TabIndex = 14;
            Button14.Text = "-";
            Button14.UseVisualStyleBackColor = true;
            // 
            // Button15
            // 
            Button15.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button15.AutoSize = true;
            Button15.FlatStyle = FlatStyle.Flat;
            Button15.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button15.Location = new Point(118, 96);
            Button15.Name = "Button15";
            Button15.Size = new Size(29, 27);
            Button15.TabIndex = 15;
            Button15.Text = "*";
            Button15.UseVisualStyleBackColor = true;
            // 
            // Button16
            // 
            Button16.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button16.AutoSize = true;
            Button16.FlatStyle = FlatStyle.Flat;
            Button16.Font = new Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button16.Location = new Point(118, 125);
            Button16.Name = "Button16";
            Button16.Size = new Size(29, 27);
            Button16.TabIndex = 16;
            Button16.Text = "/";
            Button16.UseVisualStyleBackColor = true;
            // 
            // Button17
            // 
            Button17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button17.FlatStyle = FlatStyle.Flat;
            Button17.Location = new Point(118, 12);
            Button17.Name = "Button17";
            Button17.Size = new Size(29, 23);
            Button17.TabIndex = 17;
            Button17.Text = "C";
            Button17.UseVisualStyleBackColor = true;
            // 
            // Calc
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(161, 164);
            Controls.Add(Button17);
            Controls.Add(Button16);
            Controls.Add(Button15);
            Controls.Add(Button14);
            Controls.Add(Button13);
            Controls.Add(TextBox1);
            Controls.Add(Button12);
            Controls.Add(Button11);
            Controls.Add(Button10);
            Controls.Add(Button9);
            Controls.Add(Button8);
            Controls.Add(Button7);
            Controls.Add(Button6);
            Controls.Add(Button5);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(177, 203);
            MinimumSize = new Size(177, 203);
            Name = "Calc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculatrice";
            Load += new EventHandler(Calc_Load);
            FormClosed += new FormClosedEventHandler(Calc_FormClosed);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button Button1;
        internal Button Button2;
        internal Button Button3;
        internal Button Button4;
        internal Button Button5;
        internal Button Button6;
        internal Button Button7;
        internal Button Button8;
        internal Button Button9;
        internal Button Button10;
        internal Button Button11;
        internal Button Button12;
        internal TextBox TextBox1;
        internal Button Button13;
        internal Button Button14;
        internal Button Button15;
        internal Button Button16;
        internal Button Button17;
    }
}