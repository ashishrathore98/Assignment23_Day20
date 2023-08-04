using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment23_Day20;


namespace MainApp_assignment23
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var userManagement = new UserManagement();
            userManagement.RegisterUser("example@example.com", "securepassword");
            Console.ReadKey();
        }
    }
}
