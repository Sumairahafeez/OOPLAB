using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    internal class Program
    { static List<Student> studentList = new List<Student>();
        static List<Degree> degreesList = new List<Degree>();
        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                op = Menu();
                Console.Clear();
                if (op == 1)
                {
                    studentList.Add(AddStudent());
                }
                if (op == 2)
                {
                    degreesList.Add(AddDegree());
                }
                if (op == 3)
                {   List<Student> sortedStudent = new List<Student>();
                    sortedStudent = sortStudentsAccordingToMerit();
                    PrintStudents(sortedStudent);
                }
                if (op == 4)
                {
                    viewStudents();   
                }
                if(op == 5)
                {
                    Console.WriteLine("Enter the degree: ");
                    string degName = Console.ReadLine();
                    viewStudentInDegree(degName);
                }
                if(op == 6)
                {
                    Console.WriteLine("Enter the student name: ");
                    string sName = Console.ReadLine();
                    Student s = studentPresent(sName);
                    if(s!=null)
                    {
                        viewSubjects(s);
                        registerSubject(s);
                    }
                   
                }
                if(op == 7)
                {
                    calculateFeeForAll();
                }
                Console.ReadKey();

            }
            while (op != 8);
            
            }
        static void viewSubjects(Student s)
        {
            if(s.programReg != null )
            {
                Console.WriteLine("Sub Code \t Sub Type");
                foreach(Subject i in s.programReg.subjectsTaught)
                {
                    Console.WriteLine(i.subjectCode + "\t" + i.subjectType);
                }
            }
            Console.ReadKey();
        }
        static void calculateFeeForAll()
        {
            foreach(Student s in studentList)
            {
                if(s.programReg != null)
                    {
                    Console.WriteLine("Student " + s.Name + " has " + s.calculateFee() + " fees.");
                }
            }
            Console.ReadKey();
        }
            static void registerSubject(Student s)
        {
            Console.WriteLine("Enter how many subjects you want to register: ");
            int no = int.Parse(Console.ReadLine());
            for(int i = 0; i< no; i++)
            {
                Console.WriteLine("Enter the subject code: ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach(Subject j in s.programReg.subjectsTaught)
                {
                    if(code == j.subjectCode  && !(s.registerSub.Contains(j)))
                    {
                        s.registerSub.Add(j);
                        flag = true;
                        break;
                    }
                }
                if(flag ==  false)
                {
                    Console.WriteLine("Enter a valid subject");
                    i--;
                }
                    

            }
        }
        static Student studentPresent(string name)
        {
            foreach(Student s in studentList)
            {
                if(name == s.Name && s.programReg!=null)
                {
                    return s;
                }
            }
            return null;
        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit ");
            Console.WriteLine("4. View Registered Students ");
            Console.WriteLine("5. View Students of a specific program");
            Console.WriteLine("6. Register Subjects for a specific student");
            Console.WriteLine("7. Calculate fees for all registered students");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Enter option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void viewStudentInDegree(string degName)
        {
            Console.WriteLine("Name \t FSC Marks \t Ecat Marks \t Age");
            foreach (Student s in studentList)
            {
                if (s.programReg != null)
                {   if(degName == s.programReg.degreeTitle)
                    {
                        Console.WriteLine(s.Name + "\t" + s.FSCMarks + "\t" + s.EcatMarks + "\t" + s.age);
                    }
                   
                }

            }
            Console.ReadKey();
        }
        static void viewStudents()
        {
            Console.WriteLine("Name \t FSC Marks \t Ecat Marks \t Age");
            foreach(Student s in studentList)
            {   if(s.programReg !=null )
                { 
                    Console.WriteLine(s.Name + "\t" + s.FSCMarks + "\t" + s.EcatMarks + "\t" + s.age);
                }
                
            }
            Console.ReadKey();
        }
        
        static void PrintStudents(List<Student> students)
        {
            foreach(Student s in students)
            {
                Console.WriteLine(s.ToString());
            }
            Console.ReadKey();
        }

        static List<Student> sortStudentsAccordingToMerit()
        {   List<Student>sortedList = new List<Student>();
            foreach(Student student in studentList)
            {
                student.calculateMerit();
            }
            sortedList = studentList.OrderByDescending(o=>o.merit).ToList();
            return sortedList;
        }
        static Degree AddDegree()
        {
            Console.WriteLine("Enter The Degree Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seats for this program: ");
            int seats = int.Parse(Console.ReadLine());
            Degree d = new Degree(title, duration, seats);
            return d;
        }
        static Student AddStudent()
        {
            
            bool flag=false;
            Console.WriteLine("Enter the name of Student: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the age of Student: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your fsc Marks: ");
            float FSCMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your ecat Marks: ");
            float EcatMarks = float.Parse(Console.ReadLine());
           viewDegreePrograms();
            Console.WriteLine("Enter your number of preferances: ");
            int no = int.Parse(Console.ReadLine());
            List<Degree> Preferances = new List<Degree>();
            for(int i = 0; i < no; i++)
            {
                Console.WriteLine("Enter your degree Preferance: ");
                string degName = Console.ReadLine();
                foreach(Degree d in degreesList)
                {
                    if (degreesList.Contains(d) && degName == d.degreeTitle) {
                    Preferances.Add(d);
                        flag = true;
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine("Enter a valid degree program");
                    i--;
                }
               
            }
            Student s = new Student(Name, age, FSCMarks, EcatMarks, Preferances);
            return s;
        }
         static void viewDegreePrograms()
        {
            foreach(Degree d in degreesList)
            {
                Console.WriteLine(d.degreeTitle);
            }
        }

    }
}
