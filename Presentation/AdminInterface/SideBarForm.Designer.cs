namespace Task_Management_System.Presentation
{
    partial class SideBarForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            MainPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            DashboardBtn = new Button();
            panel5 = new Panel();
            CreateTaskBtn = new Button();
            SettingsContainer = new FlowLayoutPanel();
            panel6 = new Panel();
            SettingsBtn = new Button();
            panel7 = new Panel();
            CreateUserBtn = new Button();
            panel8 = new Panel();
            CreateAdminBtn = new Button();
            panel3 = new Panel();
            LogoutBtn = new Button();
            panel2 = new Panel();
            AdminLbl = new Label();
            label1 = new Label();
            SettingsTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SettingsContainer.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(MainPanel);
            panel1.Controls.Add(flowLayoutPanel1);
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
            MainPanel.Location = new Point(298, 50);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1626, 953);
            MainPanel.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(SettingsContainer);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(298, 953);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_people_100__1_;
            pictureBox1.Location = new Point(110, 50);
            pictureBox1.Margin = new Padding(110, 50, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(DashboardBtn);
            panel4.Location = new Point(1, 169);
            panel4.Margin = new Padding(1, 15, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(291, 67);
            panel4.TabIndex = 0;
            // 
            // DashboardBtn
            // 
            DashboardBtn.BackColor = Color.WhiteSmoke;
            DashboardBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DashboardBtn.ForeColor = Color.DarkSlateGray;
            DashboardBtn.Image = Properties.Resources.icons8_dashboard_layout_25;
            DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.Location = new Point(-3, -19);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(351, 103);
            DashboardBtn.TabIndex = 1;
            DashboardBtn.Text = " Dashboard";
            DashboardBtn.UseVisualStyleBackColor = false;
            DashboardBtn.Click += DashboardBtn_Click;
            DashboardBtn.MouseLeave += DashboardBtn_MouseLeave;
            DashboardBtn.MouseMove += DashboardBtn_MouseMove;
            // 
            // panel5
            // 
            panel5.Controls.Add(CreateTaskBtn);
            panel5.Location = new Point(1, 255);
            panel5.Margin = new Padding(1, 15, 4, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(291, 67);
            panel5.TabIndex = 1;
            // 
            // CreateTaskBtn
            // 
            CreateTaskBtn.BackColor = Color.WhiteSmoke;
            CreateTaskBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTaskBtn.ForeColor = Color.DarkSlateGray;
            CreateTaskBtn.Image = Properties.Resources.icons8_add_to_clipboard_25;
            CreateTaskBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CreateTaskBtn.Location = new Point(-4, -18);
            CreateTaskBtn.Name = "CreateTaskBtn";
            CreateTaskBtn.Size = new Size(351, 103);
            CreateTaskBtn.TabIndex = 1;
            CreateTaskBtn.Text = "Create Task";
            CreateTaskBtn.UseVisualStyleBackColor = false;
            CreateTaskBtn.Click += CreateTaskBtn_Click;
            CreateTaskBtn.MouseLeave += CreateTaskBtn_MouseLeave;
            CreateTaskBtn.MouseMove += CreateTaskBtn_MouseMove;
            // 
            // SettingsContainer
            // 
            SettingsContainer.BackColor = Color.Gainsboro;
            SettingsContainer.Controls.Add(panel6);
            SettingsContainer.Controls.Add(panel7);
            SettingsContainer.Controls.Add(panel8);
            SettingsContainer.Location = new Point(1, 341);
            SettingsContainer.Margin = new Padding(1, 15, 4, 4);
            SettingsContainer.Name = "SettingsContainer";
            SettingsContainer.Size = new Size(291, 63);
            SettingsContainer.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Controls.Add(SettingsBtn);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(291, 67);
            panel6.TabIndex = 2;
            // 
            // SettingsBtn
            // 
            SettingsBtn.BackColor = Color.WhiteSmoke;
            SettingsBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SettingsBtn.ForeColor = Color.DarkSlateGray;
            SettingsBtn.Image = Properties.Resources.icons8_settings_25__1_;
            SettingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SettingsBtn.Location = new Point(-2, -22);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(351, 103);
            SettingsBtn.TabIndex = 1;
            SettingsBtn.Text = "Settings";
            SettingsBtn.UseVisualStyleBackColor = false;
            SettingsBtn.Click += SettingsBtn_Click;
            SettingsBtn.MouseLeave += SettingsBtn_MouseLeave;
            SettingsBtn.MouseMove += SettingsBtn_MouseMove;
            // 
            // panel7
            // 
            panel7.Controls.Add(CreateUserBtn);
            panel7.Location = new Point(0, 67);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(327, 67);
            panel7.TabIndex = 3;
            // 
            // CreateUserBtn
            // 
            CreateUserBtn.BackColor = Color.LightSeaGreen;
            CreateUserBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateUserBtn.ForeColor = Color.White;
            CreateUserBtn.Image = Properties.Resources.icons8_dot_23;
            CreateUserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CreateUserBtn.Location = new Point(-5, -11);
            CreateUserBtn.Name = "CreateUserBtn";
            CreateUserBtn.Size = new Size(383, 90);
            CreateUserBtn.TabIndex = 1;
            CreateUserBtn.Text = "Create User";
            CreateUserBtn.UseVisualStyleBackColor = false;
            CreateUserBtn.Click += CreateUserBtn_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(CreateAdminBtn);
            panel8.Location = new Point(0, 134);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(327, 67);
            panel8.TabIndex = 4;
            // 
            // CreateAdminBtn
            // 
            CreateAdminBtn.BackColor = Color.LightSeaGreen;
            CreateAdminBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateAdminBtn.ForeColor = Color.WhiteSmoke;
            CreateAdminBtn.Image = Properties.Resources.icons8_dot_23;
            CreateAdminBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CreateAdminBtn.Location = new Point(-6, -11);
            CreateAdminBtn.Name = "CreateAdminBtn";
            CreateAdminBtn.Size = new Size(383, 90);
            CreateAdminBtn.TabIndex = 1;
            CreateAdminBtn.Text = "Create Admin";
            CreateAdminBtn.UseVisualStyleBackColor = false;
            CreateAdminBtn.Click += CreateAdminBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(LogoutBtn);
            panel3.Location = new Point(15, 758);
            panel3.Margin = new Padding(15, 350, 3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(130, 58);
            panel3.TabIndex = 5;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.WhiteSmoke;
            LogoutBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutBtn.ForeColor = Color.DarkSlateGray;
            LogoutBtn.Image = Properties.Resources.icons8_logout_23__1_;
            LogoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.Location = new Point(-3, -8);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(146, 74);
            LogoutBtn.TabIndex = 0;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(AdminLbl);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 50);
            panel2.TabIndex = 0;
            // 
            // AdminLbl
            // 
            AdminLbl.AutoSize = true;
            AdminLbl.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AdminLbl.ForeColor = Color.White;
            AdminLbl.Location = new Point(120, 13);
            AdminLbl.Name = "AdminLbl";
            AdminLbl.Size = new Size(75, 24);
            AdminLbl.TabIndex = 1;
            AdminLbl.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 0;
            label1.Text = "Welcome:";
            // 
            // SettingsTransition
            // 
            SettingsTransition.Tick += SettingsTransition_Tick;
            // 
            // SideBarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1003);
            Controls.Add(panel1);
            Name = "SideBarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SideBarForm_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            SettingsContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel MainPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label label1;
        private Panel panel6;
        private Button SettingsBtn;
        private FlowLayoutPanel SettingsContainer;
        private Panel panel5;
        private Button CreateTaskBtn;
        private Panel panel4;
        private Button DashboardBtn;
        private Panel panel7;
        private Button CreateUserBtn;
        private Panel panel8;
        private Button CreateAdminBtn;
        private System.Windows.Forms.Timer SettingsTransition;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button LogoutBtn;
        private Label AdminLbl;
    }
}