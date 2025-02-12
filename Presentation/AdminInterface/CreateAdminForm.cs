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
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation.AdminInterface
{
    public partial class CreateAdminForm : Form
    {
        private readonly IAdminServices _adminServices;
        public CreateAdminForm(IAdminServices adminServices)
        {
            InitializeComponent();
            _adminServices = adminServices;
        }

        private async void CreateAdminBtn_Click(object sender, EventArgs e)
        {
            var createAdmin = Program.ServiceProvider.GetRequiredService<CreateAdminModalForm>();
            {
                var result = createAdmin.ShowDialog();
                await DisplayAdminInDGV();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Admin added successfully.");
                }
            }
        }
        public async Task DisplayAdminInDGV(string searchTerm = "")
        {
            var admin = await _adminServices.GetAllAdminAsync();

            var filteredAdmin = admin
           .Where(admin => admin.LastName.ToLower().Contains(searchTerm.ToLower()) ||
            admin.FirstName.ToLower().Contains(searchTerm.ToLower()))
           .ToList();

            DGVAdmin.Rows.Clear();

            foreach (var admins in filteredAdmin) 
            {
                int rowIndex = DGVAdmin.Rows.Add();
                DGVAdmin.Rows[rowIndex].Cells["AdminID"].Value = admins.AdminID;
                DGVAdmin.Rows[rowIndex].Cells["LastName"].Value = admins.LastName;
                DGVAdmin.Rows[rowIndex].Cells["FirstName"].Value = admins.FirstName;
                DGVAdmin.Rows[rowIndex].Cells["MiddleName"].Value = admins.MiddleName;
                DGVAdmin.Rows[rowIndex].Cells["Email"].Value = admins.Email;

            }
        }
        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTxt.Text.Trim();
            await DisplayAdminInDGV(searchTerm);
        }
        private async void DGVAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == DGVAdmin.Columns["EditBtn"].Index && e.RowIndex >= 0)
            {

                int AdminID = Convert.ToInt32(DGVAdmin.Rows[e.RowIndex].Cells["AdminID"].Value);

                var admin = await _adminServices.GetAdminByIDAsync(AdminID);

                if (admin != null)
                {

                    var editModalForm = Program.ServiceProvider?.GetRequiredService<EditAdminModalForm>();
                    editModalForm?.EditAdminAccount(admin);

                    var result = editModalForm?.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        await DisplayAdminInDGV();
                        MessageBox.Show("Admin edited successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("Admin not found.");
                }
            }

            else if (e.ColumnIndex == DGVAdmin.Columns["DeleteBtn"].Index)
            {

                var confirmResult = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int rowIndex = e.RowIndex;
                    string email = (string)DGVAdmin.Rows[rowIndex].Cells["Email"].Value;
                    var user = await _adminServices.DeleteAdminAsync(email);
                    DGVAdmin.Rows.RemoveAt(rowIndex);
                    MessageBox.Show("The admin has been successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private async void CreateAdminForm_Load(object sender, EventArgs e)
        {
            await DisplayAdminInDGV();
        }

       
    }
}
