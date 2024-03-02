using StoreManagementSystem.DL;
using StoreManagementSystem.UL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StoreManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Option = 0;
            DLCustomer Customer = new DLCustomer();
            DLMUser User = new DLMUser();
            DLProducts Products = new DLProducts();
            do
            {
                Option = ConsoleUtility.Menu();
                if(Option == 1)
                {
                    User.AddUser();
                }
                if(Option == 2)
                {
                   string role =  ULMUser.GetUserSignin(User);
                    
                    if (role == "Admin")
                    {
                        ULAdmin.CallAdminMenu(Products);
                    }
                    else 
                    {
                        
                        ULCustomer.CallCustomerMenu(role);
                    }
                }
            }
            while (Option != 3);
        }
    }
}
