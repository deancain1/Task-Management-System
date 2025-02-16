using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Management_System.Data_Connectivity.Context;
using Task_Management_System.Domain.DTO;
using Task_Management_System.Domain.Entities;
using Task_Management_System.Helpers;
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

        public async Task UpdateAdminAccountAsync(AdminEntity adminEntity)
        {
            try
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
                        existingAdmin.ProfilePicture = adminEntity.ProfilePicture;

                        await dbContex.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating admin account: {ex.Message}", ex);
            }
        }
        public async Task<bool> DeleteAdminAsync(string email)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception($"Error deleting admin: {ex.Message}", ex);
            }
        }

        public async Task<AdminEntity?> GetAdminInfoAsync()
        {
          
                using (var dbContext = new TMSDbContext(_dbContextOptions))
                {
                    int loggedInUserId = AdminSession.AdminID;

                    return await dbContext.Admin
                        .AsNoTracking()
                        .FirstOrDefaultAsync(user => user.AdminID == loggedInUserId);
                }
           
        }

        public async Task UpdateAccountAdminWithPasswordAsync(AdminDTO adminDTO)
        {
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                try
                {

                    var existingAdmin = await dbContext.Admin
                        .SingleOrDefaultAsync(u => u.Email.ToLower() == adminDTO.Email.ToLower());

                    if (existingAdmin != null)
                    {

                        existingAdmin.FirstName = adminDTO.FirstName;
                        existingAdmin.LastName = adminDTO.LastName;
                        existingAdmin.MiddleName = adminDTO.MiddleName;
                        existingAdmin.SecurityQuestions = adminDTO.SecurityQuestions;
                        existingAdmin.Answer = adminDTO.Answer;



                        if (!string.IsNullOrEmpty(adminDTO.Password))
                        {
                            PasswordHashAndSalt.CreatePasswordHash(adminDTO.Password, out byte[] passwordHash, out byte[] passwordSalt);
                            existingAdmin.PasswordHash = passwordHash;
                            existingAdmin.PasswordSalt = passwordSalt;
                        }


                        if (adminDTO.ProfilePicture != null)
                        {
                            existingAdmin.ProfilePicture = adminDTO.ProfilePicture;
                        }

                        dbContext.Admin.Update(existingAdmin);
                    }
                    await dbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error updating admin account: {ex.Message}", ex);
                }
            }
        }

        public async Task<AdminEntity?> GetAdminEmailForForgotPassword(string email)
        {

            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                return await dbContext.Admin
                    .Where(user => user.Email == email)
                    .Select(user => new AdminEntity
                    {
                        Email = user.Email,
                        FirstName = user.FirstName,
                        MiddleName = user.MiddleName,
                        LastName = user.LastName,
                        SecurityQuestions = user.SecurityQuestions,
                        Answer = user.Answer,
                        ProfilePicture = user.ProfilePicture,
                    })
                    .FirstOrDefaultAsync();
            }
        }
        public async Task<bool> UpdateForgottenPasswordAsync(string email, string securityQuestion, string newPassword)
        {
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                try
                {
                    var existingAdmin = await dbContext.Admin
                        .FirstOrDefaultAsync(u => u.Email == email && u.SecurityQuestions == securityQuestion);

                    if (existingAdmin == null)
                    {
                        return false;
                    }

                    if (!string.IsNullOrEmpty(newPassword))
                    {
                        PasswordHashAndSalt.CreatePasswordHash(newPassword, out byte[] passwordHash, out byte[] passwordSalt);
                        existingAdmin.PasswordHash = passwordHash;
                        existingAdmin.PasswordSalt = passwordSalt;
                    }

                    dbContext.Admin.Update(existingAdmin);
                    await dbContext.SaveChangesAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error updating password: {ex.Message}", ex);
                }
            }
        }
    }
}
