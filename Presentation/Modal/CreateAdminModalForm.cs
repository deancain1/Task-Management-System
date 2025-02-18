using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Domain.DTO;
using Task_Management_System.Helpers;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation.Modal
{
    public partial class CreateAdminModalForm : Form
    {
        private readonly ICreateAccountServices _createaccountServices;

        private byte[]? _imageBytes;

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
            string username = UsernameTxt.Text.Trim();
            string securityQuestions = SecurityQuestionsCB.Text.Trim();
            string answer = AnswerTxt.Text.Trim();
            string password = PasswordTxt.Text;
            string role = RoleTxt.Text.Trim();


            if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(securityQuestions) || string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("@gmail.com email is required.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (await _createaccountServices.AdminEmailTaken(email))
            {
                MessageBox.Show("The email address is already taken. Please use a different email.", "Email Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (await _createaccountServices.AdminUsernameTaken(username))
            {
                MessageBox.Show("The username is already taken. Please use a different email.", "Email Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string passwordError = GetPasswordStrengthError(password);
            if (!string.IsNullOrEmpty(passwordError))
            {
                MessageBox.Show(passwordError, "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          


            var registerAdmin = new AdminDTO
            {
                LastName = lastName,
                FirstName = firstName,
                MiddleName = middleName,
                Email = email,
                Username = username,
                SecurityQuestions = securityQuestions,
                Answer = answer,
                Password = password,
                ProfilePicture = _imageBytes,
                Role = role,
            };


            await _createaccountServices.RegisterAccountAdminAsync(registerAdmin);
            this.DialogResult = DialogResult.OK;
            ClearFields();
        }

        private string GetPasswordStrengthError(string password)
        {
            if (password.Length < 8)
                return "Password must be at least 8 characters long.";
            if (!Regex.IsMatch(password, @"[A-Z]"))
                return "Password must contain at least one uppercase letter.";
            if (!Regex.IsMatch(password, @"[a-z]"))
                return "Password must contain at least one lowercase letter.";
            if (!Regex.IsMatch(password, @"\d"))
                return "Password must contain at least one number.";
            if (!Regex.IsMatch(password, @"[@$!%*?&]"))
                return "Password must contain at least one special character (@$!%*?&).";

            return string.Empty;
        }
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    ProfiilePicBox.Image = Image.FromFile(imagePath);


                    _imageBytes = File.ReadAllBytes(imagePath);
                }
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
            UsernameTxt.Text = string.Empty;
            PasswordTxt.Text = string.Empty;
            SecurityQuestionsCB.SelectedIndex = -1;
            AnswerTxt.Text = string.Empty;

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.ShowPassword(PasswordTxt, ShowPasswordBtn, HidePasswordBtn);

        }

        private void HidePasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.HidePassword(PasswordTxt, ShowPasswordBtn, HidePasswordBtn);
        }
    }
}
