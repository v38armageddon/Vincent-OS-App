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
    public partial class Bureau : Form
    {
        public Bureau()
        {
            InitializeComponent();
        }

        private void Bureau_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // Date, heure, calendrier
        private void label1_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
            }
            else if (monthCalendar1.Visible == true)
            {
                monthCalendar1.Visible = false;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
            }
            else if (monthCalendar1.Visible == true)
            {
                monthCalendar1.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        // Un bouton pour fermer le bureau
        private void button2_Click(object sender, EventArgs e)
        {
            Alertelog alertelog = new Alertelog();
            alertelog.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
        }

        // Applications sur le bureau
        private void button3_Click(object sender, EventArgs e)
        {
            Bing_Chrome bing_chrome = new Bing_Chrome();
            bing_chrome.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Meme meme = new Meme();
            meme.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Notepad notepad = new Notepad();
            notepad.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Media media = new Media();
            media.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Visio visio = new Visio();
            visio.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Paints paints = new Paints();
            paints.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Exewin exewin = new Exewin();
            exewin.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Terminal terminal = new Terminal();
            terminal.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Applications applications = new Applications();
            applications.Show();
            if (applications.Visible == true)
            {
                applications.BringToFront();
            }
        }

        // Cette partie permet quand la fenêtre est trop caché par le bureau, qu'on puisse la récupérer via un bouton sans faire alt+tab
        private void button14_Click(object sender, EventArgs e)
        {
            Bing_Chrome bing_Chrome = new Bing_Chrome();
            bing_Chrome.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Meme meme = new Meme();
            meme.BringToFront();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Notepad notepad = new Notepad();
            notepad.BringToFront();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Media media = new Media();
            media.BringToFront();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Visio visio = new Visio();
            visio.BringToFront();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Paints paints = new Paints();
            paints.BringToFront();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.BringToFront();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Exewin exewin = new Exewin();
            exewin.BringToFront();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Terminal terminal = new Terminal();
            terminal.BringToFront();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.BringToFront();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Chrono chrono = new Chrono();
            chrono.BringToFront();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.BringToFront();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == true)
            {
                monthCalendar1.Visible = false;
            }
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }
    }
}
