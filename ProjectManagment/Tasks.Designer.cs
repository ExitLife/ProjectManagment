namespace ProjectManagment
{
    partial class Tasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            panel1 = new Panel();
            Task_Id = new TextBox();
            label10 = new Label();
            Project_Id = new TextBox();
            label9 = new Label();
            User_Id = new TextBox();
            label8 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Status = new ComboBox();
            Priority = new ComboBox();
            ExecDate = new DateTimePicker();
            Title = new TextBox();
            Description = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(Task_Id);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(Project_Id);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(User_Id);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Status);
            panel1.Controls.Add(Priority);
            panel1.Controls.Add(ExecDate);
            panel1.Controls.Add(Title);
            panel1.Controls.Add(Description);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 536);
            panel1.TabIndex = 0;
            // 
            // Task_Id
            // 
            Task_Id.Location = new Point(12, 80);
            Task_Id.Name = "Task_Id";
            Task_Id.Size = new Size(194, 23);
            Task_Id.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 17);
            label10.Name = "label10";
            label10.Size = new Size(96, 32);
            label10.TabIndex = 18;
            label10.Text = "Task ID";
            // 
            // Project_Id
            // 
            Project_Id.Location = new Point(392, 194);
            Project_Id.Name = "Project_Id";
            Project_Id.Size = new Size(179, 23);
            Project_Id.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(392, 131);
            label9.Name = "label9";
            label9.Size = new Size(149, 32);
            label9.TabIndex = 16;
            label9.Text = "Add project";
            // 
            // User_Id
            // 
            User_Id.Location = new Point(392, 80);
            User_Id.Name = "User_Id";
            User_Id.Size = new Size(179, 23);
            User_Id.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(392, 17);
            label8.Name = "label8";
            label8.Size = new Size(179, 32);
            label8.TabIndex = 14;
            label8.Text = "Add employee";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(494, 444);
            button4.Name = "button4";
            button4.Size = new Size(77, 60);
            button4.TabIndex = 13;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(392, 444);
            button3.Name = "button3";
            button3.Size = new Size(77, 60);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(494, 341);
            button2.Name = "button2";
            button2.Size = new Size(77, 60);
            button2.TabIndex = 11;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(392, 341);
            button1.Name = "button1";
            button1.Size = new Size(77, 60);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Status
            // 
            Status.FormattingEnabled = true;
            Status.Items.AddRange(new object[] { "To Do", "In Progress", "Done" });
            Status.Location = new Point(12, 481);
            Status.Name = "Status";
            Status.Size = new Size(183, 23);
            Status.TabIndex = 9;
            // 
            // Priority
            // 
            Priority.FormattingEnabled = true;
            Priority.Items.AddRange(new object[] { "High", "Medium", "Low" });
            Priority.Location = new Point(12, 378);
            Priority.Name = "Priority";
            Priority.Size = new Size(183, 23);
            Priority.TabIndex = 8;
            // 
            // ExecDate
            // 
            ExecDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExecDate.Location = new Point(12, 287);
            ExecDate.Name = "ExecDate";
            ExecDate.Size = new Size(298, 29);
            ExecDate.TabIndex = 7;
            // 
            // Title
            // 
            Title.Location = new Point(12, 194);
            Title.Name = "Title";
            Title.Size = new Size(194, 23);
            Title.TabIndex = 6;
            // 
            // Description
            // 
            Description.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Description.Location = new Point(705, 80);
            Description.Name = "Description";
            Description.Size = new Size(520, 424);
            Description.TabIndex = 5;
            Description.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(705, 17);
            label6.Name = "label6";
            label6.Size = new Size(146, 32);
            label6.TabIndex = 4;
            label6.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 429);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 3;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 331);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 2;
            label4.Text = "Priority";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 237);
            label3.Name = "label3";
            label3.Size = new Size(183, 32);
            label3.TabIndex = 1;
            label3.Text = "Execution date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 0;
            label2.Text = "Task title";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 66);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(82, 29);
            label1.Name = "label1";
            label1.Size = new Size(74, 32);
            label1.TabIndex = 2;
            label1.Text = "Tasks";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1234, 9);
            label7.Name = "label7";
            label7.Size = new Size(34, 40);
            label7.TabIndex = 5;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 182, 0);
            ClientSize = new Size(1280, 720);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tasks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tasks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label7;
        private ComboBox Status;
        private ComboBox Priority;
        private DateTimePicker ExecDate;
        private TextBox Title;
        private RichTextBox Description;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox Project_Id;
        private Label label9;
        private TextBox User_Id;
        private Label label8;
        private TextBox Task_Id;
        private Label label10;
    }
}