using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_Management_System.Domain.Entities
{
    public class UserEntity
    {
        [Key]
        public int UserID { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;

        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
        public string SecurityQuestions {  get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public byte[]? ProfilePicture { get; set; }
        public string Role {  get; set; } = string.Empty;
        public ICollection<TaskEntity> Tasks { get; set; } = null!;
        public ICollection<UserRoleEntity> userRoleEntities { get; set; } = null!;

       
    }
}
