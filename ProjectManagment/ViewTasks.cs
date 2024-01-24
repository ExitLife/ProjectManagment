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

namespace ProjectManagment
{
    public partial class ViewTasks : Form
    {
        public ViewTasks()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\theas\OneDrive\Dokumenty\EmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void fetchtasksdata()
        {
            Con.Open();
            string query = "select * from TasksTbl where Task_Id='" + Task_Id.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                taskidlbl.Text = dr["Task_Id"].ToString();
                titlelbl.Text = dr["Title"].ToString();
                execlbl.Text = dr["ExecDate"].ToString();
                prioritylbl.Text = dr["Priority"].ToString();
                statuslbl.Text = dr["Status"].ToString();
                desclbl.Text = dr["Description"].ToString();
                useridlbl.Text = dr["User_id"].ToString();
                projectlbl.Text = dr["Project_Id"].ToString();

            }
            Con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            fetchtasksdata();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(" TASK SUMMARY ", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString(" TASK ID: " + taskidlbl.Text + "\tTask title: " + titlelbl.Text + "", new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 200));
            e.Graphics.DrawString(" Execution date: " + execlbl.Text + "", new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 250));
            e.Graphics.DrawString(" Priority: " + prioritylbl.Text + "\tStatus: " + statuslbl.Text + "", new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 300));
            e.Graphics.DrawString(" USER ID: " + useridlbl.Text + "\tPROJECT ID: " + projectlbl.Text + "", new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 350));
            e.Graphics.DrawString(" Description: " + desclbl.Text + "", new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(10, 400));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
