using StoreManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem.BL
{
    internal class BLCustomers
    {
        public string Name;
        public string Password;
        public string Email;
        public string Address;
        public int ContactNumber;
        public List<BLProducts> OrderedProducts ;
        public BLCustomers(string name, string password, string email, string address, int contactNumber)
        {
            Name = name;
            Password = password;
            Email = email;
            Address = address;
            ContactNumber = contactNumber;
            OrderedProducts = new List<BLProducts>();
        }
        public void AddProducts(BLProducts p)
        {
            OrderedProducts.Add(p);
        }
        public float GetInvoice()
        {
            float Total = 0;
            for(int i = 0; i<OrderedProducts.Count; i++)
            {
                Total += OrderedProducts[i].Price;
            }
            return Total;
        }
    }
}
