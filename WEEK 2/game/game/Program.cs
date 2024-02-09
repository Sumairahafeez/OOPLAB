using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Header();
            Sleep(100);
            int option;
            while (option != 3)
            {
                option = startUpMenu();
                //This Menu will provide User a Start up which asks user to get started or end the game without starting
                startUpMenu();
            }
        }
        static int startUpMenu()
        {
            Console.Clear();
            Header();
            Console.ForegroundColor() = Console.color.Black;
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
    }
}
