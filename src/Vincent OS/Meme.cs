﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Meme
    {
        public Meme()
        {
            InitializeComponent();
        }

        private void meme_Load(object sender, EventArgs e)
        {
            Bureau bureau = new Bureau();
            Bureau2 bureau2 = new Bureau2();
            if (bureau.Visible == true)
            {
                bureau.Button16.Visible = true;
            }
            else if (bureau2.Visible == true)
            {
                bureau2.Button16.Visible = true;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            WebBrowser1.GoBack();
            TabPage2.Text = WebBrowser1.DocumentTitle;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            WebBrowser1.GoForward();
            TabPage2.Text = WebBrowser1.DocumentTitle;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            WebBrowser1.Navigate(TextBox1.Text);
            TabPage2.Text = WebBrowser1.DocumentTitle;
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Entrez votre destination (exemple : C:\\(nom de dossier))")
            {
                TextBox1.Text = "";
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar((int)Keys.Enter))
            {
                WebBrowser1.Navigate(TextBox1.Text);
                TabPage2.Text = WebBrowser1.DocumentTitle;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var newPage = new TabPage();
            newPage.Text = WebBrowser1.DocumentTitle;
            TabControl1.TabPages.Add(newPage);
            var webbrowswer = new WebBrowser();
            webbrowswer.Dock = DockStyle.Fill;
            webbrowswer.Navigate("C:\\Users\\");
            newPage.Controls.Add(webbrowswer);
            TabControl1.SelectedTab = newPage;
            TabPage2.Text = WebBrowser1.DocumentTitle;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TabControl1.Controls.RemoveAt(0);
            if (TabControl1.TabPages.Count == 0)
            {
                Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            WebBrowser1.Navigate("C:\\Users\\" + Environment.UserName + "\\Documents");
            TabPage2.Text = Button3.Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            WebBrowser1.Navigate("C:\\Users\\" + Environment.UserName + "\\Pictures");
            TabPage2.Text = Button4.Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            WebBrowser1.Navigate("C:\\Users\\" + Environment.UserName + "\\Music");
            TabPage2.Text = Button5.Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            WebBrowser1.Navigate("C:\\Users\\" + Environment.UserName + "\\Videos");
            TabPage2.Text = Button6.Text;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            WebBrowser1.Navigate("C:\\");
            TabPage2.Text = Button7.Text;
        }

        private void meme_FormClosed(object sender, FormClosedEventArgs e)
        {
            Bureau bureau = new Bureau();
            Bureau2 bureau2 = new Bureau2();
            if (bureau.Visible == true)
            {
                bureau.Button16.Visible = false;
            }
            else if (bureau2.Visible == true)
            {
                bureau2.Button16.Visible = false;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}