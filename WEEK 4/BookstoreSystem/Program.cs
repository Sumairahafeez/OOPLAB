using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] b = new Book[100];
            List<Member> m = new List<Member>();
            bool c = false;
            int option = 0;
            int bookIndex = 0;
            while (option != 10)
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
                if (option == 5)
                {
                    m.Add(addMember());
                }
                if (option == 6)
                {
                    Console.Write("Enter the name of the member: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Name \t member Id \t money In Bank \t Money Spent \t no of Books \t Books");
                    for (int i = 0; i < m.Count; i++)
                    {
                        c = m[i].lookForDetails(name);
                    }
                    if (c == false)
                    {
                        Console.WriteLine("Name not Present!");
                        Console.ReadKey();
                    }


                }
                if (option == 7)

                {
                    int op = 0;

                    Console.WriteLine("Enter your previous name: ");
                    string pName = Console.ReadLine();
                    op = MenuUpdate();

                    if (op == 1)
                    {
                        Console.WriteLine("Enter your name: ");
                        string name = Console.ReadLine();

                        for (int i = 0; i < m.Count; i++)
                        {
                            c = m[i].modifyName(pName, name);
                        }
                        if (c == false)
                        {
                            Console.WriteLine("Name not Present!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Name Updated Successfully!");
                            Console.ReadKey();
                        }

                    }
                    if (op == 2)
                    {
                        Console.WriteLine("Enter updated Member ID: ");
                        int id = int.Parse(Console.ReadLine());
                        for (int i = 0; i < m.Count; i++)
                        {
                            c = m[i].modifyMemberId(pName, id);
                        }
                        if (c == false)
                        {
                            Console.WriteLine("Name not Present!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Name Updated Successfully!");
                            Console.ReadKey();
                        }
                    }
                }
                if(option == 8)
                {
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your memberID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the title of the book: ");
                    string title = Console.ReadLine();
                    bool check;
                    for (int i = 0; i<b.Length; i++)
                    {
                        check = b.checkTitle(title);
                    }
                    if(check == true)
                    {
                          for(int i = 0; i<m.Count; i++)
                         {
                            m[i].purchaseBook(name, title);
                         }
                    }
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
            Console.WriteLine("5. Add Members");
            Console.WriteLine("6. Search Member ");
            Console.WriteLine("7. Update Member Information ");
            Console.WriteLine("8. Purchase a book");
            Console.WriteLine("9. Display total sales and membership stats");
            Console.WriteLine("10. Exit");
            Console.WriteLine("Enter your option: ");
            int op = int.Parse(Console.ReadLine());
            return op;
        }
        static Member addMember()
        {
            Member a = new Member();
            Console.WriteLine("Enter the Name of The member: ");
            a.person = Console.ReadLine();
            Console.WriteLine("Enter your member ID (0 if you avail member ship 1 if you dont): ");
            a.memberID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your balance in Bank: ");
            a.moneyInBank = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of Books you have bought: ");
            a.numberOfBooksBought = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.numberOfBooksBought; i++)
            {
                Console.WriteLine("Enter the name of the book: ");
                a.BooksBought.Add(Console.ReadLine());

            }
            for (int i = 0; i < a.numberOfBooksBought; i++)
            {
                Console.WriteLine("Enter the amount spent on books: ");
                a.moneySpent.Add(int.Parse(Console.ReadLine()));
            }

            return a;

        }
        static int MenuUpdate()
        {
            Console.Clear();
            Console.WriteLine("1. Name");
            Console.WriteLine("2. memberID ");

            Console.WriteLine("3. Exit");
            int op = int.Parse(Console.ReadLine());
            return op;
        }
        static Book addBook()
        {
            Book a = new Book();
            Console.WriteLine("Enter the title of the book: ");
            a.title = Console.ReadLine();
            Console.WriteLine("Enter the no of authors of the book: ");
            a.noOfAuthors = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.noOfAuthors; i++)
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
