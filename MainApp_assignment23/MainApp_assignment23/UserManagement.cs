using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment23_Day20;

namespace MainApp_assignment23
{
    public class UserManagement
    {
        public void RegisterUser(string email, string password)
        {
            if (MyUtility.IsValidEmail(email))
            {
                MyUtility.LogMessage($"Registered user with email: {email}");
            }
            else
            {
                MyUtility.LogMessage($"Invalid email: {email}");
            }
        }
    }
}