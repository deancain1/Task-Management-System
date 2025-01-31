namespace Task_Management_System.Presentation.Modal
{
    partial class EditTaskModalForm
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
            TaskIDLbl = new Label();
            label1 = new Label();
            StatusCB = new ComboBox();
            UpdateTaskBtn = new Button();
            panel3 = new Panel();
            CloseBtn = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            EndTimeDate = new DateTimePicker();
            StartTimeDate = new DateTimePicker();
            TaskDescriptionTxt = new TextBox();
            TaskTitleTxt = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(TaskIDLbl);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(StatusCB);
            panel1.Controls.Add(UpdateTaskBtn);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(EndTimeDate);
            panel1.Controls.Add(StartTimeDate);
            panel1.Controls.Add(TaskDescriptionTxt);
            panel1.Controls.Add(TaskTitleTxt);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 626);
            panel1.TabIndex = 1;
            // 
            // TaskIDLbl
            // 
            TaskIDLbl.AutoSize = true;
            TaskIDLbl.Location = new Point(83, 98);
            TaskIDLbl.Name = "TaskIDLbl";
            TaskIDLbl.Size = new Size(50, 20);
            TaskIDLbl.TabIndex = 14;
            TaskIDLbl.Text = "label7";
            TaskIDLbl.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 470);
            label1.Name = "label1";
            label1.Size = new Size(160, 24);
            label1.TabIndex = 13;
            label1.Text = "Update Status:";
            // 
            // StatusCB
            // 
            StatusCB.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            StatusCB.FormattingEnabled = true;
            StatusCB.Items.AddRange(new object[] { "Incomplete\t", "In Progress", "Completed" });
            StatusCB.Location = new Point(338, 464);
            StatusCB.Name = "StatusCB";
            StatusCB.Size = new Size(459, 36);
            StatusCB.TabIndex = 12;
            // 
            // UpdateTaskBtn
            // 
            UpdateTaskBtn.BackColor = Color.DarkCyan;
            UpdateTaskBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateTaskBtn.ForeColor = Color.White;
            UpdateTaskBtn.Location = new Point(338, 551);
            UpdateTaskBtn.Name = "UpdateTaskBtn";
            UpdateTaskBtn.Size = new Size(459, 62);
            UpdateTaskBtn.TabIndex = 11;
            UpdateTaskBtn.Text = "Update";
            UpdateTaskBtn.UseVisualStyleBackColor = false;
            UpdateTaskBtn.Click += UpdateTaskBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Controls.Add(CloseBtn);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1070, 53);
            panel3.TabIndex = 10;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseBtn.ForeColor = Color.DarkRed;
            CloseBtn.Location = new Point(1028, 13);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(24, 24);
            CloseBtn.TabIndex = 12;
            CloseBtn.Text = "X";
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(424, 13);
            label6.Name = "label6";
            label6.Size = new Size(229, 28);
            label6.TabIndex = 12;
            label6.Text = "Edit Assigned Task";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(219, 395);
            label5.Name = "label5";
            label5.Size = new Size(106, 24);
            label5.TabIndex = 9;
            label5.Text = "Deadline:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(207, 316);
            label4.Name = "label4";
            label4.Size = new Size(122, 24);
            label4.TabIndex = 8;
            label4.Text = "Start Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(145, 143);
            label3.Name = "label3";
            label3.Size = new Size(184, 24);
            label3.TabIndex = 7;
            label3.Text = "Task Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(216, 74);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 6;
            label2.Text = "Task Title:";
            // 
            // EndTimeDate
            // 
            EndTimeDate.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EndTimeDate.Location = new Point(338, 390);
            EndTimeDate.Name = "EndTimeDate";
            EndTimeDate.Size = new Size(459, 35);
            EndTimeDate.TabIndex = 5;
            EndTimeDate.Value = new DateTime(2025, 1, 20, 20, 5, 0, 0);
            // 
            // StartTimeDate
            // 
            StartTimeDate.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            StartTimeDate.Location = new Point(338, 311);
            StartTimeDate.Name = "StartTimeDate";
            StartTimeDate.Size = new Size(459, 35);
            StartTimeDate.TabIndex = 3;
            // 
            // TaskDescriptionTxt
            // 
            TaskDescriptionTxt.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TaskDescriptionTxt.Location = new Point(338, 137);
            TaskDescriptionTxt.Multiline = true;
            TaskDescriptionTxt.Name = "TaskDescriptionTxt";
            TaskDescriptionTxt.Size = new Size(459, 137);
            TaskDescriptionTxt.TabIndex = 2;
            // 
            // TaskTitleTxt
            // 
            TaskTitleTxt.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TaskTitleTxt.Location = new Point(338, 68);
            TaskTitleTxt.Name = "TaskTitleTxt";
            TaskTitleTxt.Size = new Size(459, 35);
            TaskTitleTxt.TabIndex = 1;
            // 
            // EditTaskModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 626);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditTaskModalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditTaskModalForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label TaskIDLbl;
        private Label label1;
        private ComboBox StatusCB;
        private Button UpdateTaskBtn;
        private Panel panel3;
        private Label CloseBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker EndTimeDate;
        private DateTimePicker StartTimeDate;
        private TextBox TaskDescriptionTxt;
        private TextBox TaskTitleTxt;
    }
}