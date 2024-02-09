using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Sumaira
{
    internal class Program
    {
        static void Main(string[] args)
        {   //declare option variable
            int op = 0;
            //HEADER DISPLAYING
            Header();
            Console.Read();
            //calling signinpage and taking in the option
            SignInPage(ref op);
            //display this option
            Console.WriteLine("Your option is "+op);
            Console.Read();
        }
        static void Header()
        {   //Welcome note
            Console.WriteLine("WELCOME TO MY MESS APPLICATION");
        }
        static void SignInPage(ref int option )
        {
            Console.WriteLine("1. SIGN UP ");
            Console.WriteLine("2. SIGN IN ");
            Console.WriteLine("3. Exit    ");
            Console.WriteLine("Enter your Option ");
            option = int.Parse(Console.ReadLine());
             
        }
    }
}
