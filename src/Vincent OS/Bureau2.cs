using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Vincent_OS
{
    public partial class Bureau2
    {
        public Bureau2()
        {
            InitializeComponent();
        }

        private void Bureau_Load(object sender, EventArgs e)
        {
            Timer1.Start();
            if (My.MyProject.Forms.Login.Label3.Text == "Invité")
            {
                Text = "Bureau - Session Invité";
                Label3.Text = "Invité";
            }
            else
            {
                Text = "Bureau - Session " + My.MyProject.Forms.Login.Label3.Text;
                Label3.Text = My.MyProject.Forms.Login.Label3.Text;
            }
            if (My.MyProject.Computer.Network.IsAvailable)
            {
                PictureBox5.Visible = true;
            }
            else
            {
                PictureBox6.Visible = true;
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
            Label2.Text = Conversions.ToString(DateAndTime.TimeOfDay);
            Label1.Text = Conversions.ToString(DateTime.Today);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.alertelog.Show();
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
            My.MyProject.Forms.Bing_Chrome.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.meme.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Media.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Visio.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Notepad.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Hide();
            My.MyProject.Forms.Login.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.exewin.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Paramètres.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Applications.Show();
            if (My.MyProject.Forms.Applications.Visible == true)
            {
                My.MyProject.Forms.Applications.BringToFront();
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.game.Show();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.paints.Show();
        }

        private void Button11_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.UAC.Text = "Bureau2.SerVOS a besoin de votre autorisation !";
            My.MyProject.Forms.UAC.Show();
        }

        private void Label2_Click_1(object sender, EventArgs e)
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

        // ' Cette partie permet quand la fenêtre est trop caché par le bureau, qu'on puisse la récupérer via un bouton sans faire alt+tab
        private void Button15_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Bing_Chrome.BringToFront();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.meme.BringToFront();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Notepad.BringToFront();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Media.BringToFront();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Visio.BringToFront();
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.paints.BringToFront();
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.game.BringToFront();
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.exewin.BringToFront();
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Terminal.BringToFront();
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.Store.BringToFront();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.chrono.BringToFront();
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Calc.BringToFront();
        }

        private void FlowLayoutPanel1_Click(object sender, EventArgs e)
        {
            if (MonthCalendar1.Visible == true)
            {
                MonthCalendar1.Visible = false;
            }
            if (Panel1.Visible == true)
            {
                Panel1.Visible = false;
            }
            if (Panel3.Visible == true)
            {
                Panel3.Visible = false;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            if (MonthCalendar1.Visible == true)
            {
                MonthCalendar1.Visible = false;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.UAC.Text = "Bureau2.SerVOS a besoin de votre autorisation !";
            My.MyProject.Forms.UAC.Show();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            // En dev
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (Panel3.Visible == false)
            {
                Panel3.Visible = true;
            }
            else if (Panel3.Visible == true)
            {
                Panel3.Visible = false;
            }
        }
        private void PictureBox5_MouseHover(object sender, EventArgs e)
        {
            Label4.Visible = true;
        }

        private void PictureBox6_MouseHover(object sender, EventArgs e)
        {
            Label5.Visible = true;
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Label4.Visible = false;
        }

        private void PictureBox6_MouseLeave(object sender, EventArgs e)
        {
            Label5.Visible = false;
        }
    }
}