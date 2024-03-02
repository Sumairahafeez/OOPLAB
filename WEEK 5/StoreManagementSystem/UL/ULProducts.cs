using StoreManagementSystem.BL;
using StoreManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem.UL
{
    internal class ULProducts
    {
        public static BLProducts GetProducts()
        {
            Console.WriteLine("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Product Category: ");
            string Category = Console.ReadLine();
            Console.WriteLine("Enter Product Price: ");
            float Price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity: ");
            int Quantity = int.Parse(Console.ReadLine());
            BLProducts p = new BLProducts(name,Category,Price,Quantity);
            return p;
        }
        public static void ViewProducts()
        {
            Console.WriteLine("Name  Price  Category  Stock");
            foreach(BLProducts p in DLProducts.Products)
            {
                Console.WriteLine(p.Name + " " + p.Price + " " + p.Category + " " + p.AvailableStock);
            }
            Console.ReadKey();
        }
        public static void HighestPrice(DLProducts d)
        {
           string HighPriceProduct =  d.GetHighestPrice();
            Console.WriteLine(HighPriceProduct + " has the highest Price per unit of " + d.GetPrice());
            Console.ReadKey();
        }
        public static void ShowSalesTax(DLProducts d)
        {
                foreach(BLProducts p in DLProducts.Products)
            {
                Console.WriteLine(d.GetProductNames(p) + " has sales Tax " + d.GetSalesTax(p));
            }
                
            
        }
        public static void ProductsToBeOrdered(DLProducts d)
        {
            Console.WriteLine("The Product " + d.LowStock() + " is low in stock");
        }
       
    }
}
