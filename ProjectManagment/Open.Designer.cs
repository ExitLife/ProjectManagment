namespace ProjectManagment
{
    partial class Open
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Title = new Label();
            Credits = new Label();
            Myprogress = new ProgressBar();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(104, 9);
            Title.Name = "Title";
            Title.Size = new Size(359, 32);
            Title.TabIndex = 0;
            Title.Text = "PROJECT MANAGMENT SYSTEM";
            Title.Click += label1_Click;
            // 
            // Credits
            // 
            Credits.AutoSize = true;
            Credits.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Credits.Location = new Point(143, 232);
            Credits.Name = "Credits";
            Credits.Size = new Size(266, 20);
            Credits.TabIndex = 1;
            Credits.Text = "Projekt OOP Radosław Szubart w67199";
            Credits.Click += label2_Click;
            // 
            // Myprogress
            // 
            Myprogress.Location = new Point(104, 140);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(359, 26);
            Myprogress.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(238, 116);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 3;
            label3.Text = "Loading.";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Open
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(584, 261);
            Controls.Add(label3);
            Controls.Add(Myprogress);
            Controls.Add(Credits);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Open";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Open_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Credits;
        private ProgressBar Myprogress;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}