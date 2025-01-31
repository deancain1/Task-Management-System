using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Management_System.Domain.DTO;
using Task_Management_System.Domain.Entities;

namespace Task_Management_System.Services.Contracts
{
  public interface ITaskServices
    {
        Task CreateTaskByAsync(TasksDTO taskDTO);
        Task<List<TaskEntity>> GetTasksForUserAsync();
        Task UpdateTaskStatusAsync (TaskEntity taskEntity);
        Task<List<TaskEntity>> GetCompletedTasksForUserAsync();
        Task<List<TasksDTO>> GetTotalTasksByDateAsync();
        Task<List<TasksDTO>> GetInCompleteasksByDate();
        Task<List<TasksDTO>> GetCompletedTasksByDate();
        Task<List<TasksDTO>> GetInProgressTasksByDate();
        Task<List<TaskEntity>> GetAllTaskAsync();
        Task<TaskEntity?> GetTaskByIdAsync(int taskId);
        Task<bool> DeleteTaskAsync(int taksID);
        Task UpdateTaskAsync(TaskEntity taskEntity);
    }
}
