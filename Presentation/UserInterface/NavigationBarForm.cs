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
using Task_Management_System.Domain.Entities;
using Task_Management_System.Presentation.AdminInterface;
using Task_Management_System.Presentation.Modal;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation.UserInterface
{
    public partial class NavigationBarForm : Form
    {
        public UserEntity? currentUser;
        public NavigationBarForm()
        {
            InitializeComponent();
            var homeForm = Program.ServiceProvider.GetRequiredService<HomeForm>();
            LoadForm(MainPanel, homeForm);

        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            var homeForm = Program.ServiceProvider.GetRequiredService<HomeForm>();
            LoadForm(MainPanel, homeForm);
        }
        private void TaskBtn_Click(object sender, EventArgs e)
        {
            var tasksForm = Program.ServiceProvider.GetRequiredService<TasksForm>();
            LoadForm(MainPanel, tasksForm);
        }
        private void CompletedBtn_Click(object sender, EventArgs e)
        {
            var completedTaskForm = Program.ServiceProvider.GetRequiredService<CompletedTaskForm>();
            LoadForm(MainPanel, completedTaskForm);

        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm?.Show();

        }
        public void LoadForm(Panel mainPanel, Form newForm)
        {
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.Clear();
                newForm.TopLevel = false;
                newForm.Dock = DockStyle.Fill;

                mainPanel.Controls.Add(newForm);
                mainPanel.Tag = newForm;
                newForm.Show();
        }

        private void NavigationBarForm_Load(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                UserLbl.Text = $"{"Welcome back! " + currentUser.FirstName} ";

            }
        }
    }
}
