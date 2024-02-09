using selfAssessment1b;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfAssessment1bTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Sumaira");
            Console.WriteLine("Student 1 name is: " + s1.sName);
            Student s2 = new Student("Hafeez");
            Console.WriteLine("Student 2 name is: " + s2.sName);
            Console.ReadLine();

        }
    }
}
