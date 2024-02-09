using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesmentTask1A
{
     class Student
    {
        public Student(string Name, float MarksOfFsc, float MarksOfMatric, float MarksOfEcat)
        {
            sName = Name;
            fscMarks = MarksOfFsc;
            matricMarks = MarksOfMatric;
            ecatMarks = MarksOfEcat;
        }
    public string sName;
    public float fscMarks;
    public float matricMarks;
    public float ecatMarks;
}
    
}
