using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookClone.UL
{
    internal class ConsoleUtiltity
    {
        public static int Menu()
        {
            int Op = 0;
            Console.WriteLine("WELCOME TO SOCIAL MEDIA SIMULATOR!!");
            Console.WriteLine("1. Users Operation");
            Console.WriteLine("2. Twitter Operations");
            Console.WriteLine("3. FaceBook Operations");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter Your Options: ");
            Op = int.Parse(Console.ReadLine());
            return Op;
        }
    }
}
