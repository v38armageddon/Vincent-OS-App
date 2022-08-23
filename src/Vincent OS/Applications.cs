using System;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Bing_Chrome.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.Notepad.Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.meme.Show();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.Media.Show();
        }

        private void Button9_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.paints.Show();
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.Visio.Show();
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.game.Show();
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.exewin.Show();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.Terminal.Show();
        }

        private void Button16_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.Calc.Show();
        }
    }
}