using StoreManagementSystem.BL;
using StoreManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem.UL
{
    internal class ULMUser
    {
        public static BLMUser GetUserSignUp()
        {
            Console.WriteLine("Enter the UserName: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the UserPassword: ");
            string Password = Console.ReadLine();
            Console.WriteLine("Enter the Role: ");
            string Role = Console.ReadLine();
            if(Role == "Customer")
            {
               ULCustomer.GetCustomerData(name, Password);
                
            }
            
                BLMUser user = new BLMUser(name, Password, Role);
                return user;
           
           
        }
        public static string GetUserSignin(DLMUser User)
        {
            Console.WriteLine("Enter UserName: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string Password = Console.ReadLine();
            
            string Role = User.CheckUser(name, Password);
            if(Role == "Admin")
            {
                Console.WriteLine("You Have Logged In as an ADMIN");
                Console.ReadKey();
                return Role;
            }
            else if(Role =="Customer")
            {   
                Console.WriteLine("You have logged In as a Customer");
                string Uname = DLCustomer.GetUser(name, Password);
               
                Console.ReadKey();
                return Uname;
            }
            else if(Role == " ")
            {
                Console.WriteLine("User Not Found");
                Console.ReadKey ();
                return " ";
            }
            return null;
        }
       
    }
}
