using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectManagment
{
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\theas\OneDrive\Dokumenty\EmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Project_Id.Text == "" || ProjectName.Text == "" || LaunchName.Text == "" || EndProject.Text == "" || Status.Text == "" || DescProject.Text == "" || User_Id.Text == "")
            {
                MessageBox.Show("Brakuje informacji");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into ProjectTbl values('" + Project_Id.Text.ToString() + "','" + ProjectName.Text + "','" + LaunchName.Text + "','" + EndProject.Text + "','" + Status.Text + "','" + DescProject.Text + "','" + User_Id.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Projekt został dodany pomyślnie!");
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Project_Id.Text == "")
            {
                MessageBox.Show("Wprowadź ID projektu!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from ProjectTbl where Project_Id ='" + Project_Id.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pomyślnie usunięto projekt!");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Project_Id.Text == "" || ProjectName.Text == "" || LaunchName.Text == "" || EndProject.Text == "" || Status.Text == "" || DescProject.Text == "" || User_Id.Text == "")
            {
                MessageBox.Show("Brakuje informacji");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update ProjectTbl set ProjectName='" + ProjectName.Text + "',LaunchProject='" + LaunchName.Text + "',EndProject='" + EndProject.Text + "',Status='" + Status.SelectedItem.ToString() + "',DescProject='" + DescProject.Text + "',User_Id='" + User_Id.Text.ToString() + "'where Project_Id='" + Project_Id.Text.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pomyślnie zaktualizowano dane projektu!");
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
