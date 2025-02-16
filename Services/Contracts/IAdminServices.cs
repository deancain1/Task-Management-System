using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Management_System.Domain.DTO;
using Task_Management_System.Domain.Entities;

namespace Task_Management_System.Services.Contracts
{
    public interface IAdminServices
    {
        Task<AdminEntity?> GetAdminByEmailAsync(string email);
        Task<List<AdminEntity>> GetAllAdminAsync();
        Task<AdminEntity?> GetAdminByIDAsync(int adminID);
        Task<bool> DeleteAdminAsync(string email);
        Task UpdateAdminAccountAsync(AdminEntity adminEntity);
        Task<AdminEntity?> GetAdminInfoAsync();
        Task UpdateAccountAdminWithPasswordAsync(AdminDTO adminDTO);
        Task<AdminEntity?> GetAdminEmailForForgotPassword(string email);
        Task<bool> UpdateForgottenPasswordAsync(string email, string securityQuestion, string newPassword);
    }
}
