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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Task_Management_System.Services
{
    public class CreateAccountServices : ICreateAccountServices
    {
        private readonly TMSDbContext _tMSDbContext;

        public CreateAccountServices(TMSDbContext tMSDbContext) {
            _tMSDbContext = tMSDbContext;

        }

        public async Task RegisterAccountAdminAsync(AdminDTO adminDTO)
        {
            if (adminDTO.Password != adminDTO.ConfirmPassword)
            {
                MessageBox.Show("Passwords do not match.");

            }

            if (await _tMSDbContext.Admin.AnyAsync(u => u.Email == adminDTO.Email))
            {
                MessageBox.Show("Email is already in use.");

            }
            else
            {

                PasswordHashAndSalt.CreatePasswordHash(adminDTO.Password, out byte[] PasswordHash, out byte[] PasswordSalt);

                // save data to database from dto
                var RegisterAdmin = new AdminEntity
                {
                    LastName = adminDTO.LastName,
                    FirstName = adminDTO.FirstName,
                    MiddleName = adminDTO.MiddleName,
                    Email = adminDTO.Email,
                    PasswordHash = PasswordHash,
                    PasswordSalt = PasswordSalt,

                };

                try
                {
                    _tMSDbContext.Admin.Add(RegisterAdmin);
                    await _tMSDbContext.SaveChangesAsync();
                    MessageBox.Show("Registration successful.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        }

        public async Task RegisterAccountUserAsync(UserDTO userDTO)
        {
           

            if (await _tMSDbContext.Users.AnyAsync(u => u.Email == userDTO.Email))
            {
                MessageBox.Show("Email is already in use.");

            }
            else
            {

                PasswordHashAndSalt.CreatePasswordHash(userDTO.Password, out byte[] PasswordHash, out byte[] PasswordSalt);

                // save data to database from dto
                var RegisterUser = new UserEntity
                {
                    LastName = userDTO.LastName,
                    FirstName = userDTO.FirstName,
                    MiddleName = userDTO.MiddleName,
                    Email = userDTO.Email,
                    UserProfile = userDTO.UserProfile,
                    PasswordHash = PasswordHash,
                    PasswordSalt = PasswordSalt,

                };

                try
                {
                    _tMSDbContext.Users.Add(RegisterUser);
                    await _tMSDbContext.SaveChangesAsync();
                    MessageBox.Show("Registration successful.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        }

    }
}
