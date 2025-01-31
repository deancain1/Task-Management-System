using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Management_System.Data_Connectivity.Context;
using Task_Management_System.Domain.Entities;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly TMSDbContext _tMSDbContext;
        public AdminServices(TMSDbContext tMSDbContext)
        {
            _tMSDbContext = tMSDbContext;
        }
        public async Task<AdminEntity?> GetAdminByEmailAsync(string email)
        {

            return await _tMSDbContext.Admin
                         .Where(a => a.Email == email)
                         .FirstOrDefaultAsync();

        }
    }
}
