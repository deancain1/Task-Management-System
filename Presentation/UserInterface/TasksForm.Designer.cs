namespace Task_Management_System.Presentation.UserInterface
{
    partial class TasksForm
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
            FLPTasks = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            SearchBtn = new Button();
            SearchTxt = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // FLPTasks
            // 
            FLPTasks.AutoScroll = true;
            FLPTasks.BackColor = Color.White;
            FLPTasks.Dock = DockStyle.Fill;
            FLPTasks.Location = new Point(0, 0);
            FLPTasks.Name = "FLPTasks";
            FLPTasks.Size = new Size(1924, 886);
            FLPTasks.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 943);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(FLPTasks);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 886);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(SearchBtn);
            panel3.Controls.Add(SearchTxt);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1924, 57);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(664, 14);
            label2.Name = "label2";
            label2.Size = new Size(139, 24);
            label2.TabIndex = 13;
            label2.Text = "Search Task:";
            // 
            // SearchBtn
            // 
            SearchBtn.Image = Properties.Resources.icons8_search;
            SearchBtn.Location = new Point(1211, 3);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(50, 50);
            SearchBtn.TabIndex = 12;
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchTxt
            // 
            SearchTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTxt.Location = new Point(812, 8);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(397, 38);
            SearchTxt.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 151, 178);
            label1.Location = new Point(1544, 9);
            label1.Name = "label1";
            label1.Size = new Size(326, 37);
            label1.TabIndex = 0;
            label1.Text = "Task to be Completed";
            // 
            // TasksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 943);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TasksForm";
            Text = "TasksForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FLPTasks;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Button SearchBtn;
        private TextBox SearchTxt;
        private Label label1;
    }
}