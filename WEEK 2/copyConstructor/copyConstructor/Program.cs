using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace copyConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.sName = "test";
            Student student1 = new Student(student);
            Console.WriteLine(student.sName);
            Console.WriteLine(student1.sName);
            Console.ReadLine();
        }
    }
}
