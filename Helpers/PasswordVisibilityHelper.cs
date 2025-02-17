using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task_Management_System.Helpers
{
    public static class PasswordVisibilityHelper
    {
        public static void ShowPassword(TextBox passwordTextBox, Label showLabel, Label hideLabel)
        {
            passwordTextBox.PasswordChar = '\0'; 
            showLabel.Visible = false;  
            hideLabel.Visible = true;  
        }

      
        public static void HidePassword(TextBox passwordTextBox, Label showLabel, Label hideLabel)
        {
            passwordTextBox.PasswordChar = '*'; 
            showLabel.Visible = true; 
            hideLabel.Visible = false; 
        }
    }
}

