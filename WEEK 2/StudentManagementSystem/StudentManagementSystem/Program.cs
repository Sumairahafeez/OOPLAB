using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] studentData = new Student[100];
            
            int studentIndex = 0;
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
                    studentData[studentIndex] = AddStudent(studentData, ref studentIndex);
                }
                if (option == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("****STUDENT MANAGEMENT SYSTEM****");
                    ShowStudents(studentData, ref studentIndex);
                }
                if (option == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("****STUDENT MANAGEMENT SYSTEM****");
                    CalculateAggregate(studentData, studentIndex);
                }
                if(option == 4)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("****STUDENT MANAGEMENT SYSTEM****");
                    ShowTopStudents(studentData, ref studentIndex);
                }
            }

        }
        static Student AddStudent(Student[] studentData, ref int studentIndex)
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
        static void ShowStudents(Student[] studentData, ref int studentIndex)
        {
            Console.WriteLine("Name \t MatricMarks \t FSC Marks \t Ecat Marks");
            for (int i = 0; i < studentIndex; i++)
            {
                Console.WriteLine(studentData[i].sName + " \t " + studentData[i].matricMarks + " \t " + studentData[i].fscMarks + " \t " + studentData[i].ecatMarks);
            }
            Console.ReadKey();
        }
        static void CalculateAggregate(Student[] studentData, int studentIndex)
        {
            float aggregate = 0;
            for (int i = 0; i < studentIndex; i++)

            {
                aggregate = (studentData[i].fscMarks * 50) / 1100;
                aggregate = aggregate+(studentData[i].matricMarks * 17) / 1100;
                aggregate = aggregate + (studentData[i].ecatMarks * 33) / 1100;
                studentData[i].aggregate = aggregate;
                Console.WriteLine(studentData[i].aggregate);
            }
            Console.ReadKey();
            
        }
        static void ShowTopStudents(Student[] studentData, ref int studentIndex)
        {
            float[] maxAggregate = new float[studentIndex];
            int topStudentIndex = 0;

            for (int i = 0; i < studentIndex; i++)
            {

                maxAggregate[i] = studentData[i].aggregate;


            }
            Array.Sort(maxAggregate);
            Array.Reverse(maxAggregate);
            for (int i = 0; i < 3; i++)
            {   for(int j = 0; j<studentIndex; j++)
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

