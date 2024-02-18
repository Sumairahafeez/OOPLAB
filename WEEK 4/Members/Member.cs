using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    internal class Member
    {
        public string person;
        public int memberID;
        public List<string>BooksBought = new List<string>();
        public int numberOfBooksBought;
        public int moneyInBank;
        public List<int> moneySpent = new List<int>();
        public bool modifyName(string name, string updatedName)
        {
            if(name == person)
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
