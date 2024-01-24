namespace ProjectManagment
{
    partial class ViewMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMenu));
            panel1 = new Panel();
            label5 = new Label();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 216);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(286, 122);
            label5.Name = "label5";
            label5.Size = new Size(74, 32);
            label5.TabIndex = 13;
            label5.Text = "Tasks";
            label5.Click += label5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(289, 52);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(69, 67);
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(283, 182);
            label4.Name = "label4";
            label4.Size = new Size(82, 32);
            label4.TabIndex = 4;
            label4.Text = "Home";
            label4.Click += label4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(484, 58);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 61);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(84, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 61);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(414, 122);
            label3.Name = "label3";
            label3.Size = new Size(213, 32);
            label3.TabIndex = 1;
            label3.Text = "List of employees";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 122);
            label2.Name = "label2";
            label2.Size = new Size(183, 32);
            label2.TabIndex = 0;
            label2.Text = "List of projects";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 68);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(84, 28);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 2;
            label1.Text = "ViewMenu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(626, 12);
            label7.Name = "label7";
            label7.Size = new Size(34, 40);
            label7.TabIndex = 4;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // ViewMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(672, 327);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label7;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label4;
        private PictureBox pictureBox6;
        private Label label5;
    }
}