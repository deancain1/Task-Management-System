using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System.Domain.DTO
{
    public class TasksDTO
    {
        public string TaskTitle { get; set; } = string.Empty;
        public string TaskDescription { get; set; } = string.Empty;
        public DateTime StartTime { get; set; } = DateTime.Now;
        public DateTime EndTime { get; set; } = DateTime.Now;
        public string AssignTo { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
         public int Count { get; set; }
        public int UserID { get; set; }
    }
}
