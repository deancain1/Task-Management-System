namespace Task_Management_System.Presentation.User_Control
{
    partial class CompletedTaskControl
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
            EndTimeLbl = new Label();
            StartTImeLbl = new Label();
            TaskDescriptionLbl = new Label();
            TaskTitleLbl = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
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
            TaskIDLbl.Location = new Point(12, 6);
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
            label2.Location = new Point(34, 381);
            label2.Name = "label2";
            label2.Size = new Size(122, 18);
            label2.TabIndex = 23;
            label2.Text = "Current Status:";
            // 
            // StatusLbl
            // 
            StatusLbl.BorderStyle = BorderStyle.FixedSingle;
            StatusLbl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StatusLbl.Location = new Point(162, 380);
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
            label8.Location = new Point(77, 314);
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
            label7.Location = new Point(65, 243);
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
            label6.Location = new Point(18, 106);
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
            label5.Location = new Point(70, 39);
            label5.Name = "label5";
            label5.Size = new Size(86, 18);
            label5.TabIndex = 16;
            label5.Text = "Task Title:";
            // 
            // EndTimeLbl
            // 
            EndTimeLbl.BorderStyle = BorderStyle.FixedSingle;
            EndTimeLbl.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            EndTimeLbl.Location = new Point(162, 310);
            EndTimeLbl.Name = "EndTimeLbl";
            EndTimeLbl.Size = new Size(413, 39);
            EndTimeLbl.TabIndex = 15;
            EndTimeLbl.Text = "label4";
            // 
            // StartTImeLbl
            // 
            StartTImeLbl.BorderStyle = BorderStyle.FixedSingle;
            StartTImeLbl.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            StartTImeLbl.Location = new Point(162, 243);
            StartTImeLbl.Name = "StartTImeLbl";
            StartTImeLbl.Size = new Size(413, 39);
            StartTImeLbl.TabIndex = 14;
            StartTImeLbl.Text = "label3";
            // 
            // TaskDescriptionLbl
            // 
            TaskDescriptionLbl.BorderStyle = BorderStyle.FixedSingle;
            TaskDescriptionLbl.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TaskDescriptionLbl.Location = new Point(162, 105);
            TaskDescriptionLbl.Name = "TaskDescriptionLbl";
            TaskDescriptionLbl.Size = new Size(411, 114);
            TaskDescriptionLbl.TabIndex = 13;
            TaskDescriptionLbl.Text = "label2";
            // 
            // TaskTitleLbl
            // 
            TaskTitleLbl.BorderStyle = BorderStyle.FixedSingle;
            TaskTitleLbl.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TaskTitleLbl.Location = new Point(162, 38);
            TaskTitleLbl.Name = "TaskTitleLbl";
            TaskTitleLbl.Size = new Size(411, 39);
            TaskTitleLbl.TabIndex = 12;
            TaskTitleLbl.Text = "label1";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 483);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(615, 483);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(TaskIDLbl);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(StatusLbl);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(EndTimeLbl);
            panel4.Controls.Add(StartTImeLbl);
            panel4.Controls.Add(TaskDescriptionLbl);
            panel4.Controls.Add(TaskTitleLbl);
            panel4.Location = new Point(7, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(596, 457);
            panel4.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 483);
            panel1.TabIndex = 1;
            // 
            // CompletedTaskControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "CompletedTaskControl";
            Size = new Size(615, 483);
            Load += CompletedTaskControl_Load;
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
        private Label EndTimeLbl;
        private Label StartTImeLbl;
        private Label TaskDescriptionLbl;
        private Label TaskTitleLbl;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
    }
}
