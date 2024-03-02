using FaceBookClone.BL;
using FaceBookClone.DL;
using FaceBookClone.UL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookClone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DLMUsers User = new DLMUsers();
            BLTwitter TwitterUser = new BLTwitter();
            BLFacebook Face = new BLFacebook();

            int op = 0;
            do
            {
                op = ConsoleUtiltity.Menu();
                if(op == 1)
                {
                    ULMUsers.CallingUsersOperation(User);
                }
                if(op == 2)
                {
                    ULTwitter.CallTwitterMenu(TwitterUser);
                }
                if(op == 3)
                {
                    ULFaceBook.CallFBMenu(Face);
                }
            }
            while(op != 4);
        }
    }
}
