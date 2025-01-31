using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Management_System.Data_Connectivity.Context;
using Task_Management_System.Domain.DTO;
using Task_Management_System.Domain.Entities;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Services
{
    public class TaskServices : ITaskServices
    {
        private readonly DbContextOptions<TMSDbContext> _dbContextOptions;


        public TaskServices(DbContextOptions<TMSDbContext> dbContextOptions)
        {
            _dbContextOptions = dbContextOptions;
          

        }
        public async  Task CreateTaskByAsync(TasksDTO taskDTO)
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                var CreateTask = new TaskEntity
                {
                    TaskTitle = taskDTO.TaskTitle,
                    TaskDescription = taskDTO.TaskDescription,
                    StartTime = taskDTO.StartTime,
                    EndTime = taskDTO.EndTime,
                    AssignTo = taskDTO.AssignTo,
                    UserID = taskDTO.UserID,
                    Status = taskDTO.Status,

                };

                try
                {
                    dbContextOptions.Tasks.Add(CreateTask);
                    await dbContextOptions.SaveChangesAsync();
                    MessageBox.Show("Assign Task successful.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        public async  Task<List<TaskEntity>> GetAllTaskAsync()
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Tasks.ToListAsync();
            }
        }

        public async  Task<List<TaskEntity>> GetCompletedTasksForUserAsync()
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                var loggedInUserId = UserSession.UserID;
                return await dbContextOptions.Tasks
                           .Where(task => task.UserID == loggedInUserId && task.Status == "Completed") // Assuming 'UserID' is the foreign key
                           .ToListAsync();
            }
        }

        public async Task<List<TaskEntity>> GetTasksForUserAsync()
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                var loggedInUserId = UserSession.UserID;
                return await dbContextOptions.Tasks
                            .Where(task => task.UserID == loggedInUserId && (task.Status == "Incomplete" || task.Status == "In Progress")) // Assuming 'UserID' is the foreign key
                            .ToListAsync();
            }
        }

        public async Task<List<TasksDTO>> GetTotalTasksByDateAsync()
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
              return await  dbContextOptions.Tasks
               .GroupBy(t => t.StartTime.Date)
               .Select(g => new TasksDTO
               {
               StartTime = g.Key,
               Count = g.Count()
               })
              .OrderBy(t => t.StartTime)
              .ToListAsync();
            }
        }

        public async Task<List<TasksDTO>> GetInCompleteasksByDate()
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Tasks
                  .Where(t => t.Status == "InComplete")
                  .GroupBy(t => t.StartTime.Date)
                  .Select(g => new TasksDTO
                  {
                      StartTime = g.Key,
                      Count = g.Count()
                  })
                 .OrderBy(t => t.StartTime)
                 .ToListAsync();
            }
        }
        public async Task<List<TasksDTO>> GetInProgressTasksByDate()
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Tasks
                    .Where(t => t.Status == "In Progress")
                    .GroupBy(t => t.StartTime.Date)
                    .Select(g => new TasksDTO
                    {
                        StartTime = g.Key,
                        Count = g.Count()
                    })
                    .OrderBy(t => t.StartTime)
                    .ToListAsync();
            }
        }

        public async Task<List<TasksDTO>> GetCompletedTasksByDate()
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
              return await  dbContextOptions.Tasks
                .Where(t => t.Status == "Completed")
                .GroupBy(t => t.StartTime.Date)
                .Select(g => new TasksDTO
                {
                StartTime = g.Key,
                Count = g.Count()
                })
               .OrderBy(t => t.StartTime)
               .ToListAsync();
            }
        }

       
  
        public async Task UpdateTaskStatusAsync(TaskEntity taskEntity)
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                var existingTask = await dbContextOptions.Tasks.FirstOrDefaultAsync(t => t.TaskID == taskEntity.TaskID);
                if ( existingTask != null)
                {
                    existingTask.Status = taskEntity.Status;
                    await dbContextOptions.SaveChangesAsync();
                }
            }
        }

        public async Task<bool> DeleteTaskAsync(int taksID)
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                var task = await dbContextOptions.Tasks.
                    FirstOrDefaultAsync(task => taksID == task.TaskID);
                if (task == null)
                {
                return false;
                }

                dbContextOptions.Tasks.Remove(task);
                await dbContextOptions.SaveChangesAsync();
                return true;
            }
           
        }

        public async Task<TaskEntity?> GetTaskByIdAsync(int taskId)
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Tasks.FirstOrDefaultAsync(task => task.TaskID == taskId);
            }
        }

        public async Task UpdateTaskAsync(TaskEntity taskEntity)
        {
            using ( var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                var existingTask = await dbContextOptions.Tasks.FirstOrDefaultAsync(task=> task.TaskID == taskEntity.TaskID);
                if (existingTask != null) { 

                existingTask.TaskTitle = taskEntity.TaskTitle;
                existingTask.TaskDescription = taskEntity.TaskDescription;
                existingTask.StartTime = taskEntity.StartTime;
                existingTask.EndTime = taskEntity.EndTime;
                existingTask.Status = taskEntity.Status;

                await dbContextOptions.SaveChangesAsync();
                }
            }
        }
    }
}
