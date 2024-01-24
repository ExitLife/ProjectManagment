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

namespace ProjectManagment
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\theas\OneDrive\Dokumenty\EmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (User_id.Text == "" || Firstname.Text == "" || Lastname.Text == "" || Email.Text == "" || Role.Text == "")
            {
                MessageBox.Show("Brakuje informacji");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserTbl values('" + User_id.Text.ToString() + "','" + Firstname.Text + "','" + Lastname.Text + "','" + Email.Text + "','" + Role.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Użytkownik został dodany pomyślnie!");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from userTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (User_id.Text == "")
            {
                MessageBox.Show("Wprowadź ID użytkownika!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UserTbl where User_Id ='" + User_id.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pomyślnie usunięto użytkownika!");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EmpDGV.SelectedRows.Count > 0 && EmpDGV.SelectedRows[0].Cells.Count >= 5)
            {
                User_id.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
                Firstname.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
                Lastname.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
                Email.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
                Role.Text = EmpDGV.SelectedRows[0].Cells[4].Value.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (User_id.Text == "" || Firstname.Text == "" || Lastname.Text == "" || Email.Text == "" || Role.Text == "")
            {
                MessageBox.Show("Brakuje informacji");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update UserTbl set Firstname='" + Firstname.Text + "',Lastname='" + Lastname.Text + "',Email='" + Email.Text + "',Role='" + Role.SelectedItem.ToString() + "'where User_Id='" + User_id.Text.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pomyślnie zaktualizowano dane użytkownika!");
                    Con.Close();
                    populate();
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

        private void User_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
