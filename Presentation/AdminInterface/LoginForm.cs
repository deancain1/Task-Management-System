using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using Task_Management_System.Helpers;
using Task_Management_System.Presentation.AdminInterface;
using Task_Management_System.Presentation.UserInterface;
using Task_Management_System.Services;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation
{
    public partial class LoginForm : Form
    {
        private readonly IAdminServices _adminServices;
        private readonly IUserServices _userServices;

        public LoginForm(IUserServices userServices, IAdminServices adminServices)
        {
            InitializeComponent();
            _adminServices = adminServices;
            _userServices = userServices;
        }

        private async void LoginBtn_Click_1(object sender, EventArgs e)
        {
            string email = EmailTxt.Text;
            string password = PasswordTxt.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            var admin = await _adminServices.GetAdminByEmailAsync(email);
            if (admin != null)
            {

                if (PasswordHashAndSalt.VerifyPasswordHash(password, admin.PasswordHash, admin.PasswordSalt))
                {
                    AdminSession.AdminID = admin.AdminID;
                    AdminSession.Email = admin.Email;
                    var adminMainForm = Program.ServiceProvider.GetRequiredService<SideBarForm>();
                    adminMainForm.currentAdmin = admin;
                    this.Hide();
                    adminMainForm?.Show();
                    ClearFields();
                    return;
                }
            }
            var user = await _userServices.GetUserByEmailAsync(email);
            if (user != null)
            {


                if (PasswordHashAndSalt.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                {

                    UserSession.UserID = user.UserID;
                    UserSession.Email = user.Email;
                    this.Hide();
                    var userMainForm = Program.ServiceProvider.GetRequiredService<NavigationBarForm>();
                    userMainForm.currentUser = user;
                    userMainForm.Show();
                    ClearFields();
                    return;

                }
            }
            else
            {
                MessageBox.Show("Incorrect email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ForgotPasswordBtn_Click(object sender, EventArgs e)
        {
            var forgotPasswordForm = Program.ServiceProvider.GetRequiredService<ForgotPasswordForm>();
            forgotPasswordForm?.Show();
            this.Hide();
        }
        private void ClearFields()
        {
            EmailTxt.Clear();
            PasswordTxt.Clear();
        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.ShowPassword(PasswordTxt, ShowPasswordBtn, HidePasswordBtn);
        }

        private void HidePasswordBtn_Click_1(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.HidePassword(PasswordTxt, ShowPasswordBtn, HidePasswordBtn);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
