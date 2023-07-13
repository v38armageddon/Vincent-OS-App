using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Applications
    {
        private Process execute = new Process();

        public Applications()
        {
            InitializeComponent();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            WPF.Bing_Chrome bingChrome = new WPF.Bing_Chrome();
            bingChrome.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Notepad notepad = new Notepad();
            notepad.Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Meme meme = new Meme();
            meme.Show();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            WPF.Media media = new WPF.Media();
            media.Show();
        }

        private void Button9_Click_1(object sender, EventArgs e)
        {
            Paints paints = new Paints();
            paints.Show();
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            Visio visio = new Visio();
            visio.Show();
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            game game = new game();
            game.Show();
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            exewin exewin = new exewin();
            exewin.Show();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            Terminal terminal = new Terminal();
            terminal.Show();
        }

        private void Button16_Click_1(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.Show();
        }

        private void Applications_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}