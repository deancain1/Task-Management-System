namespace Task_Management_System.Presentation.User_Control
{
    partial class DisplayTaskControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TaskIDLbl = new Label();
            label2 = new Label();
            StatusLbl = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            DeadlineLbl = new Label();
            StartTImeLbl = new Label();
            TaskTitleLbl = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            TaskDescriptionLbl = new RichTextBox();
            UpdateBtn = new Button();
            label1 = new Label();
            StatusCB = new ComboBox();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TaskIDLbl
            // 
            TaskIDLbl.BorderStyle = BorderStyle.FixedSingle;
            TaskIDLbl.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TaskIDLbl.Location = new Point(4, 107);
            TaskIDLbl.Name = "TaskIDLbl";
            TaskIDLbl.Size = new Size(58, 25);
            TaskIDLbl.TabIndex = 24;
            TaskIDLbl.Text = "label1";
            TaskIDLbl.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 151, 178);
            label2.Location = new Point(20, 321);
            label2.Name = "label2";
            label2.Size = new Size(122, 18);
            label2.TabIndex = 23;
            label2.Text = "Current Status:";
            // 
            // StatusLbl
            // 
            StatusLbl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StatusLbl.Location = new Point(149, 321);
            StatusLbl.Name = "StatusLbl";
            StatusLbl.Size = new Size(127, 35);
            StatusLbl.TabIndex = 22;
            StatusLbl.Text = "label1";
            StatusLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 151, 178);
            label8.Location = new Point(62, 236);
            label8.Name = "label8";
            label8.Size = new Size(79, 18);
            label8.TabIndex = 19;
            label8.Text = "Deadline:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 151, 178);
            label7.Location = new Point(50, 188);
            label7.Name = "label7";
            label7.Size = new Size(91, 18);
            label7.TabIndex = 18;
            label7.Text = "Start Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 151, 178);
            label6.Location = new Point(4, 69);
            label6.Name = "label6";
            label6.Size = new Size(138, 18);
            label6.TabIndex = 17;
            label6.Text = "Task Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 151, 178);
            label5.Location = new Point(55, 18);
            label5.Name = "label5";
            label5.Size = new Size(86, 18);
            label5.TabIndex = 16;
            label5.Text = "Task Title:";
            // 
            // DeadlineLbl
            // 
            DeadlineLbl.BorderStyle = BorderStyle.FixedSingle;
            DeadlineLbl.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            DeadlineLbl.Location = new Point(149, 236);
            DeadlineLbl.Name = "DeadlineLbl";
            DeadlineLbl.Size = new Size(296, 39);
            DeadlineLbl.TabIndex = 15;
            DeadlineLbl.Text = "label4";
            // 
            // StartTImeLbl
            // 
            StartTImeLbl.BorderStyle = BorderStyle.FixedSingle;
            StartTImeLbl.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            StartTImeLbl.Location = new Point(149, 188);
            StartTImeLbl.Name = "StartTImeLbl";
            StartTImeLbl.Size = new Size(296, 39);
            StartTImeLbl.TabIndex = 14;
            StartTImeLbl.Text = "label3";
            // 
            // TaskTitleLbl
            // 
            TaskTitleLbl.BorderStyle = BorderStyle.FixedSingle;
            TaskTitleLbl.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TaskTitleLbl.Location = new Point(147, 17);
            TaskTitleLbl.Name = "TaskTitleLbl";
            TaskTitleLbl.Size = new Size(296, 39);
            TaskTitleLbl.TabIndex = 12;
            TaskTitleLbl.Text = "label1";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(473, 406);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(473, 406);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(TaskDescriptionLbl);
            panel4.Controls.Add(UpdateBtn);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(StatusCB);
            panel4.Controls.Add(TaskIDLbl);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(StatusLbl);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(DeadlineLbl);
            panel4.Controls.Add(StartTImeLbl);
            panel4.Controls.Add(TaskTitleLbl);
            panel4.Location = new Point(4, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(463, 370);
            panel4.TabIndex = 0;
            // 
            // TaskDescriptionLbl
            // 
            TaskDescriptionLbl.BackColor = Color.White;
            TaskDescriptionLbl.BorderStyle = BorderStyle.FixedSingle;
            TaskDescriptionLbl.Location = new Point(147, 66);
            TaskDescriptionLbl.Name = "TaskDescriptionLbl";
            TaskDescriptionLbl.ReadOnly = true;
            TaskDescriptionLbl.Size = new Size(296, 114);
            TaskDescriptionLbl.TabIndex = 29;
            TaskDescriptionLbl.Text = "";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.LightSeaGreen;
            UpdateBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(305, 321);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(140, 45);
            UpdateBtn.TabIndex = 27;
            UpdateBtn.Text = "Update ";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 151, 178);
            label1.Location = new Point(23, 284);
            label1.Name = "label1";
            label1.Size = new Size(118, 18);
            label1.TabIndex = 26;
            label1.Text = "Update Status:";
            // 
            // StatusCB
            // 
            StatusCB.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            StatusCB.FormattingEnabled = true;
            StatusCB.Items.AddRange(new object[] { "Not Started", "Incomplete", "In Progress", "Completed" });
            StatusCB.Location = new Point(149, 284);
            StatusCB.Name = "StatusCB";
            StatusCB.Size = new Size(296, 30);
            StatusCB.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 406);
            panel1.TabIndex = 2;
            // 
            // DisplayTaskControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "DisplayTaskControl";
            Size = new Size(473, 406);
            Load += DisplayTaskControl_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label TaskIDLbl;
        private Label label2;
        private Label StatusLbl;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label DeadlineLbl;
        private Label StartTImeLbl;
        private Label TaskTitleLbl;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ComboBox StatusCB;
        private Panel panel1;
        private Button UpdateBtn;
        private Label label1;
        private RichTextBox TaskDescriptionLbl;
    }
}
