using StoreManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem.UL
{
    internal class ULAdmin
    {
        public static void CallAdminMenu(DLProducts d)
        { int op = 0;
            do
            {
                Console.Clear();
                op = ShowAdminMenu();
                if(op == 1)
                {
                    d.AddProducts();
                }
                if(op == 2)
                {
                    ULProducts.ViewProducts();
                }
                if(op == 3)
                {
                    ULProducts.HighestPrice(d);
                }
                if(op == 4)
                {
                    ULProducts.ShowSalesTax(d);
                }
                if(op == 5)
                {
                    ULProducts.ProductsToBeOrdered(d);
                }
                if(op == 6)
                {
                    ULCustomer.ViewProfile();
                }
                Console.ReadKey();
            }
            while (op != 7);
        }
        public static int ShowAdminMenu()
        {
            int op = 0;
            Console.WriteLine("1. Add Products");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Product With Highest Unit Price");
            Console.WriteLine("4. View Sales Tax Of All Products");
            Console.WriteLine("5. Products To Be Ordered");
            Console.WriteLine("6. View Profile");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Ener Your Option: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}
