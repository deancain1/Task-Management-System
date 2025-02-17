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
                        case "Not Started":

                            statusLabel.BackColor = Color.Orange;
                            statusLabel.ForeColor = Color.White;
                            break;
                        case "Incomplete":
                            statusLabel.BackColor = Color.FromArgb(185, 52, 52);
                            statusLabel.ForeColor = Color.White;
                            break;
                        case "In Progress":
                            statusLabel.BackColor = Color.MediumSlateBlue;
                            statusLabel.ForeColor = Color.White;
                            break;
                        case "Completed":
                            statusLabel.BackColor = Color.Green;
                            statusLabel.ForeColor = Color.White;
                            break;
                        default:
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
                case "Not Started":
                    statusLabel.BackColor = Color.Orange;
                    statusLabel.ForeColor = Color.White;
                    break;
                case "Incomplete":
                    statusLabel.BackColor = Color.FromArgb(185, 52, 52);
                    statusLabel.ForeColor = Color.White;  
                    break;
                case "In Progress":
                    statusLabel.BackColor = Color.MediumSlateBlue;
                    statusLabel.ForeColor = Color.White;  
                    break;
                case "Completed":
                    statusLabel.BackColor = Color.Green;
                    statusLabel.ForeColor = Color.White;  
                    break;
                default:
                    statusLabel.ForeColor = Color.Black;  
                    break;
            }
        }
    }
}

