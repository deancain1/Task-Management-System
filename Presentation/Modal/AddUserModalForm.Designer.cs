﻿namespace Task_Management_System.Presentation.Modal
{
    partial class AddUserModalForm
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
            label10 = new Label();
            Usernametxt = new TextBox();
            label9 = new Label();
            DepartmentCB = new ComboBox();
            BrowseBtn = new Button();
            ProfiilePicBox = new PictureBox();
            ShowPasswordBtn = new Label();
            HidePasswordBtn = new Label();
            ClearBtn = new Button();
            label8 = new Label();
            label7 = new Label();
            SecurityQuestionsCB = new ComboBox();
            AnswerTxt = new TextBox();
            RoleTxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            CloseBtn = new Label();
            label6 = new Label();
            CreateBtn = new Button();
            PasswordTxt = new TextBox();
            EmailTxt = new TextBox();
            MiddleNameTxt = new TextBox();
            FirstNameTxt = new TextBox();
            LastNameTxt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfiilePicBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(Usernametxt);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(DepartmentCB);
            panel1.Controls.Add(BrowseBtn);
            panel1.Controls.Add(ProfiilePicBox);
            panel1.Controls.Add(ShowPasswordBtn);
            panel1.Controls.Add(HidePasswordBtn);
            panel1.Controls.Add(ClearBtn);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(SecurityQuestionsCB);
            panel1.Controls.Add(AnswerTxt);
            panel1.Controls.Add(RoleTxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(CreateBtn);
            panel1.Controls.Add(PasswordTxt);
            panel1.Controls.Add(EmailTxt);
            panel1.Controls.Add(MiddleNameTxt);
            panel1.Controls.Add(FirstNameTxt);
            panel1.Controls.Add(LastNameTxt);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1458, 687);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(578, 74);
            label10.Name = "label10";
            label10.Size = new Size(102, 21);
            label10.TabIndex = 28;
            label10.Text = "Username:";
            // 
            // Usernametxt
            // 
            Usernametxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Usernametxt.Location = new Point(578, 108);
            Usernametxt.Name = "Usernametxt";
            Usernametxt.Size = new Size(495, 40);
            Usernametxt.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(578, 162);
            label9.Name = "label9";
            label9.Size = new Size(118, 21);
            label9.TabIndex = 26;
            label9.Text = "Department:";
            // 
            // DepartmentCB
            // 
            DepartmentCB.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            DepartmentCB.FormattingEnabled = true;
            DepartmentCB.Items.AddRange(new object[] { "Human Resources ", "Legal & Compliance ", "Finance & Accounting ", "IT Support", "Cybersecurity", "Data Analytics " });
            DepartmentCB.Location = new Point(578, 197);
            DepartmentCB.Name = "DepartmentCB";
            DepartmentCB.Size = new Size(495, 41);
            DepartmentCB.TabIndex = 25;
            // 
            // BrowseBtn
            // 
            BrowseBtn.BackColor = Color.FromArgb(88, 149, 214);
            BrowseBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BrowseBtn.ForeColor = Color.White;
            BrowseBtn.Image = Properties.Resources.icons8_browse_25;
            BrowseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BrowseBtn.Location = new Point(1155, 339);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new Size(255, 51);
            BrowseBtn.TabIndex = 24;
            BrowseBtn.Text = "Browse";
            BrowseBtn.UseVisualStyleBackColor = false;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // ProfiilePicBox
            // 
            ProfiilePicBox.BorderStyle = BorderStyle.FixedSingle;
            ProfiilePicBox.Location = new Point(1155, 74);
            ProfiilePicBox.Name = "ProfiilePicBox";
            ProfiilePicBox.Size = new Size(255, 247);
            ProfiilePicBox.TabIndex = 23;
            ProfiilePicBox.TabStop = false;
            // 
            // ShowPasswordBtn
            // 
            ShowPasswordBtn.BackColor = Color.White;
            ShowPasswordBtn.FlatStyle = FlatStyle.Flat;
            ShowPasswordBtn.Image = Properties.Resources.icons8_eye_30;
            ShowPasswordBtn.Location = new Point(1039, 476);
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
            HidePasswordBtn.Location = new Point(1039, 476);
            HidePasswordBtn.Name = "HidePasswordBtn";
            HidePasswordBtn.Size = new Size(30, 30);
            HidePasswordBtn.TabIndex = 21;
            HidePasswordBtn.Click += HidePasswordBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.FromArgb(185, 52, 52);
            ClearBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Image = Properties.Resources.icons8_clear_25;
            ClearBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ClearBtn.Location = new Point(1155, 403);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(255, 51);
            ClearBtn.TabIndex = 17;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(578, 342);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 16;
            label8.Text = "Answer:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(578, 249);
            label7.Name = "label7";
            label7.Size = new Size(177, 21);
            label7.TabIndex = 15;
            label7.Text = "Security Questions:";
            // 
            // SecurityQuestionsCB
            // 
            SecurityQuestionsCB.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SecurityQuestionsCB.FormattingEnabled = true;
            SecurityQuestionsCB.Items.AddRange(new object[] { "What was the name of your first pet?", "What is your mother’s maiden name?", "What is your favorite sports team?", "Who was your childhood hero?" });
            SecurityQuestionsCB.Location = new Point(578, 283);
            SecurityQuestionsCB.Name = "SecurityQuestionsCB";
            SecurityQuestionsCB.Size = new Size(495, 41);
            SecurityQuestionsCB.TabIndex = 14;
            // 
            // AnswerTxt
            // 
            AnswerTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AnswerTxt.Location = new Point(578, 376);
            AnswerTxt.Name = "AnswerTxt";
            AnswerTxt.Size = new Size(495, 40);
            AnswerTxt.TabIndex = 13;
            // 
            // RoleTxt
            // 
            RoleTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            RoleTxt.Location = new Point(51, 442);
            RoleTxt.Name = "RoleTxt";
            RoleTxt.Size = new Size(64, 40);
            RoleTxt.TabIndex = 12;
            RoleTxt.Text = "User";
            RoleTxt.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(578, 433);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 11;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(51, 342);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 10;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(51, 249);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 9;
            label3.Text = "Middle Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(49, 161);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 8;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 74);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 7;
            label1.Text = "Last Name:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(CloseBtn);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1456, 53);
            panel2.TabIndex = 6;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseBtn.ForeColor = Color.DarkRed;
            CloseBtn.Location = new Point(1412, 13);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(24, 24);
            CloseBtn.TabIndex = 12;
            CloseBtn.Text = "X";
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(23, 13);
            label6.Name = "label6";
            label6.Size = new Size(169, 22);
            label6.TabIndex = 12;
            label6.Text = "Add User Account";
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.FromArgb(59, 160, 145);
            CreateBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CreateBtn.ForeColor = Color.White;
            CreateBtn.Image = Properties.Resources.icons8_add_user_25__1_;
            CreateBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CreateBtn.Location = new Point(1155, 468);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(255, 51);
            CreateBtn.TabIndex = 5;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(578, 471);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.Size = new Size(495, 40);
            PasswordTxt.TabIndex = 4;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxt.Location = new Point(51, 376);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(495, 40);
            EmailTxt.TabIndex = 3;
            // 
            // MiddleNameTxt
            // 
            MiddleNameTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            MiddleNameTxt.Location = new Point(51, 283);
            MiddleNameTxt.Name = "MiddleNameTxt";
            MiddleNameTxt.Size = new Size(495, 40);
            MiddleNameTxt.TabIndex = 2;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(51, 197);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(495, 40);
            FirstNameTxt.TabIndex = 1;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(51, 108);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(495, 40);
            LastNameTxt.TabIndex = 0;
            // 
            // AddUserModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 687);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUserModalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUserModalForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfiilePicBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CreateBtn;
        private TextBox PasswordTxt;
        private TextBox EmailTxt;
        private TextBox MiddleNameTxt;
        private TextBox FirstNameTxt;
        private TextBox LastNameTxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label CloseBtn;
        private Label label6;
        private TextBox RoleTxt;
        private Label label8;
        private Label label7;
        private ComboBox SecurityQuestionsCB;
        private TextBox AnswerTxt;
        private Button ClearBtn;
        private Label ShowPasswordBtn;
        private Label HidePasswordBtn;
        private PictureBox ProfiilePicBox;
        private Button BrowseBtn;
        private Label label10;
        private TextBox Usernametxt;
        private Label label9;
        private ComboBox DepartmentCB;
    }
}