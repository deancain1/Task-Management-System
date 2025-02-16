using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System.Domain.Entities
{
    public class UserRoleEntity
    {
        
        public int UserRoleID { get; set; }
        public int UserID { get; set; }
        public UserEntity User { get; set; }
        public int RoleID { get; set; }
        public RoleEntity Role { get; set; }

    }
}
