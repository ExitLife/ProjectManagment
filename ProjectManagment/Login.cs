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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Pass.Text == "")
            {
                MessageBox.Show("Wprowadź nazwę użytkownika lub hasło ");
            }
            else if (Uid.Text == "Admin" && Pass.Text == "Admin")
            {
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Błędna nazwa użytkownika lub hasło!");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
