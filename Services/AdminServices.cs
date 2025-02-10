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
            this._dbContextOptions = dbContextOptions;
        }

 

        public async Task<AdminEntity?> GetAdminByEmailAsync(string email)
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Admin
                             .Where(a => a.Email == email)
                             .FirstOrDefaultAsync();
            }
        }

        public async Task<AdminEntity?> GetAdminByIDAsync(int adminID)
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Admin.FirstOrDefaultAsync(a => a.AdminID == adminID);
            }
        }

        public async Task<List<AdminEntity>> GetAllAdminAsync()
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Admin.ToListAsync();
            }
        }

        public async Task<AdminEntity?> GetUserByEmailAsync(string email)
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Admin
                            .Where(a => a.Email == email)
                            .FirstOrDefaultAsync();
            }
        }
        public async Task UpdateAdminAccountAsync(AdminEntity adminEntity)
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                var existingAdmin = await dbContextOptions.Admin.FirstOrDefaultAsync(admin => admin.AdminID == admin.AdminID);
                if (existingAdmin != null)
                {
                    existingAdmin.LastName = adminEntity.LastName;
                    existingAdmin.FirstName = adminEntity.FirstName;
                    existingAdmin.MiddleName = adminEntity.MiddleName;
                    existingAdmin.Email = adminEntity.Email;

                    await dbContextOptions.SaveChangesAsync();
                }
            }
        }
        public async Task<bool> DeleteAdminAsync(string email)
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                var admin = await dbContextOptions.Admin.
                    FirstOrDefaultAsync(admin => email == admin.Email);
                if (admin == null)
                {
                    return false;
                }

                dbContextOptions.Admin.Remove(admin);
                await dbContextOptions.SaveChangesAsync();
                return true;
            }
        }
    }
}
