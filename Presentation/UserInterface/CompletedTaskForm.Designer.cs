namespace Task_Management_System.Presentation.UserInterface
{
    partial class CompletedTaskForm
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
            panel2 = new Panel();
            FLPTasks = new FlowLayoutPanel();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(1906, 896);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(FLPTasks);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(1906, 839);
            panel2.TabIndex = 3;
            // 
            // FLPTasks
            // 
            FLPTasks.AutoScroll = true;
            FLPTasks.BackColor = Color.WhiteSmoke;
            FLPTasks.Dock = DockStyle.Fill;
            FLPTasks.Location = new Point(0, 0);
            FLPTasks.Name = "FLPTasks";
            FLPTasks.Size = new Size(1906, 839);
            FLPTasks.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1906, 57);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 151, 178);
            label1.Location = new Point(847, 11);
            label1.Name = "label1";
            label1.Size = new Size(301, 37);
            label1.TabIndex = 0;
            label1.Text = "Accomplished Tasks";
            // 
            // CompletedTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1906, 896);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CompletedTaskForm";
            Text = "CompletedTaskForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel FLPTasks;
        private Panel panel3;
        private Label label1;
    }
}