using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Terminal : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminal));
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox1.BackColor = System.Drawing.Color.Black;
            this.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox1.ForeColor = System.Drawing.Color.White;
            this.RichTextBox1.Location = new System.Drawing.Point(0, 0);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ReadOnly = true;
            this.RichTextBox1.Size = new System.Drawing.Size(575, 313);
            this.RichTextBox1.TabIndex = 0;
            this.RichTextBox1.Text = "Vincent OS [version 8.2.0.0]\nProjet Open Source";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(12, 316);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(127, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "vincentOS:\\>";
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox1.BackColor = System.Drawing.Color.Black;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.TextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.TextBox1.Location = new System.Drawing.Point(146, 313);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(388, 23);
            this.TextBox1.TabIndex = 2;
            this.TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.BackColor = System.Drawing.Color.ForestGreen;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(540, 313);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(35, 23);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "->";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(575, 341);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.RichTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Terminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Terminal_FormClosed);
            this.Load += new System.EventHandler(this.Terminal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal RichTextBox RichTextBox1;
        internal Label Label1;
        internal TextBox TextBox1;
        internal Button Button1;
    }
}