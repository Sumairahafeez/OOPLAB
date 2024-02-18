using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreSystem
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
            if (tit == title)
            {
                Console.Write(title + "\t" + publisher + "\t" + ISBN + "\t" + price + "\t" + stock + "\t" + publicationYear + "\t" + noOfAuthors);
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
        public bool checkTitle(string tit)
        {
            if(tit == title)
            {
                return true;
            }
            return false;
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
            if (t == title && todo == "remove")
            {
                stock = stock - no;
            }
            else if (t == title && todo == "add")
            {
                stock = stock + no;
            }
        }
       
    }
    internal class Member
    {
        public string person;
        public int memberID;
        public List<string> BooksBought = new List<string>();
        public int numberOfBooksBought;
        public int moneyInBank;
        public List<int> moneySpent = new List<int>();
        public List<Book> purchaseBooks = new List<Book>();
        public Book b;
        public void purchaseBook(string name, string title)
        {
            if(name == person)
            {
                if(memberID == 1)
                {

                }
                else if(memberID == 0)
                {
                    if(title == b.title)
                    {
                        purchaseBooks.title(Add);
                    }
                }
            }
        }
        public bool modifyName(string name, string updatedName)
        {
            if (name == person)
            {
                person = updatedName;
                return true;
            }
            return false;
        }
        public bool modifyMemberId(string name, int newId)
        {
            if (name == person)
            {
                memberID = newId;
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool lookForDetails(string name)
        {
            if (person == name)
            {
                Console.Write(name + "\t" + memberID + "\t" + "\t" + moneyInBank + "\t" + numberOfBooksBought + "\t");
                for (int i = 0; i < numberOfBooksBought; i++)
                {
                    Console.Write(BooksBought[i] + "\t");
                    Console.Write(moneySpent[i] + "\t");
                }

                Console.ReadKey();
                return true;
            }
            return false;
        }
    }
}
