using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem2
{
    internal class Student
    {
        public Student(string Name, float MarksOfMatric, float MarksOfFSC, float MarksOfEcat, float agregate)
        {
            sName = Name;
            matricMarks = MarksOfMatric;
            fscMarks = MarksOfFSC;
            ecatMarks = MarksOfEcat;
            aggregate = agregate;
        }
        public Student() {
        }
        public Student (float agg)
        {
            aggregate = agg;
        }
        public string sName;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
        public void CalculateAggregate(ref int studentIndex)
        {
            float aggregate = 0;
            
                aggregate = (fscMarks * 50) / 1100;
                aggregate = aggregate + (matricMarks * 17) / 1100;
                aggregate = aggregate + (ecatMarks * 33) / 1100;
            studentIndex++;
            Console.WriteLine(studentIndex);
            Console.WriteLine(aggregate);
               
            
            




        }
        public  void ShowStudents(ref int studentIndex)
        {
            //Console.WriteLine("Name \t MatricMarks \t FSC Marks \t Ecat Marks");
            //for (int i = 0; i < studentIndex; i++)
            {
                Console.WriteLine(sName + " \t " + matricMarks + " \t " + fscMarks + " \t " + ecatMarks);
            }
            
        }

    }
}
