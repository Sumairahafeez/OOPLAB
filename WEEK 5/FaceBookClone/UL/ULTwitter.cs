using FaceBookClone.BL;
using FaceBookClone.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookClone.UL
{
    internal class ULTwitter
    {
        public static void CallTwitterMenu(BLTwitter T)
        {
            string name="";
            int Option = 0;
            do
            {
                Option = TwitterMenu();
                Console.Clear();
                if(Option == 1)
                {
                   name = AddUser(T);
                }
                if(Option == 2)
                {
                    ViewTweets(T);
                }
                if(Option == 3)
                {   if(name != null)
                    {
                        Console.WriteLine("WELCOME BACK " + name);
                        PostTweets(T,name);
                    }
                   
                }
                Console.ReadKey();
            }
            while(Option != 4);
        }
        public static int TwitterMenu()
        {
            Console.Clear();
            int op = 0;
            Console.WriteLine("1. Add Twitter User");
            Console.WriteLine("2. View Tweets For a specific Person ");
            Console.WriteLine("3. Post Tweets for a specific Person ");
            Console.WriteLine("4. Back To Main Menu");
            Console.WriteLine("Enter your opiton: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static string AddUser(BLTwitter T)
        {
            Console.WriteLine("Enter Your UserName: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            string pass = Console.ReadLine();
            
                BLMUsers user = new BLMUsers(name, pass);
                T.AddUser(user);
                return name;
            
           
        }
        public static void ViewTweets(BLTwitter T)
        {
            Console.WriteLine("Enter user Name of the person: ");
            string name = Console.ReadLine();
            BLMUsers U = T.GetUserByUserName(name);
            string message =  U.ViewMessages();
            if(message != null)
            {
                bool flag = T.CheckMessage(message);
                if(flag == true)
                {
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine("No Message");
                }
                
            }
        }
        public static void PostTweets(BLTwitter T,string name)
        {
            
            BLMUsers U = T.GetUserByUserName(name);
            if(U != null)
            {
                Console.WriteLine("Whats Your Tweet " + name);
                string tweet = Console.ReadLine();
                U.AddMessages(tweet);
                T.AddTweet(tweet);
            }
           else
            {
                Console.WriteLine("Please Add User First");
            }
        }

    }
}
