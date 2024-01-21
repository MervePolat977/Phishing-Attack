using System;
using System.Net.Mail;

namespace SystemEmailApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("pmerve977@gmail.com");
                mail.To.Add("polatmerve515@gmail.com");
                mail.Subject = "Test Message";
                mail.Body = "This is a test message launched from my C# app";

                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("pmerve977@gmail.com", "mardin47");
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}