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

namespace Task_Management_System.Services
{
    public class CreateAccountServices : ICreateAccountServices
    {
        private readonly TMSDbContext _tMSDbContext;

        public CreateAccountServices(TMSDbContext tMSDbContext)
        {
            _tMSDbContext = tMSDbContext;
        }

       
        public async Task RegisterAccountAdminAsync(AdminDTO adminDTO)
        {
            try
            {
              
                var existingAdmin = await _tMSDbContext.Admin
                    .SingleOrDefaultAsync(u => u.Email == adminDTO.Email);

                if (existingAdmin!= null)
                {
                    throw new Exception($"A admin with the email '{adminDTO.Email}' already exists.");
                   
                }

                PasswordHashAndSalt.CreatePasswordHash(adminDTO.Password, out byte[] passwordHash, out byte[] passwordSalt);

                var createAdmin = new AdminEntity
                {
                    
                    LastName = adminDTO.LastName,
                    FirstName = adminDTO.FirstName,
                    MiddleName = adminDTO.MiddleName,
                    Email = adminDTO.Email,
                    SecurityQuestions = adminDTO.SecurityQuestions,
                    Answer = adminDTO.Answer,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    ProfilePicture = adminDTO.ProfilePicture,
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

                if (existingUser != null)
                {
                    
                 throw new Exception($"A user with the email '{userDTO.Email}' already exists.");
                 
                }

         
                PasswordHashAndSalt.CreatePasswordHash(userDTO.Password, out byte[] passwordHash, out byte[] passwordSalt);
              
                var createUser = new UserEntity
                {
                    
                    FirstName = userDTO.FirstName,
                    LastName = userDTO.LastName,
                    MiddleName = userDTO.MiddleName,
                    Email = userDTO.Email,
                    Username = userDTO.Username,
                    Department = userDTO.Department,
                    SecurityQuestions = userDTO.SecurityQuestions,
                    Answer = userDTO.Answer,
                    Role = userDTO.Role,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    ProfilePicture = userDTO.ProfilePicture,
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
