using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Presentation.User_Control;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation.UserInterface
{
    public partial class CompletedTaskForm : Form
    {
        private readonly ITaskServices _taskServices;

        public CompletedTaskForm(ITaskServices taskServices)
        {
            InitializeComponent();
            _taskServices = taskServices;

        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadCompletedTask();
        }
        public async void LoadCompletedTask(string searchTerm = "")
        {
            try
            {

                var tasks = await _taskServices.GetCompletedTasksForUserAsync();

                FLPTasks.Controls.Clear();

                var filteredTasks = tasks.Where(task =>
                 task.TaskTitle.ToLower().Contains(searchTerm.ToLower()) ||
                 task.TaskDescription.ToLower().Contains(searchTerm.ToLower()))
                 .ToList();

                foreach (var task in filteredTasks)
                {

                    CompletedTaskControl taskControl = new CompletedTaskControl(_taskServices);
                    taskControl.CompletedTask(task);

                    FLPTasks.Controls.Add(taskControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTxt.Text.Trim();
            LoadCompletedTask(searchTerm);
        }
    }
}
