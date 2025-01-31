using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Management_System.Domain.DTO;
using Task_Management_System.Domain.Entities;

namespace Task_Management_System.Services.Contracts
{
    public interface IUserServices
    {
        Task<UserEntity?> GetUserByEmailAsync(string email);
        Task<List<UserEntity>> GetAllUserNamesAsync();
        Task<List<UserEntity>> GetAllUsersAsync();
        Task<bool> DeleteUserAsync(string email);
        Task <UserEntity?> GetUserByIdAsync (int userID);
    }
}
