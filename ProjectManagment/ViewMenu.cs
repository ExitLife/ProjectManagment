using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagment
{
    public partial class ViewMenu : Form
    {
        public ViewMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ViewEmployees ViewEmp = new ViewEmployees();
            ViewEmp.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewEmployees ViewEmp = new ViewEmployees();
            ViewEmp.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ViewProjects ViewPro = new ViewProjects();
            ViewPro.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ViewProjects ViewPro = new ViewProjects();
            ViewPro.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ViewTasks tasks = new ViewTasks();
            tasks.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewTasks tasks = new ViewTasks();
            tasks.Show();
            this.Hide();
        }
    }
}
