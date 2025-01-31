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

namespace Task_Management_System.Presentation.Modal
{
    public partial class EditTaskModalForm : Form
    {
        private readonly ITaskServices _taskServices;
        private LoadDataEventHandler? _loadData;
        public EditTaskModalForm(ITaskServices taskServices)
        {
            InitializeComponent();
            _taskServices = taskServices;

        }

        public void EditTaskDetails(TaskEntity taskEntity)
        {
            TaskIDLbl.Text = taskEntity.TaskID.ToString();
            TaskTitleTxt.Text = taskEntity.TaskTitle;
            TaskDescriptionTxt.Text = taskEntity.TaskDescription;
            StartTimeDate.Text = taskEntity.StartTime.ToString("yyyy-MM-dd");
            EndTimeDate.Text = taskEntity.EndTime.ToString("yyyy-MM-dd");
            StatusCB.Text = taskEntity.Status;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void UpdateTaskBtn_Click(object sender, EventArgs e)
        {
            string TaskTitle = TaskTitleTxt.Text.Trim();
            string TaskDescription = TaskDescriptionTxt.Text.Trim();
            DateTime StartTime = StartTimeDate.Value;
            DateTime EndTime = EndTimeDate.Value;
            string Status = StatusCB.Text.Trim();

            int TaskID;
            if (!int.TryParse(TaskIDLbl.Text.Trim(), out TaskID))
            {
                MessageBox.Show("Invalid Task ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TaskTitle) ||
                string.IsNullOrWhiteSpace(TaskDescription) ||
                string.IsNullOrWhiteSpace(Status))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var UpdateTask = new TaskEntity
                {
                    TaskID = TaskID,
                    TaskTitle = TaskTitle,
                    TaskDescription = TaskDescription,
                    StartTime = StartTime,
                    EndTime = EndTime,
                    Status = Status,
                };
                await _taskServices.UpdateTaskAsync(UpdateTask);
                _loadData?.OnTaskCreated();
                this.DialogResult = DialogResult.OK;
                ClearFields();
                this.Close();
            }
        }
        private void ClearFields()
        {
            TaskTitleTxt.Text = string.Empty;
            TaskDescriptionTxt.Text = string.Empty;
            StatusCB.Text = null;
        }
    }
}
