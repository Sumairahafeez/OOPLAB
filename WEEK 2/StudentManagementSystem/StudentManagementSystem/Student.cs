using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
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
        public string sName;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
       
    }
}
