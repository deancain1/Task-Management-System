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
    public partial class CompletedTaskControl : UserControl
    {
        private readonly ITaskServices _taskServices;

        public CompletedTaskControl(ITaskServices taskServices)
        {
            InitializeComponent();
            _taskServices = taskServices;

        }
        public void CompletedTask(TaskEntity taskEntity)
        {
            TaskIDLbl.Text = taskEntity.TaskID.ToString();
            TaskTitleLbl.Text = taskEntity.TaskTitle;
            TaskDescriptionLbl.Text = taskEntity.TaskDescription;
            StartTImeLbl.Text = taskEntity.StartTime.ToString("yyyy-MM-dd");
            EndTimeLbl.Text = taskEntity.EndTime.ToString("yyyy-MM-dd");
            StatusLbl.Text = taskEntity.Status;
        }

    }
}
