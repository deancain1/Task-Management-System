using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Task_Management_System.Domain.Entities
{
    public class AdminEntity
    {
        [Key]
        public int AdminID { get; set; }

        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SecurityQuestions { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public byte[]? ProfilePicture { get; set; }
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
  

    }
}
