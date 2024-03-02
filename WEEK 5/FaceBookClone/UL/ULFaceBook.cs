using FaceBookClone.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookClone.UL
{
    internal class ULFaceBook
    {
        public static void CallFBMenu(BLFacebook F)
        {
            string name = "";
            int Option = 0;
            do
            {
                Option = FBMenu();
                Console.Clear();
                if (Option == 1)
                {
                    name = AddUser(F);
                }
                if (Option == 2)
                {
                         ViewPosts(F);
                }
                if (Option == 3)
                {
                    if (name != null)
                    {
                        Console.WriteLine("WELCOME BACK " + name);
                        Post(F, name);
                    }

                }
                Console.ReadKey();
            }
            while (Option != 4);
        }
        public static int FBMenu()
        {
            Console.Clear();
            int op = 0;
            Console.WriteLine("1. Add FaceBook User");
            Console.WriteLine("2. View Posts For a specific Person ");
            Console.WriteLine("3. Post  for a specific Person ");
            Console.WriteLine("4. Back To Main Menu");
            Console.WriteLine("Enter your opiton: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static string AddUser(BLFacebook F)
        {
            Console.WriteLine("Enter Your UserName: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            string pass = Console.ReadLine();

            BLMUsers user = new BLMUsers(name, pass);
            F.AddUser(user);
            return name;


        }
        public static void ViewPosts(BLFacebook F)
        {
            Console.WriteLine("Enter user Name of the person: ");
            string name = Console.ReadLine();
            BLMUsers U = F.GetUserByUserName(name);
            string message = U.ViewMessages();
            if(message != null)
            {
                bool flag = F.CheckMessage(message);
                if (flag == true)
                {
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine(name + " You Have no message");
                }
            }
           
           
        }
        public static void Post(BLFacebook F, string name)
        {

            BLMUsers U = F.GetUserByUserName(name);
            if(U != null)
            {
                Console.WriteLine("Whats Your Post " + name);
                string tweet = Console.ReadLine();
                F.AddPost(tweet);
                U.AddMessages(tweet);
            }
            else
            {
                Console.WriteLine("Please Sign Up First");
            }

        }
    }
}
