﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vincent_OS.WPF
{
    public partial class Bing_Chrome : Window
    {
        public Bing_Chrome()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
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

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            webView2.CoreWebView2.GoBack();
        }

        private void forwardButton_Click(object sender, RoutedEventArgs e)
        {
            webView2.CoreWebView2.GoForward();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            webView2.CoreWebView2.Navigate("https://bing.com");
        }

        private void reloadButton_Click(object sender, RoutedEventArgs e)
        {
            webView2.CoreWebView2.Reload();
        }

        private void stopReloadButton_Click(object sender, RoutedEventArgs e)
        {
            webView2.CoreWebView2.Stop();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            search();
        }

        private void webView2_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            // Mettre un UserAgent de Edge pour éviter les bloquages des sites
            var settings = webView2.CoreWebView2.Settings;
            settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.5026.0 Safari/537.36 Edg/103.0.1254.0";
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button15.Visible = false;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button15.Visible = false;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void search()
        {
            // Regarder si dans la TextBox, cela contient soit http ou https
            if (textBox.Text.Contains("http://") | textBox.Text.Contains("https://"))
            {
                webView2.CoreWebView2.Navigate(textBox.Text);
            }
            else
            {
                webView2.CoreWebView2.Navigate("https://www.bing.com/search?q=" + textBox.Text);
            }
        }
    }
}
