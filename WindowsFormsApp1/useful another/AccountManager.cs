using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace MysecondFormsApp1.project
{
    public static class AccountManager
    {
        private static readonly string _email = "best.tiger.faik.456@gmail.com";
        private static readonly string _password = "59242598";
        private static SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
        private static readonly string _mailSubject = "Codeconfirmation for Faik";

        public static string confirmationCode 
        {
            get
            {
                return new Random().Next(1000, 9999).ToString();

            }
        }

        static AccountManager()
        {
            smtpClient.Credentials = new NetWorkCredential(_email, _password);
            smtpClient.EnableSsl = true;

        }
        public static void SendMail(string receiver)
        {
            string message = CreateMessage();
            smtpClient.Sent(_email,receiver, _mailSubject,message);
        }

        private static string CreateMessage()
        {
           
            return $"your confrmcode is {confirmationCode}";
        }
        private static string CreateConfirmationCode()
        {
             return new Random().Next(1000,9999).ToString();

        }


    }
}
