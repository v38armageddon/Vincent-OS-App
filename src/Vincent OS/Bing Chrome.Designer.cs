using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Bing_Chrome : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Bing_Chrome));
            TextBox1 = new TextBox();
            TextBox1.Click += new EventHandler(TextBox1_Click);
            TextBox1.KeyPress += new KeyPressEventHandler(TextBox1_KeyPress);
            TabControl1 = new TabControl();
            TabPage2 = new TabPage();
            WebBrowser2 = new WebBrowser();
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
            TabControl1.SuspendLayout();
            TabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // TextBox1
            // 
            TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox1.Location = new Point(230, 12);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(526, 20);
            TextBox1.TabIndex = 5;
            TextBox1.Text = "Saisissez l'URL";
            // 
            // TabControl1
            // 
            TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TabControl1.Controls.Add(TabPage2);
            TabControl1.Location = new Point(0, 46);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(760, 368);
            TabControl1.TabIndex = 10;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(WebBrowser2);
            TabPage2.Location = new Point(4, 22);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(752, 342);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Bing";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // WebBrowser2
            // 
            WebBrowser2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            WebBrowser2.Location = new Point(0, 0);
            WebBrowser2.MinimumSize = new Size(20, 20);
            WebBrowser2.Name = "WebBrowser2";
            WebBrowser2.Size = new Size(752, 342);
            WebBrowser2.TabIndex = 8;
            WebBrowser2.Url = new Uri("https://www.bing.com", UriKind.Absolute);
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button1.BackColor = Color.Green;
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(735, 46);
            Button1.Name = "Button1";
            Button1.Size = new Size(21, 20);
            Button1.TabIndex = 8;
            Button1.Text = "+";
            Button1.UseVisualStyleBackColor = false;
            // 
            // Button2
            // 
            Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button2.BackColor = Color.Green;
            Button2.FlatAppearance.BorderSize = 0;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.ForeColor = Color.White;
            Button2.Location = new Point(715, 46);
            Button2.Name = "Button2";
            Button2.Size = new Size(21, 20);
            Button2.TabIndex = 11;
            Button2.Text = "-";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Button3
            // 
            Button3.BackgroundImage = (Image)resources.GetObject("Button3.BackgroundImage");
            Button3.BackgroundImageLayout = ImageLayout.Stretch;
            Button3.FlatAppearance.BorderSize = 0;
            Button3.FlatStyle = FlatStyle.Flat;
            Button3.Location = new Point(4, 0);
            Button3.Name = "Button3";
            Button3.Size = new Size(40, 40);
            Button3.TabIndex = 9;
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            Button4.BackgroundImage = (Image)resources.GetObject("Button4.BackgroundImage");
            Button4.BackgroundImageLayout = ImageLayout.Stretch;
            Button4.FlatAppearance.BorderSize = 0;
            Button4.FlatStyle = FlatStyle.Flat;
            Button4.Location = new Point(46, 0);
            Button4.Name = "Button4";
            Button4.Size = new Size(40, 40);
            Button4.TabIndex = 12;
            Button4.UseVisualStyleBackColor = true;
            // 
            // Button5
            // 
            Button5.BackgroundImage = (Image)resources.GetObject("Button5.BackgroundImage");
            Button5.BackgroundImageLayout = ImageLayout.Stretch;
            Button5.FlatAppearance.BorderSize = 0;
            Button5.FlatStyle = FlatStyle.Flat;
            Button5.Location = new Point(92, 0);
            Button5.Name = "Button5";
            Button5.Size = new Size(40, 40);
            Button5.TabIndex = 9;
            Button5.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            Button6.BackgroundImage = (Image)resources.GetObject("Button6.BackgroundImage");
            Button6.BackgroundImageLayout = ImageLayout.Stretch;
            Button6.FlatAppearance.BorderSize = 0;
            Button6.FlatStyle = FlatStyle.Flat;
            Button6.Location = new Point(138, 0);
            Button6.Name = "Button6";
            Button6.Size = new Size(40, 40);
            Button6.TabIndex = 9;
            Button6.UseVisualStyleBackColor = true;
            // 
            // Button7
            // 
            Button7.BackgroundImage = (Image)resources.GetObject("Button7.BackgroundImage");
            Button7.BackgroundImageLayout = ImageLayout.Stretch;
            Button7.FlatAppearance.BorderSize = 0;
            Button7.FlatStyle = FlatStyle.Flat;
            Button7.Location = new Point(184, 0);
            Button7.Name = "Button7";
            Button7.Size = new Size(40, 40);
            Button7.TabIndex = 13;
            Button7.UseVisualStyleBackColor = true;
            // 
            // Bing_Chrome
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(762, 415);
            Controls.Add(Button7);
            Controls.Add(Button6);
            Controls.Add(Button5);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(TabControl1);
            Controls.Add(TextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(778, 449);
            Name = "Bing_Chrome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bing Chrome";
            TabControl1.ResumeLayout(false);
            TabPage2.ResumeLayout(false);
            FormClosed += new FormClosedEventHandler(Bing_Chrome_FormClosed);
            Load += new EventHandler(Bing_Chrome_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal TextBox TextBox1;
        internal TabControl TabControl1;
        internal TabPage TabPage2;
        internal WebBrowser WebBrowser2;
        internal Button Button1;
        internal Button Button2;
        internal Button Button3;
        internal Button Button4;
        internal Button Button5;
        internal Button Button6;
        internal Button Button7;
    }
}