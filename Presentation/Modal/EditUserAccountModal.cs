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
using Task_Management_System.Helpers;
using Task_Management_System.Services.Contracts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_Management_System.Presentation.Modal
{
    public partial class EditUserAccountModal : Form
    {
        private readonly IUserServices _userServices;
        private LoadDataEventHandler? _loadData;
        private byte[]? _imageBytes;
        public EditUserAccountModal(IUserServices userServices)
        {
            InitializeComponent();
            _userServices = userServices;
        }

        public void EditUserAccount(UserEntity userEntity)
        {
            UserIDLbl.Text = userEntity.UserID.ToString();
            LastNameTxt.Text = userEntity.LastName;
            FirstNameTxt.Text = userEntity.FirstName;
            MiddleNameTxt.Text = userEntity.MiddleName;
            EmailTxt.Text = userEntity.Email;
            UsernameTxt.Text = userEntity.Username;
            if (userEntity.ProfilePicture != null && userEntity.ProfilePicture.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(userEntity.ProfilePicture))
                {
                    ProfilePicBox.Image = Image.FromStream(ms);
                }
            }

        }
        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            string lastname = LastNameTxt.Text.Trim();
            string firstname = FirstNameTxt.Text.Trim();
            string middlename = MiddleNameTxt.Text.Trim();
            string email = EmailTxt.Text.Trim();
            string username = UsernameTxt.Text.Trim();
            int UserID;
            if (!int.TryParse(UserIDLbl.Text.Trim(), out UserID))
            {
                MessageBox.Show("Invalid Task ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(lastname) ||
                string.IsNullOrWhiteSpace(firstname) ||
                string.IsNullOrWhiteSpace(middlename) ||
                 string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var UpdateUser = new UserEntity
                {
                    UserID = UserID,
                    LastName = lastname,
                    FirstName = firstname,
                    MiddleName = middlename,
                    Email = email,
                    Username = username,
                    ProfilePicture = _imageBytes
                };
                await _userServices.UpdateUserAccountAsync(UpdateUser);
                _loadData?.OnUserCreated();
                this.DialogResult = DialogResult.OK;
                ClearFields();
                this.Close();
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
            LastNameTxt.Text = string.Empty;
            FirstNameTxt.Text = string.Empty;
            MiddleNameTxt.Text = string.Empty;
            EmailTxt.Text = string.Empty;
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
