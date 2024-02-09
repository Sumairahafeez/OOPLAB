using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student StudentsData = new Student(); 
           
            /*for(int i = 0; i<5; i++)
            {
                StudentsData[i] = TakeStudentInput();
            }*/
            PrintStudentsData(StudentsData);
            Console.Read();

        }/*
        static Student TakeStudentInput() 
        { 
            Student s1 = new Student();
            Console.WriteLine("Enter Student Name: ");
            s1.sname = Console.ReadLine();
            Console.WriteLine("Enter Student Matric Marks: ");
            s1.matricMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student FSC Marks: ");
            s1.fscMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Ecat Marks: ");
            s1.ecatMarks= int.Parse(Console.ReadLine());
            return s1;

        }*/
        static void PrintStudentsData(Student StudentsData)
        {
            Console.WriteLine("Name \t Matric Marks \t fscMarks \t ecat Marks \t ");
            
                Console.WriteLine(StudentsData.sname + "\t" + StudentsData.matricMarks + "\t" + StudentsData.fscMarks + "\t" + StudentsData.ecatMarks);
            
        }
    }
}
