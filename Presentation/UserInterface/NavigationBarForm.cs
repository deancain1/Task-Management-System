using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Presentation.AdminInterface;
using Task_Management_System.Presentation.Modal;

namespace Task_Management_System.Presentation.UserInterface
{
    public partial class NavigationBarForm : Form
    {
        public NavigationBarForm()
        {
            InitializeComponent();
            ShowForm(new HomeForm());
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ShowForm(new HomeForm());
        }
        private void TaskBtn_Click(object sender, EventArgs e)
        {
          
       
            var tasksForm = Program.ServiceProvider.GetRequiredService<TasksForm>();
            
            ShowForm(tasksForm);
            tasksForm.Refresh();
        }
        private void CompletedBtn_Click(object sender, EventArgs e)
        {
            var completedTaskForm = Program.ServiceProvider.GetRequiredService<CompletedTaskForm>();
           
            ShowForm(completedTaskForm);
            completedTaskForm.Refresh();
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm.Show(); // Show the LoginForm

        }
        public void ShowForm(object form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form? f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();

        }


    }
}
