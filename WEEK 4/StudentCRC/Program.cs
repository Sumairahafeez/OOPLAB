using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.WriteLine("Enter Your Name: ");
            st.Name=Console.ReadLine();
            Console.WriteLine("Enter Your Roll Number: ");
            st.rollNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your CGPA: ");
            st.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your matric Marks: ");
            st.matricMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your fsc Marks: ");
            st.fscMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your ecat Marks: ");
            st.ecatMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your home Town: ");
            st.homeTown = (Console.ReadLine());
            Console.WriteLine("Are You a Hostelite write true for yes and false for no: ");
            st.isHostelie = bool.Parse(Console.ReadLine());
            Console.WriteLine("Are You Taking any scholarship: ");
            st.isTakingScholarship = bool.Parse(Console.ReadLine());
            double merit = st.calculateMerit();
           
            bool result = st.isEligibleForScholarship(merit);
            if(result == true)
            {
                Console.WriteLine("Yes You Are Eligible for scholarship");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No you are not eligible");
                Console.ReadKey();
            }
        }
    }
}
