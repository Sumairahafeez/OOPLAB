using FaceBookClone.BL;
using FaceBookClone.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookClone.UL
{
    internal class ULMUsers
    {
        public static void CallingUsersOperation(DLMUsers M)
        {
            int option = 0;
            do
            {
                option = UsersMenu();
                Console.Clear();
                if(option == 1)
                {
                    M.AddSignUp();
                }
                if(option == 2)
                {
                   string name = TakeSignIn(M);
                    if(name != null)
                    {
                        CallUsers(name,M);
                    }
                }
                Console.ReadKey();
            }
            while (option != 3);
           
        }
        public static int UsersMenu()
        {
            Console.Clear();
            int op = 0;
            Console.WriteLine("1. Create a new User");
            Console.WriteLine("2. Log IN");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter Your Options: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static BLMUsers SignUp()
        {
            Console.WriteLine("Enter Your User Name: ");
            string UName = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            string UPass = Console.ReadLine();
            BLMUsers user = new BLMUsers(UName, UPass);
            return user;
        }
        public static string TakeSignIn(DLMUsers M)
        {
            Console.WriteLine("Enter Your UserName: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            string pass = Console.ReadLine();
           bool check =  M.CheckUser(name, pass);
            if(check == true)
            {
                return name;
            }
            if(check == false)
            {
                Console.WriteLine("Invalid Input");
            }
            return null;
        }
        public static void CallUsers(string name, DLMUsers D)
        {
            Console.WriteLine("WELCOME TO USERSHUB " + name);
            int op = 0;
            do
            {
                op = ValidUserMenu();
                BLMUsers U = D.GetUsers(name);
                Console.Clear();
                Console.WriteLine("WELCOME TO USERSHUB " + name);
                if (op == 1)
                {
                    ViewProfile(U);
                }
                if(op == 2)
                {
                    GetPasswordEncrypted(U);
                }
                if( op == 3)
                {
                   
                    GetPasswordChecked(U);
                }
                if(op == 4)
                {
                    GetPasswordChanged(U);
                }
                if(op == 5)
                {
                    Console.WriteLine("Your Password is " + U.GetPassword());
                }
                Console.ReadKey();
            }
            while (op != 6);
        }
        public static int ValidUserMenu()
        {
            Console.Clear();
            int op = 0;
            Console.WriteLine("1. View Profile");
            Console.WriteLine("2. Encrypt Password");
            Console.WriteLine("3. Check Password");
            Console.WriteLine("4. Change Password");
            Console.WriteLine("5. Get Password");
            Console.WriteLine("6. Log Out");
            Console.WriteLine("Enter Your Choice: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static void ViewProfile(BLMUsers User)
        {
            Console.WriteLine("User Name \t \t User Passwords");
            Console.WriteLine(User.UserName + "\t \t" + User.Password);
            Console.ReadKey();
        }
        public static void GetPasswordEncrypted(BLMUsers User)
        {
            Console.WriteLine("Enter a word: ");
            string enr = Console.ReadLine();
            Console.WriteLine("Your Encrypted Password is: "+User.EncryptPassword(enr));
        }
        public static bool GetPasswordChecked(BLMUsers User)
        {
            Console.WriteLine("Enter Your Password: ");
            string pass = Console.ReadLine();
            bool check = User.CheckPassword(pass);
            if(check == true)
            {
                Console.WriteLine("You Have Got the right Password!!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Password is wrong!!");
                return false;
            }
            return true;
        }
        public static void GetPasswordChanged(BLMUsers User)
        {
            Console.WriteLine("Enter Your Previous Password: ");
            string pre = Console.ReadLine();
            bool check = User.CheckPassword(pre);
            if(check == true)
            {
                NewPassword(User);
            }
            else
            {
                Console.WriteLine("Wrong Password!");
                GetPasswordChecked(User);
            }
            
        }
        public static void NewPassword(BLMUsers User)
        {
            Console.WriteLine("Enter Your New Password: ");
            string pass1 = Console.ReadLine();
            Console.WriteLine("Enter password to confirm: ");
            string pass2 = Console.ReadLine();
            if(pass1 == pass2)
            {
                User.Password = pass1;
                Console.WriteLine("Password Changed Successfully!!");
            }
            else
            {
                Console.WriteLine("UnMatched Passwords!!");
            }
            Console.ReadKey();
        }

    }
}
