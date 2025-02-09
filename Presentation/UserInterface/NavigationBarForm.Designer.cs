namespace Task_Management_System.Presentation.UserInterface
{
    partial class NavigationBarForm
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
            panel1 = new Panel();
            MainPanel = new Panel();
            panel2 = new Panel();
            UserLbl = new Label();
            panel4 = new Panel();
            LogoutBtn = new Button();
            panel8 = new Panel();
            HomeBtn = new Button();
            panel6 = new Panel();
            CompletedBtn = new Button();
            panel7 = new Panel();
            TaskBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(MainPanel);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 1003);
            panel1.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 60);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1924, 943);
            MainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(UserLbl);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 60);
            panel2.TabIndex = 0;
            // 
            // UserLbl
            // 
            UserLbl.AutoSize = true;
            UserLbl.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserLbl.ForeColor = Color.White;
            UserLbl.Location = new Point(34, 19);
            UserLbl.Name = "UserLbl";
            UserLbl.Size = new Size(55, 25);
            UserLbl.TabIndex = 7;
            UserLbl.Text = "User";
            // 
            // panel4
            // 
            panel4.Controls.Add(LogoutBtn);
            panel4.Location = new Point(1753, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(149, 60);
            panel4.TabIndex = 3;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.DarkSlateGray;
            LogoutBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Image = Properties.Resources.icons8_logout_23;
            LogoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.Location = new Point(-4, -17);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(186, 88);
            LogoutBtn.TabIndex = 1;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(HomeBtn);
            panel8.Location = new Point(1235, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(149, 60);
            panel8.TabIndex = 4;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.DarkSlateGray;
            HomeBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HomeBtn.ForeColor = Color.White;
            HomeBtn.Image = Properties.Resources.icons8_home_23;
            HomeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            HomeBtn.Location = new Point(-4, -17);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(186, 88);
            HomeBtn.TabIndex = 1;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(CompletedBtn);
            panel6.Location = new Point(1580, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(149, 60);
            panel6.TabIndex = 2;
            // 
            // CompletedBtn
            // 
            CompletedBtn.BackColor = Color.DarkSlateGray;
            CompletedBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CompletedBtn.ForeColor = Color.White;
            CompletedBtn.Image = Properties.Resources.icons8_pass_23;
            CompletedBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CompletedBtn.Location = new Point(-4, -17);
            CompletedBtn.Name = "CompletedBtn";
            CompletedBtn.Size = new Size(186, 88);
            CompletedBtn.TabIndex = 1;
            CompletedBtn.Text = "Completed";
            CompletedBtn.UseVisualStyleBackColor = false;
            CompletedBtn.Click += CompletedBtn_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(TaskBtn);
            panel7.Location = new Point(1408, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(149, 60);
            panel7.TabIndex = 3;
            // 
            // TaskBtn
            // 
            TaskBtn.BackColor = Color.DarkSlateGray;
            TaskBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TaskBtn.ForeColor = Color.White;
            TaskBtn.Image = Properties.Resources.icons8_task_23;
            TaskBtn.ImageAlign = ContentAlignment.MiddleLeft;
            TaskBtn.Location = new Point(-4, -17);
            TaskBtn.Name = "TaskBtn";
            TaskBtn.Size = new Size(186, 88);
            TaskBtn.TabIndex = 1;
            TaskBtn.Text = "Task";
            TaskBtn.UseVisualStyleBackColor = false;
            TaskBtn.Click += TaskBtn_Click;
            // 
            // NavigationBarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1003);
            Controls.Add(panel1);
            Name = "NavigationBarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += NavigationBarForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel8;
        private Button HomeBtn;
        private Panel panel7;
        private Button TaskBtn;
        private Panel panel6;
        private Button CompletedBtn;
        private Panel panel4;
        private Button LogoutBtn;
        private Panel MainPanel;
        private Label UserLbl;
    }
}