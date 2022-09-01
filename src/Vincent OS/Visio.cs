using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Visio
    {
        public Visio()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
        private List<string> Images;
        private int Index = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button20.Visible = true;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button20.Visible = true;
            }
            Images = new List<string>();
            Panel1.Controls.Add(PictureBox1);
        }

        private void OuvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "Images|*.jpeg;*.jpg;*.png;*.bmp;*.ico;*.cur";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (PictureBox1.Image is not null)
                    {
                        PictureBox1.Image.Dispose();
                    }
                    PictureBox1.Image = Image.FromFile(open.FileName);
                    PictureBoxManager();
                    string dossier = open.FileName.Substring(0, open.FileName.LastIndexOf(@"\"));
                    var r = from i in Directory.GetFiles(dossier)
                            where i.ToLower().EndsWith("jpeg") | i.ToLower().EndsWith("jpg") | i.ToLower().EndsWith("png") | i.ToLower().EndsWith("bmp") | i.ToLower().EndsWith("ico") | i.ToLower().EndsWith("cur")
                            select i;
                    Images.Clear();
                    for (int x = 0, loopTo = r.Count(); x <= loopTo; x++)
                    {
                        Images.Add(r.ElementAtOrDefault(x));
                        if ((r.ElementAtOrDefault(x) ?? "") == (open.FileName ?? ""))
                        {
                            Index = x;
                        }
                    }
                }
            }
        }

        private void PictureBoxManager()
        {
            if (PictureBox1.Image.Width > Panel1.Width & PictureBox1.Image.Height > Panel1.Height)
            {
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                PictureBox1.Dock = DockStyle.Fill;
            }
            else if (PictureBox1.Image.Width > Panel1.Width | PictureBox1.Image.Height > Panel1.Height)
            {
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                PictureBox1.Dock = DockStyle.Fill;
            }
            else
            {
                PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                PictureBox1.Dock = DockStyle.Fill;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Images.Count > 1)
            {
                if (Index + 1 > Images.Count - 1)
                {
                    Index = 0;
                }
                else
                {
                    Index = Index + 1;
                }
                PictureBox1.Image.Dispose();
                PictureBox1.Image = Image.FromFile(Images[Index]);
                PictureBoxManager();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Images.Count > 1)
            {
                if (Index - 1 < 0)
                {
                    Index = Images.Count - 1;
                }
                else
                {
                    Index = Index - 1;
                }
                PictureBox1.Image.Dispose();
                PictureBox1.Image = Image.FromFile(Images[Index]);
                PictureBoxManager();
            }
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (PictureBox1.Dock == DockStyle.Fill)
            {
                PictureBox1.Dock = DockStyle.None;
                PictureBox1.Size = new Size(PictureBox1.Image.Width * 2, PictureBox1.Image.Height * 2);
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                if (PictureBox1.Width < Panel1.Width)
                {
                    PictureBox1.Location = new Point((int)Math.Round(Panel1.Width / 2d - PictureBox1.Width), PictureBox1.Location.Y);
                }
            }
            else
            {
                PictureBoxManager();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (PictureBox1.Image is not null)
            {
                PictureBoxManager();
                PictureBox1.Location = new Point(0, 0);
            }
        }

        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Images.Count > 0)
            {
                PictureBox1.Image.Dispose();
                try
                {
                    File.Delete(Images[Index]);
                    Images.RemoveAt(Index);
                    if (Images.Count > 0)
                    {
                        if (Index > Images.Count - 1)
                        {
                            Index = 0;
                        }
                        PictureBox1.Image = Image.FromFile(Images[Index]);
                    }
                    else
                    {
                        PictureBox1.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Visio_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button20.Visible = false;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button20.Visible = false;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}