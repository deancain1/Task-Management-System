using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            _taskServices = taskServices;
        }

        private async Task InitializeChart()
        {
            ChartPanel.Controls.Clear();

            int totalTasksCount = await _taskServices.GetTotalTasksCountAsync();
            int incompleteTasksCount = await _taskServices.GetIncompleteTasksCountAsync();
            int completedTasksCount = await _taskServices.GetCompletedTasksCountAsync();
            int inProgressTasksCount = await _taskServices.GetInProgressTasksCountAsync();

            var plotModel = new PlotModel { Title = "Task Distribution", TextColor = OxyColor.FromRgb(149, 61, 215) };

            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Task Status",
                Labels = { "Total", "Incomplete", "In Progress", "Completed" }
            };

            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Task Count",
                Minimum = 0
            };

            plotModel.Axes.Add(categoryAxis);
            plotModel.Axes.Add(valueAxis);

            var taskSeries = new LineSeries
            {
                Title = "Tasks",
                Color = OxyColor.FromRgb(0, 128, 255),
                MarkerType = MarkerType.Circle
            };

            taskSeries.Points.Add(new DataPoint(0, totalTasksCount));       
            taskSeries.Points.Add(new DataPoint(1, incompleteTasksCount)); 
            taskSeries.Points.Add(new DataPoint(2, inProgressTasksCount));  
            taskSeries.Points.Add(new DataPoint(3, completedTasksCount));   

            plotModel.Series.Add(taskSeries);

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
            await LoadCompletedTask();
            await LoadInCompleteTask();
            await InitializeChart();
        }

        public async Task LoadTask()
        {
            int totalCount = await _taskServices.GetTotalTasksCountAsync();
            TotalTaskLbl.Text = totalCount.ToString();
        }

        public async Task LoadInProgressTask()
        {
            int inProgressCount = await _taskServices.GetInProgressTasksCountAsync();
            InProgressLbl.Text = inProgressCount.ToString();
        }

        public async Task LoadCompletedTask()
        {
            int completedCount = await _taskServices.GetCompletedTasksCountAsync();
            CompletedTaskLbl.Text = completedCount.ToString();
        }

        public async Task LoadInCompleteTask()
        {
            int incompleteCount = await _taskServices.GetIncompleteTasksCountAsync();
            InCompleteTaskLbl.Text = incompleteCount.ToString();
        }
    }
}
