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
using Task_Management_System.Services;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation.User_Control
{
    public partial class DisplayTaskControl : UserControl
    {
        private readonly ITaskServices _taskServices;

        public DisplayTaskControl(ITaskServices taskServices)
        {
            InitializeComponent();
            _taskServices = taskServices;

        }
        public void SetTask(TaskEntity taskEntity)
        {
            TaskIDLbl.Text = taskEntity.TaskID.ToString();
            TaskTitleLbl.Text = taskEntity.TaskTitle;
            TaskDescriptionLbl.Text = taskEntity.TaskDescription;
            StartTImeLbl.Text = taskEntity.StartTime.ToString("yyyy-MM-dd");
            EndTimeLbl.Text = taskEntity.EndTime.ToString("yyyy-MM-dd");
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

                    // Remove the current DisplayTaskControl from the parent container
                    parentControl.Controls.Remove(this);

                    // Optionally, pass the task to another control (like CompletedTaskControl)
                    var completedTasksControl = parentControl.Controls.OfType<CompletedTaskControl>().FirstOrDefault();
                    if (completedTasksControl != null)
                    {
                        completedTasksControl.CompletedTask(updatedTask); // Add task to the completed list
                    }

                }
                else if (updatedTask.Status == "Incomplete" || updatedTask.Status == "In Progress")
                {
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
    }
}
