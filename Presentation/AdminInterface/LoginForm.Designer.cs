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
            panel1 = new Panel();
            panel3 = new Panel();
            CloseBtn = new Label();
            label3 = new Label();
            label2 = new Label();
            ShowPasswordBtn = new Label();
            HidePasswordBtn = new Label();
            label1 = new Label();
            label7 = new Label();
            LoginBtn = new Button();
            PasswordTxt = new TextBox();
            EmailTxt = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 248, 248);
            panel3.Controls.Add(CloseBtn);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(ShowPasswordBtn);
            panel3.Controls.Add(HidePasswordBtn);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(LoginBtn);
            panel3.Controls.Add(PasswordTxt);
            panel3.Controls.Add(EmailTxt);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(550, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(649, 739);
            panel3.TabIndex = 2;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            CloseBtn.ForeColor = Color.DarkRed;
            CloseBtn.Location = new Point(608, 9);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(29, 31);
            CloseBtn.TabIndex = 23;
            CloseBtn.Text = "X";
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label3
            // 
            label3.Image = Properties.Resources.icons8_password_43;
            label3.Location = new Point(115, 357);
            label3.Name = "label3";
            label3.Size = new Size(43, 41);
            label3.TabIndex = 22;
            // 
            // label2
            // 
            label2.Image = Properties.Resources.icons8_email_43;
            label2.Location = new Point(115, 289);
            label2.Name = "label2";
            label2.Size = new Size(43, 41);
            label2.TabIndex = 21;
            // 
            // ShowPasswordBtn
            // 
            ShowPasswordBtn.BackColor = Color.White;
            ShowPasswordBtn.FlatStyle = FlatStyle.Flat;
            ShowPasswordBtn.Image = Properties.Resources.icons8_eye_30;
            ShowPasswordBtn.Location = new Point(519, 361);
            ShowPasswordBtn.Name = "ShowPasswordBtn";
            ShowPasswordBtn.Size = new Size(30, 30);
            ShowPasswordBtn.TabIndex = 20;
            ShowPasswordBtn.Click += ShowPasswordBtn_Click;
            // 
            // HidePasswordBtn
            // 
            HidePasswordBtn.BackColor = Color.White;
            HidePasswordBtn.FlatStyle = FlatStyle.Flat;
            HidePasswordBtn.Image = Properties.Resources.icons8_hide_30;
            HidePasswordBtn.Location = new Point(519, 361);
            HidePasswordBtn.Name = "HidePasswordBtn";
            HidePasswordBtn.Size = new Size(30, 30);
            HidePasswordBtn.TabIndex = 19;
            HidePasswordBtn.Click += HidePasswordBtn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(282, 486);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 16;
            label1.Text = "Forgot Password?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(222, 207);
            label7.Name = "label7";
            label7.Size = new Size(254, 46);
            label7.TabIndex = 13;
            label7.Text = "Member Login";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(0, 151, 178);
            LoginBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(164, 414);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(393, 60);
            LoginBtn.TabIndex = 12;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click_1;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(164, 357);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.Size = new Size(393, 41);
            PasswordTxt.TabIndex = 4;
            // 
            // EmailTxt
            // 
            EmailTxt.AccessibleDescription = "";
            EmailTxt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxt.Location = new Point(164, 289);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(393, 41);
            EmailTxt.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Task_Management_System__5_;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 739);
            panel2.TabIndex = 0;
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
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel3;
        private Label ShowPasswordBtn;
        private Label HidePasswordBtn;
        private Label label1;
        private Label label7;
        private Button LoginBtn;
        private TextBox PasswordTxt;
        public TextBox EmailTxt;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label CloseBtn;
    }
}