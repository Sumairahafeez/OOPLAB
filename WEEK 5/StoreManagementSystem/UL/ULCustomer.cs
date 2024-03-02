using Microsoft.SqlServer.Server;
using StoreManagementSystem.BL;
using StoreManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem.UL
{
    internal class ULCustomer
    {
        public static void CallCustomerMenu(string UserName)
        {    
            BLCustomers user = DLCustomer.GetCustomer(UserName);
            if(user != null)
            {
                Console.Clear();
                Console.WriteLine("Welcome Back " + UserName);
                int option = 0;
                do
                {
                    option = CustomerMenu();
                    if (option == 1)
                    {
                        ULProducts.ViewProducts();
                    }
                    if (option == 2)
                    {
                        BuyProducts(user);
                    }
                    if (option == 3)
                    {
                        GetProductsInvoice(user);
                    }
                    if (option == 4)
                    {
                        ViewProfileOfCustomer(user);
                    }
                }
                while (option != 5);
            }
           
        }
        public static int CustomerMenu()
        {
            int op;
            Console.WriteLine("1. View Products");
            Console.WriteLine("2. Buy Products");
            Console.WriteLine("3. Generate Invoice");
            Console.WriteLine("4. View Profile");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter Your Option");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static void ViewProfile()
        {
            Console.WriteLine("Name Password Email ContactNumber");
            foreach(BLCustomers c in DLCustomer.CustomerList)
            {
                Console.WriteLine(c.Name + " " + c.Password + " " + c.Email + " " + c.ContactNumber + " ");
            }
            Console.ReadKey();
        }
        public static void BuyProducts(BLCustomers c)
        {
            
            Console.WriteLine("Enter the product name you want to buy: ");
            string name = Console.ReadLine();
            BLProducts pr = DLProducts.IFProductExist(name);
            if (pr != null)
            {
                c.AddProducts(pr);
            }
           
           
            
        }
        public static void ViewProfileOfCustomer(BLCustomers c)
        {
            
                Console.WriteLine(c.Name + "  " + c.Password + "  " + c.ContactNumber + "  " + c.Email);
            
            Console.ReadKey();
        }
        public static void GetProductsInvoice(BLCustomers c)
        {
            Console.WriteLine("Your Invoice is as follow ");
            for(int i = 0; i<c.OrderedProducts.Count; i++)
            {
                Console.WriteLine(c.OrderedProducts[i].Name + "\t \t " + c.OrderedProducts[i].Price);
            }
            Console.WriteLine("Your Total Invoice is: " + c.GetInvoice());
        }
        public static void GetCustomerData(string name, string password)
        {
            Console.WriteLine("Enter Your Email: ");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter Your Adress: ");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter Your Conatct Number: ");
            int Contact = int.Parse(Console.ReadLine());
            BLCustomers customers = new BLCustomers(name, password, Email, Address, Contact);
            DLCustomer.AddCustomer(customers);
        }
    }
}
