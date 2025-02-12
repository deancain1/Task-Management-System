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
using Task_Management_System.Presentation.UserInterface;

namespace Task_Management_System.Presentation
{
    public partial class SideBarForm : Form
    {
        public AdminEntity? currentAdmin;
        public SideBarForm()
        {
            InitializeComponent();
            var dashboardForm = Program.ServiceProvider.GetRequiredService<DashboardForm>();
            LoadForm(MainPanel, dashboardForm);
            dashboardForm.Refresh();
        }

        private async void CreateTaskBtn_Click(object sender, EventArgs e)
        {
            var tasksForm = Program.ServiceProvider.GetRequiredService<CreateTaskForm>();
            await tasksForm.DisplayTaskInDGV();
            LoadForm(MainPanel, tasksForm);
            tasksForm.Refresh();
        }
        private void DashboardBtn_Click(object sender, EventArgs e)
        {

            var dashboardForm = Program.ServiceProvider.GetRequiredService<DashboardForm>();
            LoadForm(MainPanel, dashboardForm);
            dashboardForm.LoadAllTasks();
        }


        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsTransition.Start();
        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            var userForm = Program.ServiceProvider.GetRequiredService<AddUserForm>();
            LoadForm(MainPanel, userForm);
            userForm.Refresh();
        }

        private void CreateAdminBtn_Click(object sender, EventArgs e)
        {
            var createAdminForm = Program.ServiceProvider.GetRequiredService<CreateAdminForm>();
            LoadForm(MainPanel, createAdminForm);
            createAdminForm.Refresh();
        }

        bool settingExpand = false;
        private void SettingsTransition_Tick(object sender, EventArgs e)
        {
            if (settingExpand == false)
            {

                SettingsContainer.Height += 95;
                if (SettingsContainer.Height >= 200)
                {
                    SettingsContainer.Height = 200;
                    SettingsTransition.Stop();
                    settingExpand = true;
                }
            }
            else
            {

                SettingsContainer.Height -= 95;
                if (SettingsContainer.Height <= 55)
                {
                    SettingsContainer.Height = 55;
                    SettingsTransition.Stop();
                    settingExpand = false;
                }
            }
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


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            var LoginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            this.Hide();
            LoginForm.Show();

        }

        private void DashboardBtn_MouseMove(object sender, MouseEventArgs e)
        {
            DashboardBtn.BackColor = Color.LightSeaGreen;
            DashboardBtn.ForeColor = Color.White;
        }

        private void DashboardBtn_MouseLeave(object sender, EventArgs e)
        {
            DashboardBtn.BackColor = Color.FromArgb(247, 248, 248);
            DashboardBtn.ForeColor = Color.DarkSlateGray;
        }

        private void CreateTaskBtn_MouseMove(object sender, MouseEventArgs e)
        {
            CreateTaskBtn.BackColor = Color.LightSeaGreen;
            CreateTaskBtn.ForeColor = Color.White;
        }

        private void CreateTaskBtn_MouseLeave(object sender, EventArgs e)
        {
            CreateTaskBtn.BackColor = Color.FromArgb(247, 248, 248);
            CreateTaskBtn.ForeColor = Color.DarkSlateGray;
        }

        private void SettingsBtn_MouseMove(object sender, MouseEventArgs e)
        {
            SettingsBtn.BackColor = Color.LightSeaGreen;
            SettingsBtn.ForeColor = Color.White;
        }

        private void SettingsBtn_MouseLeave(object sender, EventArgs e)
        {
            SettingsBtn.BackColor = Color.FromArgb(247, 248, 248);
            SettingsBtn.ForeColor = Color.DarkSlateGray;
        }

        private void SideBarForm_Load(object sender, EventArgs e)
        {
            if (currentAdmin != null)
            {
                AdminLbl.Text = $"{currentAdmin.FirstName} {currentAdmin.LastName}";

            }
        }
    }
}
