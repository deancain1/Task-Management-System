using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Data_Connectivity.Context;
using Task_Management_System.Domain.DTO;
using Task_Management_System.Domain.Entities;
using Task_Management_System.Helpers;
using Task_Management_System.Services.Contracts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Task_Management_System.Services
{
    public class CreateAccountServices : ICreateAccountServices
    {
        private readonly TMSDbContext _tMSDbContext;

        public CreateAccountServices(TMSDbContext tMSDbContext)
        {
            _tMSDbContext = tMSDbContext;
        }

        public async  Task<bool> UserEmailTaken(string email)
        {
            return await _tMSDbContext.Users.AnyAsync(u => u.Email == email);
        }
        public async Task<bool> AdminEmailTaken(string email)
        {
            return await _tMSDbContext.Admin.AnyAsync(u => u.Email == email);
        }
        public async Task<bool> UserUsernameTaken(string username)
        {
            return await _tMSDbContext.Users.AnyAsync(u => u.Username == username);
        }
        public async Task<bool> AdminUsernameTaken(string username)
        {
            return await _tMSDbContext.Admin.AnyAsync(u => u.Username == username);
        }


        public async Task RegisterAccountAdminAsync(AdminDTO adminDTO)
        {
            try
            {
              
                var existingAdmin = await _tMSDbContext.Admin
                    .SingleOrDefaultAsync(u => u.Email == adminDTO.Email);

                PasswordHashAndSalt.CreatePasswordHash(adminDTO.Password, out byte[] passwordHash, out byte[] passwordSalt);

                var createAdmin = new AdminEntity
                {
                    
                    LastName = adminDTO.LastName,
                    FirstName = adminDTO.FirstName,
                    MiddleName = adminDTO.MiddleName,
                    Email = adminDTO.Email,
                    Username = adminDTO.Username,
                    SecurityQuestions = adminDTO.SecurityQuestions,
                    Answer = adminDTO.Answer,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    ProfilePicture = adminDTO.ProfilePicture,
                    Role = adminDTO.Role,
                };


                _tMSDbContext.Admin.Add(createAdmin);
                await _tMSDbContext.SaveChangesAsync();
             
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Adding User:  {ex.Message}, {ex.InnerException ?? ex}");
            }
        }

        public async Task RegisterAccountUserAsync(UserDTO userDTO)
        {
            try
            {
              
                var existingUser = await _tMSDbContext.Users
                    .SingleOrDefaultAsync(u => u.Email == userDTO.Email);

                PasswordHashAndSalt.CreatePasswordHash(userDTO.Password, out byte[] passwordHash, out byte[] passwordSalt);
              
                var createUser = new UserEntity
                {
                    LastName = userDTO.LastName,
                    FirstName = userDTO.FirstName,
                    MiddleName = userDTO.MiddleName,
                    Email = userDTO.Email,
                    Username = userDTO.Username,
                    Department = userDTO.Department,
                    SecurityQuestions = userDTO.SecurityQuestions,
                    Answer = userDTO.Answer,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    ProfilePicture = userDTO.ProfilePicture,
                    Role = userDTO.Role,
                };

                _tMSDbContext.Users.Add(createUser);
                await _tMSDbContext.SaveChangesAsync();
               

            }
            catch (Exception ex)
            {
                throw new Exception($"Error Adding User:  {ex.Message}, {ex.InnerException ?? ex}");
            }


        }
    }
}
