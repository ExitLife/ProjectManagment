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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Projects pro = new Projects();
            pro.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Projects pro = new Projects();
            pro.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ViewMenu view = new ViewMenu();
            view.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
            this.Hide();
        }
    }
}
