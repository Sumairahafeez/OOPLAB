using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book[] b = new Book[100];
            int option = 0;
            int bookIndex = 0;
            while (option != 5)
            {
                option = Menu();
                if (option == 1)
                {
                    b[bookIndex] = (addBook());
                    bookIndex++;
                }
                if (option == 2)
                {
                    Console.WriteLine("Enter the title of the book you want to search: ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Title \t publisher \t ISBN \t Price \t Stock \t Publication Year \t Authors");
                    for (int i = 0; i < bookIndex; i++)
                    {
                        b[i].showDetails(title);
                    }
                }
                if (option == 3)
                {
                    Console.WriteLine("Enter the ISBN of the book you want to search: ");
                    int ISBN = int.Parse(Console.ReadLine());
                    Console.WriteLine("Title \t publisher \t ISBN \t Price \t Stock \t Publication Year \t Authors");
                    for (int i = 0; i < bookIndex; i++)
                    {
                        b[i].showDetailsbyISBN(ISBN);
                    }
                }
                if (option == 4)
                {
                    reStock(b, bookIndex);

                }

            }
        }
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Search Book By Title ");
            Console.WriteLine("3. Search for book by ISBN ");
            Console.WriteLine("4. Update Stock of Book ");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your option: ");
            int op = int.Parse(Console.ReadLine());
            return op;
        }
        static Book addBook()
        {   Book a = new Book();
            Console.WriteLine("Enter the title of the book: ");
            a.title = Console.ReadLine();
            Console.WriteLine("Enter the no of authors of the book: ");
            a.noOfAuthors = int.Parse(Console.ReadLine());
            for(int i = 0; i < a.noOfAuthors; i++)
            {
                Console.WriteLine("Enter the author of the book");
                a.authors.Add(Console.ReadLine());
                    
            }
            Console.WriteLine("Enter the publisher: ");
            a.publisher = Console.ReadLine();
            Console.WriteLine("Enter the ISBN: ");
            a.ISBN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of the book: ");
            a.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the quantity in stock: ");
            a.stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the publication Year: ");
            a.publicationYear = int.Parse(Console.ReadLine());
            
            return a;


        }
        static void reStock(Book[] b, int bookIndex)
        {
                Console.WriteLine("If you want to add Books Enter 1 and if you want to remove books Enter 0: ");
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    Console.WriteLine("Enter the title of the book: ");
                    string tit = Console.ReadLine();
                    Console.WriteLine("Enter the number of book you want to remove: ");
                    int no = int.Parse(Console.ReadLine());
                    for (int i = 0; i < bookIndex; i++)
                    {
                        b[i].UpdateStock(tit, no, "remove");
                    }
                    Console.WriteLine("Books are Removed!");
                    Console.ReadKey();
                }
                if (num == 1)
                {
                    Console.WriteLine("Enter the title of the book: ");
                    string tit = Console.ReadLine();
                    Console.WriteLine("Enter the number of book you want to add: ");
                    int no = int.Parse(Console.ReadLine());
                    for (int i = 0; i < bookIndex; i++)
                    {
                        b[i].UpdateStock(tit, no, "add");
                    }
                    Console.WriteLine("Books are added!");
                    Console.ReadKey();
                }
            
        }
    }
}
