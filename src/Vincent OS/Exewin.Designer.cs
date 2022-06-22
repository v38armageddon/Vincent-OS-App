using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class exewin : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(exewin));
            Label1 = new Label();
            TextBox1 = new TextBox();
            TextBox1.KeyPress += new KeyPressEventHandler(TextBox1_KeyPress);
            Button1 = new Button();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(-1, -1);
            Label1.Name = "Label1";
            Label1.Size = new Size(395, 32);
            Label1.TabIndex = 0;
            Label1.Text = "Pour exécuter une application Windows, mettez l'adresse du fichier" + '\r' + '\n' + "(exemple : C:" + @"\(nom du fichier)\(nom de l'application en .exe)" + '\r' + '\n';
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(2, 43);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(357, 20);
            TextBox1.TabIndex = 2;
            // 
            // Button1
            // 
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(365, 43);
            Button1.Name = "Button1";
            Button1.Size = new Size(29, 20);
            Button1.TabIndex = 3;
            Button1.Text = "->";
            Button1.UseVisualStyleBackColor = true;
            // 
            // exewin
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 75);
            Controls.Add(Button1);
            Controls.Add(TextBox1);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "exewin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exécuter une application Windows";
            Load += new EventHandler(exewin_Load);
            FormClosed += new FormClosedEventHandler(exewin_FormClosed);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label1;
        internal TextBox TextBox1;
        internal Button Button1;
    }
}