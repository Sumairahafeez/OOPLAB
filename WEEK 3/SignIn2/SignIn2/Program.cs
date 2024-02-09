using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MUser> user = new List<MUser>();
            int userCount = 0;
            int option = 0;
            int currentStudent = 0;
            string path = "D:\\2nd semester\\OOP Lab\\WEEK 3\\SignIn2\\SignIn2\\bin\\Debug\\signIn.txt";
            ReadData(path, user);
            while (option != 3)

            {
                option = LogInPage();
                if (option == 1)
                {
                    SignUpHeader();
                    MUser signUpUser = new MUser();
                    SignUpCredentials(signUpUser);
                    bool check = SignUp(signUpUser, user, ref userCount);
                    if (check == true)
                    {
                        StoreDataInFile(path, signUpUser);
                        Console.WriteLine("You Have Signed Up SuccesFully!:)");
                        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    }
                    if (check == false)
                    {
                        Console.WriteLine("User Name Already Exists:]");
                        Console.ReadKey();
                    }
                }
                    if (option == 2)
                    {
                        MUser signInUser = new MUser();
                        SignInHeader();
                        Console.ForegroundColor = ConsoleColor.Green;
                        signInUser = TakeSignInInput();
                        bool isValid = SignInValidity(signInUser,user, ref userCount, ref currentStudent);
                        string role = "";

                        if (isValid == true)
                        {
                            role = SignIn(signInUser, user);
                            
                        }
                        else if (isValid == false)
                        {
                            Console.WriteLine("Invalid Credentials :>");
                            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                            Console.ReadKey();
                        }
                    }
                   
                    }
            }
        
        static string SignIn(MUser userData, List<MUser> user)
        {
            for (int i = 0; i < user.Count; i++)
            {
                if (userData.username == user[i].username && userData.password == user[i].password)
                {
                    return user[i].role;
                }
            }
            return null;
        }
        static bool SignInValidity(MUser userData, List<MUser> user, ref int userCount, ref int currentStudent)
        {
            bool flag = false;
            for (int i = 0; i < user.Count; i++)
            {
                if (userData.username == user[i].username && userData.password == user[i].password)
                {
                    flag = true;
                    currentStudent = i;
                    break;
                }
            }
            return flag;
        }
        static MUser TakeSignInInput()
        {
            string inputName, inputPassword;
            Console.Write("Enter your user Name: ");
            inputName = Console.ReadLine();
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.Write("Enter your  Password: ");
            inputPassword = Console.ReadLine();
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            MUser user = new MUser(inputName, inputPassword);
            Console.ReadKey();
            return user;
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
        static void SignUpCredentials(MUser signUpData)
        {

            Console.Clear();

            bool isDone = true;
            while (isDone != false)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter your Name(alphabets only): ");
                signUpData.username = Console.ReadLine();
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                bool check = signUpData.NameValidity();
                bool isValid;
                if (check == true)
                {
                    Console.WriteLine("Invalid UserName! :o");
                    Console.ReadKey();

                }
                if (check == false)
                {
                    Console.Write("Enter your Password(must have 8 characters): ");
                    signUpData.password = Console.ReadLine();
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                }
                isValid = signUpData.PasswordValidity();
                if (isValid == false)
                {
                    Console.WriteLine("InValid Password! :o");
                    Console.ReadKey();

                }
                if (isValid == true)
                {
                    Console.Write("Enter your role(Manager or Student): ");
                    signUpData.role = Console.ReadLine();
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    if (signUpData.role != "Manager" && signUpData.role != "Student")
                    {
                        Console.WriteLine("Please Enter a valid role!");
                        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                        Console.ReadKey();
                    }


                }
                isDone = false;
            }

        }
        static void SignInHeader()
        {
            Console.Clear();

            Console.WriteLine("                                               #                 #          \r\n                                     \r\n                                         ###   ##     ###  ###   ##    ###   \r\n                                        ##      #    #  #  #  #   #    #  #  \r\n                                          ##    #     ##   #  #   #    #  #  \r\n                                        ###    ###   #     #  #  ###   #  #  \r\n                                                      ###                    ");



        }
        static void SignUpHeader()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                                                #                 #          \r\n                                     \r\n                                         ###   ##     ###  ###   ##    ###   \r\n                                        ##      #    #  #  #  #   #    #  #  \r\n                                          ##    #     ##   #  #   #    #  #  \r\n                                        ###    ###   #     #  #  ###   #  #  \r\n                                                      ###                    \r\n");

        }
        static bool SignUp(MUser SignUpUserData, List<MUser> user, ref int userCount)
        {
            //check if user name not entered and then add them in the array
            if (!CheckValidity(ref SignUpUserData.username, user, ref userCount))
            {
                MUser s = new MUser();
                s.username = SignUpUserData.username;           //add name and password in the array
                s.password = SignUpUserData.password;
                s.role = SignUpUserData.role;
                user.Add(s);
                userCount++;
                return true;
            }
            return false;
        }
        static bool CheckValidity(ref string name, List<MUser> user, ref int userCount)
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
        static bool ReadData(string path, List<MUser>user)
        {
            if(File.Exists(path))
            {
                StreamReader signIN = new StreamReader(path);
                string record;
                while((record =  signIN.ReadLine())!= null) {
                    
                    MUser u = new MUser();
                    u.username = parseData(record, 1);
                    u.password = parseData(record, 2);
                    u.role = parseData(record, 3);
                    user.Add(u);
                    return true;
                }
            
            }
            return false;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for(int i = 0; i < record.Length; i++)
            {
                if (record[i] ==',')
                {
                    comma++;
                }
                if(comma == field)
                {
                    item += record[i];
                }
            }
            return item;


        }
        static void StoreDataInFile(string path, MUser user)
        {
            path = "D:\\2nd semester\\OOP Lab\\WEEK 3\\signIn.txt";
            StreamWriter signIN = new StreamWriter(path, true);
            signIN.WriteLine(user.username + "," + user.password +"," + user.role);
            signIN.Flush();
            signIN.Close();

        }
    }
}
