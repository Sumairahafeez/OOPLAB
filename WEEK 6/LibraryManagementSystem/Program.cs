using LibraryManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {  //BOOKS ARE COMPOSED IN AUTHORS 
           Author A = new Author("Umera Ahmed","Female","Umera@gmail.com");
            A.AddBooks("JKP", 2);
            A.AddBooks("Peer e Kamil", 2);
            Console.WriteLine(A.GetName()+" has written the book ");
            for (int i = 0; i<A.GetBooksListCount();  i++)
            {
                Console.WriteLine(A.GetBook(i));
            }
            Console.ReadKey();
        }
    }
}
