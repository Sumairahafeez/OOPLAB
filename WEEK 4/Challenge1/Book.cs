using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Book
    {
        public string title;
        public List<string> authors = new List<string>();
        public string publisher;
        public int ISBN;
        public float price;
        public int stock;
        public int publicationYear;
        public int noOfAuthors;
        public void showDetails(string tit)
        {
            if(tit == title) 
            {
                Console.Write(title +"\t"+ publisher +"\t"+ ISBN+ "\t"+ price+"\t"+stock+"\t"+publicationYear+"\t"+noOfAuthors);
                for(int i = 0; i < authors.Count; i++)
                {
                    Console.Write(authors[i]+"\t");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Book not found ");
                Console.ReadKey();
            }
        }
        public void showDetailsbyISBN(int Inum)
        {
            if (ISBN == Inum)
            {
                Console.Write(title + "\t" + publisher + "\t" + ISBN + "\t" + price + "\t" + stock + "\t" + publicationYear + "\t");
                for (int i = 0; i < authors.Count; i++)
                {
                    Console.Write(authors[i] + "\t");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Book not found ");
                Console.ReadKey();
            }
        }
        public void UpdateStock(string t, int no, string todo)
        {
            if (t == title && todo=="remove")
            {
                stock = stock - no;
            }
            else if(t == title && todo=="add")
            {
                stock = stock + no;
            }
        }


    }
}
