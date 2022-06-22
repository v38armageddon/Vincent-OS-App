using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Notepad
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button17.Visible = true;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button17.Visible = true;
            }
        }

        private void NouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.Text = "";
        }

        private void OuvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)OpenFileDialog1.ShowDialog() == 1)
            {
                RichTextBox1.LoadFile(OpenFileDialog1.FileName);
            }
        }

        private void EnrengisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.SaveFile(SaveFileDialog1.FileName);
        }

        private void EnrengisterSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)SaveFileDialog1.ShowDialog() == 1)
            {
                RichTextBox1.SaveFile(SaveFileDialog1.FileName);
            }
        }

        private void AperçuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog1.ShowDialog();
        }

        private void ImprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((int)PrintDialog1.ShowDialog() == 1)
            {
                PrintDocument1.Print();
            }
        }

        private void AnnulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.Undo();
        }

        private void RétablirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.Redo();
        }

        private void CopierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.Copy();
        }

        private void CouperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.Cut();
        }

        private void CollerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.Paste();
        }

        private void CouleurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)ColorDialog1.ShowDialog() == 1)
            {
                RichTextBox1.SelectionColor = ColorDialog1.Color;
            }
        }

        private void PoliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)FontDialog1.ShowDialog() == 1)
            {
                RichTextBox1.SelectionFont = FontDialog1.Font;
            }
        }

        private void CouleurDeFondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)ColorDialog1.ShowDialog() == 1)
            {
                RichTextBox1.BackColor = ColorDialog1.Color;
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(RichTextBox1.Text, RichTextBox1.SelectionFont, Brushes.Black, 100f, 100f);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            RichTextBox1.WordWrap = CheckBox1.Checked;
        }

        private void Notepad_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button17.Visible = false;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button17.Visible = false;
            }
        }
    }
}