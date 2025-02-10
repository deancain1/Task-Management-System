namespace Task_Management_System.Presentation.AdminInterface
{
    partial class CreateTaskForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            DGVTasks = new DataGridView();
            TaskID = new DataGridViewTextBoxColumn();
            TaskTitle = new DataGridViewTextBoxColumn();
            TaskDescription = new DataGridViewTextBoxColumn();
            StartTime = new DataGridViewTextBoxColumn();
            Deadline = new DataGridViewTextBoxColumn();
            AssignTo = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            EditBtn = new DataGridViewImageColumn();
            DeleteBtn = new DataGridViewImageColumn();
            AssignTaskBtn = new Button();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTasks).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1626, 53);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(147, 24);
            label1.TabIndex = 1;
            label1.Text = "CREATE TASK";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 66);
            panel4.Name = "panel4";
            panel4.Size = new Size(1629, 49);
            panel4.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(1528, 14);
            label9.Name = "label9";
            label9.Size = new Size(73, 22);
            label9.TabIndex = 9;
            label9.Text = "Actions";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(1445, 15);
            label8.Name = "label8";
            label8.Size = new Size(63, 22);
            label8.TabIndex = 8;
            label8.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(1265, 15);
            label7.Name = "label7";
            label7.Size = new Size(92, 22);
            label7.TabIndex = 7;
            label7.Text = "Assign To";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1019, 15);
            label6.Name = "label6";
            label6.Size = new Size(85, 22);
            label6.TabIndex = 6;
            label6.Text = "Deadline";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(780, 15);
            label5.Name = "label5";
            label5.Size = new Size(98, 22);
            label5.TabIndex = 5;
            label5.Text = "Start Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(538, 15);
            label4.Name = "label4";
            label4.Size = new Size(150, 22);
            label4.TabIndex = 4;
            label4.Text = "Task Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(345, 14);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 3;
            label3.Text = "Task Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(125, 15);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 2;
            label2.Text = "Task ID";
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(AssignTaskBtn);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(1626, 900);
            panel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_search;
            button1.Location = new Point(415, 8);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(397, 38);
            textBox1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(DGVTasks);
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(1626, 834);
            panel1.TabIndex = 3;
            // 
            // DGVTasks
            // 
            DGVTasks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVTasks.BackgroundColor = Color.White;
            DGVTasks.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DGVTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVTasks.ColumnHeadersHeight = 50;
            DGVTasks.Columns.AddRange(new DataGridViewColumn[] { TaskID, TaskTitle, TaskDescription, StartTime, Deadline, AssignTo, Status, EditBtn, DeleteBtn });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DGVTasks.DefaultCellStyle = dataGridViewCellStyle7;
            DGVTasks.Location = new Point(0, 0);
            DGVTasks.Name = "DGVTasks";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            DGVTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DGVTasks.RowHeadersWidth = 51;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DGVTasks.RowsDefaultCellStyle = dataGridViewCellStyle9;
            DGVTasks.RowTemplate.Height = 50;
            DGVTasks.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DGVTasks.ShowCellToolTips = false;
            DGVTasks.Size = new Size(1626, 709);
            DGVTasks.TabIndex = 0;
            DGVTasks.CellContentClick += DGVTasks_CellContentClick;
            DGVTasks.CellFormatting += DGVTasks_CellFormatting;
            // 
            // TaskID
            // 
            TaskID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TaskID.DefaultCellStyle = dataGridViewCellStyle2;
            TaskID.HeaderText = "Task ID";
            TaskID.MinimumWidth = 6;
            TaskID.Name = "TaskID";
            // 
            // TaskTitle
            // 
            TaskTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TaskTitle.HeaderText = "Task Title";
            TaskTitle.MinimumWidth = 6;
            TaskTitle.Name = "TaskTitle";
            // 
            // TaskDescription
            // 
            TaskDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            TaskDescription.DefaultCellStyle = dataGridViewCellStyle3;
            TaskDescription.HeaderText = "TaskDescription";
            TaskDescription.MinimumWidth = 6;
            TaskDescription.Name = "TaskDescription";
            TaskDescription.ReadOnly = true;
            TaskDescription.Width = 200;
            // 
            // StartTime
            // 
            StartTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StartTime.DefaultCellStyle = dataGridViewCellStyle4;
            StartTime.HeaderText = "Start Time";
            StartTime.MinimumWidth = 6;
            StartTime.Name = "StartTime";
            // 
            // Deadline
            // 
            Deadline.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Deadline.DefaultCellStyle = dataGridViewCellStyle5;
            Deadline.HeaderText = "Deadline";
            Deadline.MinimumWidth = 6;
            Deadline.Name = "Deadline";
            // 
            // AssignTo
            // 
            AssignTo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AssignTo.HeaderText = "Assign To";
            AssignTo.MinimumWidth = 6;
            AssignTo.Name = "AssignTo";
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            Status.DefaultCellStyle = dataGridViewCellStyle6;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 85;
            // 
            // EditBtn
            // 
            EditBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EditBtn.HeaderText = "Edit";
            EditBtn.Image = Properties.Resources.icons8_edit_25__1_;
            EditBtn.MinimumWidth = 6;
            EditBtn.Name = "EditBtn";
            EditBtn.Width = 43;
            // 
            // DeleteBtn
            // 
            DeleteBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DeleteBtn.HeaderText = "Delete";
            DeleteBtn.Image = Properties.Resources.icons8_delete_25;
            DeleteBtn.MinimumWidth = 6;
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Width = 63;
            // 
            // AssignTaskBtn
            // 
            AssignTaskBtn.BackColor = Color.MediumSeaGreen;
            AssignTaskBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AssignTaskBtn.ForeColor = Color.White;
            AssignTaskBtn.Location = new Point(1415, 3);
            AssignTaskBtn.Name = "AssignTaskBtn";
            AssignTaskBtn.Size = new Size(207, 61);
            AssignTaskBtn.TabIndex = 2;
            AssignTaskBtn.Text = "Assign New Task";
            AssignTaskBtn.UseVisualStyleBackColor = false;
            AssignTaskBtn.Click += AssignTaskBtn_Click;
            // 
            // CreateTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1626, 953);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateTaskForm";
            Text = "CreateTaskForm";
            Load += CreateTaskForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Button AssignTaskBtn;
        private Panel panel1;
        private Panel panel4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label9;
        private DataGridView DGVTasks;
        private DataGridViewTextBoxColumn TaskID;
        private DataGridViewTextBoxColumn TaskTitle;
        private DataGridViewTextBoxColumn TaskDescription;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn Deadline;
        private DataGridViewTextBoxColumn AssignTo;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewImageColumn EditBtn;
        private DataGridViewImageColumn DeleteBtn;
    }
}