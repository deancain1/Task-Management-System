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
using Task_Management_System.Services;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation.UserInterface
{
    public partial class TasksForm : Form
    {
        private readonly ITaskServices _taskServices;

        public TasksForm(ITaskServices taskServices)
        {
            InitializeComponent();
            _taskServices = taskServices;

        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadTasks();
        }
        public async void LoadTasks(string searchTerm = "")
        {
            try
            {
               
                FLPTasks.Controls.Clear();
                var tasks = await _taskServices.GetTasksForUserAsync();

       
                var filteredTasks = tasks.Where(task =>
                    task.TaskTitle.ToLower().Contains(searchTerm.ToLower()) ||
                    task.TaskDescription.ToLower().Contains(searchTerm.ToLower()))
                    .ToList();

              
                foreach (var task in filteredTasks)
                {
                    var taskControl = new DisplayTaskControl(_taskServices);
                    taskControl.SetTask(task);
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
            LoadTasks(searchTerm);
        }
    }
}
