using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookClone.BL
{
    internal class BLMUsers
    {
        public string UserName;
        public string Password;
        List<string> Messages;
        public BLMUsers(string name , string pass)
        {
            UserName = name;
            Password = pass;
            Messages = new List<string>();
        }
        public string EncryptPassword(string Encryption)
        {
            int count = Encryption.Length;
            while(true)
            {
                
                if(count % 3 != 0)
                {
                    Encryption += "#";
                    count++;
                    
                }
                else
                {
                    break;
                }
            }
           
            int NoOFSeg = count / 3;
            
            string FirstPast = "";
            string EncryptPassword = "";
            int PasswordLength = Password.Length / 2;
           
            for(int i = 0; i<PasswordLength; i++)
            {
               for(int k = 0; k<NoOFSeg; k++)
                {
                    FirstPast += Encryption[k];
                }
                FirstPast = FirstPast + Password[i];  
                for(int x =NoOFSeg; x<2*NoOFSeg; x++)
                {
                    FirstPast += Encryption[x];
                }
                for(int y = i+1; y< Password.Length; y++)
                {
                    FirstPast = FirstPast + Password[y];
                    
                }
                   
                
               
                for(int z = 2*NoOFSeg; z<3*NoOFSeg; z++ )
                {
                    FirstPast += Encryption[z];
                }
            }
            
            return FirstPast;
        }
        public bool CheckPassword(string pass)
        {
            if (pass == Password)
            {
                return true;
            }
            return false;
        }
        public string GetPassword()
        {
            
            string ast = "";
            for(int i = 0; i < Password.Length; i++)
            {
                ast += "*";
            }
            return ast;
        }
        public string ViewMessages()
        {   
            foreach(string M in Messages)
            {
                return M;
               
            }
            return null; 
        }
        public void AddMessages(string message)
        {
            Messages.Add(message);
        }
    }
}
