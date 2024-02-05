using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public class EmailSender  // Single Responsibility Principle 
    {
        public void SendEmail(string email)
        {
            //using (var client = new SmtpClient())
            //{
            //    client.Connect("smtp.friends.com", 587, false);

            //    // Note: only needed if the SMTP server requires authentication
            //    client.Authenticate("joey", "password");

            //    client.Send(message);
            //    client.Disconnect(true);
            //}
        }
        public void SendHtmlEmail(string email)
        {

        }
        public void SendscheduledEmail(string email, DateTime date) 
        {

        }
        public void NewMemberWelcomeEmail(string email)
        {

        }
    }
}
