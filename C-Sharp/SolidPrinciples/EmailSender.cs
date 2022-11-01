using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class EmailSender
    {
        public void SendEmail(string email)
        { 
            /*
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.friends.com", 587, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("joey", "password");

                client.Send(message);
                client.Disconnect(true);
            }
            */
        }
        public void SendHtmlEmail(string email)
        {

        }
        public void SendScheduleEmail(string email, DateTime date)
        {

        }
        public void NewMemberWelcomeEmail(string email)
        {

        }
    }
}
