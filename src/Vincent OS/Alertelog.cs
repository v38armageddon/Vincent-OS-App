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
    public partial class Alertelog : Form
    {
        public Alertelog()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Arrêter")
            {
                
            }
            else if (comboBox1.Text == "Déconnecter")
            {
                
            }
            else if (comboBox1.Text == "Debug.Terminal")
            {
                
            }
            else
            {
                MessageBox.Show("", "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
