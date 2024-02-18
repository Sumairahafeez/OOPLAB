using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            Console.WriteLine("Enter the title of the book: ");
            b.title = Console.ReadLine();
            Console.WriteLine("Enter the author of the book: ");
            b.author = Console.ReadLine();
            Console.WriteLine("Enter the number of pages of the book: ");
            b.pages = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the No of Chapters: ");
            int chap = int.Parse(Console.ReadLine());
            for (int i = 0; i < chap; i++)
            {
                Console.WriteLine("Enter the name of Chapter: ");
                string name = Console.ReadLine();
                b.chapters.Add(name);
            }

            Console.WriteLine("Enter the bookMarked Page: ");
            b.bookMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price: ");
            b.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the book available now true for yes and false for no: ");
            b.isAvailable = bool.Parse(Console.ReadLine());
            if(b.isAvailable)
            {
                Console.WriteLine("The given book if Available: ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The given book is not available: ");
                Console.ReadKey();
            }
            Console.WriteLine("Enter the Chapter Number: ");
            int chapNo = int.Parse(Console.ReadLine());
            string chapter = b.getChapter(chapNo);
            Console.WriteLine("The given Chapter is: " + chapter);
            Console.ReadKey();
            Console.WriteLine("Your BookMark is at: " + b.bookMarks);

        }
       
    }
}
