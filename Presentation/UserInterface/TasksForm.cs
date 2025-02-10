using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Data_Connectivity.Context;
using Task_Management_System.Domain.Entities;
using Task_Management_System.Presentation.User_Control;
using Task_Management_System.Services;
using Task_Management_System.Services.Contracts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Task_Management_System.Presentation.UserInterface
{
    public partial class TasksForm : Form
    {
        private readonly ITaskServices _taskServices;
     
     
        public TasksForm(ITaskServices taskServices  )
        {

            InitializeComponent();
            this._taskServices = taskServices;
           
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadTasks();
        }
        public async void LoadTasks()
        {
            try
            {
               FLPTasks.Controls.Clear();
                var tasks = await _taskServices.GetTasksForUserAsync();

                // Populate the UI with tasks
                foreach (var task in tasks)
                {

                    DisplayTaskControl taskControl = new DisplayTaskControl(_taskServices);
                    taskControl.SetTask(task);

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
