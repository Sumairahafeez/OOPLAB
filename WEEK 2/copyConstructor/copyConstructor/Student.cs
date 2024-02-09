using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace copyConstructor
{
    internal class Student
    {
        public Student()
        {
            Console.WriteLine("This is Default Constructor!");

        }
        public Student(Student s)
        {
            sName = s.sName;
            fscMarks = s.fscMarks;
            matricMarks = s.matricMarks;
            ecatMarks = s.ecatMarks;
        }
        public string sName;
        public float fscMarks;
        public float matricMarks;
        public float ecatMarks;

    }
}
