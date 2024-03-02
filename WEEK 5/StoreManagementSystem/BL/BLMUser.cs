using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem.BL
{
    internal class BLMUser
    {
        public string UserName;
        public string Password;
        public string Role;
        
        public BLMUser(string UserName, string Password, string Role)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Role = Role;

        }

    }
    
}
