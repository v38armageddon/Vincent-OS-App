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
            RichTextBox1 = new RichTextBox();
            Label1 = new Label();
            TextBox1 = new TextBox();
            Button1 = new Button();
            SuspendLayout();
            // 
            // RichTextBox1
            // 
            RichTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RichTextBox1.BackColor = Color.Black;
            RichTextBox1.BorderStyle = BorderStyle.None;
            RichTextBox1.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RichTextBox1.ForeColor = Color.White;
            RichTextBox1.Location = new Point(0, 0);
            RichTextBox1.Margin = new Padding(4, 3, 4, 3);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.ReadOnly = true;
            RichTextBox1.Size = new Size(671, 361);
            RichTextBox1.TabIndex = 0;
            RichTextBox1.Text = "Vincent OS [version 10.1.0.0]\nProjet Open Source";
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label1.AutoSize = true;
            Label1.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(14, 365);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(127, 16);
            Label1.TabIndex = 1;
            Label1.Text = "vincentOS:\\>";
            // 
            // TextBox1
            // 
            TextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBox1.BackColor = Color.Black;
            TextBox1.BorderStyle = BorderStyle.FixedSingle;
            TextBox1.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox1.ForeColor = Color.Transparent;
            TextBox1.Location = new Point(170, 361);
            TextBox1.Margin = new Padding(4, 3, 4, 3);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(452, 23);
            TextBox1.TabIndex = 2;
            TextBox1.KeyPress += TextBox1_KeyPress;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button1.BackColor = Color.ForestGreen;
            Button1.FlatStyle = FlatStyle.Popup;
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(630, 361);
            Button1.Margin = new Padding(4, 3, 4, 3);
            Button1.Name = "Button1";
            Button1.Size = new Size(41, 27);
            Button1.TabIndex = 3;
            Button1.Text = "->";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // Terminal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(671, 393);
            Controls.Add(Button1);
            Controls.Add(TextBox1);
            Controls.Add(Label1);
            Controls.Add(RichTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Terminal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Terminal";
            FormClosed += Terminal_FormClosed;
            Load += Terminal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        internal RichTextBox RichTextBox1;
        internal Label Label1;
        internal TextBox TextBox1;
        internal Button Button1;
    }
}