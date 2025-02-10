using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OxyPlot.Axes;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Presentation.AdminInterface
{
    public partial class DashboardForm : Form
    {
        private readonly ITaskServices _taskServices;


        public DashboardForm(ITaskServices taskServices)
        {
            InitializeComponent();
            this._taskServices = taskServices;
          
        }

        private async Task InitializeChart()
        {
          
            ChartPanel.Controls.Clear();

            var totalTasksData = await _taskServices.GetTotalTasksByDateAsync();
            var incompleteTasksData = await _taskServices.GetInCompleteasksByDate();
            var completedTasksData = await _taskServices.GetCompletedTasksByDate();
            var inProgressTasksData = await _taskServices.GetInProgressTasksByDate();

            var plotModel = new PlotModel { Title = "Task Progression", TextColor = OxyColor.FromRgb(149, 61, 215) };

            var totalTasksSeries = new LineSeries
            {
                Title = "Total Tasks",
                ItemsSource = totalTasksData.Select(t => new DataPoint(DateTimeAxis.ToDouble(t.StartTime), t.Count)).ToArray(),
                Color = OxyColor.FromRgb(0, 0, 255),
                MarkerType = MarkerType.Circle
            };

            var incompleteTasksSeries = new LineSeries
            {
                Title = "Incomplete Tasks",
                ItemsSource = incompleteTasksData.Select(t => new DataPoint(DateTimeAxis.ToDouble(t.StartTime), t.Count)).ToArray(),
                Color = OxyColor.FromRgb(255, 0, 0),
                MarkerType = MarkerType.Triangle
            };

            var completedTasksSeries = new LineSeries
            {
                Title = "Completed Tasks",
                ItemsSource = completedTasksData.Select(t => new DataPoint(DateTimeAxis.ToDouble(t.StartTime), t.Count)).ToArray(),
                Color = OxyColor.FromRgb(0, 128, 0),
                MarkerType = MarkerType.Square
            };

            var inProgressTasksSeries = new LineSeries
            {
                Title = "In Progress Tasks",
                ItemsSource = inProgressTasksData.Select(t => new DataPoint(DateTimeAxis.ToDouble(t.StartTime), t.Count)).ToArray(),
                Color = OxyColor.FromRgb(149, 61, 215),
                MarkerType = MarkerType.Diamond
            };

            plotModel.Series.Add(totalTasksSeries);
            plotModel.Series.Add(incompleteTasksSeries);
            plotModel.Series.Add(completedTasksSeries);
            plotModel.Series.Add(inProgressTasksSeries);

            plotModel.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "MMMM",
                Title = "Date"
            });

            var plotView = new PlotView
            {
                Model = plotModel,
                Dock = DockStyle.Fill
            };

            ChartPanel.Controls.Add(plotView);
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadAllTasks();
        }
        public async void LoadAllTasks()
        {

            await LoadTask();
            await LoadInProgressTask();
           await  LoadCompletedTask();
           await  LoadInCompleteTask();
            await InitializeChart();

        }
        public async Task LoadTask()
        {
            var totalTasks = await _taskServices.GetTotalTasksByDateAsync();
            int totalCount = totalTasks.Sum(task => task.Count);
            TotalTaskLbl.Text = totalCount.ToString();
        }

        public async Task LoadInProgressTask()
        {
            var inProgressTasks = await _taskServices.GetInProgressTasksByDate();
            int inProgressCount = inProgressTasks.Sum(task => task.Count);
            InProgressLbl.Text = inProgressCount.ToString();
        }

        public async Task LoadCompletedTask()
        {
            var completedTasks = await _taskServices.GetCompletedTasksByDate();
            int completedCount = completedTasks.Sum(task => task.Count);
            CompletedTaskLbl.Text = completedCount.ToString();
        }
        public async Task LoadInCompleteTask()
        {
            var AllUsers = await _taskServices.GetInCompleteasksByDate();
            int UsersCount = AllUsers.Sum(user => user.Count);
            InCompleteTaskLbl.Text = UsersCount.ToString();
        }

    }
}

