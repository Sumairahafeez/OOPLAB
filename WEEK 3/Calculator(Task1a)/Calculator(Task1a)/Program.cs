using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Task1a_
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            
            calculator c = new calculator();
            Console.Write("Enter First Number: ");
            c.num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second Number: ");
            c.num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the operation you want to perform( +,-,*,/): ");
            c.operation = Char.Parse(Console.ReadLine());

            Console.WriteLine("Result is: " + Calculation(c)); 
            Console.ReadKey();
        }
            static public float Calculation(calculator c)
        {
            float result = 0;
            if (c.operation == '+')
            {
                result = c.Add();
            }
            else if (c.operation == '*')
            {
                result = c.Multiply();
            }
            else if (c.operation == '/')
            {
                result = c.Division();
            }
            else if (c.operation == '-')
            {
                result = c.Subtraction();
            }
            return result;
        }
    }
}
