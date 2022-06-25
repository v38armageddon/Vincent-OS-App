using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Utilisateur : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utilisateur));
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(41, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(257, 22);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Votre nom d\'utilsateur actuel :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(95, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(145, 22);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "[UTILISATEUR]";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Green;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(263, 99);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(59, 20);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Changer";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(3, 99);
            this.TextBox1.MaxLength = 16;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(253, 20);
            this.TextBox1.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Red;
            this.Label3.Location = new System.Drawing.Point(0, 68);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(322, 28);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Afin d\'éviter des problèmes entre nom d\'utilsateur personnalisé et\r\n Vincent OS. " +
    "La limite de caractères est de 16 pour l\'instant.";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(333, 131);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Utilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changer le nom d\'utilisateur";
            this.Load += new System.EventHandler(this.Utilisateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Label Label1;
        internal Label Label2;
        internal Button Button1;
        internal TextBox TextBox1;
        internal Label Label3;
    }
}