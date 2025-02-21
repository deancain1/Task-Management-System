﻿using Microsoft.EntityFrameworkCore;
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
using Task_Management_System.Helpers;
using Task_Management_System.Services.Contracts;

namespace Task_Management_System.Services
{
    public class UserServices : IUserServices
    {
        private readonly DbContextOptions<TMSDbContext> _dbContextOptions;
        public UserServices(DbContextOptions<TMSDbContext> dbContextOptions)
        {

            _dbContextOptions = dbContextOptions;

        }

   

        public async Task<List<UserEntity>> GetAllUserNamesAsync()
        {
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                return await dbContext.Users
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
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                return await dbContext.Users.ToListAsync();
            }
        }

        public async Task<UserEntity?> GetUserByEmailAsync(string email)
        {

            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                return await dbContext.Users
               .FirstOrDefaultAsync(u => u.Email == email);
            }
        }
    
    

        public async Task<UserEntity?> GetUserByIdAsync(int userID)
        {
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                return await dbContext.Users.FirstOrDefaultAsync(a => a.UserID == userID);
            }
        }

        public async Task<UserEntity?> GetUserEmailForForgotPassword(string email)
        {
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                return await dbContext.Users
                    .Where(user => user.Email == email)
                    .Select(user => new UserEntity
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

        public async Task<UserEntity?> GetUserInfoAsync()
        {
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                int loggedInUserId = UserSession.UserID;

                return await dbContext.Users
                    .AsNoTracking()
                    .FirstOrDefaultAsync(user => user.UserID == loggedInUserId);
                   

            }
        }

        public async Task UpdateAccountUserWithPasswordAsync(UserDTO userDTO)
        {
           using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                try
                {

                    var existingUser = await dbContext.Users
                        .SingleOrDefaultAsync(u => u.Email == userDTO.Email);

                    if (existingUser == null)
                    {
                        throw new InvalidOperationException($"No user found with the email '{userDTO.Email}'.");
                    }

                    existingUser.FirstName = userDTO.FirstName;
                    existingUser.MiddleName = userDTO.MiddleName;
                    existingUser.LastName = userDTO.LastName;
                    existingUser.Username = userDTO.Username;

                    if (!string.IsNullOrEmpty(userDTO.Password))
                    {
                        PasswordHashAndSalt.CreatePasswordHash(userDTO.Password, out byte[] passwordHash, out byte[] passwordSalt);
                        existingUser.PasswordHash = passwordHash;
                        existingUser.PasswordSalt = passwordSalt;
                    }


                    if (userDTO.ProfilePicture != null)
                    {
                        existingUser.ProfilePicture = userDTO.ProfilePicture;
                    }

                    dbContext.Users.Update(existingUser);
                    await dbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error Updating User: {ex.Message}", ex.InnerException ?? ex);
                }
            }
        }
      
        public async Task UpdateUserAccountAsync(UserEntity userEntity)
        {
            try
            {
                using (var dbContext = new TMSDbContext(_dbContextOptions))
                {
                    var existingUser = await dbContext.Users.FirstOrDefaultAsync(user => user.UserID == userEntity.UserID);
                    if (existingUser != null)
                    {
                        existingUser.LastName = userEntity.LastName;
                        existingUser.FirstName = userEntity.FirstName;
                        existingUser.MiddleName = userEntity.MiddleName;
                        existingUser.Email = userEntity.Email;
                        existingUser.Username = userEntity.Username;
                        existingUser.ProfilePicture = userEntity.ProfilePicture;


                        await dbContext.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex) {

                throw new Exception($"Error Updating User: {ex.Message}", ex.InnerException ?? ex);
            }
        }

        public async Task<bool> UpdateForgottenPasswordAsync(string email, string securityQuestion, string newPassword)
        {
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                try
                {
                    var existingUser = await dbContext.Users
                        .FirstOrDefaultAsync(u => u.Email == email && u.SecurityQuestions == securityQuestion);

                    if (existingUser == null)
                    {
                        return false;
                    }

                    if (!string.IsNullOrEmpty(newPassword))
                    {
                        PasswordHashAndSalt.CreatePasswordHash(newPassword, out byte[] passwordHash, out byte[] passwordSalt);
                        existingUser.PasswordHash = passwordHash;
                        existingUser.PasswordSalt = passwordSalt;
                    }

                    dbContext.Users.Update(existingUser);
                    await dbContext.SaveChangesAsync();
                    return true; 
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error updating password: {ex.Message}", ex);
                }
            }
        }
        public async Task<bool> DeleteUserAsync(string email)
        {
            using (var dbContext = new TMSDbContext(_dbContextOptions))
            {
                var user = await dbContext.Users.
                    FirstOrDefaultAsync(users => email == users.Email);
                if (user == null)
                {
                    return false;
                }

                dbContext.Users.Remove(user);
                await dbContext.SaveChangesAsync();
                return true;
            }
        }
    }
}
