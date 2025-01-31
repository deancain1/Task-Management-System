namespace Task_Management_System.Presentation
{
    partial class RegisterAdminForm
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
            panel3 = new Panel();
            ExitBtn = new Label();
            panel2 = new Panel();
            LoginHereBtn = new Label();
            label8 = new Label();
            label7 = new Label();
            SignUpBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ConfirmPasswordTxt = new TextBox();
            PasswordTxt = new TextBox();
            EmailTxt = new TextBox();
            MiddleNameTxt = new TextBox();
            FirstNameTxt = new TextBox();
            LastNameTxt = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 739);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.taskbg4;
            panel3.Controls.Add(ExitBtn);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(427, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(772, 739);
            panel3.TabIndex = 1;
            // 
            // ExitBtn
            // 
            ExitBtn.AutoSize = true;
            ExitBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExitBtn.ForeColor = Color.DarkRed;
            ExitBtn.Location = new Point(736, 9);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(24, 24);
            ExitBtn.TabIndex = 0;
            ExitBtn.Text = "X";
            ExitBtn.Click += ExitBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(LoginHereBtn);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(SignUpBtn);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ConfirmPasswordTxt);
            panel2.Controls.Add(PasswordTxt);
            panel2.Controls.Add(EmailTxt);
            panel2.Controls.Add(MiddleNameTxt);
            panel2.Controls.Add(FirstNameTxt);
            panel2.Controls.Add(LastNameTxt);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 739);
            panel2.TabIndex = 0;
            // 
            // LoginHereBtn
            // 
            LoginHereBtn.AutoSize = true;
            LoginHereBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LoginHereBtn.ForeColor = Color.White;
            LoginHereBtn.Location = new Point(272, 674);
            LoginHereBtn.Name = "LoginHereBtn";
            LoginHereBtn.Size = new Size(101, 21);
            LoginHereBtn.TabIndex = 15;
            LoginHereBtn.Text = "Login here";
            LoginHereBtn.Click += LoginHereBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(40, 674);
            label8.Name = "label8";
            label8.Size = new Size(230, 21);
            label8.TabIndex = 14;
            label8.Text = "Already have an account?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(80, 90);
            label7.Name = "label7";
            label7.Size = new Size(255, 34);
            label7.TabIndex = 13;
            label7.Text = "Register Account";
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.Turquoise;
            SignUpBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpBtn.Location = new Point(40, 587);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(348, 45);
            SignUpBtn.TabIndex = 12;
            SignUpBtn.Text = "Signup";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 496);
            label6.Name = "label6";
            label6.Size = new Size(172, 21);
            label6.TabIndex = 11;
            label6.Text = "Confirm Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(40, 429);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 10;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 360);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 294);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 8;
            label3.Text = "Middle Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 228);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 7;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 163);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 6;
            label1.Text = "Last Name:";
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPasswordTxt.Location = new Point(40, 521);
            ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            ConfirmPasswordTxt.Size = new Size(348, 30);
            ConfirmPasswordTxt.TabIndex = 5;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(40, 452);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(348, 30);
            PasswordTxt.TabIndex = 4;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxt.Location = new Point(40, 384);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(348, 30);
            EmailTxt.TabIndex = 3;
            // 
            // MiddleNameTxt
            // 
            MiddleNameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MiddleNameTxt.Location = new Point(40, 318);
            MiddleNameTxt.Name = "MiddleNameTxt";
            MiddleNameTxt.Size = new Size(348, 30);
            MiddleNameTxt.TabIndex = 2;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(40, 252);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(348, 30);
            FirstNameTxt.TabIndex = 1;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(40, 187);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(348, 30);
            LastNameTxt.TabIndex = 0;
            // 
            // RegisterAccountUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 739);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterAccountUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterAccountUserForm";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox MiddleNameTxt;
        private TextBox FirstNameTxt;
        private TextBox LastNameTxt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox ConfirmPasswordTxt;
        private TextBox PasswordTxt;
        private TextBox EmailTxt;
        private Button SignUpBtn;
        private Label LoginHereBtn;
        private Label label8;
        private Label label7;
        private Panel panel3;
        private Label ExitBtn;
    }
}