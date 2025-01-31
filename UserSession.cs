using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    public static class UserSession
    {
        public static int ?UserID { get; set; }

        // Store the currently logged-in user's email
        public static string Email { get; set; }
    }
}
