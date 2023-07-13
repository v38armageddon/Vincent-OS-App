using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Bureau
    {
        public Bureau()
        {
            InitializeComponent();
        }

        private void Bureau_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Timer1.Start();
            Login login = new Login();
            if (login.Label2.Text == "Superutilisateur")
            {
                Text = "Bureau - Session Superutilisateur";
                Label3.Text = "Superutilisateur";
            }
            else
            {
                Text = "Bureau - Session " + login.Label2.Text;
                Label3.Text = login.Label2.Text;
            }
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                PictureBox6.Visible = true;
            }
            else
            {
                PictureBox7.Visible = true;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            if (MonthCalendar1.Visible == false)
            {
                MonthCalendar1.Visible = true;
            }
            else if (MonthCalendar1.Visible == true)
            {
                MonthCalendar1.Visible = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Today;
            Label1.Text = time.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            alertelog alertelog = new alertelog();
            alertelog.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (Panel1.Visible == false)
            {
                Panel1.Visible = true;
            }
            else if (Panel1.Visible == true)
            {
                Panel1.Visible = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WPF.Bing_Chrome bingChrome = new WPF.Bing_Chrome();
            bingChrome.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Meme meme = new Meme();
            meme.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            WPF.Media media = new WPF.Media();
            media.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Visio visio = new Visio();
            visio.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Notepad notepad = new Notepad();
            notepad.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Paramètres paramètres = new Paramètres();
            paramètres.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            exewin exewin = new exewin();
            exewin.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Applications applications = new Applications();
            applications.Show();
            if (applications.Visible == true)
            {
                applications.BringToFront();
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            game game = new game();
            game.Show();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Paints paints = new Paints();
            paints.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Terminal terminal = new Terminal();
            terminal.Show();
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            if (MonthCalendar1.Visible == false)
            {
                MonthCalendar1.Visible = true;
            }
            else if (MonthCalendar1.Visible == true)
            {
                MonthCalendar1.Visible = false;
            }
        }

        // Cette partie permet quand la fenêtre est trop caché par le bureau, qu'on puisse la récupérer via un bouton sans faire alt+tab
        private void Button15_Click(object sender, EventArgs e)
        {
            WPF.Bing_Chrome bingChrome = new WPF.Bing_Chrome();
            bingChrome.Activate();
            bingChrome.Topmost = true;
            bingChrome.Topmost = false;
            bingChrome.Focus();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Meme meme = new Meme();
            meme.BringToFront();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            Notepad notepad = new Notepad();
            notepad.BringToFront();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            WPF.Media media = new WPF.Media();
            media.Activate();
            media.Topmost = true;
            media.Topmost = false;
            media.Focus();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Visio visio = new Visio();
            visio.BringToFront();
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            Paints paints = new Paints();
            paints.BringToFront();
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            game game = new game();
            game.BringToFront();
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            exewin exewin = new exewin();
            exewin.BringToFront();
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            Terminal terminal = new Terminal();
            terminal.BringToFront();
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.BringToFront();
        }

        private void FlowLayoutPanel1_Click_1(object sender, EventArgs e)
        {
            if (MonthCalendar1.Visible == true)
            {
                MonthCalendar1.Visible = false;
            }
            if (Panel1.Visible == true)
            {
                Panel1.Visible = false;
            }
        }

        private void PictureBox7_MouseHover(object sender, EventArgs e)
        {
            Label5.Visible = true;
        }

        private void PictureBox6_MouseHover(object sender, EventArgs e)
        {
            Label4.Visible = true;
        }

        private void PictureBox7_MouseLeave(object sender, EventArgs e)
        {
            Label5.Visible = false;
        }

        private void PictureBox6_MouseLeave(object sender, EventArgs e)
        {
            Label4.Visible = false;
        }
    }
}