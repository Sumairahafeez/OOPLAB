using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookClone.BL
{
    internal class BLTwitter
    {
        List<BLMUsers> TwitterUsers;
        List<string> Tweets;
        public  BLTwitter()
        {
            TwitterUsers = new List<BLMUsers>();
            Tweets = new List<string>();
        }
        public void AddUser(BLMUsers user)
        {
            TwitterUsers.Add(user);
        }
        public BLMUsers GetUserByUserName(string userName)
        {
            foreach (BLMUsers user in TwitterUsers)
            {
                if(user.UserName == userName) return user;
            }
            return null;
        }
       public void AddTweet(string T)
        {
            Tweets.Add(T);
        }
        public bool CheckMessage(string message)
        {
            foreach (string M in Tweets)
            {
                if (M == message) return true;
            }
            return false;
        }
    }
}
