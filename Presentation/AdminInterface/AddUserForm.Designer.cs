namespace Task_Management_System.Presentation.AdminInterface
{
    partial class AddUserForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            panel4 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            DGVUsers = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            EditBtn = new DataGridViewImageColumn();
            DeleteBtn = new DataGridViewImageColumn();
            AddUserBtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsers).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(AddUserBtn);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1626, 953);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_search;
            button1.Location = new Point(415, 59);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(397, 38);
            textBox1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 115);
            panel4.Name = "panel4";
            panel4.Size = new Size(1626, 50);
            panel4.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(1505, 12);
            label7.Name = "label7";
            label7.Size = new Size(73, 22);
            label7.TabIndex = 6;
            label7.Text = "Actions";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1191, 12);
            label6.Name = "label6";
            label6.Size = new Size(56, 22);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(901, 12);
            label5.Name = "label5";
            label5.Size = new Size(124, 22);
            label5.TabIndex = 4;
            label5.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(617, 12);
            label4.Name = "label4";
            label4.Size = new Size(102, 22);
            label4.TabIndex = 3;
            label4.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(334, 12);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(68, 12);
            label2.Name = "label2";
            label2.Size = new Size(73, 22);
            label2.TabIndex = 1;
            label2.Text = "User ID";
            // 
            // panel3
            // 
            panel3.Controls.Add(DGVUsers);
            panel3.Location = new Point(0, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(1626, 834);
            panel3.TabIndex = 2;
            // 
            // DGVUsers
            // 
            DGVUsers.BackgroundColor = Color.White;
            DGVUsers.BorderStyle = BorderStyle.None;
            DGVUsers.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            DGVUsers.ColumnHeadersHeight = 50;
            DGVUsers.Columns.AddRange(new DataGridViewColumn[] { UserID, LastName, FirstName, MiddleName, Email, EditBtn, DeleteBtn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVUsers.DefaultCellStyle = dataGridViewCellStyle2;
            DGVUsers.Dock = DockStyle.Fill;
            DGVUsers.Location = new Point(0, 0);
            DGVUsers.Name = "DGVUsers";
            DGVUsers.RowHeadersWidth = 51;
            DGVUsers.RowTemplate.Height = 29;
            DGVUsers.Size = new Size(1626, 834);
            DGVUsers.TabIndex = 0;
            DGVUsers.CellContentClick += DGVUsers_CellContentClick;
            // 
            // UserID
            // 
            UserID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserID.HeaderText = "User ID";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            // 
            // MiddleName
            // 
            MiddleName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MiddleName.HeaderText = "Middle Name";
            MiddleName.MinimumWidth = 6;
            MiddleName.Name = "MiddleName";
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // EditBtn
            // 
            EditBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EditBtn.HeaderText = "Edit";
            EditBtn.Image = Properties.Resources.icons8_edit_25__1_;
            EditBtn.MinimumWidth = 6;
            EditBtn.Name = "EditBtn";
            EditBtn.ReadOnly = true;
            EditBtn.Resizable = DataGridViewTriState.True;
            EditBtn.SortMode = DataGridViewColumnSortMode.Automatic;
            EditBtn.Width = 64;
            // 
            // DeleteBtn
            // 
            DeleteBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DeleteBtn.HeaderText = "Delete";
            DeleteBtn.Image = Properties.Resources.icons8_delete_25;
            DeleteBtn.MinimumWidth = 6;
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.ReadOnly = true;
            DeleteBtn.Resizable = DataGridViewTriState.True;
            DeleteBtn.SortMode = DataGridViewColumnSortMode.Automatic;
            DeleteBtn.Width = 82;
            // 
            // AddUserBtn
            // 
            AddUserBtn.BackColor = Color.MediumSeaGreen;
            AddUserBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddUserBtn.ForeColor = Color.White;
            AddUserBtn.Location = new Point(1389, 56);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(225, 55);
            AddUserBtn.TabIndex = 1;
            AddUserBtn.Text = "Create User";
            AddUserBtn.UseVisualStyleBackColor = false;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1626, 53);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(216, 24);
            label1.TabIndex = 1;
            label1.Text = "Create User Account";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1626, 953);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUserForm";
            Load += AddUserForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVUsers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddUserBtn;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private DataGridView DGVUsers;
        private Panel panel4;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private Label label7;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewImageColumn EditBtn;
        private DataGridViewImageColumn DeleteBtn;
    }
}