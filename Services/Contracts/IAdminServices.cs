using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Management_System.Domain.Entities;

namespace Task_Management_System.Services.Contracts
{
    public interface IAdminServices
    {
        Task<AdminEntity?> GetAdminByEmailAsync(string email);
    }
}
