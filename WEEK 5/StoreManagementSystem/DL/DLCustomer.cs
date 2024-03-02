using StoreManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem.DL
{
    internal class DLCustomer
    {
        public static List<BLCustomers> CustomerList = new List<BLCustomers>();
        public static void AddCustomer(BLCustomers c)
        {
           CustomerList.Add(c);
            
        }
        public static string GetUser(string name,string password)
        {
            foreach (BLCustomers customers in CustomerList)
            {
                if(customers.Name == name && customers.Password == password)
                {
                    return customers.Name;
                }
            }
            return null;
        }
        public static void GetCustomerAddProducts(string name, BLProducts p)
        {
            foreach (BLCustomers customers in CustomerList)
            {
                if (customers.Name == name)
                {
                    customers.AddProducts(p);
                }
            }
        }
        public static BLCustomers GetCustomer(string name)
        {
            foreach(BLCustomers customers in CustomerList)
            {
                if (customers.Name == name)
                {
                    return customers;
                }
            }
            return null;
        }
    }
}
