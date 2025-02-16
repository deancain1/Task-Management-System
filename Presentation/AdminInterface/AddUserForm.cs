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
using Task_Management_System.Presentation.Modal;
using Task_Management_System.Services;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation.AdminInterface
{
    public partial class AddUserForm : Form
    {
        private readonly IUserServices _userServices;
        public AddUserForm(IUserServices userServices)
        {
            InitializeComponent();
            _userServices = userServices;
        }

        private async void AddUserBtn_Click(object sender, EventArgs e)
        {
            var addUserForm = Program.ServiceProvider.GetRequiredService<AddUserModalForm>();
            {
                var result = addUserForm.ShowDialog();
                await DisplayUsersInDGV();
            
            }
        }

        public async Task DisplayUsersInDGV(string searchTerm = "")
        {
            var users = await _userServices.GetAllUsersAsync(); 
       

            var filteredUser = users
           .Where(user => user.LastName.ToLower().Contains(searchTerm.ToLower()) ||
            user.FirstName.ToLower().Contains(searchTerm.ToLower()))
           .ToList();

            DGVUsers.Rows.Clear();

            foreach (var user in filteredUser)
            {
                int rowIndex = DGVUsers.Rows.Add();
                DGVUsers.Rows[rowIndex].Cells["UserID"].Value = user.UserID;
                DGVUsers.Rows[rowIndex].Cells["LastName"].Value = user.LastName;
                DGVUsers.Rows[rowIndex].Cells["FirstName"].Value = user.FirstName;
                DGVUsers.Rows[rowIndex].Cells["MiddleName"].Value = user.MiddleName;
                DGVUsers.Rows[rowIndex].Cells["Email"].Value = user.Email;

            }
        }
        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTxt.Text.Trim();
            await DisplayUsersInDGV(searchTerm);
        }

        private async void AddUserForm_Load(object sender, EventArgs e)
        {
            await DisplayUsersInDGV();
        }


        private async void DGVUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == DGVUsers.Columns["EditBtn"].Index && e.RowIndex >= 0)
            {

                int UserID = Convert.ToInt32(DGVUsers.Rows[e.RowIndex].Cells["UserID"].Value);

                var user = await _userServices.GetUserByIdAsync(UserID);

                if (user != null)
                {

                    var editModalForm = Program.ServiceProvider?.GetRequiredService<EditUserAccountModal>();
                    editModalForm?.EditUserAccount(user);

                    var result = editModalForm?.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        await DisplayUsersInDGV();
                        MessageBox.Show("User edited successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }

            else if (e.ColumnIndex == DGVUsers.Columns["DeleteBtn"].Index)
            {

                var confirmResult = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int rowIndex = e.RowIndex;
                    string email = (string)DGVUsers.Rows[rowIndex].Cells["Email"].Value;
                    var user = await _userServices.DeleteUserAsync(email);
                    DGVUsers.Rows.RemoveAt(rowIndex);
                    MessageBox.Show("The user has been successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }

}

