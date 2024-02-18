using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRC
{
    internal class Student
    {
        public string Name;
        public int rollNumber;
        public float cgpa;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public string homeTown;
        public bool isHostelie;
        public bool isTakingScholarship;
        public double calculateMerit()
        {
            double merit = (fscMarks*0.06) + (ecatMarks *0.04);
            
            return merit;
        }
        public bool isEligibleForScholarship(double merit)
        {
            if(isHostelie==true && merit>80)
            {
                return true;
            }
            return false;
        }

    }
}
