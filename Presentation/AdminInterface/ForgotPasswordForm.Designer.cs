namespace Task_Management_System.Presentation.AdminInterface
{
    partial class ForgotPasswordForm
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
            label1 = new Label();
            EmailTxt = new TextBox();
            SearchAccountBtn = new Button();
            label4 = new Label();
            panel1 = new Panel();
            QuestionAccountPanel = new Panel();
            SecurityQuestionPanel = new Panel();
            PasswordPanel = new Panel();
            ShowConfirmPasswordBtn = new Label();
            HideConfirmPasswordBtn = new Label();
            ShowPasswordBtn = new Label();
            HidePasswordBtn = new Label();
            BackFPBtn = new Button();
            NewPasswordTxt = new TextBox();
            label8 = new Label();
            label9 = new Label();
            ConfirmPasswordTxt = new TextBox();
            UpdateBtn = new Button();
            BackToFPBtn = new Button();
            label7 = new Label();
            label6 = new Label();
            AnswerTxt = new TextBox();
            SubmitBtn = new Button();
            SecurityQuestionLbl = new Label();
            EmailLbl = new Label();
            LoginBtn = new Label();
            label5 = new Label();
            ProfilePicBox = new PictureBox();
            YesBtn = new Button();
            NoBtn = new Button();
            FullNameLbl = new Label();
            panel2 = new Panel();
            BackLogInBtn = new Label();
            panel1.SuspendLayout();
            QuestionAccountPanel.SuspendLayout();
            SecurityQuestionPanel.SuspendLayout();
            PasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePicBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(75, 233);
            label1.Name = "label1";
            label1.Size = new Size(362, 36);
            label1.TabIndex = 1;
            label1.Text = "Forgot your password?";
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxt.Location = new Point(30, 327);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(439, 38);
            EmailTxt.TabIndex = 3;
            // 
            // SearchAccountBtn
            // 
            SearchAccountBtn.BackColor = Color.FromArgb(19, 149, 87);
            SearchAccountBtn.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            SearchAccountBtn.ForeColor = Color.White;
            SearchAccountBtn.Image = Properties.Resources.icons8_search_account_27;
            SearchAccountBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SearchAccountBtn.Location = new Point(30, 380);
            SearchAccountBtn.Name = "SearchAccountBtn";
            SearchAccountBtn.Size = new Size(439, 49);
            SearchAccountBtn.TabIndex = 5;
            SearchAccountBtn.Text = "Search Account";
            SearchAccountBtn.UseVisualStyleBackColor = false;
            SearchAccountBtn.Click += SearchAccountBtn_Click;
            SearchAccountBtn.MouseLeave += SearchAccountBtn_MouseLeave;
            SearchAccountBtn.MouseMove += SearchAccountBtn_MouseMove;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(30, 294);
            label4.Name = "label4";
            label4.Size = new Size(164, 24);
            label4.TabIndex = 6;
            label4.Text = "Enter your email:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(QuestionAccountPanel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SearchAccountBtn);
            panel1.Controls.Add(EmailTxt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(BackLogInBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 739);
            panel1.TabIndex = 0;
            // 
            // QuestionAccountPanel
            // 
            QuestionAccountPanel.BackColor = Color.White;
            QuestionAccountPanel.BorderStyle = BorderStyle.FixedSingle;
            QuestionAccountPanel.Controls.Add(SecurityQuestionPanel);
            QuestionAccountPanel.Controls.Add(EmailLbl);
            QuestionAccountPanel.Controls.Add(LoginBtn);
            QuestionAccountPanel.Controls.Add(label5);
            QuestionAccountPanel.Controls.Add(ProfilePicBox);
            QuestionAccountPanel.Controls.Add(YesBtn);
            QuestionAccountPanel.Controls.Add(NoBtn);
            QuestionAccountPanel.Controls.Add(FullNameLbl);
            QuestionAccountPanel.Location = new Point(250, 173);
            QuestionAccountPanel.Name = "QuestionAccountPanel";
            QuestionAccountPanel.Size = new Size(721, 377);
            QuestionAccountPanel.TabIndex = 9;
            // 
            // SecurityQuestionPanel
            // 
            SecurityQuestionPanel.BackColor = Color.White;
            SecurityQuestionPanel.BorderStyle = BorderStyle.FixedSingle;
            SecurityQuestionPanel.Controls.Add(PasswordPanel);
            SecurityQuestionPanel.Controls.Add(BackToFPBtn);
            SecurityQuestionPanel.Controls.Add(label7);
            SecurityQuestionPanel.Controls.Add(label6);
            SecurityQuestionPanel.Controls.Add(AnswerTxt);
            SecurityQuestionPanel.Controls.Add(SubmitBtn);
            SecurityQuestionPanel.Controls.Add(SecurityQuestionLbl);
            SecurityQuestionPanel.Location = new Point(-1, -1);
            SecurityQuestionPanel.Name = "SecurityQuestionPanel";
            SecurityQuestionPanel.Size = new Size(721, 377);
            SecurityQuestionPanel.TabIndex = 15;
            // 
            // PasswordPanel
            // 
            PasswordPanel.BackColor = Color.White;
            PasswordPanel.BorderStyle = BorderStyle.FixedSingle;
            PasswordPanel.Controls.Add(ShowConfirmPasswordBtn);
            PasswordPanel.Controls.Add(HideConfirmPasswordBtn);
            PasswordPanel.Controls.Add(ShowPasswordBtn);
            PasswordPanel.Controls.Add(HidePasswordBtn);
            PasswordPanel.Controls.Add(BackFPBtn);
            PasswordPanel.Controls.Add(NewPasswordTxt);
            PasswordPanel.Controls.Add(label8);
            PasswordPanel.Controls.Add(label9);
            PasswordPanel.Controls.Add(ConfirmPasswordTxt);
            PasswordPanel.Controls.Add(UpdateBtn);
            PasswordPanel.Location = new Point(-1, -1);
            PasswordPanel.Name = "PasswordPanel";
            PasswordPanel.Size = new Size(721, 377);
            PasswordPanel.TabIndex = 16;
            // 
            // ShowConfirmPasswordBtn
            // 
            ShowConfirmPasswordBtn.BackColor = Color.White;
            ShowConfirmPasswordBtn.FlatStyle = FlatStyle.Flat;
            ShowConfirmPasswordBtn.Image = Properties.Resources.icons8_eye_30;
            ShowConfirmPasswordBtn.Location = new Point(620, 199);
            ShowConfirmPasswordBtn.Name = "ShowConfirmPasswordBtn";
            ShowConfirmPasswordBtn.Size = new Size(30, 30);
            ShowConfirmPasswordBtn.TabIndex = 24;
            ShowConfirmPasswordBtn.Click += ShowConfirmPasswordBtn_Click;
            // 
            // HideConfirmPasswordBtn
            // 
            HideConfirmPasswordBtn.BackColor = Color.White;
            HideConfirmPasswordBtn.FlatStyle = FlatStyle.Flat;
            HideConfirmPasswordBtn.Image = Properties.Resources.icons8_hide_30;
            HideConfirmPasswordBtn.Location = new Point(620, 200);
            HideConfirmPasswordBtn.Name = "HideConfirmPasswordBtn";
            HideConfirmPasswordBtn.Size = new Size(30, 30);
            HideConfirmPasswordBtn.TabIndex = 23;
            HideConfirmPasswordBtn.Click += HideConfirmPasswordBtn_Click_1;
            // 
            // ShowPasswordBtn
            // 
            ShowPasswordBtn.BackColor = Color.White;
            ShowPasswordBtn.FlatStyle = FlatStyle.Flat;
            ShowPasswordBtn.Image = Properties.Resources.icons8_eye_30;
            ShowPasswordBtn.Location = new Point(621, 111);
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
            HidePasswordBtn.Location = new Point(621, 110);
            HidePasswordBtn.Name = "HidePasswordBtn";
            HidePasswordBtn.Size = new Size(30, 30);
            HidePasswordBtn.TabIndex = 21;
            HidePasswordBtn.Click += HidePasswordBtn_Click;
            // 
            // BackFPBtn
            // 
            BackFPBtn.BackColor = Color.Transparent;
            BackFPBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackFPBtn.ForeColor = Color.DarkRed;
            BackFPBtn.Location = new Point(12, 333);
            BackFPBtn.Name = "BackFPBtn";
            BackFPBtn.Size = new Size(94, 29);
            BackFPBtn.TabIndex = 9;
            BackFPBtn.Text = "Back";
            BackFPBtn.UseVisualStyleBackColor = false;
            BackFPBtn.Click += BackFPBtn_Click;
            // 
            // NewPasswordTxt
            // 
            NewPasswordTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            NewPasswordTxt.Location = new Point(52, 107);
            NewPasswordTxt.Name = "NewPasswordTxt";
            NewPasswordTxt.PasswordChar = '*';
            NewPasswordTxt.Size = new Size(602, 38);
            NewPasswordTxt.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(52, 164);
            label8.Name = "label8";
            label8.Size = new Size(158, 22);
            label8.TabIndex = 6;
            label8.Text = "Confirm Password:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(52, 74);
            label9.Name = "label9";
            label9.Size = new Size(130, 22);
            label9.TabIndex = 5;
            label9.Text = "New Password:";
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPasswordTxt.Location = new Point(52, 195);
            ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            ConfirmPasswordTxt.PasswordChar = '*';
            ConfirmPasswordTxt.Size = new Size(602, 38);
            ConfirmPasswordTxt.TabIndex = 4;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(13, 196, 85);
            UpdateBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(52, 257);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(604, 48);
            UpdateBtn.TabIndex = 3;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // BackToFPBtn
            // 
            BackToFPBtn.BackColor = Color.Transparent;
            BackToFPBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackToFPBtn.ForeColor = Color.DarkRed;
            BackToFPBtn.Location = new Point(13, 337);
            BackToFPBtn.Name = "BackToFPBtn";
            BackToFPBtn.Size = new Size(94, 29);
            BackToFPBtn.TabIndex = 10;
            BackToFPBtn.Text = "Back";
            BackToFPBtn.UseVisualStyleBackColor = false;
            BackToFPBtn.Click += BackToFPBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(56, 151);
            label7.Name = "label7";
            label7.Size = new Size(73, 22);
            label7.TabIndex = 6;
            label7.Text = "Answer:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(52, 64);
            label6.Name = "label6";
            label6.Size = new Size(154, 22);
            label6.TabIndex = 5;
            label6.Text = "Security Question:";
            // 
            // AnswerTxt
            // 
            AnswerTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            AnswerTxt.Location = new Point(58, 182);
            AnswerTxt.Name = "AnswerTxt";
            AnswerTxt.Size = new Size(602, 38);
            AnswerTxt.TabIndex = 4;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.FromArgb(13, 196, 85);
            SubmitBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitBtn.ForeColor = Color.White;
            SubmitBtn.Location = new Point(58, 238);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(602, 42);
            SubmitBtn.TabIndex = 3;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // SecurityQuestionLbl
            // 
            SecurityQuestionLbl.BorderStyle = BorderStyle.FixedSingle;
            SecurityQuestionLbl.Location = new Point(56, 96);
            SecurityQuestionLbl.Name = "SecurityQuestionLbl";
            SecurityQuestionLbl.Size = new Size(600, 39);
            SecurityQuestionLbl.TabIndex = 0;
            // 
            // EmailLbl
            // 
            EmailLbl.Location = new Point(171, 195);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(374, 28);
            EmailLbl.TabIndex = 16;
            EmailLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginBtn
            // 
            LoginBtn.AutoSize = true;
            LoginBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.FromArgb(32, 49, 189);
            LoginBtn.Location = new Point(3, 333);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(189, 25);
            LoginBtn.TabIndex = 15;
            LoginBtn.Text = "Log in with password";
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(270, 232);
            label5.Name = "label5";
            label5.Size = new Size(176, 22);
            label5.TabIndex = 14;
            label5.Text = "Is this your account?";
            // 
            // ProfilePicBox
            // 
            ProfilePicBox.BorderStyle = BorderStyle.FixedSingle;
            ProfilePicBox.Location = new Point(270, 11);
            ProfilePicBox.Name = "ProfilePicBox";
            ProfilePicBox.Size = new Size(166, 140);
            ProfilePicBox.TabIndex = 13;
            ProfilePicBox.TabStop = false;
            // 
            // YesBtn
            // 
            YesBtn.BackColor = Color.FromArgb(13, 196, 85);
            YesBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            YesBtn.ForeColor = Color.White;
            YesBtn.Location = new Point(368, 281);
            YesBtn.Name = "YesBtn";
            YesBtn.Size = new Size(177, 42);
            YesBtn.TabIndex = 3;
            YesBtn.Text = "Yes";
            YesBtn.UseVisualStyleBackColor = false;
            YesBtn.Click += YesBtn_Click;
            // 
            // NoBtn
            // 
            NoBtn.BackColor = Color.FromArgb(196, 13, 33);
            NoBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            NoBtn.ForeColor = Color.White;
            NoBtn.Location = new Point(171, 281);
            NoBtn.Name = "NoBtn";
            NoBtn.Size = new Size(177, 42);
            NoBtn.TabIndex = 2;
            NoBtn.Text = "No";
            NoBtn.UseVisualStyleBackColor = false;
            NoBtn.Click += NoBtn_Click;
            // 
            // FullNameLbl
            // 
            FullNameLbl.Location = new Point(171, 158);
            FullNameLbl.Name = "FullNameLbl";
            FullNameLbl.Size = new Size(374, 28);
            FullNameLbl.TabIndex = 0;
            FullNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Untitled_design__5_1;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(528, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 739);
            panel2.TabIndex = 0;
            // 
            // BackLogInBtn
            // 
            BackLogInBtn.AutoSize = true;
            BackLogInBtn.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BackLogInBtn.Location = new Point(179, 442);
            BackLogInBtn.Name = "BackLogInBtn";
            BackLogInBtn.Size = new Size(129, 23);
            BackLogInBtn.TabIndex = 10;
            BackLogInBtn.Text = "Back to Login";
            BackLogInBtn.Click += BackLogInBtn_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 739);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            QuestionAccountPanel.ResumeLayout(false);
            QuestionAccountPanel.PerformLayout();
            SecurityQuestionPanel.ResumeLayout(false);
            SecurityQuestionPanel.PerformLayout();
            PasswordPanel.ResumeLayout(false);
            PasswordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox EmailTxt;
        private Button SearchAccountBtn;
        private Label label4;
        private Panel panel1;
        private Panel QuestionAccountPanel;
        private Label label5;
        private PictureBox ProfilePicBox;
        private Button YesBtn;
        private Button NoBtn;
        private Label FullNameLbl;
        private Panel panel2;
        private Panel SecurityQuestionPanel;
        private Label label7;
        private Label label6;
        private TextBox AnswerTxt;
        private Button SubmitBtn;
        private Label SecurityQuestionLbl;
        private Panel PasswordPanel;
        private TextBox NewPasswordTxt;
        private Label label8;
        private Label label9;
        private TextBox ConfirmPasswordTxt;
        private Button UpdateBtn;
        private Label LoginBtn;
        private Label EmailLbl;
        private Button BackFPBtn;
        private Label BackLogInBtn;
        private Label ShowConfirmPasswordBtn;
        private Label HideConfirmPasswordBtn;
        private Label ShowPasswordBtn;
        private Label HidePasswordBtn;
        private Button BackToFPBtn;
    }
}