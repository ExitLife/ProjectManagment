namespace ProjectManagment
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            Uid = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Pass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(55, 9);
            label1.Name = "label1";
            label1.Size = new Size(366, 32);
            label1.TabIndex = 1;
            label1.Text = "PROJECT MANAGMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(136, 103);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // Uid
            // 
            Uid.Location = new Point(223, 101);
            Uid.Name = "Uid";
            Uid.Size = new Size(93, 23);
            Uid.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 192, 0);
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(198, 62);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 4;
            label3.Text = "Log In";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(141, 150);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // Pass
            // 
            Pass.Location = new Point(223, 148);
            Pass.Name = "Pass";
            Pass.Size = new Size(93, 23);
            Pass.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(143, 185);
            button1.Name = "button1";
            button1.Size = new Size(75, 45);
            button1.TabIndex = 7;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(241, 185);
            button2.Name = "button2";
            button2.Size = new Size(75, 45);
            button2.TabIndex = 8;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(454, 9);
            label7.Name = "label7";
            label7.Size = new Size(34, 40);
            label7.TabIndex = 9;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(500, 250);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Pass);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Uid);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Uid;
        private Label label3;
        private Label label4;
        private TextBox Pass;
        private Button button1;
        private Button button2;
        private Label label7;
    }
}