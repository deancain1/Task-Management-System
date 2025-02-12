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

        public async Task<UserEntity?> GetUserInfoAsync()
        {
            using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                int loggedInUserId = UserSession.UserID;

                return await dbContextOptions.Users
                    .AsNoTracking()
                    .FirstOrDefaultAsync(user => user.UserID == loggedInUserId);
                   

            }
        }

        public async Task UpdateAccountUserWithPasswordAsync(UserDTO userDTO)
        {
           using (var dbContextOptions = new TMSDbContext(_dbContextOptions))
            {
                try
                {

                    var existingUser = await dbContextOptions.Users
                        .SingleOrDefaultAsync(u => u.Email.ToLower() == userDTO.Email.ToLower());

                    if (existingUser == null)
                    {
                        throw new InvalidOperationException($"No user found with the email '{userDTO.Email}'.");
                    }


                    existingUser.FirstName = userDTO.FirstName;
                    existingUser.LastName = userDTO.LastName;
                    existingUser.MiddleName = userDTO.MiddleName;
                    existingUser.SecurityQuestions = userDTO.SecurityQuestions;
                    existingUser.Answer = userDTO.Answer;
                    existingUser.Role = userDTO.Role;


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

                    dbContextOptions.Users.Update(existingUser);
                    await dbContextOptions.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error Updating User: {ex.Message}", ex.InnerException ?? ex);
                }
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
                    existingUser.ProfilePicture = userEntity.ProfilePicture;


                    await dbContextOptions.SaveChangesAsync();
                }
            }
        }
    }
}
