using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class chrono : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(chrono));
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            ProgressBar1 = new ProgressBar();
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new Point(12, 41);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 0;
            Button1.Text = "Start";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(93, 41);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 1;
            Button2.Text = "Stop";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Location = new Point(174, 41);
            Button3.Name = "Button3";
            Button3.Size = new Size(75, 23);
            Button3.TabIndex = 2;
            Button3.Text = "Reset";
            Button3.UseVisualStyleBackColor = true;
            // 
            // ProgressBar1
            // 
            ProgressBar1.Location = new Point(12, 12);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(240, 23);
            ProgressBar1.TabIndex = 3;
            // 
            // Timer1
            // 
            // 
            // chrono
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 79);
            Controls.Add(ProgressBar1);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "chrono";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chronomètre";
            Load += new EventHandler(chrono_Load);
            FormClosed += new FormClosedEventHandler(chrono_FormClosed);
            ResumeLayout(false);

        }
        internal Button Button1;
        internal Button Button2;
        internal Button Button3;
        internal ProgressBar ProgressBar1;
        internal Timer Timer1;

    }
}