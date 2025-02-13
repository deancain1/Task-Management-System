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
        private readonly DbContextOptions<TMSDbContext> _dbContextOptions;
        public AdminServices(DbContextOptions<TMSDbContext> dbContextOptions)
        {
            _dbContextOptions = dbContextOptions;
        }

        public async Task<AdminEntity?> GetAdminByEmailAsync(string email)
        {
            using (var dbContex = new TMSDbContext(_dbContextOptions))
            {
                return await dbContex.Admin
                             .Where(a => a.Email == email)
                             .FirstOrDefaultAsync();
            }
        }

        public async Task<AdminEntity?> GetAdminByIDAsync(int adminID)
        {
            using (var dbContex = new TMSDbContext(_dbContextOptions))
            {
                return await dbContex.Admin.FirstOrDefaultAsync(a => a.AdminID == adminID);
            }
        }

        public async Task<List<AdminEntity>> GetAllAdminAsync()
        {
            using (var dbContex = new TMSDbContext(_dbContextOptions))
            {
                return await dbContex.Admin.ToListAsync();
            }
        }

        public async Task<AdminEntity?> GetUserByEmailAsync(string email)
        {
            using (var dbContex = new TMSDbContext(_dbContextOptions))
            {
                return await dbContex.Admin
                            .Where(a => a.Email == email)
                            .FirstOrDefaultAsync();
            }
        }
        public async Task UpdateAdminAccountAsync(AdminEntity adminEntity)
        {
            using (var dbContex = new TMSDbContext(_dbContextOptions))
            {
                var existingAdmin = await dbContex.Admin.FirstOrDefaultAsync(admin => admin.AdminID == admin.AdminID);
                if (existingAdmin != null)
                {
                    existingAdmin.LastName = adminEntity.LastName;
                    existingAdmin.FirstName = adminEntity.FirstName;
                    existingAdmin.MiddleName = adminEntity.MiddleName;
                    existingAdmin.Email = adminEntity.Email;

                    await dbContex.SaveChangesAsync();
                }
            }
        }
        public async Task<bool> DeleteAdminAsync(string email)
        {
            using (var dbContex = new TMSDbContext(_dbContextOptions))
            {
                var admin = await dbContex.Admin.
                    FirstOrDefaultAsync(admin => email == admin.Email);
                if (admin == null)
                {
                    return false;
                }

                dbContex.Admin.Remove(admin);
                await dbContex.SaveChangesAsync();
                return true;
            }
        }
    }
}
