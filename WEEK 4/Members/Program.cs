using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> m = new List<Member>();
            int option = 0;
            bool c = false;
            while (option!= 4)
            {
                option = Menu();
                if(option == 1)
                {
                    m.Add(addMember());
                }
                if(option == 2)
                {
                    Console.Write("Enter the name of the member: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Name \t member Id \t money In Bank \t Money Spent \t no of Books \t Books");
                    for(int i = 0; i < m.Count; i++)
                    {
                        c=m[i].lookForDetails(name);
                    }
                    if (c == false)
                    {
                        Console.WriteLine("Name not Present!");
                        Console.ReadKey();
                    }
                    

                }
                if (option == 3)
                    
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
                            if(c == false)
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
                                c=m[i].modifyMemberId(pName, id);
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
            }
        }
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Members");
            Console.WriteLine("2. Search Member ");
            Console.WriteLine("3. Update Member Information ");
            
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your option: ");
            int op = int.Parse(Console.ReadLine());
            return op;
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
        static Member addMember()
        {
            Member a = new Member();
            Console.WriteLine("Enter the Name of The member: ");
            a.person=Console.ReadLine();
            Console.WriteLine("Enter your member ID (0 if you avail member ship 1 if you dont): ");
            a.memberID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your balance in Bank: ");
            a.moneyInBank = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of Books you have bought: ");
            a.numberOfBooksBought = int.Parse(Console.ReadLine());
            for(int i=0; i<a.numberOfBooksBought; i++)
            {
                Console.WriteLine("Enter the name of the book: ");
                a.BooksBought.Add(Console.ReadLine());

            }
            for(int i=0; i<a.numberOfBooksBought;i++)
            {
                Console.WriteLine("Enter the amount spent on books: ");
                a.moneySpent.Add(int.Parse(Console.ReadLine()));
            }
            
            return a;

        }
    }
}
