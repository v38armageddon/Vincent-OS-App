using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Vincent_OS
{
    public partial class Calc
    {
        // 'Interface à Retravailler
        private decimal Firstnum;
        private decimal Secondnum;
        private int Operation;
        private bool Operator_Selector = false;

        public Calc()
        {
            InitializeComponent();
        }

        private void Calc_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button26.Visible = true;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button26.Visible = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += "1";
            }
            else
            {
                TextBox1.Text = "1";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += "2";
            }
            else
            {
                TextBox1.Text = "2";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += "3";
            }
            else
            {
                TextBox1.Text = "3";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += "4";
            }
            else
            {
                TextBox1.Text = "4";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += "5";
            }
            else
            {
                TextBox1.Text = "5";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += "6";
            }
            else
            {
                TextBox1.Text = "6";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += "7";
            }
            else
            {
                TextBox1.Text = "7";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += "8";
            }
            else
            {
                TextBox1.Text = "8";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += "9";
            }
            else
            {
                TextBox1.Text = "9";
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (!TextBox1.Text.Contains(","))
            {
                TextBox1.Text += ",";
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += "0";
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
        }
        // ' Système opération
        private void Button13_Click(object sender, EventArgs e)
        {
            Firstnum = Conversions.ToDecimal(TextBox1.Text);
            TextBox1.Text = "0";
            Operator_Selector = true;
            Operation = 1;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Firstnum = Conversions.ToDecimal(TextBox1.Text);
            TextBox1.Text = "0";
            Operator_Selector = true;
            Operation = 2;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Firstnum = Conversions.ToDecimal(TextBox1.Text);
            TextBox1.Text = "0";
            Operator_Selector = true;
            Operation = 3;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Firstnum = Conversions.ToDecimal(TextBox1.Text);
            TextBox1.Text = "0";
            Operator_Selector = true;
            Operation = 4;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (Operator_Selector == true)
            {
                Secondnum = Conversions.ToDecimal(TextBox1.Text);
                if (Operation == 1)
                {
                    TextBox1.Text = (Firstnum + Secondnum).ToString();
                }
                else if (Operation == 2)
                {
                    TextBox1.Text = (Firstnum - Secondnum).ToString();
                }
                else if (Operation == 3)
                {
                    TextBox1.Text = (Firstnum * Secondnum).ToString();
                }
                else if (Secondnum == 0m)
                {
                    TextBox1.Text = "Div par zéro impossible !";
                }
                else
                {
                    TextBox1.Text = (Firstnum / Secondnum).ToString();
                }
                Operator_Selector = false;
            }
        }

        private void Calc_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button26.Visible = false;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button26.Visible = false;
            }
        }
    }
}