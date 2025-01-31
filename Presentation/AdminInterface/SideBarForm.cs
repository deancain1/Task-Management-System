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
using Task_Management_System.Presentation.UserInterface;

namespace Task_Management_System.Presentation
{
    public partial class SideBarForm : Form
    {
        public SideBarForm()
        {
            InitializeComponent();
            var dashboardForm = Program.ServiceProvider.GetRequiredService<DashboardForm>();

            ShowForm(dashboardForm);
            dashboardForm.Refresh();
        }
        private void DashboardBtn_Click(object sender, EventArgs e)
        {

            var dashboardForm = Program.ServiceProvider.GetRequiredService<DashboardForm>();

            ShowForm(dashboardForm);
            dashboardForm.LoadAllTasks();
        }

        private async void CreateTaskBtn_Click(object sender, EventArgs e)
        {
            var tasksForm = Program.ServiceProvider.GetRequiredService<CreateTaskForm>();
            await tasksForm.DisplayTaskInDGV();
            ShowForm(tasksForm);
            tasksForm.Refresh();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsTransition.Start();
        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            var userForm = Program.ServiceProvider.GetRequiredService<AddUserForm>();
            ShowForm(userForm);
            userForm.Refresh();
        }

        private void CreateAdminBtn_Click(object sender, EventArgs e)
        {

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
            DashboardBtn.BackColor = Color.WhiteSmoke;
            DashboardBtn.ForeColor = Color.DarkSlateGray;
        }

        private void CreateTaskBtn_MouseMove(object sender, MouseEventArgs e)
        {
            CreateTaskBtn.BackColor = Color.LightSeaGreen;
            CreateTaskBtn.ForeColor = Color.White;
        }

        private void CreateTaskBtn_MouseLeave(object sender, EventArgs e)
        {
            CreateTaskBtn.BackColor = Color.WhiteSmoke;
            CreateTaskBtn.ForeColor = Color.DarkSlateGray;
        }

        private void SettingsBtn_MouseMove(object sender, MouseEventArgs e)
        {
            SettingsBtn.BackColor = Color.LightSeaGreen;
            SettingsBtn.ForeColor = Color.White;
        }

        private void SettingsBtn_MouseLeave(object sender, EventArgs e)
        {
            SettingsBtn.BackColor = Color.WhiteSmoke;
            SettingsBtn.ForeColor = Color.DarkSlateGray;
        }
    }
}
