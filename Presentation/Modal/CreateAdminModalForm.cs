using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Data_Connectivity.Context;
using Task_Management_System.Domain.DTO;
using Task_Management_System.Helpers;
using Task_Management_System.Services;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation.Modal
{
    public partial class CreateAdminModalForm : Form
    {
        private readonly ICreateAccountServices _createaccountServices;
        private LoadDataEventHandler? _loadData;
        public CreateAdminModalForm(ICreateAccountServices createAccountServices)
        {
            InitializeComponent();
            _createaccountServices = createAccountServices;
        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {

            string lastName = LastNameTxt.Text.Trim();
            string firstName = FirstNameTxt.Text.Trim();
            string middleName = MiddleNameTxt.Text.Trim();
            string email = EmailTxt.Text.Trim();
            string securityquestions = SecurityQuestionsCB.Text.Trim();
            string answer = AnswerTxt.Text.Trim();
            string password = PasswordTxt.Text;


            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                //use dto to transfer data to entity
                var RegisterAdmin = new AdminDTO
                {
                    LastName = lastName,
                    FirstName = firstName,
                    MiddleName = middleName,
                    Email = email,
                    SecurityQuestions = securityquestions,
                    Answer = answer,
                    Password = password,

                };
                await _createaccountServices.RegisterAccountAdminAsync(RegisterAdmin);
                _loadData?.OnUserCreated();
                this.DialogResult = DialogResult.OK;
                this.Close();
                ClearFields();
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {

            LastNameTxt.Text = string.Empty;
            FirstNameTxt.Text = string.Empty;
            MiddleNameTxt.Text = string.Empty;
            EmailTxt.Text = string.Empty;
            PasswordTxt.Text = string.Empty;
        }
        private void ClearFields()
        {
            LastNameTxt.Text = string.Empty;
            FirstNameTxt.Text = string.Empty;
            MiddleNameTxt.Text = string.Empty;
            EmailTxt.Text = string.Empty;
            PasswordTxt.Text = string.Empty;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxt.PasswordChar == '*')
            {
                HidePasswordBtn.BringToFront();
                PasswordTxt.PasswordChar = '\0';
            }
        }

        private void HidePasswordBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxt.PasswordChar == '\0')
            {
                ShowPasswordBtn.BringToFront();
                PasswordTxt.PasswordChar = '*';
            }
        }
    }
}
