using StoreManagementSystem.BL;
using StoreManagementSystem.UL;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem.DL
{
    internal class DLProducts
    {
        public static List<BLProducts> Products = new List<BLProducts>();
       
        public void AddProducts()
        {
            Products.Add(ULProducts.GetProducts());
        }
        public string GetHighestPrice()
        {
            float Max = 0;
            foreach (BLProducts p in Products)
            {
                if(p.Price > Max)
                    Max = p.Price;
            }
            foreach (BLProducts p in Products)
            {
                if(Max == p.Price)
                {
                    return p.Name;
                }
            }
            return null;
        }
        public float GetPrice()
        {
            float Max = 0;
            foreach (BLProducts p in Products)
            {
                if (p.Price > Max)
                    Max = p.Price;
            }
            return Max;
        }
        public string GetProductNames(BLProducts Product)
        {
            foreach (BLProducts p in Products)
            {   if(Product == p)
                {
                    return p.Name;
                }
               
            }
            return null;
        }
        public float GetSalesTax(BLProducts Product)
        {
            foreach(BLProducts p in Products)
            {   if(Product == p)
                {
                    if (p.Category == "Fruits")
                    {
                        return 5;
                    }
                    else if (p.Category == "Grocery")
                    {
                        return 10;
                    }
                    else
                    {
                        return 15;
                    }
                }
                
            }
            return 0;
        }
        public string LowStock()
        {   bool flag = false;
            foreach(BLProducts p in Products)
            {
                flag = p.CheckStock();
                if(flag == true)
                {
                    return p.Name;
                }
            }
            return null;
        }
        public static BLProducts IFProductExist(string Pname)
        {
            foreach( BLProducts p in Products)
            {
                if(p.Name == Pname)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
