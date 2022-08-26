using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2;

namespace Vincent_OS
{
    public partial class Bing_Chrome
    {
        public Bing_Chrome()
        {
            InitializeComponent();
        }

        private void Bing_Chrome_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button15.Visible = true;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button15.Visible = true;
            }
        }
        
        private void Button3_Click(object sender, EventArgs e)
        {
            webView2.CoreWebView2.GoBack();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            webView2.CoreWebView2.GoForward();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            webView2.CoreWebView2.Navigate("https://bing.com");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            webView2.CoreWebView2.Reload();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            webView2.CoreWebView2.Stop();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            search();
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Saisissez l'URL")
            {
                TextBox1.Text = "";
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar((int)Keys.Enter))
            {
                search();
            }
        }

        private void webView2_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            // Fix le problème de connexion à Google dû au UserAgent, voir https://github.com/MicrosoftEdge/WebView2Feedback/issues/1647
            var settings = webView2.CoreWebView2.Settings;
            if (webView2.Source.ToString().Contains("https://accounts.google.com"))
            {
                settings.UserAgent = GetMobileUserAgent();
            }
        }

        private void Bing_Chrome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button15.Visible = false;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button15.Visible = false;
            }
        }

        private void search()
        {
            // Regarder si dans la TextBox, cela contient soit http ou https
            if (TextBox1.Text.Contains("http://") | TextBox1.Text.Contains("https://"))
            {
                webView2.CoreWebView2.Navigate(TextBox1.Text);
            }
            else
            {
                webView2.CoreWebView2.Navigate("http://www.bing.com/search?q=" + TextBox1.Text);
            }
        }

        private string GetMobileUserAgent()
        {
            return "Chrome";
        }
    }
}