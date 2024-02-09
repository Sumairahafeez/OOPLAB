using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SignIn2
{
    internal class MUser
    {   
        public MUser(string name, string pass) 
        {
            username = name;
            password = pass;
        }
        public MUser ()
        {

        }
        public string username;
        public string password;
        public string role;
       
        public bool NameValidity()
        {
            bool flag = false;
            for (int i = 0; i < username.Length; i++)
            {
                if (username[i] == '1' || username[i] == '2' || username[i] == '3' || username[i] == '4' || username[i] == '5' || username[i] == '6' || username[i] == '7' || username[i] == '8' || username[i] == '9' || username[i] == '0')
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public bool PasswordValidity()
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
    }
}
