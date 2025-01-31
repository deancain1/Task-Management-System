using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System.Helpers
{
    public class LoadDataEventHandler
    {
        public event EventHandler? TaskCreated;
        public event EventHandler? UserCreated;


        public void OnTaskCreated()
        {
            TaskCreated?.Invoke(this, EventArgs.Empty);
        }
        public void OnUserCreated()
        {
            UserCreated?.Invoke(this, EventArgs.Empty);
        }
    }
}
