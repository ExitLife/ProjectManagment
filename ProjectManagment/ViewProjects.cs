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
    public partial class ViewProjects : Form
    {
        public ViewProjects()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\theas\OneDrive\Dokumenty\EmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void fetchprojectdata()
        {
            Con.Open();
            string query = "select * from ProjectTbl where Project_Id='" + Project_Id.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                projectidlbl.Text = dr["Project_Id"].ToString();
                namelbl.Text = dr["ProjectName"].ToString();
                launchlbl.Text = dr["LaunchProject"].ToString();
                endlbl.Text = dr["EndProject"].ToString();
                statuslbl.Text = dr["Status"].ToString();
                desclbl.Text = dr["DescProject"].ToString();
                addemplbl.Text = dr["User_id"].ToString();

            }
            Con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fetchprojectdata();
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
            e.Graphics.DrawString(" PROJECT SUMMARY ", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString(" ProjectID: " + projectidlbl.Text + "\tProject name: " + namelbl.Text + "", new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 250));
            e.Graphics.DrawString(" Launch date: " + launchlbl.Text + "", new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 300));
            e.Graphics.DrawString(" End date: " + endlbl.Text + "", new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 350));
            e.Graphics.DrawString(" Status: " + statuslbl.Text + "\tUser: " + addemplbl.Text + "", new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 400));
            e.Graphics.DrawString(" Project description: " + desclbl.Text + "", new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 450));
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
