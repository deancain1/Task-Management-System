using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Task_Management_System.Domain.DTO;
using Task_Management_System.Helpers;
using Task_Management_System.Services;
using Task_Management_System.Services.Contracts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Task_Management_System.Presentation.Modal
{
    public partial class AddUserModalForm : Form
    {
        private readonly ICreateAccountServices _createAccountServices;

        private byte[]? _imageBytes; 

        public AddUserModalForm(ICreateAccountServices createAccountServices)
        {
            InitializeComponent();
            _createAccountServices = createAccountServices;
        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {
            string lastName = LastNameTxt.Text.Trim();
            string firstName = FirstNameTxt.Text.Trim();
            string middleName = MiddleNameTxt.Text.Trim();
            string email = EmailTxt.Text.Trim();
            string username = Usernametxt.Text.Trim();
            string department = DepartmentCB.Text.Trim();
            string password = PasswordTxt.Text;
            string securityquestions = SecurityQuestionsCB.Text;
            string answer = AnswerTxt.Text;
            string role = RoleTxt.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("@gmail.com required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (await _createAccountServices.UserEmailTaken(email))
            {
                MessageBox.Show("The email address is already taken. Please use a different email.", "Email Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (await _createAccountServices.UserUsernameTaken(username))
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
          


            var registerUser = new UserDTO
            {
                LastName = lastName,
                FirstName = firstName,
                MiddleName = middleName,
                Email = email,
                Username = username,
                Department = department,
                SecurityQuestions = securityquestions,
                Answer = answer,
                Password = password,
                Role = role,
                ProfilePicture = _imageBytes
            };

            await _createAccountServices.RegisterAccountUserAsync(registerUser);
            this.DialogResult = DialogResult.OK;
            ClearFields();
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
        private void ClearFields()
        {

            LastNameTxt.Text = string.Empty;
            FirstNameTxt.Text = string.Empty;
            MiddleNameTxt.Text = string.Empty;
            EmailTxt.Text = string.Empty;
            Usernametxt.Text = string.Empty;
            PasswordTxt.Text = string.Empty;
            AnswerTxt.Text = string.Empty;
            SecurityQuestionsCB.SelectedIndex = -1; 
            DepartmentCB.SelectedIndex = -1;
            _imageBytes = null;  
            ProfiilePicBox.Image = null;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
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
