using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesmentTask1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Sumaira",1041, 1085, 274);
            Student s2 = new Student("Sammra", 1032, 1075, 270);
            Student s3 = new Student("Tehreem", 1055, 1044, 280);
            Student s4 = new Student("Sadia", 1077,1050, 290);
            Student s5 = new Student("Zainab", 1085, 1090, 280);
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
