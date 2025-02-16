using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System.Helpers
{
    public class StatusUpdater
    {
     
        public static void UpdateStatusLabel(Label statusLabel, string selectedStatus, bool updateLabel)
        {
            if (updateLabel)
            {
               
                if (statusLabel.Text != selectedStatus)
                {
                    switch (selectedStatus)
                    {
                        case "Incomplete":
                            statusLabel.Text = "Incomplete";  
                            statusLabel.ForeColor = Color.Red; 
                            break;
                        case "In Progress":
                            statusLabel.Text = "In Progress";  
                            statusLabel.ForeColor = Color.MediumSlateBlue; 
                            break;
                        case "Completed":
                            statusLabel.Text = "Completed";  
                            statusLabel.ForeColor = Color.Green; 
                            break;
                        default:
                            statusLabel.Text = "Unknown Status";  
                            statusLabel.ForeColor = Color.Black; 
                            break;
                    }
                }
            }
        }

        public static void SetInitialStatusColor(Label statusLabel, string initialStatus)
        {
         
            switch (initialStatus)
            {
                case "Incomplete":
                    statusLabel.ForeColor = Color.Red;  
                    break;
                case "In Progress":
                    statusLabel.ForeColor = Color.MediumSlateBlue;  
                    break;
                case "Completed":
                    statusLabel.ForeColor = Color.Green;  
                    break;
                default:
                    statusLabel.ForeColor = Color.Black;  
                    break;
            }
        }
    }
}

