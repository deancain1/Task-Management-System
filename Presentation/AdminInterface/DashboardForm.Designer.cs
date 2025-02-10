namespace Task_Management_System.Presentation.AdminInterface
{
    partial class DashboardForm
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
            NumberUsers = new Panel();
            pictureBox4 = new PictureBox();
            InCompleteTaskLbl = new Label();
            label4 = new Label();
            ChartPanel = new Panel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            CompletedTaskLbl = new Label();
            label8 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            monthCalendar1 = new MonthCalendar();
            panel9 = new Panel();
            InProgressLbl = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            panel3 = new Panel();
            TotalTaskLbl = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            NumberUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(NumberUsers);
            panel1.Controls.Add(ChartPanel);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1597, 953);
            panel1.TabIndex = 0;
            // 
            // NumberUsers
            // 
            NumberUsers.BackColor = Color.IndianRed;
            NumberUsers.Controls.Add(pictureBox4);
            NumberUsers.Controls.Add(InCompleteTaskLbl);
            NumberUsers.Controls.Add(label4);
            NumberUsers.Location = new Point(417, 102);
            NumberUsers.Name = "NumberUsers";
            NumberUsers.Size = new Size(367, 177);
            NumberUsers.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icon31;
            pictureBox4.Location = new Point(234, 21);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 120);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // InCompleteTaskLbl
            // 
            InCompleteTaskLbl.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            InCompleteTaskLbl.ForeColor = Color.White;
            InCompleteTaskLbl.Location = new Point(22, 58);
            InCompleteTaskLbl.Name = "InCompleteTaskLbl";
            InCompleteTaskLbl.Size = new Size(120, 59);
            InCompleteTaskLbl.TabIndex = 1;
            InCompleteTaskLbl.Text = "5";
            InCompleteTaskLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 34);
            label4.Name = "label4";
            label4.Size = new Size(178, 24);
            label4.TabIndex = 0;
            label4.Text = "Incomplete Task";
            // 
            // ChartPanel
            // 
            ChartPanel.BorderStyle = BorderStyle.FixedSingle;
            ChartPanel.Location = new Point(44, 347);
            ChartPanel.Name = "ChartPanel";
            ChartPanel.Size = new Size(929, 461);
            ChartPanel.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MediumSeaGreen;
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(CompletedTaskLbl);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(1203, 102);
            panel5.Name = "panel5";
            panel5.Size = new Size(367, 177);
            panel5.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon1;
            pictureBox1.Location = new Point(233, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // CompletedTaskLbl
            // 
            CompletedTaskLbl.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            CompletedTaskLbl.ForeColor = Color.White;
            CompletedTaskLbl.Location = new Point(34, 58);
            CompletedTaskLbl.Name = "CompletedTaskLbl";
            CompletedTaskLbl.Size = new Size(120, 59);
            CompletedTaskLbl.TabIndex = 1;
            CompletedTaskLbl.Text = "5";
            CompletedTaskLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 34);
            label8.Name = "label8";
            label8.Size = new Size(170, 24);
            label8.TabIndex = 0;
            label8.Text = "Completed Task";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(monthCalendar1);
            panel4.Location = new Point(1093, 397);
            panel4.Name = "panel4";
            panel4.Size = new Size(306, 270);
            panel4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.MediumSlateBlue;
            label6.Location = new Point(91, 10);
            label6.Name = "label6";
            label6.Size = new Size(119, 24);
            label6.TabIndex = 0;
            label6.Text = "CALENDAR";
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.RosyBrown;
            monthCalendar1.ForeColor = Color.DarkRed;
            monthCalendar1.Location = new Point(20, 43);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.BackColor = Color.MediumSlateBlue;
            panel9.Controls.Add(InProgressLbl);
            panel9.Controls.Add(pictureBox3);
            panel9.Controls.Add(label5);
            panel9.Location = new Point(810, 102);
            panel9.Name = "panel9";
            panel9.Size = new Size(367, 177);
            panel9.TabIndex = 7;
            // 
            // InProgressLbl
            // 
            InProgressLbl.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            InProgressLbl.ForeColor = Color.White;
            InProgressLbl.Location = new Point(24, 58);
            InProgressLbl.Name = "InProgressLbl";
            InProgressLbl.Size = new Size(120, 59);
            InProgressLbl.TabIndex = 3;
            InProgressLbl.Text = "5";
            InProgressLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icon2;
            pictureBox3.Location = new Point(235, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 120);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 34);
            label5.Name = "label5";
            label5.Size = new Size(127, 24);
            label5.TabIndex = 0;
            label5.Text = "In Progress";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.Controls.Add(TotalTaskLbl);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(22, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(367, 177);
            panel3.TabIndex = 6;
            // 
            // TotalTaskLbl
            // 
            TotalTaskLbl.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            TotalTaskLbl.ForeColor = Color.White;
            TotalTaskLbl.Location = new Point(11, 58);
            TotalTaskLbl.Name = "TotalTaskLbl";
            TotalTaskLbl.Size = new Size(120, 59);
            TotalTaskLbl.TabIndex = 4;
            TotalTaskLbl.Text = "5";
            TotalTaskLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icon3;
            pictureBox2.Location = new Point(234, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 34);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 0;
            label2.Text = "Total Task";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1597, 53);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(140, 24);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1597, 953);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            panel1.ResumeLayout(false);
            NumberUsers.ResumeLayout(false);
            NumberUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel9;
        private PictureBox pictureBox3;
        private Label label5;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel2;
        private Panel panel4;
        private Label label6;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label CompletedTaskLbl;
        private Label label8;
        private Panel ChartPanel;
        private Label InProgressLbl;
        private Label TotalTaskLbl;
        private Panel NumberUsers;
        private PictureBox pictureBox4;
        private Label InCompleteTaskLbl;
        private Label label4;
    }
}