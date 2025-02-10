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
            this._taskServices = taskServices;
            
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadCompletedTask();
        }
        public async void LoadCompletedTask()
        {
            try
            {
                // Retrieve tasks for the logged-in user
                var tasks = await _taskServices.GetCompletedTasksForUserAsync();

                // Populate the UI with tasks
                foreach (var task in tasks)
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
    }
}
