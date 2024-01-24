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
using System.Drawing.Printing;

namespace ProjectManagment
{
    public partial class ViewEmployees : Form
    {
        public ViewEmployees()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\theas\OneDrive\Dokumenty\EmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void fetchuserdata()
        {
            Con.Open();
            string query = "select * from UserTbl where User_Id='" + User_id.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Useridlbl.Text = dr["User_id"].ToString();
                Firstnamelbl.Text = dr["Firstname"].ToString();
                Lastnamelbl.Text = dr["Lastname"].ToString();
                Emaillbl.Text = dr["Email"].ToString();
                Rolelbl.Text = dr["Role"].ToString();
            }
            Con.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fetchuserdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(" USER SUMMARY ", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString(" UserID: "+ Useridlbl.Text +"\tFirstname: "+ Firstnamelbl.Text +"", new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10,250));
            e.Graphics.DrawString(" Email: " + Emaillbl.Text + "\tLastname: " + Lastnamelbl.Text + "", new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 300));
            e.Graphics.DrawString(" Role: "+ Rolelbl.Text +"", new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10,350));
        }
    }
}
