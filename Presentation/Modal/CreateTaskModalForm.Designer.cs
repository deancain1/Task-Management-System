namespace Task_Management_System.Presentation.Modal
{
    partial class CreateTaskModalForm
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
            ClearBtn = new Button();
            TaskDescriptionTxt = new RichTextBox();
            StatusLbl = new Label();
            label1 = new Label();
            UsersCB = new ComboBox();
            AssignTaskBtn = new Button();
            panel3 = new Panel();
            CloseBtn = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            EndTimeDate = new DateTimePicker();
            StartTimeDate = new DateTimePicker();
            TaskTitleTxt = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ClearBtn);
            panel1.Controls.Add(TaskDescriptionTxt);
            panel1.Controls.Add(StatusLbl);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UsersCB);
            panel1.Controls.Add(AssignTaskBtn);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(EndTimeDate);
            panel1.Controls.Add(StartTimeDate);
            panel1.Controls.Add(TaskTitleTxt);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 618);
            panel1.TabIndex = 0;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.FromArgb(242, 92, 56);
            ClearBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(648, 406);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(229, 62);
            ClearBtn.TabIndex = 16;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // TaskDescriptionTxt
            // 
            TaskDescriptionTxt.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TaskDescriptionTxt.Location = new Point(105, 227);
            TaskDescriptionTxt.Name = "TaskDescriptionTxt";
            TaskDescriptionTxt.Size = new Size(492, 241);
            TaskDescriptionTxt.TabIndex = 15;
            TaskDescriptionTxt.Text = "";
            // 
            // StatusLbl
            // 
            StatusLbl.AutoSize = true;
            StatusLbl.Location = new Point(105, 486);
            StatusLbl.Name = "StatusLbl";
            StatusLbl.Size = new Size(84, 20);
            StatusLbl.TabIndex = 14;
            StatusLbl.Text = "Incomplete";
            StatusLbl.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(650, 287);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 13;
            label1.Text = "Assign to:";
            // 
            // UsersCB
            // 
            UsersCB.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UsersCB.FormattingEnabled = true;
            UsersCB.Location = new Point(650, 325);
            UsersCB.Name = "UsersCB";
            UsersCB.Size = new Size(462, 36);
            UsersCB.TabIndex = 12;
            // 
            // AssignTaskBtn
            // 
            AssignTaskBtn.BackColor = Color.FromArgb(0, 151, 178);
            AssignTaskBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AssignTaskBtn.ForeColor = Color.White;
            AssignTaskBtn.Location = new Point(883, 406);
            AssignTaskBtn.Name = "AssignTaskBtn";
            AssignTaskBtn.Size = new Size(229, 62);
            AssignTaskBtn.TabIndex = 11;
            AssignTaskBtn.Text = "Assign Task";
            AssignTaskBtn.UseVisualStyleBackColor = false;
            AssignTaskBtn.Click += AssignTaskBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(CloseBtn);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1185, 53);
            panel3.TabIndex = 10;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseBtn.ForeColor = Color.DarkRed;
            CloseBtn.Location = new Point(1150, 13);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(24, 24);
            CloseBtn.TabIndex = 12;
            CloseBtn.Text = "X";
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(11, 15);
            label6.Name = "label6";
            label6.Size = new Size(161, 22);
            label6.TabIndex = 12;
            label6.Text = "Assign New Task\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(650, 188);
            label5.Name = "label5";
            label5.Size = new Size(106, 24);
            label5.TabIndex = 9;
            label5.Text = "Deadline:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(650, 96);
            label4.Name = "label4";
            label4.Size = new Size(122, 24);
            label4.TabIndex = 8;
            label4.Text = "Start Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(105, 188);
            label3.Name = "label3";
            label3.Size = new Size(184, 24);
            label3.TabIndex = 7;
            label3.Text = "Task Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(105, 96);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 6;
            label2.Text = "Task Title:";
            // 
            // EndTimeDate
            // 
            EndTimeDate.CustomFormat = "MMM/dd/ yyyy hh:mm:ss tt";
            EndTimeDate.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EndTimeDate.Format = DateTimePickerFormat.Custom;
            EndTimeDate.Location = new Point(650, 227);
            EndTimeDate.Name = "EndTimeDate";
            EndTimeDate.Size = new Size(462, 35);
            EndTimeDate.TabIndex = 5;
            EndTimeDate.Value = new DateTime(2025, 1, 20, 20, 5, 0, 0);
            // 
            // StartTimeDate
            // 
            StartTimeDate.CustomFormat = "MMM/dd/ yyyy hh:mm:ss tt";
            StartTimeDate.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            StartTimeDate.Format = DateTimePickerFormat.Custom;
            StartTimeDate.Location = new Point(653, 135);
            StartTimeDate.Name = "StartTimeDate";
            StartTimeDate.Size = new Size(459, 35);
            StartTimeDate.TabIndex = 3;
            // 
            // TaskTitleTxt
            // 
            TaskTitleTxt.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TaskTitleTxt.Location = new Point(105, 137);
            TaskTitleTxt.Name = "TaskTitleTxt";
            TaskTitleTxt.Size = new Size(492, 35);
            TaskTitleTxt.TabIndex = 1;
            // 
            // CreateTaskModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 618);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateTaskModalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateTaskModalForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker StartTimeDate;
        private TextBox TaskTitleTxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker EndTimeDate;
        private Panel panel3;
        private Label CloseBtn;
        private Label label6;
        private Button AssignTaskBtn;
        private Label label1;
        private ComboBox UsersCB;
        private Label StatusLbl;
        private RichTextBox TaskDescriptionTxt;
        private Button ClearBtn;
    }
}