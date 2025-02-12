namespace Task_Management_System.Presentation.UserInterface
{
    partial class ProfileForm
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
            panel2 = new Panel();
            ShowCurrentPasswordBtn = new Label();
            HideCurrentPasswordBtn = new Label();
            ShowPasswordBtn = new Label();
            HidePasswordBtn = new Label();
            UpdateBtn = new Button();
            BrowseBtn = new Button();
            panel3 = new Panel();
            label7 = new Label();
            ProfilePicBox = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            NewPasswordTxt = new TextBox();
            CurrentPasswordTxt = new TextBox();
            EmailTxt = new TextBox();
            LastNameTxt = new TextBox();
            MiddleNameTxt = new TextBox();
            FirstNameTxt = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePicBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1906, 896);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ShowCurrentPasswordBtn);
            panel2.Controls.Add(HideCurrentPasswordBtn);
            panel2.Controls.Add(ShowPasswordBtn);
            panel2.Controls.Add(HidePasswordBtn);
            panel2.Controls.Add(UpdateBtn);
            panel2.Controls.Add(BrowseBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(ProfilePicBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(NewPasswordTxt);
            panel2.Controls.Add(CurrentPasswordTxt);
            panel2.Controls.Add(EmailTxt);
            panel2.Controls.Add(LastNameTxt);
            panel2.Controls.Add(MiddleNameTxt);
            panel2.Controls.Add(FirstNameTxt);
            panel2.Location = new Point(216, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(1495, 625);
            panel2.TabIndex = 0;
            // 
            // ShowCurrentPasswordBtn
            // 
            ShowCurrentPasswordBtn.BackColor = Color.White;
            ShowCurrentPasswordBtn.FlatStyle = FlatStyle.Flat;
            ShowCurrentPasswordBtn.Image = Properties.Resources.icons8_eye_30;
            ShowCurrentPasswordBtn.Location = new Point(1088, 258);
            ShowCurrentPasswordBtn.Name = "ShowCurrentPasswordBtn";
            ShowCurrentPasswordBtn.Size = new Size(30, 30);
            ShowCurrentPasswordBtn.TabIndex = 24;
            ShowCurrentPasswordBtn.Click += ShowCurrentPasswordBtn_Click;
            // 
            // HideCurrentPasswordBtn
            // 
            HideCurrentPasswordBtn.BackColor = Color.White;
            HideCurrentPasswordBtn.FlatStyle = FlatStyle.Flat;
            HideCurrentPasswordBtn.Image = Properties.Resources.icons8_hide_30;
            HideCurrentPasswordBtn.Location = new Point(1088, 258);
            HideCurrentPasswordBtn.Name = "HideCurrentPasswordBtn";
            HideCurrentPasswordBtn.Size = new Size(30, 30);
            HideCurrentPasswordBtn.TabIndex = 23;
            HideCurrentPasswordBtn.Click += HideCurrentPasswordBtn_Click;
            // 
            // ShowPasswordBtn
            // 
            ShowPasswordBtn.BackColor = Color.White;
            ShowPasswordBtn.FlatStyle = FlatStyle.Flat;
            ShowPasswordBtn.Image = Properties.Resources.icons8_eye_30;
            ShowPasswordBtn.Location = new Point(1088, 371);
            ShowPasswordBtn.Name = "ShowPasswordBtn";
            ShowPasswordBtn.Size = new Size(30, 30);
            ShowPasswordBtn.TabIndex = 22;
            ShowPasswordBtn.Click += ShowPasswordBtn_Click;
            // 
            // HidePasswordBtn
            // 
            HidePasswordBtn.BackColor = Color.White;
            HidePasswordBtn.FlatStyle = FlatStyle.Flat;
            HidePasswordBtn.Image = Properties.Resources.icons8_hide_30;
            HidePasswordBtn.Location = new Point(1088, 371);
            HidePasswordBtn.Name = "HidePasswordBtn";
            HidePasswordBtn.Size = new Size(30, 30);
            HidePasswordBtn.TabIndex = 21;
            HidePasswordBtn.Click += HidePasswordBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(0, 151, 178);
            UpdateBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBtn.Location = new Point(1202, 410);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(226, 53);
            UpdateBtn.TabIndex = 15;
            UpdateBtn.Text = "Save Changes";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // BrowseBtn
            // 
            BrowseBtn.BackColor = Color.LightSeaGreen;
            BrowseBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BrowseBtn.Location = new Point(1202, 334);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new Size(226, 53);
            BrowseBtn.TabIndex = 14;
            BrowseBtn.Text = "Browse";
            BrowseBtn.UseVisualStyleBackColor = false;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1493, 47);
            panel3.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 7);
            label7.Name = "label7";
            label7.Size = new Size(134, 31);
            label7.TabIndex = 7;
            label7.Text = "Edit Profile";
            // 
            // ProfilePicBox
            // 
            ProfilePicBox.BorderStyle = BorderStyle.FixedSingle;
            ProfilePicBox.Location = new Point(1192, 66);
            ProfilePicBox.Name = "ProfilePicBox";
            ProfilePicBox.Size = new Size(255, 247);
            ProfilePicBox.TabIndex = 12;
            ProfilePicBox.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(668, 313);
            label6.Name = "label6";
            label6.Size = new Size(174, 31);
            label6.TabIndex = 11;
            label6.Text = "New Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(668, 207);
            label5.Name = "label5";
            label5.Size = new Size(207, 31);
            label5.TabIndex = 10;
            label5.Text = "Current Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(668, 101);
            label4.Name = "label4";
            label4.Size = new Size(79, 31);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(105, 313);
            label3.Name = "label3";
            label3.Size = new Size(132, 31);
            label3.TabIndex = 8;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(105, 207);
            label2.Name = "label2";
            label2.Size = new Size(165, 31);
            label2.TabIndex = 7;
            label2.Text = "Middle Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 101);
            label1.Name = "label1";
            label1.Size = new Size(136, 31);
            label1.TabIndex = 6;
            label1.Text = "First Name:";
            // 
            // NewPasswordTxt
            // 
            NewPasswordTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            NewPasswordTxt.Location = new Point(668, 366);
            NewPasswordTxt.Name = "NewPasswordTxt";
            NewPasswordTxt.PasswordChar = '*';
            NewPasswordTxt.Size = new Size(458, 38);
            NewPasswordTxt.TabIndex = 5;
            // 
            // CurrentPasswordTxt
            // 
            CurrentPasswordTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentPasswordTxt.Location = new Point(668, 256);
            CurrentPasswordTxt.Name = "CurrentPasswordTxt";
            CurrentPasswordTxt.PasswordChar = '*';
            CurrentPasswordTxt.Size = new Size(458, 38);
            CurrentPasswordTxt.TabIndex = 4;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxt.Location = new Point(668, 145);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(458, 38);
            EmailTxt.TabIndex = 3;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(105, 366);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(458, 38);
            LastNameTxt.TabIndex = 2;
            // 
            // MiddleNameTxt
            // 
            MiddleNameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MiddleNameTxt.Location = new Point(105, 256);
            MiddleNameTxt.Name = "MiddleNameTxt";
            MiddleNameTxt.Size = new Size(458, 38);
            MiddleNameTxt.TabIndex = 1;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(105, 145);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(458, 38);
            FirstNameTxt.TabIndex = 0;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1906, 896);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox FirstNameTxt;
        private Button UpdateBtn;
        private Button BrowseBtn;
        private Panel panel3;
        private Label label7;
        private PictureBox ProfilePicBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox NewPasswordTxt;
        private TextBox CurrentPasswordTxt;
        private TextBox EmailTxt;
        private TextBox LastNameTxt;
        private TextBox MiddleNameTxt;
        private Label ShowPasswordBtn;
        private Label HidePasswordBtn;
        private Label ShowCurrentPasswordBtn;
        private Label HideCurrentPasswordBtn;
    }
}