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
using Task_Management_System.Helpers;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation.UserInterface
{
    public partial class ProfileForm : Form
    {
        private readonly IUserServices _userServices;
        private UserEntity _userEntity;
        private byte[]? _imageBytes;


        public ProfileForm(IUserServices userServices,
            UserEntity userEntity)
        {
            InitializeComponent();
            _userServices = userServices;
            _userEntity = userEntity;

        }

        private async void ProfileForm_Load(object sender, EventArgs e)
        {
            var user = await _userServices.GetUserInfoAsync();

            if (user != null)
            {
                FirstNameTxt.Text = user.FirstName;
                MiddleNameTxt.Text = user.MiddleName;
                LastNameTxt.Text = user.LastName;
                EmailTxt.Text = user.Email;
                UsernameTxt.Text = user.Username;
                DepartmentTxt.Text = user.Department;


                if (user.ProfilePicture != null && user.ProfilePicture.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(user.ProfilePicture))
                    {
                        ProfilePicBox.Image = Image.FromStream(ms);
                    }
                }

            }
            else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var updateUser = new UserDTO
                {

                    FirstName = FirstNameTxt.Text,
                    MiddleName = MiddleNameTxt.Text,
                    LastName = LastNameTxt.Text,
                    Email = EmailTxt.Text,
                    Password = NewPasswordTxt.Text,
                    ProfilePicture = _imageBytes
                };

                await _userServices.UpdateAccountUserWithPasswordAsync(updateUser);
                ClearFields();
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Updating Profile:  {ex.Message}, {ex.InnerException ?? ex}");
            }

        }
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    ProfilePicBox.Image = Image.FromFile(imagePath);


                    _imageBytes = File.ReadAllBytes(imagePath);
                }
            }

        }

        private void ClearFields()
        {
            CurrentPasswordTxt.Text = string.Empty;
            NewPasswordTxt.Text = string.Empty;
        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.ShowPassword(NewPasswordTxt, ShowPasswordBtn, HidePasswordBtn);
        }

        private void HidePasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.HidePassword(NewPasswordTxt, ShowPasswordBtn, HidePasswordBtn);

        }

        private void ShowCurrentPasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.ShowPassword(CurrentPasswordTxt, ShowCurrentPasswordBtn, HideCurrentPasswordBtn);
        }

        private void HideCurrentPasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.HidePassword(CurrentPasswordTxt, ShowCurrentPasswordBtn, HideCurrentPasswordBtn);

        }
    }
}
