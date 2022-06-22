using System;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Bing_Chrome
    {
        public Bing_Chrome()
        {
            InitializeComponent();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            WebBrowser2.GoBack();
            TabPage2.Text = WebBrowser2.DocumentTitle; // ' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            WebBrowser2.GoForward();
            TabPage2.Text = WebBrowser2.DocumentTitle; // ' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            WebBrowser2.GoHome();
            TabPage2.Text = WebBrowser2.DocumentTitle; // ' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            WebBrowser2.Refresh();
            TabPage2.Text = WebBrowser2.DocumentTitle; // ' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            WebBrowser2.Stop();
            TabPage2.Text = WebBrowser2.DocumentTitle; // ' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            search();
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
            TabPage2.Text = WebBrowser2.DocumentTitle; // ' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var newPage = new TabPage();
            newPage.Text = WebBrowser2.DocumentTitle;
            TabControl1.TabPages.Add(newPage);
            var webbrowswer = new WebBrowser();
            webbrowswer.Dock = DockStyle.Fill;
            webbrowswer.Navigate("https://www.bing.com");
            newPage.Controls.Add(webbrowswer);
            TabControl1.SelectedTab = newPage;
            TabPage2.Text = WebBrowser2.DocumentTitle; // ' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
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

        private void search()
        {
            // ' Regarder si dans la TextBox, cela contient soit http ou https
            if (TextBox1.Text.Contains("http://") | TextBox1.Text.Contains("https://"))
            {
                WebBrowser2.Navigate(TextBox1.Text);
                TabPage2.Text = WebBrowser2.DocumentTitle; // ' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
            }
            else
            {
                WebBrowser2.Navigate("http://www.bing.com/search?q=" + TextBox1.Text);
                TabPage2.Text = WebBrowser2.DocumentTitle;
            } // ' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TabControl1.Controls.RemoveAt(0);
            if (TabControl1.TabPages.Count == 0)
            {
                Close();
            }
        }
    }
}