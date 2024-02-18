using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UAMS
{
    internal class Student
    {
        public string Name;
        public int age;
        public float FSCMarks;
        public float EcatMarks;
        public float merit;
        public List<Degree> degreePreferances = new List<Degree>();
        public List<Subject> registerSub = new List<Subject>();
        public Degree programReg;
        public Student(string name, int age, float fSCMarks, float ecatMarks, List<Degree> degreePreferances)
        {
            Name = name;
            this.age = age;
            FSCMarks = fSCMarks;
            EcatMarks = ecatMarks;
            
            this.degreePreferances = degreePreferances;
            
        }

        public int getCreditHours()
        {
            int Count = 0;
            foreach (Subject i in registerSub)
            {
                Count += i.creditHours;
            }
            return Count;
        }
        public void calculateMerit()
        {
            merit = (FSCMarks*0.06f)+(EcatMarks*0.04f);
        }
        public float calculateFee()
        {
            float fee = 0;
            for(int i=0; i < registerSub.Count;i++)
            {
                fee += registerSub[i].subjectFee;
            }
            return fee;
        }
        public bool registerSubject(Subject s)
        {
            int stCH = programReg.getCreditHours();
            if(programReg !=null && programReg.isSubjectExists(s) && stCH+s.creditHours<=9)
            {
                registerSub.Add(s);
                return true;
            }
            return false;
        }
       

    }
    internal class Subject
    {
        public string subjectCode;
        public int creditHours;
        public string subjectType;
        public int subjectFee;
        
    }
    internal class Degree
    {
        public string degreeTitle;
        public int duration;
        public int seats;

        public List<Subject> subjectsTaught;
        public Degree(string degreeTitle, int duration, int seats)
        {
            this.degreeTitle = degreeTitle;
            this.duration = duration;
            this.seats = seats;
            subjectsTaught = new List<Subject>();
        }

        public int getCreditHours()
        {
            int Count = 0;
            foreach(Subject i in subjectsTaught)
            {
                Count += i.creditHours;
            }
            return Count;
        }
        public bool isSubjectExists(Subject s)
        {
            foreach (Subject i in subjectsTaught)
            {
                if (i.subjectCode == s.subjectCode)
                {
                    return true;
                }
            }
            return false;
        }
        public bool addSubject(Subject s)
        {
            int creditHours = getCreditHours();
            if(creditHours + s.creditHours<=20)
            {
                subjectsTaught.Add(s);
                return true;
            }
            return false;
        }

    }
}
