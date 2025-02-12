using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Task_Management_System.Domain.DTO;
using Task_Management_System.Helpers;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation.Modal
{
    public partial class AddUserModalForm : Form
    {
        private readonly ICreateAccountServices _createAccountServices;
        private LoadDataEventHandler? _loadData;
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
            string password = PasswordTxt.Text;
            string securityquestions = SecurityQuestionsCB.Text;
            string answer = AnswerTxt.Text;
            string role = RoleTxt.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Use DTO to transfer data to entity
            var registerUser = new UserDTO
            {
                FirstName = firstName,
                LastName = lastName,
                MiddleName = middleName,
                Email = email,
                Role = role,
                SecurityQuestions = securityquestions,
                Answer = answer,
                Password = password,
                ProfilePicture = _imageBytes
            };

            await _createAccountServices.RegisterAccountUserAsync(registerUser);
            _loadData?.OnUserCreated();

            this.DialogResult = DialogResult.OK;
            this.Close();
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
      

        private void ClearFields()
        {
            LastNameTxt.Text = string.Empty;
            FirstNameTxt.Text = string.Empty;
            MiddleNameTxt.Text = string.Empty;
            EmailTxt.Text = string.Empty;
            PasswordTxt.Text = string.Empty;
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

        private void HidePasswordBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxt.PasswordChar == '\0')
            {
                ShowPasswordBtn.BringToFront();
                PasswordTxt.PasswordChar = '*';
            }
        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxt.PasswordChar == '*')
            {
                HidePasswordBtn.BringToFront();
                PasswordTxt.PasswordChar = '\0';
            }
        }

      
    }
}
