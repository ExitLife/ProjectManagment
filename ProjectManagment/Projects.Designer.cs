namespace ProjectManagment
{
    partial class Projects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projects));
            panel1 = new Panel();
            User_Id = new TextBox();
            label8 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            Add = new Button();
            Project_Id = new TextBox();
            label5 = new Label();
            Desc = new Label();
            DescProject = new RichTextBox();
            label6 = new Label();
            EndProject = new DateTimePicker();
            label4 = new Label();
            LaunchName = new DateTimePicker();
            label3 = new Label();
            ProjectName = new TextBox();
            Status = new ComboBox();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(User_Id);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Add);
            panel1.Controls.Add(Project_Id);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Desc);
            panel1.Controls.Add(DescProject);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(EndProject);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(LaunchName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ProjectName);
            panel1.Controls.Add(Status);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(1282, 536);
            panel1.TabIndex = 0;
            // 
            // User_Id
            // 
            User_Id.Location = new Point(306, 102);
            User_Id.Name = "User_Id";
            User_Id.Size = new Size(179, 23);
            User_Id.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(306, 47);
            label8.Name = "label8";
            label8.Size = new Size(179, 32);
            label8.TabIndex = 17;
            label8.Text = "Add employee";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(437, 379);
            button4.Name = "button4";
            button4.Size = new Size(83, 73);
            button4.TabIndex = 16;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(306, 379);
            button3.Name = "button3";
            button3.Size = new Size(83, 73);
            button3.TabIndex = 15;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(137, 379);
            button2.Name = "button2";
            button2.Size = new Size(83, 73);
            button2.TabIndex = 14;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Add
            // 
            Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Add.Location = new Point(12, 379);
            Add.Name = "Add";
            Add.Size = new Size(83, 73);
            Add.TabIndex = 13;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Project_Id
            // 
            Project_Id.Location = new Point(12, 102);
            Project_Id.Name = "Project_Id";
            Project_Id.Size = new Size(200, 23);
            Project_Id.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 47);
            label5.Name = "label5";
            label5.Size = new Size(128, 32);
            label5.TabIndex = 11;
            label5.Text = "Project ID";
            // 
            // Desc
            // 
            Desc.AutoSize = true;
            Desc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Desc.Location = new Point(700, 47);
            Desc.Name = "Desc";
            Desc.Size = new Size(231, 32);
            Desc.TabIndex = 10;
            Desc.Text = "Project description";
            // 
            // DescProject
            // 
            DescProject.BorderStyle = BorderStyle.FixedSingle;
            DescProject.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DescProject.Location = new Point(700, 102);
            DescProject.Name = "DescProject";
            DescProject.Size = new Size(388, 350);
            DescProject.TabIndex = 9;
            DescProject.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(306, 255);
            label6.Name = "label6";
            label6.Size = new Size(176, 32);
            label6.TabIndex = 8;
            label6.Text = "End of project";
            // 
            // EndProject
            // 
            EndProject.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EndProject.Location = new Point(306, 296);
            EndProject.Name = "EndProject";
            EndProject.Size = new Size(275, 29);
            EndProject.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(306, 139);
            label4.Name = "label4";
            label4.Size = new Size(214, 32);
            label4.TabIndex = 5;
            label4.Text = "Launch of project";
            // 
            // LaunchName
            // 
            LaunchName.CalendarFont = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LaunchName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LaunchName.Location = new Point(306, 197);
            LaunchName.Name = "LaunchName";
            LaunchName.Size = new Size(275, 29);
            LaunchName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 255);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 3;
            label3.Text = "Status";
            // 
            // ProjectName
            // 
            ProjectName.Location = new Point(12, 197);
            ProjectName.Name = "ProjectName";
            ProjectName.Size = new Size(200, 23);
            ProjectName.TabIndex = 2;
            // 
            // Status
            // 
            Status.FormattingEnabled = true;
            Status.Items.AddRange(new object[] { "In progress", "Done" });
            Status.Location = new Point(12, 299);
            Status.Name = "Status";
            Status.Size = new Size(200, 23);
            Status.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 0;
            label2.Text = "Project name";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(75, 64);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(93, 27);
            label1.Name = "label1";
            label1.Size = new Size(127, 40);
            label1.TabIndex = 9;
            label1.Text = "Projects";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1234, 12);
            label7.Name = "label7";
            label7.Size = new Size(34, 40);
            label7.TabIndex = 10;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // Projects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(1280, 720);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Projects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projects";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label7;
        private Label label2;
        private Label label3;
        private TextBox ProjectName;
        private ComboBox Status;
        private Label label4;
        private DateTimePicker LaunchName;
        private Label label6;
        private DateTimePicker EndProject;
        private Label Desc;
        private RichTextBox DescProject;
        private Label label5;
        private TextBox Project_Id;
        private Button button3;
        private Button button2;
        private Button Add;
        private Button button4;
        private TextBox User_Id;
        private Label label8;
    }
}