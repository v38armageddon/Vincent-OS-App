using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class paints
    {
        // Tout ceci permet de faire fonctionner les outils de dessins
        private Bitmap b = new Bitmap(1000, 1000);
        private string tool = "pencil";
        private string color;
        private string del = "0";
        private string size = "2";
        private Pen penS = new Pen(Brushes.Black, 2f);
        private Pen penBS = new Pen(Brushes.Blue, 2f);
        private Pen penYS = new Pen(Brushes.Yellow, 2f);
        private Pen penRS = new Pen(Brushes.Red, 2f);
        private Pen penGS = new Pen(Brushes.Green, 2f);
        private Pen pen = new Pen(Brushes.Black, 5f);
        private Pen penB = new Pen(Brushes.Blue, 5f);
        private Pen penY = new Pen(Brushes.Yellow, 5f);
        private Pen penR = new Pen(Brushes.Red, 5f);
        private Pen penG = new Pen(Brushes.Green, 5f);
        private Pen deleteS = new Pen(Brushes.White, 8f);
        private Pen delete = new Pen(Brushes.White, 20f);

        public paints()
        {
            InitializeComponent();
        }

        private void paints_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button21.Visible = true;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button21.Visible = true;
            }
        }
        private Point _PictureBox1_MouseMove_coord = new Point();

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var g = Graphics.FromImage(b);
            if (e.Button == MouseButtons.Left & tool == "pencil")
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                if (color == "blue" & size == "2")
                {
                    penBS.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    penBS.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(penBS, _PictureBox1_MouseMove_coord.X, _PictureBox1_MouseMove_coord.Y, e.X, e.Y);
                }
                else if (color == "blue" & size == "5")
                {
                    penB.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    penB.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(penB, _PictureBox1_MouseMove_coord.X, _PictureBox1_MouseMove_coord.Y, e.X, e.Y);
                }
                else if (color == "yellow" & size == "2")
                {
                    penYS.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    penYS.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(penYS, _PictureBox1_MouseMove_coord.X, _PictureBox1_MouseMove_coord.Y, e.X, e.Y);
                }
                else if (color == "yellow" & size == "5")
                {
                    penY.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    penY.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(penY, _PictureBox1_MouseMove_coord.X, _PictureBox1_MouseMove_coord.Y, e.X, e.Y);
                }
                else if (color == "red" & size == "2")
                {
                    penRS.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    penRS.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(penRS, _PictureBox1_MouseMove_coord.X, _PictureBox1_MouseMove_coord.Y, e.X, e.Y);
                }
                else if (color == "red" & size == "5")
                {
                    penR.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    penR.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(penR, _PictureBox1_MouseMove_coord.X, _PictureBox1_MouseMove_coord.Y, e.X, e.Y);
                }
                else if (color == "green" & size == "2")
                {
                    penGS.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    penGS.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(penGS, _PictureBox1_MouseMove_coord.X, _PictureBox1_MouseMove_coord.Y, e.X, e.Y);
                }
                else if (color == "green" & size == "5")
                {
                    penG.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    penG.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(penG, _PictureBox1_MouseMove_coord.X, _PictureBox1_MouseMove_coord.Y, e.X, e.Y);
                }
                else if (color == "none" & del == "1" & size == "2")
                {
                    deleteS.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    deleteS.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(deleteS, _PictureBox1_MouseMove_coord.X, _PictureBox1_MouseMove_coord.Y, e.X, e.Y);
                }
                else if (color == "none" & del == "1" & size == "5")
                {
                    delete.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    delete.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(delete, _PictureBox1_MouseMove_coord.X, _PictureBox1_MouseMove_coord.Y, e.X, e.Y);
                }
                else if (size == "2")
                {
                    penS.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    penS.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(penS, _PictureBox1_MouseMove_coord.X, _PictureBox1_MouseMove_coord.Y, e.X, e.Y);
                }
                else if (size == "5")
                {
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(pen, _PictureBox1_MouseMove_coord.X, _PictureBox1_MouseMove_coord.Y, e.X, e.Y);
                }
                g.Dispose();
                PictureBox1.BackgroundImage = b;
                Refresh();
            }
            _PictureBox1_MouseMove_coord = e.Location;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (tool == "fill")
            {
                PictureBox1.BackgroundImage = null;
                var g = Graphics.FromImage(b);
                g.Clear(Color.Transparent);
                if (color == "blue")
                {
                    PictureBox1.BackColor = Color.Blue;
                }
                else if (color == "yellow")
                {
                    PictureBox1.BackColor = Color.Yellow;
                }
                else if (color == "red")
                {
                    PictureBox1.BackColor = Color.Red;
                }
                else if (color == "green")
                {
                    PictureBox1.BackColor = Color.Green;
                }
                else
                {
                    PictureBox1.BackColor = Color.Black;
                }
            }
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            color = "red";
        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            color = "green";
        }

        private void Panel3_Click(object sender, EventArgs e)
        {
            color = "blue";
        }

        private void Panel4_Click(object sender, EventArgs e)
        {
            color = "yellow";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            size = "2";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            size = "5";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            color = "none";
            tool = "pencil";
            del = "1";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var g = Graphics.FromImage(b);
            g.Clear(Color.White);
            PictureBox1.BackColor = Color.White;
            PictureBox1.BackgroundImage = null;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            del = "0";
            tool = "pencil";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            del = "0";
            tool = "fill";
        }

        private void paints_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button21.Visible = false;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button21.Visible = false;
            }
        }
    }
}