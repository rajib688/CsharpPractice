using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class MemberShip
    {
        public void CreateMember(string username, string email, string password)
        {
            /*
            Member member = new Member();
            member.Name = "Morium";
            member.Gpa = 4.50;
            member.DateOfBirth = new DateTime(1999, 2, 3);
            member.StudentID = Guid.NewGuid();
            member.IsActive = false;
            trainingDbContext.Members.Add(member);

            TrainingDbContext.SaveChanges();
            */

            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(email);
        }
    }
}
