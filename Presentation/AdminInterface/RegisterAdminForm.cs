using Microsoft.EntityFrameworkCore;
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
using Task_Management_System.Domain.DTO;
using Task_Management_System.Domain.Entities;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation
{
    public partial class RegisterAdminForm : Form
    {
        private readonly ICreateAccountServices _createAccountServices;
        public RegisterAdminForm(ICreateAccountServices createAccountServices)
        {
            InitializeComponent();
            _createAccountServices = createAccountServices;
        }


        private async void SignUpBtn_Click(object sender, EventArgs e)
        {
            string lastName = LastNameTxt.Text.Trim();
            string firstName = FirstNameTxt.Text.Trim();
            string middleName = MiddleNameTxt.Text.Trim();
            string email = EmailTxt.Text.Trim();
            string password = PasswordTxt.Text;
            string confirmPassword = ConfirmPasswordTxt.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //use dto to transfer data to entity
                var RegisterAdmin = new AdminDTO
                {
                    FirstName = firstName,
                    LastName = lastName,
                    MiddleName = middleName,
                    Email = email,
                    Password = password,
                    ConfirmPassword = confirmPassword,
                };

                await _createAccountServices.RegisterAccountAdminAsync(RegisterAdmin);
                ClearFields();
            }
        }
        private void ClearFields()
        {
            FirstNameTxt.Text = string.Empty;
            LastNameTxt.Text = string.Empty;
            MiddleNameTxt.Text = string.Empty;
            EmailTxt.Text = string.Empty;
            PasswordTxt.Text = string.Empty;
            ConfirmPasswordTxt.Text = string.Empty;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginHereBtn_Click(object sender, EventArgs e)
        {
            var registerForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            registerForm.Show();
            this.Hide();
        }
    }
}

