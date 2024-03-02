using StoreManagementSystem.BL;
using StoreManagementSystem.UL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem.DL
{
    internal class DLMUser
    {
        static List<BLMUser> Userlist =  new List<BLMUser>();
        public void AddUser()
        {
            Userlist.Add(ULMUser.GetUserSignUp());
           

        }
        public  string CheckUser(string UserName, string Password)
        {
            foreach (BLMUser User in Userlist)
            {
                if (User.UserName == UserName && User.Password == Password)
                {
                    return User.Role;
                }
            }
            return null;
        }
        public static void StoreUsers(BLMUser User)
        {
            string path = "";
            StreamWriter File = new StreamWriter(path, true);
            File.WriteLine(User.UserName+","+User.Password+","+User.Role);
            File.Flush();
            File.Close();
        }
    }
}
