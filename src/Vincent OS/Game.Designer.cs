using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class game : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Label1 = new Label();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.BackgroundImage = (Image)resources.GetObject("Button1.BackgroundImage");
            Button1.BackgroundImageLayout = ImageLayout.Stretch;
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(95, 8);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 73);
            Button1.TabIndex = 0;
            Button1.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(176, 30);
            Label1.Name = "Label1";
            Label1.Size = new Size(96, 24);
            Label1.TabIndex = 1;
            Label1.Text = "Labyrinth";
            // 
            // Button2
            // 
            Button2.BackColor = Color.Green;
            Button2.FlatAppearance.BorderSize = 0;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Font = new Font("Calibri", 11.25f);
            Button2.ForeColor = Color.White;
            Button2.Location = new Point(7, 87);
            Button2.Name = "Button2";
            Button2.Size = new Size(212, 30);
            Button2.TabIndex = 2;
            Button2.Text = "Exécuter un jeu non-Vincent OS";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Button4
            // 
            Button4.BackColor = Color.Green;
            Button4.FlatAppearance.BorderSize = 0;
            Button4.FlatStyle = FlatStyle.Flat;
            Button4.Font = new Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button4.ForeColor = Color.White;
            Button4.Location = new Point(225, 87);
            Button4.Name = "Button4";
            Button4.Size = new Size(146, 30);
            Button4.TabIndex = 5;
            Button4.Text = "Obtenir plus de jeux";
            Button4.UseVisualStyleBackColor = false;
            // 
            // game
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(383, 132);
            Controls.Add(Button4);
            Controls.Add(Button2);
            Controls.Add(Label1);
            Controls.Add(Button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionnaire de jeux";
            Load += new EventHandler(game_Load);
            FormClosed += new FormClosedEventHandler(game_FormClosed);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Button Button1;
        internal Label Label1;
        internal Button Button2;
        internal Button Button4;
    }
}