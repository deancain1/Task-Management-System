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
           
            using (var dbContex = new TMSDbContext(_dbContextOptions))
            {
                try
                {
                    var CreateTask = new TaskEntity

                    {
                    TaskTitle = taskDTO.TaskTitle,
                    TaskDescription = taskDTO.TaskDescription,
                    StartTime = taskDTO.StartTime,
                    Deadline = taskDTO.Deadline,
                    AssignTo = taskDTO.AssignTo,
                    UserID = taskDTO.UserID,
                    Status = taskDTO.Status,
                    };
                    dbContex.Tasks.Add(CreateTask);
                    await dbContex.SaveChangesAsync();
              
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error Creating Task:  {ex.Message}, {ex.InnerException ?? ex}");
                }
            }
        }

        public async  Task<List<TaskEntity>> GetAllTaskAsync()
        {
            using (var dbContex = new TMSDbContext(_dbContextOptions))
            {
                return await dbContex.Tasks.ToListAsync();
            }
        }

        public async  Task<List<TaskEntity>> GetCompletedTasksForUserAsync()
        {
            using (var dbContex = new TMSDbContext(_dbContextOptions))
            {
                var loggedInUserId = UserSession.UserID;
                return await dbContex.Tasks
                           .Where(task => task.UserID == loggedInUserId && task.Status == "Completed") 
                           .ToListAsync();
            }
        }

        public async Task<List<TaskEntity>> GetTasksForUserAsync()
        {
            using (var dbContex = new TMSDbContext(_dbContextOptions))
            {
                var loggedInUserId = UserSession.UserID;
                return await dbContex.Tasks
                            .Where(task => task.UserID == loggedInUserId && (task.Status == "Not Started" || task.Status == "Incomplete" || task.Status == "In Progress")) 
                            .ToListAsync();
            }
        }
        public async Task<int> GetTotalTasksCountAsync()
        {
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                return await dbContext.Tasks.CountAsync();
            }
        }

        public async  Task<int> GetNotStartedTasksCountAsync()
        {
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                return await dbContext.Tasks.CountAsync(t => t.Status == "Not Started");
            }
        }
        public async Task<int> GetIncompleteTaskCountAsync()
        {
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                return await dbContext.Tasks.CountAsync(t => t.Status == "Incomplete");
            }
        }
        public async Task<int> GetInProgressTasksCountAsync()
        {
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                return await dbContext.Tasks.CountAsync(t => t.Status == "In Progress");
            }
        }

        public async Task<int> GetCompletedTasksCountAsync()
        {
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                return await dbContext.Tasks.CountAsync(t => t.Status == "Completed");
            }
        }
       

  
        public async Task UpdateTaskStatusAsync(TaskEntity taskEntity)
        {
            try
            {
                using (var dbContex = new TMSDbContext(_dbContextOptions))
                {
                    var existingTask = await dbContex.Tasks.FirstOrDefaultAsync(t => t.TaskID == taskEntity.TaskID);
                    if (existingTask != null)
                    {
                        existingTask.Status = taskEntity.Status;
                        await dbContex.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Upadating Task Status:  {ex.Message}, {ex.InnerException ?? ex}");
            }
        }

        public async Task<bool> DeleteTaskAsync(int taksID)
        {
            using (var dbContex = new TMSDbContext(_dbContextOptions))
            {
                var task = await dbContex.Tasks.
                    FirstOrDefaultAsync(task => taksID == task.TaskID);
                if (task == null)
                {
                return false;
                }

                dbContex.Tasks.Remove(task);
                await dbContex.SaveChangesAsync();
                return true;
            }
           
        }

        public async Task<TaskEntity?> GetTaskByIdAsync(int taskId)
        {
            using (var dbContex = new TMSDbContext(_dbContextOptions))
            {
                return await dbContex.Tasks.FirstOrDefaultAsync(task => task.TaskID == taskId);
            }
        }

        public async Task UpdateTaskAsync(TaskEntity taskEntity)
        {
            try
            {
                using (var dbContex = new TMSDbContext(_dbContextOptions))
                {
                    var existingTask = await dbContex.Tasks.FirstOrDefaultAsync(task => task.TaskID == taskEntity.TaskID);
                    if (existingTask != null)
                    {

                        existingTask.TaskTitle = taskEntity.TaskTitle;
                        existingTask.TaskDescription = taskEntity.TaskDescription;
                        existingTask.StartTime = taskEntity.StartTime;
                        existingTask.Deadline = taskEntity.Deadline;
                        existingTask.Status = taskEntity.Status;

                        await dbContex.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Upadating Task:  {ex.Message}, {ex.InnerException ?? ex}");
            }
        }
    }
}
