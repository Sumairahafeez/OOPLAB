using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MUser[] user = new MUser[100];
            int userCount = 0;
            int option = 0;
            int currentStudent = 0;
            
            while (option!=3)

            {
                option = LogInPage();
                if(option == 1)
                {
                    string name="", password="", role = "";
                    SignUpCredentials(ref name, ref password, ref role);
                    bool check = SignUp(ref name, ref password, ref role, user, ref userCount);
                    if(check == true)
                    {
                        Console.WriteLine("You Have Signed Up SuccesFully!:)");
                        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    }
                    
                    if (check == false)
                    {
                        Console.WriteLine("User Name Already Exists:]");
                        Console.ReadKey();
            }
                }
                if(option == 2)
                {
                    SignInHeader();
                    Console.ForegroundColor = ConsoleColor.Green;
                    string inputName, inputPassword;
                    Console.Write("Enter your user Name: ");
                    inputName = Console.ReadLine();
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    Console.Write("Enter your  Password: ");
                    inputPassword = Console.ReadLine();
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    bool isValid = SignInValidity(ref inputName, ref inputPassword, user, ref userCount, ref currentStudent);
                    string role="";

                    if (isValid == true)
                    {
                        role = SignIn(ref inputName,ref inputPassword, user,ref userCount);

                    }
                    else if (isValid == false)
                    {
                        Console.WriteLine("Invalid Credentials :>");
                        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                        Console.ReadKey();
            }
                    if (role == "Manager")
                    {
                        bool find = CheckManager();
                        if (find == true)
                        {
                            Console.WriteLine("You Have Succesfully logged in as a Manager ");
                            Console.ReadKey();
                        }
                        if (find == false)
                        {
                            Console.WriteLine("Manager not Found:o");
                            Console.ReadKey();
                }


                    }
                    else if (role == "Student")
                    {

                        Console.WriteLine("You Have Succesfully logged in as a Student ");
                        Console.ReadKey();
                    }

                }
                if (option < 1 || option > 3)
                {
                    Console.WriteLine("Please Enter a Valid Option!");
                    Console.ReadKey();
                    
        }
            }
            }

        static bool CheckManager()
            {
                string superPassword;
                Console.WriteLine("What is the Super Password: ");
                superPassword = Console.ReadLine();
                if (superPassword == "12345678")
                {
                    return true;
                }
            return false;
            }
        
        static string SignIn(ref string InputName, ref string InputPassword, MUser[] user, ref int userCount)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (InputName == user[i].username && InputPassword == user[i].password)
                {
                    return user[i].role;
                }
            }
            return null;
        }
        static bool SignInValidity(ref string InputName,ref string InputPassword, MUser[] user,ref int userCount, ref int currentStudent)
        {
            bool flag = false;
            for (int i = 0; i < userCount; i++)
            {
                if (InputName ==user[i].username && InputPassword == user[i].password)
                {
                    flag = true;
                    currentStudent = i;
                    break;
                }
            }
            return flag;
        }
        static void SignInHeader()
        {
            Console.Clear();
                
            Console.WriteLine("                                               #                 #          \r\n                                     \r\n                                         ###   ##     ###  ###   ##    ###   \r\n                                        ##      #    #  #  #  #   #    #  #  \r\n                                          ##    #     ##   #  #   #    #  #  \r\n                                        ###    ###   #     #  #  ###   #  #  \r\n                                                      ###                    ");


    
        }
        static int LogInPage()
        {
            Console.Clear();
            int option;
            LogInPageHeader();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Sign Up         ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("2. Sign In         ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("3. Exit            ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.Write("Enter your Option: ");
            string op;
            op = Console.ReadLine();
            option = int.Parse(op);
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.ReadKey();
            return option;
        }
        static void LogInPageHeader()
        {
            
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                        #                     ###                 ####                       \r\n                        #                      #                  #   #                      \r\n                        #       ###    ## #    #    # ##          #   #   ###    ## #   ###  \r\n                        #      #   #  #  #     #    ##  #         ####       #  #  #   #   # \r\n                        #      #   #   ##      #    #   #         #       ####   ##    ##### \r\n                        #      #   #  #        #    #   #         #      #   #  #      #     \r\n                        #####   ###    ###    ###   #   #         #       ####   ###    ###  \r\n                                      #   #                                     #   #        \r\n                                        ###                                       ###         ");
            
        }
        static void SignUpCredentials(ref string name, ref string password, ref string role)
        {

            Console.Clear();
            
            bool isDone = true;
            while (isDone != false)
            {
                SignUpHeader();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter your Name(alphabets only): ");
                name = Console.ReadLine();
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                bool check = NameValidity(name);
                bool isValid;
                if (check == true)
                {
                    Console.WriteLine("Invalid UserName! :o");
                    Console.ReadKey();

                }
                if (check == false)
                {
                    Console.Write("Enter your Password(must have 8 characters): ");
                    password = Console.ReadLine();
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                }
                isValid = PasswordValidity(password);
                if (isValid == false)
                {
                    Console.WriteLine("InValid Password! :o");
                    Console.ReadKey();

                }
                if (isValid == true)
                {
                    Console.Write("Enter your role(Manager or Student): ");
                    role = Console.ReadLine();
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    if (role != "Manager" && role != "Student")
                    {
                        Console.WriteLine("Please Enter a valid role!");
                        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                        
                    }

                }
                isDone = false;
            }

        }
        static void SignUpHeader()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                                                #                 #          \r\n                                     \r\n                                         ###   ##     ###  ###   ##    ###   \r\n                                        ##      #    #  #  #  #   #    #  #  \r\n                                          ##    #     ##   #  #   #    #  #  \r\n                                        ###    ###   #     #  #  ###   #  #  \r\n                                                      ###                    \r\n");
        
    }
        static bool NameValidity(string name)
        {
            bool flag = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == '1' || name[i] == '2' || name[i] == '3' || name[i] == '4' || name[i] == '5' || name[i] == '6' || name[i] == '7' || name[i] == '8' || name[i] == '9' || name[i] == '0')
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        static bool PasswordValidity(string password)
        {
            int count = 0;
            bool flag = true;
            for (int i = 0; i < password.Length; i++)
            {
                count++;
            }

            if (count < 8)
            {
                flag = false;
            }
            return flag;
        }
        static bool SignUp(ref string name, ref string password, ref string role, MUser[] user, ref int userCount)
        {
            //check if user name not entered and then add them in the array
            if (!CheckValidity(ref name, user, ref userCount))
            {
                MUser s = new MUser();
                s.username = name;           //add name and password in the array
                s.password = password;
                s.role = role;
                user[userCount]= s;
                userCount++;
                return true;
            }
            return false;
        }
        static bool CheckValidity(ref string name, MUser[] user, ref int userCount)
        {
            bool isValid = false;
            for (int i = 0; i < userCount; i++)
            {
                if (name == user[i].username)
                {
                    isValid = true;
                }
            }
            return isValid;
        }
    }
}
