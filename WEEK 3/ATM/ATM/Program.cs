using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {   ATM a = new ATM();
            int op = 0;
            while(op != 7)
            {
                op = ShowFirstPage(a);
                if (op == 1)
                {
                    

                    a.ShowBalance();
                    Console.ReadKey();
                }
                if (op == 2)
                {
                    bool check = a.checkPin();
                    if (check == true)
                    {
                        float w = a.Withdraw();
                        Console.WriteLine(w + " Successfully withdrawn from your account");
                        Console.ReadKey();
                    }
                   
                }
                if(op == 3)
                {   bool check = a.checkPin();
                    if (check == true)
                    {
                        float d = a.Deposit();
                        Console.WriteLine(d + " Successfully deposited to your account");
                        Console.ReadKey();
                    }
                   
                }
                if(op == 4)
                {
                    a.CheckHistory();
                }
                if(op == 6)
                {
                   a.checkPin();
                }
            }
             
        }
        static int ShowFirstPage(ATM aTM) 
        {   Console.Clear();
            int op = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*******ATM**********");
            Console.WriteLine("1. SHOW BALANCE");
            Console.WriteLine("2. WITHDRAW AMOUNT");
            Console.WriteLine("3. DEPOSIT AMOUNT ");
            Console.WriteLine("4. TRANSACTION HISTORY ");
            Console.WriteLine("5. CARD VALIDATION   ");
            Console.WriteLine("6. PIN VALIDATION    ");
            Console.WriteLine("7.Exit");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}
