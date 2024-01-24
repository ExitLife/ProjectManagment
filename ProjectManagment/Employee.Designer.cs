namespace ProjectManagment
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            label1 = new Label();
            panel1 = new Panel();
            EmpDGV = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Role = new ComboBox();
            Email = new TextBox();
            Lastname = new TextBox();
            Firstname = new TextBox();
            User_id = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, 29);
            label1.Name = "label1";
            label1.Size = new Size(272, 40);
            label1.TabIndex = 0;
            label1.Text = "Manage employee";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(EmpDGV);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Role);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(Lastname);
            panel1.Controls.Add(Firstname);
            panel1.Controls.Add(User_id);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 536);
            panel1.TabIndex = 1;
            // 
            // EmpDGV
            // 
            EmpDGV.BackgroundColor = Color.WhiteSmoke;
            EmpDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmpDGV.Location = new Point(538, 12);
            EmpDGV.Name = "EmpDGV";
            EmpDGV.RowTemplate.Height = 25;
            EmpDGV.Size = new Size(541, 501);
            EmpDGV.TabIndex = 21;
            EmpDGV.CellContentClick += EmpDGV_CellContentClick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(139, 465);
            button4.Name = "button4";
            button4.Size = new Size(83, 48);
            button4.TabIndex = 20;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 465);
            button3.Name = "button3";
            button3.Size = new Size(83, 48);
            button3.TabIndex = 19;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(139, 411);
            button2.Name = "button2";
            button2.Size = new Size(83, 48);
            button2.TabIndex = 18;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 411);
            button1.Name = "button1";
            button1.Size = new Size(83, 48);
            button1.TabIndex = 17;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Role
            // 
            Role.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Role.FormattingEnabled = true;
            Role.Items.AddRange(new object[] { "Analyst", "Designer", "Administrator", "Tester", "Project Manager", "Developer" });
            Role.Location = new Point(12, 364);
            Role.Name = "Role";
            Role.Size = new Size(210, 33);
            Role.TabIndex = 16;
            // 
            // Email
            // 
            Email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Email.Location = new Point(12, 268);
            Email.Name = "Email";
            Email.Size = new Size(210, 33);
            Email.TabIndex = 15;
            // 
            // Lastname
            // 
            Lastname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Lastname.Location = new Point(196, 164);
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(131, 33);
            Lastname.TabIndex = 14;
            // 
            // Firstname
            // 
            Firstname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Firstname.Location = new Point(12, 164);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(131, 33);
            Firstname.TabIndex = 13;
            // 
            // User_id
            // 
            User_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            User_id.Location = new Point(12, 56);
            User_id.Name = "User_id";
            User_id.Size = new Size(131, 29);
            User_id.TabIndex = 12;
            User_id.TextChanged += User_id_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 315);
            label6.Name = "label6";
            label6.Size = new Size(61, 32);
            label6.TabIndex = 11;
            label6.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(72, 32);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(196, 108);
            label4.Name = "label4";
            label4.Size = new Size(119, 32);
            label4.TabIndex = 9;
            label4.Text = "Lastname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 8;
            label3.Text = "Firstname";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 7;
            label2.Text = "User ID";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 74);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1234, 12);
            label7.Name = "label7";
            label7.Size = new Size(34, 40);
            label7.TabIndex = 3;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(1280, 720);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox Role;
        private TextBox Email;
        private TextBox Lastname;
        private TextBox Firstname;
        private TextBox User_id;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView EmpDGV;
        private Label label7;
    }
}