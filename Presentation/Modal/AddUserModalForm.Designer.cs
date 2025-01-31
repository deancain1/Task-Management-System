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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
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
            panel1.Size = new Size(1071, 611);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(275, 427);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 11;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(310, 341);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 10;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(245, 250);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 9;
            label3.Text = "Middle Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(266, 162);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 8;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(266, 75);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 7;
            label1.Text = "Last Name:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(CloseBtn);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1069, 53);
            panel2.TabIndex = 6;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CloseBtn.ForeColor = Color.DarkRed;
            CloseBtn.Location = new Point(1037, 13);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(22, 21);
            CloseBtn.TabIndex = 12;
            CloseBtn.Text = "X";
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(23, 13);
            label6.Name = "label6";
            label6.Size = new Size(163, 21);
            label6.TabIndex = 12;
            label6.Text = "Add User Account";
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.DarkCyan;
            CreateBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateBtn.ForeColor = Color.White;
            CreateBtn.Location = new Point(340, 527);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(413, 50);
            CreateBtn.TabIndex = 5;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(340, 462);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(413, 40);
            PasswordTxt.TabIndex = 4;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxt.Location = new Point(340, 375);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(413, 40);
            EmailTxt.TabIndex = 3;
            // 
            // MiddleNameTxt
            // 
            MiddleNameTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            MiddleNameTxt.Location = new Point(340, 284);
            MiddleNameTxt.Name = "MiddleNameTxt";
            MiddleNameTxt.Size = new Size(413, 40);
            MiddleNameTxt.TabIndex = 2;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(340, 198);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(413, 40);
            FirstNameTxt.TabIndex = 1;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(340, 109);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(413, 40);
            LastNameTxt.TabIndex = 0;
            // 
            // AddUserModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 611);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUserModalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUserModalForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}