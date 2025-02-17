namespace Task_Management_System.Presentation.AdminInterface
{
    partial class AdminProfileForm
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
            panel2 = new Panel();
            ShowCurrentPasswordBtn = new Label();
            HideCurrentPasswordBtn = new Label();
            ShowPasswordBtn = new Label();
            HidePasswordBtn = new Label();
            UpdateBtn = new Button();
            BrowseBtn = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ProfilePicBox = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            NewPasswordTxt = new TextBox();
            CurrentPasswordTxt = new TextBox();
            EmailTxt = new TextBox();
            LastNameTxt = new TextBox();
            MiddleNameTxt = new TextBox();
            FirstNameTxt = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            label8 = new Label();
            UsernameTxt = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePicBox).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(UsernameTxt);
            panel2.Controls.Add(ShowCurrentPasswordBtn);
            panel2.Controls.Add(HideCurrentPasswordBtn);
            panel2.Controls.Add(ShowPasswordBtn);
            panel2.Controls.Add(HidePasswordBtn);
            panel2.Controls.Add(UpdateBtn);
            panel2.Controls.Add(BrowseBtn);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(ProfilePicBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(NewPasswordTxt);
            panel2.Controls.Add(CurrentPasswordTxt);
            panel2.Controls.Add(EmailTxt);
            panel2.Controls.Add(LastNameTxt);
            panel2.Controls.Add(MiddleNameTxt);
            panel2.Controls.Add(FirstNameTxt);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1608, 906);
            panel2.TabIndex = 1;
            // 
            // ShowCurrentPasswordBtn
            // 
            ShowCurrentPasswordBtn.BackColor = Color.White;
            ShowCurrentPasswordBtn.FlatStyle = FlatStyle.Flat;
            ShowCurrentPasswordBtn.Image = Properties.Resources.icons8_eye_30;
            ShowCurrentPasswordBtn.Location = new Point(1540, 366);
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
            HideCurrentPasswordBtn.Location = new Point(1540, 366);
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
            ShowPasswordBtn.Location = new Point(1538, 496);
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
            HidePasswordBtn.Location = new Point(1538, 496);
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
            UpdateBtn.Location = new Point(80, 510);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(255, 53);
            UpdateBtn.TabIndex = 18;
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
            BrowseBtn.Location = new Point(80, 441);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new Size(255, 52);
            BrowseBtn.TabIndex = 17;
            BrowseBtn.Text = "Browse";
            BrowseBtn.UseVisualStyleBackColor = false;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1069, 435);
            label7.Name = "label7";
            label7.Size = new Size(174, 28);
            label7.TabIndex = 16;
            label7.Text = "New Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1067, 307);
            label6.Name = "label6";
            label6.Size = new Size(211, 28);
            label6.TabIndex = 15;
            label6.Text = "Current Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(460, 560);
            label5.Name = "label5";
            label5.Size = new Size(79, 28);
            label5.TabIndex = 14;
            label5.Text = "Email:";
            // 
            // ProfilePicBox
            // 
            ProfilePicBox.BorderStyle = BorderStyle.FixedSingle;
            ProfilePicBox.Location = new Point(80, 179);
            ProfilePicBox.Name = "ProfilePicBox";
            ProfilePicBox.Size = new Size(255, 247);
            ProfilePicBox.TabIndex = 13;
            ProfilePicBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(460, 435);
            label4.Name = "label4";
            label4.Size = new Size(131, 28);
            label4.TabIndex = 10;
            label4.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(460, 307);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 9;
            label2.Text = "Middle Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(460, 179);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 8;
            label3.Text = "First Name:";
            // 
            // NewPasswordTxt
            // 
            NewPasswordTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            NewPasswordTxt.Location = new Point(1069, 495);
            NewPasswordTxt.Name = "NewPasswordTxt";
            NewPasswordTxt.PasswordChar = '*';
            NewPasswordTxt.Size = new Size(502, 38);
            NewPasswordTxt.TabIndex = 6;
            // 
            // CurrentPasswordTxt
            // 
            CurrentPasswordTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentPasswordTxt.Location = new Point(1069, 363);
            CurrentPasswordTxt.Name = "CurrentPasswordTxt";
            CurrentPasswordTxt.PasswordChar = '*';
            CurrentPasswordTxt.Size = new Size(502, 38);
            CurrentPasswordTxt.TabIndex = 5;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxt.Location = new Point(462, 605);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(502, 38);
            EmailTxt.TabIndex = 4;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(460, 496);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(502, 38);
            LastNameTxt.TabIndex = 3;
            // 
            // MiddleNameTxt
            // 
            MiddleNameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MiddleNameTxt.Location = new Point(460, 362);
            MiddleNameTxt.Name = "MiddleNameTxt";
            MiddleNameTxt.Size = new Size(502, 38);
            MiddleNameTxt.TabIndex = 2;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(460, 223);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(502, 38);
            FirstNameTxt.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1608, 55);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 0;
            label1.Text = "Edit Profile";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1069, 179);
            label8.Name = "label8";
            label8.Size = new Size(128, 28);
            label8.TabIndex = 26;
            label8.Text = "Username:";
            // 
            // UsernameTxt
            // 
            UsernameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTxt.Location = new Point(1071, 224);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(502, 38);
            UsernameTxt.TabIndex = 25;
            // 
            // AdminProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1608, 906);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminProfileForm";
            Text = "AdminProfileForm";
            Load += AdminProfileForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePicBox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label ShowCurrentPasswordBtn;
        private Label HideCurrentPasswordBtn;
        private Label ShowPasswordBtn;
        private Label HidePasswordBtn;
        private Button UpdateBtn;
        private Button BrowseBtn;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox ProfilePicBox;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox NewPasswordTxt;
        private TextBox CurrentPasswordTxt;
        private TextBox EmailTxt;
        private TextBox LastNameTxt;
        private TextBox MiddleNameTxt;
        private TextBox FirstNameTxt;
        private Panel panel3;
        private Label label1;
        private Label label8;
        private TextBox UsernameTxt;
    }
}