using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Updates : Form
    {
        public Updates()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label1.Text = "Vérification...";
            label1.BackColor = Color.DarkGoldenrod;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                progressBar1.Value = 0;
                button1.Enabled = true;
                webView21.Visible = true;
                label1.Text = "Vincent OS est à jour !";
                label1.BackColor = Color.Green;
            }
        }
    }
}
