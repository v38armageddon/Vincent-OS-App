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
    public partial class Login2bureau2 : Form
    {
        public Login2bureau2()
        {
            InitializeComponent();
        }

        private void Login2bureau2_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(3);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                progressBar1.Value = 0;
                Bureau2 b = new Bureau2();
                b.Show();
                this.Close();
            }
        }
    }
}
