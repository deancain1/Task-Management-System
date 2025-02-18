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
using Task_Management_System.Services;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation.AdminInterface
{
    public partial class AdminProfileForm : Form
    {
        private readonly IAdminServices _adminServices;
        private AdminEntity _adminEntity;
        private byte[]? _imageBytes;
        public AdminProfileForm(IAdminServices adminServices, AdminEntity adminEntity)
        {
            InitializeComponent();
            _adminServices = adminServices;
            _adminEntity = adminEntity;

        }
        private async void AdminProfileForm_Load(object sender, EventArgs e)
        {
            var admin = await _adminServices.GetAdminInfoAsync();

            if (admin != null)
            {
                FirstNameTxt.Text = admin.FirstName;
                MiddleNameTxt.Text = admin.MiddleName;
                LastNameTxt.Text = admin.LastName;
                EmailTxt.Text = admin.Email;
                UsernameTxt.Text = admin.Username;


                if (admin.ProfilePicture != null && admin.ProfilePicture.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(admin.ProfilePicture))
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
            var updatedaAdmin = new AdminDTO
            {

                FirstName = FirstNameTxt.Text,
                MiddleName = MiddleNameTxt.Text,
                LastName = LastNameTxt.Text,
                Email = EmailTxt.Text,
                Username = UsernameTxt.Text,
                Password = NewPasswordTxt.Text,
                ProfilePicture = _imageBytes
            };

            await _adminServices.UpdateAccountAdminWithPasswordAsync(updatedaAdmin);
            ClearFields();
            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void ShowCurrentPasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.ShowPassword(CurrentPasswordTxt, ShowCurrentPasswordBtn, HideCurrentPasswordBtn);
        }

        private void HideCurrentPasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.HidePassword(CurrentPasswordTxt, ShowCurrentPasswordBtn, HideCurrentPasswordBtn);
        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.ShowPassword(NewPasswordTxt, ShowPasswordBtn, HidePasswordBtn);
        }

        private void HidePasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.HidePassword(NewPasswordTxt, ShowPasswordBtn, HidePasswordBtn);
        }
    }
}
