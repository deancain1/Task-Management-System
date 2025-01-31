using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Task_Management_System.Data_Connectivity.Context;
using Task_Management_System.Domain.Entities;
using System;
using System.IO;
using System.Windows.Forms;
using Task_Management_System.Services.Contracts;
using Task_Management_System.Services;
using Task_Management_System.Presentation;
using Task_Management_System.Presentation.AdminInterface;
using Task_Management_System.Presentation.Modal;
using Task_Management_System.Presentation.UserInterface;

namespace Task_Management_System
{
     static class Program
    {

        public static IServiceProvider? ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();


            var services = new ServiceCollection();

            services.AddScoped<ICreateAccountServices, CreateAccountServices>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ITaskServices, TaskServices>();
            services.AddScoped<IAdminServices, AdminServices>();


            services.AddScoped<AdminEntity>();
            services.AddScoped<UserEntity>();
            services.AddScoped<TaskEntity>();


            //Admin Interfaces
        
            services.AddScoped<SideBarForm>();
            services.AddScoped<DashboardForm>();
            services.AddScoped<CreateTaskForm>();  
            services.AddScoped<CreateTaskModalForm>();
            services.AddScoped<AddUserForm>();
            services.AddScoped<AddUserModalForm>();
            services.AddScoped<EditTaskModalForm>();
            services.AddScoped<EditUserAccountModal>();

            //Both
            services.AddScoped<RegisterAdminForm>();
            services.AddScoped<LoginForm>();

            //User Interfaces
            services.AddScoped<NavigationBarForm>();
            services.AddScoped<TasksForm>();
            services.AddScoped<CompletedTaskForm>();
          

            services.AddDbContext<TMSDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            ServiceProvider = services.BuildServiceProvider();
 
            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }
    }
}