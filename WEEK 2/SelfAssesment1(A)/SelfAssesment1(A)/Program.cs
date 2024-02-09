using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment1_A_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            Student s5 = new Student();
            Console.WriteLine("Name \t Fsc Marks \t Matric Marks \t Ecat Mark");
            DisplayStudentData(s1);
            DisplayStudentData(s2);
            DisplayStudentData(s3);
            DisplayStudentData(s4);
            DisplayStudentData(s5);
            Console.ReadLine();
        }
        static void DisplayStudentData(Student student)
        {
            
            Console.WriteLine(student.sName + " \t " + student.fscMarks + " \t " + student.matricMarks + " \t " + student.ecatMarks);
        }
    }
}
