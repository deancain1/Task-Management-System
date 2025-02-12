namespace Task_Management_System.Presentation.AdminInterface
{
    partial class CreateAdminForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            SearchBtn = new Button();
            SearchTxt = new TextBox();
            panel4 = new Panel();
            panel6 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            DGVAdmin = new DataGridView();
            AdminID = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            EditBtn = new DataGridViewImageColumn();
            DeleteBtn = new DataGridViewImageColumn();
            CreateAdminBtn = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAdmin).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1626, 953);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(SearchBtn);
            panel2.Controls.Add(SearchTxt);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(CreateAdminBtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(1626, 900);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(460, 20);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 9;
            label2.Text = "Search Admin:";
            // 
            // SearchBtn
            // 
            SearchBtn.Image = Properties.Resources.icons8_search;
            SearchBtn.Location = new Point(1003, 6);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(50, 50);
            SearchBtn.TabIndex = 8;
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchTxt
            // 
            SearchTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTxt.Location = new Point(600, 10);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(397, 38);
            SearchTxt.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(DGVAdmin);
            panel4.Location = new Point(0, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(1626, 834);
            panel4.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label13);
            panel6.Location = new Point(1, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1626, 50);
            panel6.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(1505, 12);
            label8.Name = "label8";
            label8.Size = new Size(73, 22);
            label8.TabIndex = 6;
            label8.Text = "Actions";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(1191, 12);
            label9.Name = "label9";
            label9.Size = new Size(56, 22);
            label9.TabIndex = 5;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(901, 12);
            label10.Name = "label10";
            label10.Size = new Size(124, 22);
            label10.TabIndex = 4;
            label10.Text = "Middle Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(617, 12);
            label11.Name = "label11";
            label11.Size = new Size(102, 22);
            label11.TabIndex = 3;
            label11.Text = "First Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(334, 12);
            label12.Name = "label12";
            label12.Size = new Size(100, 22);
            label12.TabIndex = 2;
            label12.Text = "Last Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(68, 12);
            label13.Name = "label13";
            label13.Size = new Size(90, 22);
            label13.TabIndex = 1;
            label13.Text = "Admin ID";
            // 
            // DGVAdmin
            // 
            DGVAdmin.BackgroundColor = Color.White;
            DGVAdmin.BorderStyle = BorderStyle.None;
            DGVAdmin.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            DGVAdmin.ColumnHeadersHeight = 50;
            DGVAdmin.Columns.AddRange(new DataGridViewColumn[] { AdminID, LastName, FirstName, MiddleName, Email, EditBtn, DeleteBtn });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DGVAdmin.DefaultCellStyle = dataGridViewCellStyle5;
            DGVAdmin.Dock = DockStyle.Fill;
            DGVAdmin.Location = new Point(0, 0);
            DGVAdmin.Name = "DGVAdmin";
            DGVAdmin.RowHeadersWidth = 51;
            DGVAdmin.RowTemplate.Height = 29;
            DGVAdmin.Size = new Size(1626, 834);
            DGVAdmin.TabIndex = 1;
            DGVAdmin.CellContentClick += DGVAdmin_CellContentClick;
            // 
            // AdminID
            // 
            AdminID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AdminID.HeaderText = "Admin ID";
            AdminID.MinimumWidth = 6;
            AdminID.Name = "AdminID";
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
            // CreateAdminBtn
            // 
            CreateAdminBtn.BackColor = Color.FromArgb(63, 255, 0);
            CreateAdminBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CreateAdminBtn.ForeColor = Color.Black;
            CreateAdminBtn.Location = new Point(1395, 0);
            CreateAdminBtn.Name = "CreateAdminBtn";
            CreateAdminBtn.Size = new Size(207, 61);
            CreateAdminBtn.TabIndex = 3;
            CreateAdminBtn.Text = "Create Admin";
            CreateAdminBtn.UseVisualStyleBackColor = false;
            CreateAdminBtn.Click += CreateAdminBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1626, 53);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(235, 24);
            label1.TabIndex = 0;
            label1.Text = "Create Admin Account";
            // 
            // CreateAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1626, 953);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAdminForm";
            Text = "CreateAdminForm";
            Load += CreateAdminForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAdmin).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button CreateAdminBtn;
        private Panel panel4;
        private DataGridView DGVAdmin;
        private DataGridViewTextBoxColumn AdminID;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewImageColumn EditBtn;
        private DataGridViewImageColumn DeleteBtn;
        private Panel panel6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label2;
        private Button SearchBtn;
        private TextBox SearchTxt;
    }
}