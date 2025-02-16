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

namespace Task_Management_System.Presentation.Modal
{
    public partial class CreateTaskModalForm : Form
    {
        private readonly IUserServices _userServices;
        private readonly ITaskServices _taskServices;
        private List<UserEntity> _users = new List<UserEntity>();
        private LoadDataEventHandler? _loadData;
        public CreateTaskModalForm(IUserServices userServices, ITaskServices taskServices)
        {
            InitializeComponent();
            _userServices = userServices;
           _taskServices = taskServices;

        }
        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            await LoadUserNamesIntoComboBox();
        }
        public async Task LoadUserNamesIntoComboBox()
        {
            var userNames = await _userServices.GetAllUserNamesAsync();
            _users = userNames;
            UsersCB.Items.Clear();
            foreach (var user in userNames)
            {
                UsersCB.Items.Add($"{user.FirstName + " " + user.MiddleName + " " + user.LastName}");
            }
        }

        private async void AssignTaskBtn_Click(object sender, EventArgs e)
        {
            string TaskTitle = TaskTitleTxt.Text.Trim();
            string TaskDescription = TaskDescriptionTxt.Text.Trim();
            DateTime StartTime = StartTimeDate.Value;
            DateTime EndTime = EndTimeDate.Value;
            string AssignToName = UsersCB.Text.Trim();
            string Status = StatusLbl.Text.Trim();

            var user = _users.FirstOrDefault(u =>
            $"{u.FirstName.Trim()} {u.MiddleName?.Trim()} {u.LastName.Trim()}".Trim() == AssignToName.Trim());

            if (user == null)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int AssignToId = user.UserID;

            if (string.IsNullOrWhiteSpace(TaskTitle) ||
                string.IsNullOrWhiteSpace(TaskDescription) ||
                string.IsNullOrWhiteSpace(AssignToName))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var CreateTask = new TasksDTO
                {
                    TaskTitle = TaskTitle,
                    TaskDescription = TaskDescription,
                    StartTime = StartTime,
                    EndTime = EndTime,
                    AssignTo = AssignToName,
                    Status = Status,
                    UserID = AssignToId
                };
                await _taskServices.CreateTaskByAsync(CreateTask);
                _loadData?.OnTaskCreated();
                this.DialogResult = DialogResult.OK;
                ClearFields();
                this.Close();
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TaskTitleTxt.Text = string.Empty;
            TaskDescriptionTxt.Text = string.Empty;
            UsersCB.Text = null;
        }
        private void ClearFields()
        {
            TaskTitleTxt.Text = string.Empty;
            TaskDescriptionTxt.Text = string.Empty;
            UsersCB.Text = null;
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
