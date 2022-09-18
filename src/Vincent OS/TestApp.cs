using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class TestApp : Form
    {
        public TestApp()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroProgressSpinner1.Spinning == false)
            {
                metroProgressSpinner1.Spinning = true;
            }
            else
            {
                metroProgressSpinner1.Spinning = false;
            }
        }
    }
}
