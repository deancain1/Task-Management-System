﻿namespace Task_Management_System.Presentation.UserInterface
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
            label9 = new Label();
            DepartmentTxt = new TextBox();
            label8 = new Label();
            UsernameTxt = new TextBox();
            ShowCurrentPasswordBtn = new Label();
            HideCurrentPasswordBtn = new Label();
            ShowPasswordBtn = new Label();
            HidePasswordBtn = new Label();
            UpdateBtn = new Button();
            BrowseBtn = new Button();
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
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(DepartmentTxt);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(UsernameTxt);
            panel2.Controls.Add(ShowCurrentPasswordBtn);
            panel2.Controls.Add(HideCurrentPasswordBtn);
            panel2.Controls.Add(ShowPasswordBtn);
            panel2.Controls.Add(HidePasswordBtn);
            panel2.Controls.Add(UpdateBtn);
            panel2.Controls.Add(BrowseBtn);
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
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1906, 896);
            panel2.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(816, 224);
            label9.Name = "label9";
            label9.Size = new Size(150, 31);
            label9.TabIndex = 28;
            label9.Text = "Department:";
            // 
            // DepartmentTxt
            // 
            DepartmentTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            DepartmentTxt.Location = new Point(915, 280);
            DepartmentTxt.Name = "DepartmentTxt";
            DepartmentTxt.Size = new Size(458, 38);
            DepartmentTxt.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(839, 98);
            label8.Name = "label8";
            label8.Size = new Size(127, 31);
            label8.TabIndex = 26;
            label8.Text = "Username:";
            // 
            // UsernameTxt
            // 
            UsernameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTxt.Location = new Point(915, 152);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(458, 38);
            UsernameTxt.TabIndex = 25;
            // 
            // ShowCurrentPasswordBtn
            // 
            ShowCurrentPasswordBtn.BackColor = Color.White;
            ShowCurrentPasswordBtn.FlatStyle = FlatStyle.Flat;
            ShowCurrentPasswordBtn.Image = Properties.Resources.icons8_eye_30;
            ShowCurrentPasswordBtn.Location = new Point(1335, 409);
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
            HideCurrentPasswordBtn.Location = new Point(1335, 409);
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
            ShowPasswordBtn.Location = new Point(1335, 531);
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
            HidePasswordBtn.Location = new Point(1335, 531);
            HidePasswordBtn.Name = "HidePasswordBtn";
            HidePasswordBtn.Size = new Size(30, 30);
            HidePasswordBtn.TabIndex = 21;
            HidePasswordBtn.Click += HidePasswordBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(59, 160, 145);
            UpdateBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Image = Properties.Resources.icons8_update_25;
            UpdateBtn.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateBtn.Location = new Point(1575, 432);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(255, 53);
            UpdateBtn.TabIndex = 15;
            UpdateBtn.Text = "Save Changes";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // BrowseBtn
            // 
            BrowseBtn.BackColor = Color.FromArgb(88, 149, 214);
            BrowseBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BrowseBtn.ForeColor = Color.White;
            BrowseBtn.Image = Properties.Resources.icons8_browse_25;
            BrowseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BrowseBtn.Location = new Point(1575, 364);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new Size(255, 53);
            BrowseBtn.TabIndex = 14;
            BrowseBtn.Text = "Browse";
            BrowseBtn.UseVisualStyleBackColor = false;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // ProfilePicBox
            // 
            ProfilePicBox.BorderStyle = BorderStyle.FixedSingle;
            ProfilePicBox.Location = new Point(1575, 98);
            ProfilePicBox.Name = "ProfilePicBox";
            ProfilePicBox.Size = new Size(255, 247);
            ProfilePicBox.TabIndex = 12;
            ProfilePicBox.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(792, 467);
            label6.Name = "label6";
            label6.Size = new Size(174, 31);
            label6.TabIndex = 11;
            label6.Text = "New Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(759, 348);
            label5.Name = "label5";
            label5.Size = new Size(207, 31);
            label5.TabIndex = 10;
            label5.Text = "Current Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(223, 480);
            label4.Name = "label4";
            label4.Size = new Size(79, 31);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(170, 348);
            label3.Name = "label3";
            label3.Size = new Size(132, 31);
            label3.TabIndex = 8;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(141, 224);
            label2.Name = "label2";
            label2.Size = new Size(165, 31);
            label2.TabIndex = 7;
            label2.Text = "Middle Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(170, 98);
            label1.Name = "label1";
            label1.Size = new Size(136, 31);
            label1.TabIndex = 6;
            label1.Text = "First Name:";
            // 
            // NewPasswordTxt
            // 
            NewPasswordTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            NewPasswordTxt.Location = new Point(915, 526);
            NewPasswordTxt.Name = "NewPasswordTxt";
            NewPasswordTxt.PasswordChar = '*';
            NewPasswordTxt.Size = new Size(458, 38);
            NewPasswordTxt.TabIndex = 5;
            // 
            // CurrentPasswordTxt
            // 
            CurrentPasswordTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentPasswordTxt.Location = new Point(915, 407);
            CurrentPasswordTxt.Name = "CurrentPasswordTxt";
            CurrentPasswordTxt.PasswordChar = '*';
            CurrentPasswordTxt.Size = new Size(458, 38);
            CurrentPasswordTxt.TabIndex = 4;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxt.Location = new Point(262, 526);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(458, 38);
            EmailTxt.TabIndex = 3;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(262, 407);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(458, 38);
            LastNameTxt.TabIndex = 2;
            // 
            // MiddleNameTxt
            // 
            MiddleNameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MiddleNameTxt.Location = new Point(262, 280);
            MiddleNameTxt.Name = "MiddleNameTxt";
            MiddleNameTxt.Size = new Size(458, 38);
            MiddleNameTxt.TabIndex = 1;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(262, 152);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(458, 38);
            FirstNameTxt.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1641, 50);
            label7.Name = "label7";
            label7.Size = new Size(134, 31);
            label7.TabIndex = 29;
            label7.Text = "Edit Profile";
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
            ((System.ComponentModel.ISupportInitialize)ProfilePicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox FirstNameTxt;
        private Button UpdateBtn;
        private Button BrowseBtn;
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
        private Label label8;
        private TextBox UsernameTxt;
        private Label label9;
        private TextBox DepartmentTxt;
        private Label label7;
    }
}