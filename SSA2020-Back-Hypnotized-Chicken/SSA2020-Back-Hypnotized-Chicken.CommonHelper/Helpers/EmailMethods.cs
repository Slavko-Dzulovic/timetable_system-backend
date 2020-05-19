using System;
using System.Text;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;

namespace SSA2020_Back_Hypnotized_Chicken.CommonHelper.Helpers
{
    public static class EmailMethods
    {
        public static bool SendEmail(string username, string firstName, string lastName, string password)
        {
            var stringBuilder = new StringBuilder();
            var messageText = stringBuilder.Append(
                    "Hello, you received this email because you became an admin on the Timtable system. Your login information:")
                .Append(Environment.NewLine)
                .Append($"Username: {username}")
                .Append(Environment.NewLine)
                .Append($"Password: {password}").ToString();
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Timetable system", "timetable.ftn.cacak@gmail.com"));
                message.To.Add(new MailboxAddress(string.Join(" ", firstName, lastName), username));
                message.Subject = "Admin credentials";
                message.Body = new TextPart("plain")
                {
                    Text = messageText
                };
                
                using (var client = new SmtpClient())
                {

                    client.Connect("smtp.gmail.com", 587, false);

                    //SMTP server authentication if needed
                    client.Authenticate("timetable.ftn.cacak@gmail.com", "FTNCacak2016");

                    client.Send(message);

                    client.Disconnect(true);
                }
                    
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}