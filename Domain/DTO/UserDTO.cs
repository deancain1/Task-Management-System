using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System.Domain.DTO
{
    public class UserDTO
    {
    
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string SecurityQuestions { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public string  Password { get; set; } = string.Empty;
        public byte[]? ProfilePicture { get; set; }
        public string Role {  get; set; } = string.Empty;
      
    }
}
