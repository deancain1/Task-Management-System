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
    public partial class CreateTaskForm : Form
    {
        private readonly ITaskServices _taskServices;
        private readonly IUserServices _userServices;
        public CreateTaskForm(ITaskServices taskServices, IUserServices userServices)
        {
            InitializeComponent();
            _taskServices = taskServices;
            _userServices = userServices;

        }

        private async void AssignTaskBtn_Click(object sender, EventArgs e)
        {
            var createTaskModalForm = Program.ServiceProvider?.GetRequiredService<CreateTaskModalForm>();
            {
                if (createTaskModalForm == null)
                {
                    MessageBox.Show("Failed to load the task creation form.");
                    return;
                }
                var result = createTaskModalForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    await createTaskModalForm.LoadUserNamesIntoComboBox();
                    await DisplayTaskInDGV();
                    MessageBox.Show("Task created successfully.");
                }
            }
        }
        public async Task DisplayTaskInDGV(string searchTerm = "")
        {
             var tasks = await _taskServices.GetAllTaskAsync();

             var filteredTasks = tasks
            .Where(task => task.TaskTitle.ToLower().Contains(searchTerm.ToLower()) ||
             task.TaskDescription.ToLower().Contains(searchTerm.ToLower()))
            .ToList();

            DGVTasks.Rows.Clear();

            foreach (var task in filteredTasks)
            {
                int rowIndex = DGVTasks.Rows.Add();
                DGVTasks.Rows[rowIndex].Cells["TaskID"].Value = task.TaskID;
                DGVTasks.Rows[rowIndex].Cells["TaskTitle"].Value = task.TaskTitle;
                DGVTasks.Rows[rowIndex].Cells["TaskDescription"].Value = task.TaskDescription;
                DGVTasks.Rows[rowIndex].Cells["StartTime"].Value = task.StartTime;
                DGVTasks.Rows[rowIndex].Cells["Deadline"].Value = task.EndTime;
                DGVTasks.Rows[rowIndex].Cells["AssignTo"].Value = task.AssignTo;
                DGVTasks.Rows[rowIndex].Cells["Status"].Value = task.Status;
            }
        }

          private async void SearchBtn_Click_1(object sender, EventArgs e)
        {

            string searchTerm = SearchTxt.Text.Trim();
            await DisplayTaskInDGV(searchTerm);
        }
     


        private async void CreateTaskForm_Load(object sender, EventArgs e)
        {
            await DisplayTaskInDGV();
        }


        private async void DGVTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVTasks.Columns["EditBtn"].Index && e.RowIndex >= 0)
            {

                int TaskID = Convert.ToInt32(DGVTasks.Rows[e.RowIndex].Cells["TaskID"].Value);

                var task = await _taskServices.GetTaskByIdAsync(TaskID);

                if (task != null)
                {

                    var editModalForm = Program.ServiceProvider?.GetRequiredService<EditTaskModalForm>();
                    editModalForm?.EditTaskDetails(task);

                    var result = editModalForm?.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        await DisplayTaskInDGV();
                        MessageBox.Show("Task edited successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("Task not found.");
                }
            }



            else if (e.ColumnIndex == DGVTasks.Columns["DeleteBtn"].Index)
            {

                var confirmResult = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int rowIndex = e.RowIndex;
                    int TaskID = Convert.ToInt32(DGVTasks.Rows[rowIndex].Cells["TaskID"].Value);
                    var task = await _taskServices.DeleteTaskAsync(TaskID);
                    DGVTasks.Rows.RemoveAt(rowIndex);
                    MessageBox.Show("The task has been successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DGVTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == DGVTasks.Columns["TaskDescription"].Index && e.Value != null)
            {

                string? text = e.Value.ToString();
                if (text?.Length > 20)
                {
                    e.Value = InsertNewLineAfter(text, 20);
                }
            }

        }
        private string InsertNewLineAfter(string text, int interval)
        {
            for (int i = interval; i < text.Length; i += interval + 1)
            {
                text = text.Insert(i, "\n");
            }
            return text;
        }

      
    }
}

