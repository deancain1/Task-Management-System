namespace Task_Management_System.Presentation
{
    partial class LoginForm
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
            panel3 = new Panel();
            ExitBtn = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            RegisterHereBtn = new Label();
            label8 = new Label();
            label7 = new Label();
            LoginBtn = new Button();
            label5 = new Label();
            label4 = new Label();
            PasswordTxt = new TextBox();
            EmailTxt = new TextBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.taskbg4;
            panel3.Controls.Add(ExitBtn);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(427, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(772, 739);
            panel3.TabIndex = 2;
            // 
            // ExitBtn
            // 
            ExitBtn.AutoSize = true;
            ExitBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExitBtn.ForeColor = Color.DarkRed;
            ExitBtn.Location = new Point(736, 9);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(24, 24);
            ExitBtn.TabIndex = 17;
            ExitBtn.Text = "X";
            ExitBtn.Click += ExitBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 739);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(RegisterHereBtn);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(LoginBtn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(PasswordTxt);
            panel2.Controls.Add(EmailTxt);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 739);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 378);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 16;
            label1.Text = "Forgot Password";
            // 
            // RegisterHereBtn
            // 
            RegisterHereBtn.AutoSize = true;
            RegisterHereBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterHereBtn.ForeColor = Color.White;
            RegisterHereBtn.Location = new Point(272, 674);
            RegisterHereBtn.Name = "RegisterHereBtn";
            RegisterHereBtn.Size = new Size(124, 21);
            RegisterHereBtn.TabIndex = 15;
            RegisterHereBtn.Text = "Register here";
            RegisterHereBtn.Click += RegisterHereBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(22, 674);
            label8.Name = "label8";
            label8.Size = new Size(244, 21);
            label8.TabIndex = 14;
            label8.Text = "Don't have an account yet?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(109, 147);
            label7.Name = "label7";
            label7.Size = new Size(214, 34);
            label7.TabIndex = 13;
            label7.Text = "Login Account";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.MediumSeaGreen;
            LoginBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.Location = new Point(40, 419);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(348, 45);
            LoginBtn.TabIndex = 12;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(40, 315);
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
            label4.Location = new Point(40, 246);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(40, 338);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(348, 30);
            PasswordTxt.TabIndex = 4;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxt.Location = new Point(40, 270);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(348, 30);
            EmailTxt.TabIndex = 3;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 739);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label RegisterHereBtn;
        private Label label8;
        private Label label7;
        private Button LoginBtn;
        private Label label5;
        private Label label4;
        private TextBox PasswordTxt;
        private Label ExitBtn;
        public TextBox EmailTxt;
    }
}