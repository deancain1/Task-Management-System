namespace Task_Management_System.Presentation.Modal
{
    partial class EditAdminModalForm
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
            BrowseBtn = new Button();
            ProfilePicBox = new PictureBox();
            AdminIDLbl = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            CloseBtn = new Label();
            label6 = new Label();
            UpdateBtn = new Button();
            EmailTxt = new TextBox();
            MiddleNameTxt = new TextBox();
            FirstNameTxt = new TextBox();
            LastNameTxt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePicBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BrowseBtn);
            panel1.Controls.Add(ProfilePicBox);
            panel1.Controls.Add(AdminIDLbl);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(UpdateBtn);
            panel1.Controls.Add(EmailTxt);
            panel1.Controls.Add(MiddleNameTxt);
            panel1.Controls.Add(FirstNameTxt);
            panel1.Controls.Add(LastNameTxt);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1202, 595);
            panel1.TabIndex = 2;
            // 
            // BrowseBtn
            // 
            BrowseBtn.BackColor = Color.FromArgb(88, 149, 214);
            BrowseBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BrowseBtn.ForeColor = Color.White;
            BrowseBtn.Image = Properties.Resources.icons8_browse_25;
            BrowseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BrowseBtn.Location = new Point(841, 358);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new Size(255, 51);
            BrowseBtn.TabIndex = 25;
            BrowseBtn.Text = "Browse";
            BrowseBtn.UseVisualStyleBackColor = false;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // ProfilePicBox
            // 
            ProfilePicBox.BorderStyle = BorderStyle.FixedSingle;
            ProfilePicBox.Location = new Point(841, 97);
            ProfilePicBox.Name = "ProfilePicBox";
            ProfilePicBox.Size = new Size(255, 247);
            ProfilePicBox.TabIndex = 24;
            ProfilePicBox.TabStop = false;
            // 
            // AdminIDLbl
            // 
            AdminIDLbl.AutoSize = true;
            AdminIDLbl.Location = new Point(11, 65);
            AdminIDLbl.Name = "AdminIDLbl";
            AdminIDLbl.Size = new Size(50, 20);
            AdminIDLbl.TabIndex = 12;
            AdminIDLbl.Text = "label7";
            AdminIDLbl.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(125, 361);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 10;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(81, 289);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 9;
            label3.Text = "Middle Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(100, 201);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 8;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 133);
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
            panel2.Size = new Size(1200, 53);
            panel2.TabIndex = 6;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseBtn.ForeColor = Color.DarkRed;
            CloseBtn.Location = new Point(1158, 13);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(24, 24);
            CloseBtn.TabIndex = 12;
            CloseBtn.Text = "X";
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(23, 13);
            label6.Name = "label6";
            label6.Size = new Size(178, 21);
            label6.TabIndex = 12;
            label6.Text = "Edit Admin Account";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.LightSeaGreen;
            UpdateBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(841, 415);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(255, 51);
            UpdateBtn.TabIndex = 5;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxt.Location = new Point(214, 361);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(495, 40);
            EmailTxt.TabIndex = 3;
            // 
            // MiddleNameTxt
            // 
            MiddleNameTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            MiddleNameTxt.Location = new Point(214, 289);
            MiddleNameTxt.Name = "MiddleNameTxt";
            MiddleNameTxt.Size = new Size(495, 40);
            MiddleNameTxt.TabIndex = 2;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(214, 201);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(495, 40);
            FirstNameTxt.TabIndex = 1;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(214, 133);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(495, 40);
            LastNameTxt.TabIndex = 0;
            // 
            // EditAdminModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 595);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditAdminModalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditAdminModalForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePicBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label AdminIDLbl;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label CloseBtn;
        private Label label6;
        private Button UpdateBtn;
        private TextBox EmailTxt;
        private TextBox MiddleNameTxt;
        private TextBox FirstNameTxt;
        private TextBox LastNameTxt;
        private PictureBox ProfilePicBox;
        private Button BrowseBtn;
    }
}