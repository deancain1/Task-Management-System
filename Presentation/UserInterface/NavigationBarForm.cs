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


        private void NavigationBarForm_Load(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                UserLbl.Text = $"{"Welcome back! " + currentUser.FirstName} ";

            }
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            var homeForm = Program.ServiceProvider.GetRequiredService<HomeForm>();
            LoadForm(MainPanel, homeForm);
        }

        private void TasksBtn_Click(object sender, EventArgs e)
        {
            var tasksForm = Program.ServiceProvider.GetRequiredService<TasksForm>();
            LoadForm(MainPanel, tasksForm);
        }

        private void CompletedBtn_Click(object sender, EventArgs e)
        {
            var completedTaskForm = Program.ServiceProvider.GetRequiredService<CompletedTaskForm>();
            LoadForm(MainPanel, completedTaskForm);
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            var profileForm = Program.ServiceProvider.GetRequiredService<ProfileForm>();
            LoadForm(MainPanel, profileForm);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm?.Show();
            this.Close();
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

        private void HomeBtn_MouseMove(object sender, MouseEventArgs e)
        {

            HomeBtn.BackColor = Color.LightSeaGreen;
            HomeBtn.ForeColor = Color.DarkSlateGray;
        }

        private void HomeBtn_MouseLeave(object sender, EventArgs e)
        {
            HomeBtn.BackColor = Color.DarkSlateGray;
            HomeBtn.ForeColor = Color.White;
        }

        private void TasksBtn_MouseMove(object sender, MouseEventArgs e)
        {
            TasksBtn.BackColor = Color.LightSeaGreen;
            TasksBtn.ForeColor = Color.DarkSlateGray;
        }

        private void TasksBtn_MouseLeave(object sender, EventArgs e)
        {
            TasksBtn.BackColor = Color.DarkSlateGray;
            TasksBtn.ForeColor = Color.White;
        }

        private void CompletedBtn_MouseMove(object sender, MouseEventArgs e)
        {
            CompletedBtn.BackColor = Color.LightSeaGreen;
            CompletedBtn.ForeColor = Color.DarkSlateGray;
        }

        private void CompletedBtn_MouseLeave(object sender, EventArgs e)
        {
            CompletedBtn.BackColor = Color.DarkSlateGray;
            CompletedBtn.ForeColor = Color.White;
        }

        private void ProfileBtn_MouseMove(object sender, MouseEventArgs e)
        {
            ProfileBtn.BackColor = Color.LightSeaGreen;
            ProfileBtn.ForeColor = Color.DarkSlateGray;
        }

        private void ProfileBtn_MouseLeave(object sender, EventArgs e)
        {
            ProfileBtn.BackColor = Color.DarkSlateGray;
            ProfileBtn.ForeColor = Color.White;
        }

        private void LogoutBtn_MouseMove(object sender, MouseEventArgs e)
        {
            LogoutBtn.BackColor = Color.LightSeaGreen;
            LogoutBtn.ForeColor = Color.DarkSlateGray;
        }

        private void LogoutBtn_MouseLeave_1(object sender, EventArgs e)
        {
            LogoutBtn.BackColor = Color.DarkSlateGray;
            LogoutBtn.ForeColor = Color.White;
        }
    }
}
