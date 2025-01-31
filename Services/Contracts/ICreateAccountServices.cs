using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Management_System.Domain.DTO;

namespace Task_Management_System.Services.Contracts
{
    public interface ICreateAccountServices
    {
        Task RegisterAccountUserAsync(UserDTO userDTO);
        Task RegisterAccountAdminAsync(AdminDTO adminDTO);
    }
}
