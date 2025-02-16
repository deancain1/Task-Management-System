using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System.Domain.Entities
{
    public class RoleEntity
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public ICollection<UserRoleEntity> Roles { get; set; } = null!;
    }
}
