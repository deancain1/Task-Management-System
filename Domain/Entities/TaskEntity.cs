﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System.Domain.Entities
{
    public class TaskEntity
    {

        public int TaskID{ get; set; }
        public string TaskTitle { get; set; } = string.Empty;
        public string TaskDescription { get; set; } = string.Empty;
        public DateTime StartTime { get; set; } = DateTime.Now;
        public DateTime Deadline { get; set;} = DateTime.Now;
        public string AssignTo { get; set; } = string.Empty;
        public string Status {  get; set; } = string.Empty;
        public int UserID { get; set; }
        public UserEntity Users { get; set; }
  


    }
}
