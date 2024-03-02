using FaceBookClone.BL;
using FaceBookClone.UL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookClone.DL
{
    internal class DLMUsers
    {
        public static List<BLMUsers> UsersList = new List<BLMUsers>();
        public void AddSignUp()
        {
            UsersList.Add(ULMUsers.SignUp());
        }
        public bool CheckUser(string Name, string Pass)
        {
            foreach(BLMUsers U in  UsersList)
            {
                if(U.UserName == Name && U.Password == Pass)
                {
                    return true;
                }
            }
            return false;
        }
        public BLMUsers GetUsers(string name)
        {
            foreach (BLMUsers U in UsersList)
            {
                if(U.UserName.Equals(name))
                {
                    return U as BLMUsers;
                }
            }
            return null;
        }
    }
}
