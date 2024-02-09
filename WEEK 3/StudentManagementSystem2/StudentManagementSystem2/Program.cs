using StudentManagementSystem2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentIndex = 0;
            List<Student> s = new List<Student>();
            Student s1 = new Student();
            
            Console.WriteLine("****STUDENT MANAGEMENT SYSTEM****");
            int option = 0;
            while (option != 5)
            {
                option = DisplayMenu();
                if (option == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("****STUDENT MANAGEMENT SYSTEM****");
                   s.Add(AddStudent(s, ref studentIndex));

                }
                if (option == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("****STUDENT MANAGEMENT SYSTEM****");
                    Console.WriteLine("Name \t MatricMarks \t FSC Marks \t Ecat Marks");
                    for (int i = 0; i< s.Count; i++)
                    {
                        s[i].ShowStudents(ref studentIndex);
                    }
                    Console.ReadKey();

                }
                if (option == 3)
                {   
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("****STUDENT MANAGEMENT SYSTEM****");
                    for(int i = 0; i< s.Count; i++)
                    {
                        s[i].CalculateAggregate(ref studentIndex);
                    }
                    Console.ReadKey();



                }
                
                if (option == 4)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("****STUDENT MANAGEMENT SYSTEM****");
                    ShowTopStudents(s, ref studentIndex);
                }
               
            }

        }
        static Student AddStudent(List<Student> studentData, ref int studentIndex)
        {
            //Decalare Variables
            string name;
            float matricMarks;
            float fscMarks;
            float ecatMarks;

            //Take input from user
            Console.WriteLine("Enter the Name of Student: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Marks in Matric: ");
            matricMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marks in fsc: ");
            fscMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marks in ECAT: ");
            ecatMarks = float.Parse(Console.ReadLine());

            Student s1 = new Student(name, matricMarks, fscMarks, ecatMarks, 0);
            studentIndex++;
            return s1;
        }
        static int DisplayMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****STUDENT MANAGEMENT SYSTEM****");
            int op = 0;
            Console.WriteLine("1. ADD STUDENT ");
            Console.WriteLine("2. SHOW STUDENTS ");
            Console.WriteLine("3. CALCULATE AGGREGATE ");
            Console.WriteLine("4. TOP STUDENTS ");
            Console.WriteLine("5. EXIT    ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        static void ShowTopStudents(List<Student> studentData, ref int studentIndex)
        {
            float[] maxAggregate = new float[studentIndex];
            int topStudentIndex = 0;

            for (int i = 0; i < studentData.Count; i++)
            {

                maxAggregate[i] = studentData[i].aggregate;


            }
            Array.Sort(maxAggregate);
            Array.Reverse(maxAggregate);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < studentData.Count; j++)
                {
                    if (maxAggregate[i] == studentData[j].aggregate)
                    {
                        topStudentIndex = j;
                        Console.WriteLine(i + 1 + "st Aggregate is of " + studentData[topStudentIndex].sName);
                    }
                }

            }
            Console.ReadKey();






        }

    }
    
}
