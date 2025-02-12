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
using Task_Management_System.Services;
using Task_Management_System.Services.Contracts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_Management_System.Presentation.User_Control
{
    public partial class DisplayTaskControl : UserControl
    {
        private readonly ITaskServices _taskServices;
        public event EventHandler? TaskCompleted;

        public DisplayTaskControl(ITaskServices taskServices)
        {
            InitializeComponent();
            this._taskServices = taskServices;

        }

        public void SetTask(TaskEntity taskEntity)
        {
            TaskIDLbl.Text = taskEntity.TaskID.ToString();
            TaskTitleLbl.Text = taskEntity.TaskTitle;
            TaskDescriptionLbl.Text = taskEntity.TaskDescription;
            StartTImeLbl.Text = taskEntity.StartTime.ToString("yyyy-MM-dd hh:mm:ss");
            EndTimeLbl.Text = taskEntity.EndTime.ToString("yyyy-MM-dd hh:mm:ss");
            StatusLbl.Text = taskEntity.Status;
        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {

                var updatedTask = new TaskEntity
                {
                    TaskID = int.Parse(TaskIDLbl.Text),
                    TaskTitle = TaskTitleLbl.Text,
                    TaskDescription = TaskDescriptionLbl.Text,
                    StartTime = DateTime.Parse(StartTImeLbl.Text),
                    EndTime = DateTime.Parse(EndTimeLbl.Text),
                    Status = StatusCB.Text
                };


                await _taskServices.UpdateTaskStatusAsync(updatedTask);


                if (updatedTask.Status == "Completed")
                {
                    var parentControl = this.Parent;
                    parentControl.Controls.Remove(this);
                    TaskCompleted?.Invoke(this, EventArgs.Empty);


                }
                else if (updatedTask.Status == "Incomplete" || updatedTask.Status == "In Progress")
                {
                    string selectedStatus = StatusCB.SelectedItem?.ToString() ?? string.Empty;
                    StatusUpdater.UpdateStatusLabel(StatusLbl, selectedStatus, true);
                    StatusLbl.Text = updatedTask.Status;
                    MessageBox.Show("Task status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Error");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayTaskControl_Load(object sender, EventArgs e)
        {
            string initialStatus = StatusLbl.Text;
            StatusUpdater.SetInitialStatusColor(StatusLbl, initialStatus);
        }

        private void TaskIDLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
