using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATM
    {
        public int amount=50000;
        public string pin;
        public List<string> Transactions;
        public ATM() 
        {
            Transactions = new List<string>();
        }
       
        public void ShowBalance()
        {
            Console.WriteLine("Your Balance is: " + amount);
        }
        public float Withdraw()
        {
            int withDraw;
            Console.Write("Enter the amount you want to withdraw: ");
            withDraw = int.Parse(Console.ReadLine());
            amount  = amount - withDraw;
            Transactions.Add("WithDrawn: " + withDraw.ToString());
            return withDraw;
        }
        public float Deposit()
        {
            int deposit;
            Console.WriteLine("Enter the amount you want to deposit: ");
            deposit = int.Parse(Console.ReadLine());
            amount = amount + deposit;
            Transactions.Add("Deposited: "+deposit.ToString());
            return deposit;
        }
        public void CheckHistory()
        {
            for(int i = 0; i < Transactions.Count; i++)
            {
                Console.WriteLine(i+1+" " + Transactions[i]);

            }
            Console.ReadKey ();
        }
        public bool PinValidation()
        {
            if(pin.Length != 4)
            {
                return false;
            }
            return true;
        }
        public bool checkPin()
        {
            Console.WriteLine("Enter your Pin: ");
            pin = Console.ReadLine();
            bool check = PinValidation();

            if (check == false)
            {
                Console.WriteLine("Please Enter a Valid Pin");
                Console.ReadKey();
            }
            if (check == true)
            {
                Console.WriteLine("Valid Pin");
                Console.ReadKey();
                return true;
            }
            return false;
        }

            



            
    }
}
