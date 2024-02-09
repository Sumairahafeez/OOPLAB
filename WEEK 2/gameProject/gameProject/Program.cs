using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static int StartUpMenu()
        {
            Console.Clear();
            Header();
            Console.ForegroundColor = ConsoleColor.White;
            int op;
            Console.WriteLine("1. INSTRUCTIONS");
            Console.WriteLine("************");
            Console.WriteLine("2. START OVER");
            Console.WriteLine("************");
            Console.WriteLine("3. END");
            Console.WriteLine("************");
            Console.Write("Enter Your Option: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        static void Header()
        {

        }
    }
}
