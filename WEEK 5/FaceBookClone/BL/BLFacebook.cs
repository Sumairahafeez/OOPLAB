using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookClone.BL
{
    internal class BLFacebook
    {
        List<BLMUsers> FaceBookList;
        List<string> posts;
        public BLFacebook()
        {
            FaceBookList = new List<BLMUsers>();
        }
        public BLMUsers GetUserByUserName(string userName)
        {
            foreach (BLMUsers user in FaceBookList)
            {
                if (user.UserName == userName) return user;
            }
            return null;
        }
        public void AddUser(BLMUsers user)
        {
            FaceBookList.Add(user);
        }
        public void AddPost(string p)
        {
            posts = new List<string>();
            posts.Add(p);

        }
        public bool   CheckMessage(string message)
        {
            foreach(string M in posts)
            {
                if (M == message) return true;
            }
            return false;
        }
    }
}
