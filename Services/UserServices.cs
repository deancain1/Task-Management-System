using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Data_Connectivity.Context;
using Task_Management_System.Domain.DTO;
using Task_Management_System.Domain.Entities;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Services
{
    public class UserServices : IUserServices
    {
        private readonly DbContextOptions<TMSDbContext> _dbContextOptions;
        public UserServices(DbContextOptions<TMSDbContext> dbContextOptions)
        {

            this._dbContextOptions = dbContextOptions;

        }

        public async Task<bool> DeleteUserAsync(string email)
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                var user = await dbContextOptions.Users.
                    FirstOrDefaultAsync(users => email == users.Email);
                if (user == null)
                {
                    return false;
                }

                dbContextOptions.Users.Remove(user);
                await dbContextOptions.SaveChangesAsync();
                return true;
            }
        }

        public async Task<List<UserEntity>> GetAllUserNamesAsync()
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Users
                                           .Select(user => new UserEntity
                                           {
                                               UserID = user.UserID,
                                               FirstName = user.FirstName,
                                               MiddleName = user.MiddleName,
                                               LastName = user.LastName
                                           })
                                           .ToListAsync();
            }
        }

        public async Task<List<UserEntity>> GetAllUsersAsync()
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Users.ToListAsync();
            }
        }

        public async Task<UserEntity?> GetUserByEmailAsync(string email)
        {
            try
            {
                using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
                {
                    return await dbContextOptions.Users
                   .FirstOrDefaultAsync(u => u.Email == email);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving users email.{ex.Message} ", ex);
            }
        }

        public async Task<UserEntity?> GetUserByIdAsync(int userID)
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Users.FirstOrDefaultAsync(a => a.UserID == userID);
            }
        }
        public async Task UpdateUserAccountAsync(UserEntity userEntity)
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                var existingUser = await dbContextOptions.Users.FirstOrDefaultAsync(user => user.UserID == user.UserID);
                if (existingUser != null)
                {
                    existingUser.LastName = userEntity.LastName;
                    existingUser.FirstName = userEntity.FirstName;
                    existingUser.MiddleName = userEntity.MiddleName;
                    existingUser.Email = userEntity.Email;

                    await dbContextOptions.SaveChangesAsync();
                }
            }
        }
    }
}
