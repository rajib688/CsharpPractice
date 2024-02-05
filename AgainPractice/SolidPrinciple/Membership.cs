using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public class Membership  // Single Responsibility Principle 
    {
        public void CreateMember(string username, string password, string email)
        {

            // code here insert 



            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(email);

        }

        //EmailSender code akhn theke soliye fela hoice 

    }
}
