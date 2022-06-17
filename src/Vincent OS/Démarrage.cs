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
    public partial class Démarrage : Form
    {
        public Démarrage()
        {
            InitializeComponent();
        }

        private void Démarrage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Login l = new Login();
                l.Show();
                this.Hide();
                System.IO.Stream str = Properties.Resources.startingSound;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
                player.Play();
            }
        }
    }
}
