using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products[] products = new Products[100];
            int productIndex=0;
            int option = 0;
            while(option != 4)
            {
                option = DisplayMenu();
                if(option == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("****PRODUCTS MANAGEMENT SYSTEM****");
                    products[productIndex] = AddProducts(products, ref productIndex);
                }
                if(option == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("****PRODUCTS MANAGEMENT SYSTEM****");
                    ShowProducts(products,ref productIndex);
                } 
                if(option == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("****PRODUCTS MANAGEMENT SYSTEM****");
                    float sWorth = StoreWorth(products, ref productIndex);
                    Console.WriteLine("Your Store Worth is: " + sWorth);
                    Console.ReadKey();
                }
            }

        }
        static int DisplayMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("****PRODUCTS MANAGEMENT SYSTEM****");
            int op = 0;
            Console.WriteLine("1. ADD PRODUCTS ");
            Console.WriteLine("2. SHOW PRODUCTS ");
            Console.WriteLine("3. CALCULATE STORE WORTH ");
            Console.WriteLine("4. EXIT  ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        static Products AddProducts(Products[] products, ref int productIndex)
        {
            Products p1 = new Products();
            Console.WriteLine("Enter the Product ID: ");
            p1.id = Console.ReadLine();
            Console.WriteLine("Enter the Product Name: ");
            p1.name = Console.ReadLine();
            Console.WriteLine("Enter the Product Price: ");
            p1.price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Product Category: ");
            p1.category = Console.ReadLine();
            Console.WriteLine("Enter the Product BrandName: ");
            p1.BrandName = Console.ReadLine();
            Console.WriteLine("Enter the Product Country: ");
            p1.Country = Console.ReadLine();
            productIndex++;
            return p1;

        }
        static void ShowProducts(Products[] products,ref int productIndex)
        {
            Console.WriteLine("Product ID \t Product Name \t Product Price \t Product Category \t Product BrandName \t Country");
            for(int i = 0; i<productIndex; i++)
            {
                Console.WriteLine(products[i].id + "\t" + products[i].name + "\t" + products[i].price+"\t" + products[i].category + "\t" + products[i].BrandName +"\t" + products[i].Country);
            }
            Console.ReadKey();
        }
        static float StoreWorth(Products[] products,ref int productIndex)
        {
            float worth = 0;
            for(int i = 0;i<productIndex;i++)
            {
                worth += products[i].price;
            }
            return worth;
        }
    }
}
