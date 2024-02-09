using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business
{
    internal class Program
    {
        static void Main(string[] args)
        {   //DECLARE VARIABLES
            int userNum = 500;
            int userCount = 0;
            int option = 0;
            int room = 0;
            int studentIndex = 0;
            int currentStudent = 0;
            string name = "", password = "", role = "";
            string inputName = "", inputPassword = "";
            string[] userName = new string[userNum];
            string[] userPassword = new string[userNum];
            string[] userRole = new string[userNum];
            int[] roomNumber = new int[userNum];
            string[] offDate = new string[300];
            string[] offMonth = new string[300];
            string[] updateDays = new string[100];
            string[] updateMonths = new string[100];
            string[] toUpdateDays = new string[100];
            string[] toUpdateMonths = new string[100];
            int bill = 0, profit = 0;
            string[] date = new string[100];
            string[] votedMenu = new string[100];
            string[] complaintBox = new string[100];
            int days = 0;
            string offDates = "";
            int budget = 0, things = 0;
            string fileName = "";
            LoadSignIn(userName,userPassword,userRole,fileName, ref userCount);
            //CALLING HEADER
            Header();

            while (option != 3)
            {   //loginpage will return the options
                LoginPage(ref option);
                if (option == 1) //1=signup
                {   //declare variables to get the names from user and check their valididty after that store these
                    //values in the arrays.

                    SignUpCredentials(ref name, ref password, ref role);
                    bool check = SignUp(ref name, ref password, ref role, userName, userPassword, userRole, ref userCount);//to check that name is included in string
                    {
                        if (check == true)
                        {
                            if (role == "Student")
                            {


                                Console.Write("Enter your room number: ");
                                room = int.Parse(Console.ReadLine());
                                // if(room != "1" && room != "2" && room != "3" && room != "4" && room != "5" && room != "6" && room != "7" && room != "8" && room != "9" && room != "0")
                                // {
                                //    Console.WriteLine("Please Enter a Valid room Number!";
                                //     Breaking():

                                //     continue;
                                // }


                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You Have Signed Up SuccesFully!:)");
                            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                            HappyFace();
                            Breaking();
                            studentIndex++;
                            Console.WriteLine("You have signed up as " + studentIndex + " student.");
                        }
                        if (check == false)
                        {
                            Console.WriteLine("User Name Already Exists:]");
                            SadFace();
                            Breaking();
                        }



                    }
                }
                if (option == 2)
                {
                    Console.Clear();
                    SignInHeader();
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.Write("Enter your user Name: ");
                    inputName = Console.ReadLine();
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    Console.Write("Enter your  Password: ");
                    inputPassword = Console.ReadLine();
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    bool isValid = SignInValidity(inputName, inputPassword, userName, userPassword, userCount, currentStudent);
                    string Role;

                    if (isValid == true)
                    {
                        role = SignIn(inputName, inputPassword, userName, userPassword, userRole, userCount);

                    }
                    else if (isValid == false)
                    {
                        Console.WriteLine("Invalid Credentials :>");
                        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                        Breaking();
                    }
                    if (role == "Manager")
                    {
                        bool find = CheckManager();
                        if (find == true)
                        {
                            Console.WriteLine("You Have Succesfully logged in as a Manager ");
                            HappyFace();
                            Breaking();
                            FunctionalityOfManager(days, budget, things, studentIndex, bill, profit, complaintBox, currentStudent, date, votedMenu);
                        }
                        if (find == false)
                        {
                            Console.WriteLine("Manager not Found:o");
                            SadFace();
                            Breaking();
                        }


                    }
                    else if (role == "Student")
                    {

                        Console.WriteLine("You Have Succesfully logged in as a Student ");
                        Breaking();
                        FunctionalityOfStudent(offDate, offMonth, ref days, currentStudent, ref bill, date, votedMenu, complaintBox, userName, userPassword);
                    }

                }
                if (option < 1 || option > 3)
                {
                    Console.WriteLine("Please Enter a Valid Option!");
                    SadFace();
                    Breaking();
                 }
                if (option == 3)
                {
                    StoreSignIn(userName, userPassword, userRole, fileName, ref userCount);
                }

            }
            

        }
        
        static void Header()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" __  __                   __  __                                                            _      _____              _                    \r\n|  \\/  |                 |  \\/  |                                                          | |    / ____|            | |                   \r\n| \\  / |  ___  ___  ___  | \\  / |  __ _  _ __    __ _   __ _   ___  _ __ ___    ___  _ __  | |_  | (___   _   _  ___ | |_   ___  _ __ ___  \r\n| |\\/| | / _ \\/ __|/ __| | |\\/| | / _` || '_ \\  / _` | / _` | / _ \\| '_ ` _ \\  / _ \\| '_ \\ | __|  \\___ \\ | | | |/ __|| __| / _ \\| '_ ` _ \\ \r\n| |  | ||  __/\\__ \\\\__ \\ | |  | || (_| || | | || (_| || (_| ||  __/| | | | | ||  __/| | | || |_   ____) || |_| |\\__ \\| |_ |  __/| | | | | |\r\n|_|  |_| \\___||___/|___/ |_|  |_| \\__,_||_| |_| \\__,_| \\__, | \\___||_| |_| |_| \\___||_| |_| \\__| |_____/  \\__, ||___/ \\__| \\___||_| |_| |_|\r\n                                                        __/ |                                              __/ |                           \r\n                                                       |___/                                              |___/                            \r\n");
        }
        static void LogInPageHeader()
        { Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                        #                     ###                 ####                       \r\n                        #                      #                  #   #                      \r\n                        #       ###    ## #    #    # ##          #   #   ###    ## #   ###  \r\n                        #      #   #  #  #     #    ##  #         ####       #  #  #   #   # \r\n                        #      #   #   ##      #    #   #         #       ####   ##    ##### \r\n                        #      #   #  #        #    #   #         #      #   #  #      #     \r\n                        #####   ###    ###    ###   #   #         #       ####   ###    ###  \r\n                                      #   #                                     #   #        \r\n                                        ###                                       ###         ");
        }
        static void SignUpHeader()
        { Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                        #                            \r\n                                     \r\n                                 ###   ##     ###  ###   #  #  ###   \r\n                                ##      #    #  #  #  #  #  #  #  #  \r\n                                  ##    #     ##   #  #  #  #  #  #  \r\n                                ###    ###   #     #  #   ###  ###   \r\n                                              ###              # ");
        }
        static void SadFace()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            {
                Console.WriteLine("                           .-=+****+=-.         \r\n                          :*@%*=-::::-=*%@*-      \r\n                        -%%=.            .=%%=    \r\n                      .#@-                  -@%.  \r\n                     .@%.     .        .     .%@. \r\n                     #@.    .@@@:    .@@@.    .@% \r\n                    :@+      =*=      =*=      +@:\r\n                    -@=                        -@=\r\n                    :@+       -*%@%%@%*-       +@:\r\n                    %@.    =@#-.     -#@=     @% \r\n                    .@%.   *=          -*    %@. \r\n                      .%@-                  -@%.  \r\n                        =%%=.             =%@=    \r\n                          -*@%*=-:..:-=+%@*-      \r\n                            .-=+*##**=-.         ");
            }
        }
        static void HappyFace()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                                         ..              \r\n                                                    .:::....:::.         \r\n                                                   -.          .-        \r\n                                                  =   .%:  :%.   =       \r\n                                                 =     :    .     =      \r\n                                                 =   :        :   =      \r\n                                                 .:  .-      ::  ::      \r\n                                                  ::   ::::::   ::       \r\n                                                   ::.      .::         \r\n                                                     .::::::.          ");
        }
        static void SignInHeader()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                                                #                 #          \r\n                                     \r\n                                         ###   ##     ###  ###   ##    ###   \r\n                                        ##      #    #  #  #  #   #    #  #  \r\n                                          ##    #     ##   #  #   #    #  #  \r\n                                        ###    ###   #     #  #  ###   #  #  \r\n                                                      ###                    \r\n");
        }
        static void LoginPage(ref int option)
        {
            Console.Clear();
            Header();
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

        }
        static void SignUpCredentials(ref string name, ref string password, ref string role)
        {

            Console.Clear();
            Header();
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
                    SadFace();
                    Breaking();

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
                    SadFace();
                    Breaking();

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
                        Breaking();
                    }

                }
                isDone = false;
            }

        }
        static bool SignUp(ref string name, ref string password, ref string role, string[] userName, string[] userPassword, string[] userRole, ref int userCount)
        {
            //check if user name not entered and then add them in the array
            if (!CheckValidity(ref name, userName, ref userCount))
            {
                userName[userCount] = name;           //add name and password in the array
                userPassword[userCount] = password;
                userRole[userCount] = role;
                userCount++;
                return true;
            }
            return false;
        }
        static bool CheckValidity(ref string name, string[] userName, ref int userCount)
        {
            bool isValid = false;
            for (int i = 0; i < userCount; i++)
            {
                if (name == userName[i])
                {
                    isValid = true;
                }
            }
            return isValid;
        }
        static void Breaking()
        {
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
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
        static bool SignInValidity(string InputName, string InputPassword, string[] userName, string[] userPassword, int userCount, int currentStudent)
        {
            bool flag = false;
            for (int i = 0; i < userCount; i++)
            {
                if (InputName == userName[i] && InputPassword == userPassword[i])
                {
                    flag = true;
                    currentStudent = i;
                    break;
                }
            }
            return flag;
        }
        static string SignIn(string InputName, string InputPassword, string[] userName, string[] userPassword, string[] userRole, int userCount)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (InputName == userName[i] && InputPassword == userPassword[i])
                {
                    return userRole[i];
                }
            }
            return null;
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
        static void FunctionalityOfManager(int days, int budget, int things, int studentIndex, int bill, int profit, string[] complaintBox, int currentStudent, string[] date, string[] votedMenu)
        {
            int op = 0;
            while (op != 8)
            {
                ManagerPage();
                op = ManagerfirstPage();
                if (op == 1)
                {
                    CallingManagerMenu(days, budget, things, studentIndex, bill, profit, complaintBox, currentStudent, date, votedMenu);

                }
                
                else if (op == 2)
                {
                    Console.Clear();

                    Header();
                    ManagerPage();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    CallAddStock(ref things);
                    string[] stock = new string[things];
                    int[] quantity = new int[things];
                    AddStock(stock, quantity, things, bill, profit);

                }
                else if (op == 3)
                {
                    Console.WriteLine("Please Enter Stock First!");
                    Breaking();
                }

                else if (op == 8)
                {
                    break;
                }

                /*
                else if (op == 5)
                {
                    Console.Clear();
                    Header();
                    ManagerPage();
                    
                    bill = MakeBill(budget, studentIndex, bill, profit);

                    Console.WriteLine("Your Bill per each student is: " + bill);
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    Breaking();
                   
                }
                /*
                else if (op == 6)
                {
                    Console.Clear();
                    Header();
                    ManagerPage();
                    
                    Console.Write("Enter your Profit Margin: ");
                     profit=int.Parse(Console.ReadLine());
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    Console.WriteLine("Your Profit is " + CalculateProfit(bill, profit) + " per each student");
                    Breaking();
                  Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");

                }
                /*
                else if (op == 7)
                {
                    Console.Clear();
                    header();
                    managerPage();
                    setcolor(7);
                    viewComplaints(complaintBox, currentStudent);
                    Breaking():
                }*/
                /*else if (op == 4)
                {
                    Console.Clear();
                    Header();
                    ManagerPage();

                    bool anotherCheck = CheckStudentIndex(studentIndex);
                    {
                        if (anotherCheck == true)
                        {
                            ViewStudentVotedMenu(date, votedMenu, currentStudent);
                            Breaking():
                        }
                        else
                        {
                            Console.WriteLine("No Votes!");
                            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                            Breaking();
                        }
                    }
                */

                }
                if (op < 1 || op > 8)
                {
                    Console.Clear();
                    Header();
                    ManagerPage();

                    Console.WriteLine("Please Enter a Valid Option!");
                    SadFace();
                    Breaking();
                    FunctionalityOfManager(days, budget, things, studentIndex, bill, profit, complaintBox, currentStudent, date, votedMenu);
                }
            }
        
        static void ManagerPage()
        {
            Console.Clear();
            Header();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                             #  #                                      \r\n                                                ####                                      \r\n                                                ####   ###  ###    ###   ###   ##   ###   \r\n                                                #  #  #  #  #  #  #  #  #  #  # ##  #  #  \r\n                                                #  #  # ##  #  #  # ##   ##   ##    #     \r\n                                                #  #   # #  #  #   # #  #      ##   #     \r\n                                                                         ###              ");

        }
        static int ManagerfirstPage()
        {
            Console.Clear();
            Header();
            ManagerPage();
            Console.ForegroundColor = ConsoleColor.Cyan;
            int option;

            Console.WriteLine("1. MENU                      ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("2. ADD STOCK                 ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("3. VIEW STOCK                ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("4. VIEW VOTES                ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("5. BILLING                   ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("6. PROFIT                    ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("7. COMPLAINTS                ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("8. LOG OUT                   ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");

            Console.WriteLine("#Your Options:               ");
            option = int.Parse(Console.ReadLine());
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            return option;

        }
        static int CallingManagerMenu(int days, int budget, int things, int studentIndex, int bill, int profit, string[] complaintBox, int currentStudent, string[] date, string[] votedMenu)

        {
            string day;
            int choice = Managermenu();
            if (choice == 1)
            {
                Console.Clear();
                ManagerPage();
                
                Console.WriteLine("Enter the number of days for which you want to enter the menu: ");
                day = Console.ReadLine();
                bool check = IntValidations(day);
                if (check == true)
                {
                    days = 0;
                    days += int.Parse(day);
                }
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            }
            string[] menulunch=new string[days];
            string[] menuDinner=new string[days];
            int[] budgetlunch=new int[days];
            int[] budgetDinner=new int[days];
            if (choice == 1)
            {

                Create(menulunch, menuDinner, budgetlunch, budgetDinner, days, budget, things, studentIndex, bill, profit, complaintBox, currentStudent, date, votedMenu);

            }
            else if (choice == 2)
            {

                return choice;
            }


            if (choice == 3)
            {
                FunctionalityOfManager(days, budget, things, studentIndex, bill, profit, complaintBox, currentStudent, date, votedMenu);
            }
            if (choice < 1 || choice > 3)
            {
                Console.Clear();
                Header();
                ManagerPage();
                
                Console.WriteLine("Please Enter a Valid Option!");
                SadFace();
                Breaking();

                    CallingManagerMenu(days, budget, things, studentIndex, bill, profit, complaintBox, currentStudent, date, votedMenu);
            }
            return 0;

        }
        static int Managermenu()
        {
            Console.Clear();
            Header();
            ManagerPage();
            
            int option;

            Console.WriteLine("1.CREATE MENU                                     ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("2.VIEW MENU                                       ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("3.EXIT                                            ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.Write("Your Option:                                      ");
            option = int.Parse(Console.ReadLine());
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            return option;
        }
        static void Create(string[] menulunch, string[] menuDinner, int[] budgetlunch, int[] budgetDinner, int days, int budget, int things, int studentIndex, int bill, int profit, string[] complaintBox, int currentStudent, string[] date, string[] votedMenu)
        {
            string lunchbudget="", dinnerbudget="";
            for (int i = 0; i < days; i++)
            {
                Console.WriteLine("Menu for Day " + (i + 1) + " Lunch: ");
                menulunch[i]   = Console.ReadLine();
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                Console.WriteLine("Menu for Day " + (i + 1) + " dinner: ");
                menuDinner[i] = Console.ReadLine();
                
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                Console.Write("Enter budget for Day " +( i + 1) + " Lunch: ");
                lunchbudget = Console.ReadLine();
                bool check = IntValidations(lunchbudget);
                if (check == true)
                {
                    budgetlunch[i] = int.Parse(lunchbudget);
                }
                if (check == false)
                {
                    days = 0;
                    //    create(menulunch, menuDinner, budgetlunch, budgetDinner, days, budget, things, studentIndex, bill, profit, complaintBox,currentStudent, date, votedMenu);
                    CallingManagerMenu(days, budget, things, studentIndex, bill, profit, complaintBox, currentStudent, date, votedMenu);
                }
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                Console.WriteLine("Enter budget for Day " +( i + 1) + " Dinner: ");
                dinnerbudget=Console.ReadLine();
                bool valid = IntValidations(dinnerbudget);
                if (valid == true)
                {
                    budgetDinner[i] = int.Parse(dinnerbudget);
                }
                if (valid == false)
                {
                    days = 0;
                    // create(menulunch, menuDinner, budgetlunch, budgetDinner, days, budget, things, studentIndex, bill, profit, complaintBox,currentStudent, date, votedMenu);
                    CallingManagerMenu(days, budget, things, studentIndex, bill, profit, complaintBox, currentStudent, date, votedMenu);
                }
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                budget = budgetlunch[i] + budgetDinner[i];


            }
            Breaking();
    // storeMenucreatedByManager(menulunch,menuDinner,budgetlunch, budgetDinner, days, fileName);
    int op = CallingManagerMenu(days, budget, things, studentIndex, bill, profit, complaintBox, currentStudent, date, votedMenu);
            if (op == 2)
            {
                ViewMenu(menulunch, menuDinner, days, budget, things, studentIndex, bill, profit, complaintBox, currentStudent, date, votedMenu);

            }
        }
        static bool IntValidations(string code)
        {
            {
                bool flag = false;
                int i = 0;
                while (i < code.Length)
                {

                    if (code[i] > 47 && code[i] < 58)
                    {
                        i++;
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        Console.Write("Please Enter an Integer!");
                        Breaking();
                 break;
                    }
                }
                return flag;
            }
        }
        static void ViewMenu(string[] menulunch, string[] menuDinner, int days, int budget, int things, int studentIndex, int bill, int profit, string[] complaintBox, int currentStudent, string[] date, string[] votedMenu)
        {
            Console.Clear();
            Header();
            ManagerPage();
            
            int choice;
            Console.WriteLine("Day \t" + "\t" + "LUNCH \t" + "\t" + " DINNER");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            for (int i = 0; i < days; i++)
            {

                Console.WriteLine("Day " +( i + 1) + "\t \t" + menulunch[i] + " \t \t" + menuDinner[i]);
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");

            }
            Breaking();
            CallingManagerMenu(days, budget, things, studentIndex, bill, profit, complaintBox, currentStudent, date, votedMenu);


        }
        static void CallAddStock(ref int things)
        {
            things = 0;
            string thing;
            Console.Write("Enter the Number of things you want to add to the stock: ");
            thing=Console.ReadLine();
            bool check = IntValidations(thing);
            if (check == true)
            {
                things += int.Parse(thing);
            }
            if (check == false)
            {
                things = 0;
                CallAddStock(ref things);
            }
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
        }
        static void AddStock(string[] stock, int[] quantity, int things, int bill, int profit)
        {
            string quant;
            for (int i = 0; i < things; i++)
            {
                Console.Write("Enter the things you want to order: ");
                stock[i]=Console.ReadLine();
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                Console.Write("Enter the quantity of these things(in kgs): ");
                quant=Console.ReadLine();
                bool check = IntValidations(quant);
                if (check == true)
                {
                    quantity[i] = int.Parse(quant);
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");

                }

            }
            Breaking();
            int op = ManagerfirstPage();
               {
                if (op == 3)
                {
                    ViewStock(stock, quantity, things);
                }
               }
        }
        static void ViewStock(string[] stock, int[] quantity, int things)
        {
            ManagerPage();
            
            Console.WriteLine("no. stock" + "\t \t" + "quantity(kg)");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            for (int i = 0; i < things; i++)
            {
                Console.WriteLine(i + 1 + ". " + stock[i] + "\t \t" + quantity[i] + "kg");
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            }
            Breaking();

}
        static int FunctionalityOfStudent(string[] offDate, string[] offMonth, ref int days, int currentStudent, ref int bill, string[] date, string[] votedMenu, string[] complaintBox, string[] userName, string[] userPassword)
        {
            string day;
            int option=0;
            days = 0;
            while (option != 9)
            {
                StudentHeader();
                option = StudentFirstPage();
                if (option == 1)
                {
                    Console.Clear();
                    Header();
                    StudentHeader();
                    
                    Console.Write("How many days you want to off: ");
                    day = Console.ReadLine();
                    bool check = IntValidations(day);

                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    if (check == true)
                    {
                        days += int.Parse(day);
                        AddAttendence(offDate, offMonth, days, currentStudent, bill);
                    }



                }
                
                if (option == 2)
                {
                    Console.Clear();
                    Header();
                    StudentHeader();
                    
                    UpdateAttendence(offDate, offMonth, ref days, currentStudent, bill);
                }
                
                if (option == 3)
                {
                    Console.Clear();
                    Header();
                    StudentHeader();
                    
                    ViewAttendence(offDate, offMonth, days, currentStudent, bill);

                }
                /*
                if (option == 4)
                {
                    Console.Clear();
                    header();
                    studentHeader();
                    setcolor(15);
                    Console.WriteLine(" Your bill is " << checkBill(bill, offDate, offMonth, days, currentStudent);

                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    Breaking():
    }
                else if (option == 5)
                {
                    Console.Clear();
                    header();
                    studentHeader();
                    setcolor(15);
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    Console.WriteLine("Coming Soon");
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    Console.WriteLine("Development work under process! :)";
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    Breaking():
    }
                if (option == 6)
                {
                    Console.Clear();
                    header();
                    studentHeader();
                    setcolor(15);
                    studentVotedMenu(date, votedMenu, currentStudent);
                    Breaking():
    }
                else if (option == 7)
                {
                    Console.Clear();
                    header();
                    studentHeader();
                    setcolor(15);
                    studentsComplaint(complaintBox, currentStudent);
                    Breaking():
                 }
                else if (option == 8)
                {
                    Console.Clear();
                    header();
                    studentHeader();
                    setcolor(15);
                    editStudentAccount(currentStudent, userName, userPassword);
                }
                */
                else if (option < 1 || option > 9)
                {
                    Console.Clear();
                    Header();
                    StudentHeader();
                    
                    Console.WriteLine("Please Enter a Valid Option!");
                    Breaking();
    
    }
                


            }
            return 0;
        }
        static void StudentHeader()
        {
            Console.Clear();
            Header();
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("                                                ##    #             #               #    \r\n                                               #  #   #             #               #    \r\n                                                #    ###   #  #   ###   ##   ###   ###   \r\n                                                 #    #    #  #  #  #  # ##  #  #   #    \r\n                                               #  #   #    #  #  #  #  ##    #  #   #    \r\n                                                ##     ##   ###   ###   ##   #  #    ##  \r\n                                          ");
        }
        static int StudentFirstPage()
        {
            Console.Clear();
            Header();
            StudentHeader();
           

            int op;
            Console.WriteLine("1. ADD MESS ATTENDENCE        ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("2. UPDATE MESS ATTENDENCE     ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("3. VIEW MESS ATTENDENCE       ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("4. CHECK BILL                 ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("5. PAY BILL                   ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("6. VOTE FOR MENU              ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("7. COMPLAINT                  ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("8. EDIT ACCOUNT               ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("9. LOG OUT                    ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.Write("CHOOSE YOUR OPTION:           ");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            return op;
        }
        static void AddAttendence(string[] offDate, string[] offMonth, int days, int currentStudent, int bill)
        {
            string startDate;
            string endDate;
            Console.Write("From which date you want to off: ");
            offDate[currentStudent]=Console.ReadLine();
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("To Which date you want to off: ");
            offMonth[currentStudent]=Console.ReadLine();
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Breaking();
 


}
        static void UpdateAttendence(string[] offDates, string[] offMonths, ref int days, int currentStudent, int bill)
        {

            string day;
            Console.Write("Now how many days you want to update: ");
            day = Console.ReadLine();
            bool check = IntValidations(day);
            if (check == true)
            {
                days = 0;
                days += int.Parse(day);
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                Console.Write("Enter the starting date: ");
                offDates[currentStudent] = Console.ReadLine();
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                Console.Write("Enter the ending date: ");
                offMonths[currentStudent] = Console.ReadLine();
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                Breaking();  
         }
            if (check == false)
            {
                days = 0;
                Console.Clear();
                Header();
                StudentHeader();
                
                UpdateAttendence(offDates, offMonths, ref days, currentStudent, bill);
            }





        }
        static void ViewAttendence(string[] offDates, string[] offMonths, int days, int currentStudent, int bill)
        {
            Console.WriteLine("Days Off" + "\t \t" + "Starting Date" + "\t \t" + "Starting Month");
            Console.WriteLine( "<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine(days + "\t \t" + offDates[currentStudent] + "\t \t" + offMonths[currentStudent] + "\t \t");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Breaking();

}
        static void StoreSignIn(string[] userName, string[] userPassword, string[] userRole, string fileName,ref int userCount)
        { //fileName = "SignIn.txt";
            string path = "D:\\2nd semester\\OOP Lab\\Business\\SignIn.txt";
            if (File.Exists(path))
            {
                StreamWriter SignIN = new StreamWriter(path,true);
               for(int i = 0; i<userCount; i++)
                {
                    SignIN.Flush();
                    SignIN.WriteLine(userName[i] + "," + userPassword[i] + "," + userRole[i]);
                   
                }
                
                
                SignIN.Close();
                
            }
        }
        static void LoadSignIn(string[] userName, string[] userPassword, string[] userRole, string fileName, ref int userCount)
        {
            string path = "D:\\2nd semester\\OOP Lab\\Business\\SignIn.txt";
            if(File.Exists(path))
            {
               StreamReader SignIn = new StreamReader(path);
                string record;
                while((record =  SignIn.ReadLine()) != null)
                {
                    Console.WriteLine(record);

                }
                SignIn.Close();
            }
            else
            {
                Console.WriteLine("Not Exist!");
            }
        }
    }
}
