using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem.UL
{
    internal class ConsoleUtility
    {
        public static int Menu()
        {
            Console.Clear();
            int op;
            Console.WriteLine("1. Sign UP");
            Console.WriteLine("2. Sign IN");
            Console.WriteLine("3. Exit");
            Console.Write("Enter Your Option: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
      
    }

}
