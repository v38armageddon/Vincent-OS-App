using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Store
    {
        public Store()
        {
            InitializeComponent();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button8.Visible = true;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button8.Visible = true;
            }
        }

        // Premier onglet
        private void Button11_Click(object sender, EventArgs e)
        {
            Process.Start("https//www.vincent-os.cf/pages/about");
        }

        // Vincent OS Legacy
        private void Button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/v38armageddon/Vincent-OS-App/tree/legacy");
        }

        // Chrono
        private void Button9_Click(object sender, EventArgs e)
        {
            Button9.Text = "Ajouté !";
            Button9.Enabled = false;
            My.MyProject.Forms.Download.Panel6.Visible = true;
        }

        // WebSM
        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.microsoft.com/store/productId/9NVMBH7W0HXF");
        }

        // Deuxième onglet
        private void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "Ajouté !";
            Button1.Enabled = false;
            My.MyProject.Forms.Download.Panel1.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Button2.Text = "Ajouté !";
            Button2.Enabled = false;
            My.MyProject.Forms.Download.Panel2.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button3.Text = "Ajouté !";
            Button3.Enabled = false;
            My.MyProject.Forms.Download.Panel3.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Button4.Text = "Ajouté !";
            Button4.Enabled = false;
            My.MyProject.Forms.Download.Panel4.Visible = true;
        }

        private void VosTéléchargementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Download.Show();
        }

        private void Store_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button8.Visible = false;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button8.Visible = false;
            }
        }
    }
}