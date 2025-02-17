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
            panel7 = new Panel();
            LogoutBtn = new Button();
            panel3 = new Panel();
            HomeBtn = new Button();
            panel6 = new Panel();
            ProfileBtn = new Button();
            panel4 = new Panel();
            TasksBtn = new Button();
            panel5 = new Panel();
            CompletedBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            MainPanel.Location = new Point(0, 61);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1924, 942);
            MainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(UserLbl);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 61);
            panel2.TabIndex = 0;
            // 
            // UserLbl
            // 
            UserLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserLbl.ForeColor = Color.White;
            UserLbl.Location = new Point(38, 16);
            UserLbl.Name = "UserLbl";
            UserLbl.Size = new Size(297, 31);
            UserLbl.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Controls.Add(LogoutBtn);
            panel7.Location = new Point(1773, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(127, 61);
            panel7.TabIndex = 4;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.DarkSlateGray;
            LogoutBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Location = new Point(-28, -17);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(187, 95);
            LogoutBtn.TabIndex = 1;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            LogoutBtn.MouseLeave += LogoutBtn_MouseLeave_1;
            LogoutBtn.MouseMove += LogoutBtn_MouseMove;
            // 
            // panel3
            // 
            panel3.Controls.Add(HomeBtn);
            panel3.Location = new Point(1230, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(127, 61);
            panel3.TabIndex = 0;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.DarkSlateGray;
            HomeBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HomeBtn.ForeColor = Color.White;
            HomeBtn.Location = new Point(-28, -17);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(187, 95);
            HomeBtn.TabIndex = 1;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            HomeBtn.MouseLeave += HomeBtn_MouseLeave;
            HomeBtn.MouseMove += HomeBtn_MouseMove;
            // 
            // panel6
            // 
            panel6.Controls.Add(ProfileBtn);
            panel6.Location = new Point(1638, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(127, 61);
            panel6.TabIndex = 3;
            // 
            // ProfileBtn
            // 
            ProfileBtn.BackColor = Color.DarkSlateGray;
            ProfileBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProfileBtn.ForeColor = Color.White;
            ProfileBtn.Location = new Point(-28, -17);
            ProfileBtn.Name = "ProfileBtn";
            ProfileBtn.Size = new Size(187, 95);
            ProfileBtn.TabIndex = 1;
            ProfileBtn.Text = "Profile";
            ProfileBtn.UseVisualStyleBackColor = false;
            ProfileBtn.Click += ProfileBtn_Click;
            ProfileBtn.MouseLeave += ProfileBtn_MouseLeave;
            ProfileBtn.MouseMove += ProfileBtn_MouseMove;
            // 
            // panel4
            // 
            panel4.Controls.Add(TasksBtn);
            panel4.Location = new Point(1366, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(127, 61);
            panel4.TabIndex = 1;
            // 
            // TasksBtn
            // 
            TasksBtn.BackColor = Color.DarkSlateGray;
            TasksBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TasksBtn.ForeColor = Color.White;
            TasksBtn.Location = new Point(-28, -17);
            TasksBtn.Name = "TasksBtn";
            TasksBtn.Size = new Size(187, 95);
            TasksBtn.TabIndex = 1;
            TasksBtn.Text = "Tasks";
            TasksBtn.UseVisualStyleBackColor = false;
            TasksBtn.Click += TasksBtn_Click;
            TasksBtn.MouseLeave += TasksBtn_MouseLeave;
            TasksBtn.MouseMove += TasksBtn_MouseMove;
            // 
            // panel5
            // 
            panel5.Controls.Add(CompletedBtn);
            panel5.Location = new Point(1502, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(127, 61);
            panel5.TabIndex = 2;
            // 
            // CompletedBtn
            // 
            CompletedBtn.BackColor = Color.DarkSlateGray;
            CompletedBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CompletedBtn.ForeColor = Color.White;
            CompletedBtn.Location = new Point(-28, -17);
            CompletedBtn.Name = "CompletedBtn";
            CompletedBtn.Size = new Size(187, 95);
            CompletedBtn.TabIndex = 1;
            CompletedBtn.Text = "Completed";
            CompletedBtn.UseVisualStyleBackColor = false;
            CompletedBtn.Click += CompletedBtn_Click;
            CompletedBtn.MouseLeave += CompletedBtn_MouseLeave;
            CompletedBtn.MouseMove += CompletedBtn_MouseMove;
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
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel MainPanel;
        private Panel panel6;
        private Button ProfileBtn;
        private Panel panel5;
        private Button CompletedBtn;
        private Panel panel4;
        private Button TasksBtn;
        private Panel panel3;
        private Button HomeBtn;
        private Panel panel2;
        private Panel panel7;
        private Button LogoutBtn;
        private Label UserLbl;
    }
}