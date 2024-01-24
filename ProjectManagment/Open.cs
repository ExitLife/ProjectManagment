namespace ProjectManagment
{
    public partial class Open : Form
    {
        public Open()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogress.Value = startpoint;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                this.Hide();
                Login log = new Login();
                log.Show();
            }
        }

        private void Open_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}