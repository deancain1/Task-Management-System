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

namespace Task_Management_System.Presentation.Modal
{
    public partial class EditAdminModalForm : Form
    {
        private readonly IAdminServices _adminServices;
        private LoadDataEventHandler? _loadData;
        private byte[]? _imageBytes;
        public EditAdminModalForm(IAdminServices adminServices)
        {
            InitializeComponent();
            _adminServices = adminServices;
        }
        public void EditAdminAccount(AdminEntity adminEntity)
        {
            AdminIDLbl.Text = adminEntity.AdminID.ToString();
            LastNameTxt.Text = adminEntity.LastName;
            FirstNameTxt.Text = adminEntity.FirstName;
            MiddleNameTxt.Text = adminEntity.MiddleName;

            EmailTxt.Text = adminEntity.Email;
            if (adminEntity.ProfilePicture != null && adminEntity.ProfilePicture.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(adminEntity.ProfilePicture))
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
            int AdminID;
            if (!int.TryParse(AdminIDLbl.Text.Trim(), out AdminID))
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
                var UpdateAdmin = new AdminEntity
                {
                    AdminID = AdminID,
                    LastName = lastname,
                    FirstName = firstname,
                    MiddleName = middlename,
                    Email = email,
                    ProfilePicture = _imageBytes
                };
                await _adminServices.UpdateAdminAccountAsync(UpdateAdmin);
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
