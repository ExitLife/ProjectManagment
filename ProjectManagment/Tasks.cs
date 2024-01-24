using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectManagment
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\theas\OneDrive\Dokumenty\EmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Task_Id.Text == "" || Title.Text == "" || ExecDate.Text == "" || Priority.Text == "" || Status.Text == "" || Description.Text == "" || User_Id.Text == "" || Project_Id.Text == "")
            {
                MessageBox.Show("Brakuje informacji");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into TasksTbl values('" + Task_Id.Text.ToString() + "','" + Title.Text + "','" + ExecDate.Text + "','" + Priority.Text + "','" + Status.Text + "','" + Description.Text + "','" + User_Id.Text.ToString() + "','" + Project_Id.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Zadanie zostało dodane pomyślnie!");
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
            if (Task_Id.Text == "")
            {
                MessageBox.Show("Wprowadź ID zadania!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from TasksTbl where Task_Id ='" + Task_Id.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pomyślnie usunięto zadanie!");
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
            if (Task_Id.Text == "" || Title.Text == "" || ExecDate.Text == "" || Priority.Text == "" || Status.Text == "" || Description.Text == "" || User_Id.Text == "" || Project_Id.Text == "")
            {
                MessageBox.Show("Brakuje informacji");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update TasksTbl set Title='" + Title.Text + "',ExecDate='" + ExecDate.Text + "',Priority='" + Priority.SelectedItem.ToString() + "',Status='" + Status.SelectedItem.ToString() + "',Description='"+Description.Text+"',User_ID='"+User_Id.Text+"',Project_Id='"+Project_Id.Text+"'where Task_Id='" + Task_Id.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pomyślnie zaktualizowano dane zadania!");
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
