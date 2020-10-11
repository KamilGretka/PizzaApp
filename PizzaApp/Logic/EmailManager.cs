using PizzaApp.Cryptography;
using PizzaApp.Models;
using System;
using System.Net;
using System.Net.Mail;

namespace PizzaApp.Logic
{
    internal class EmailManager
    {
        internal EmailSendStatus SendEmail(string userEmail, string emailSubject, string emailBody)
        {
            EmailSendStatus emailSendStatus = new EmailSendStatus();
            try
            {
                string decryptedEmail = CryptographyHelper.DecryptSentence(Properties.Settings.Default.Email);
                using (MailMessage msg = new MailMessage())
                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(decryptedEmail, CryptographyHelper.DecryptSentence(Properties.Settings.Default.EmailPassword)),
                    Timeout = 100000,
                    EnableSsl = true
                })
                {
                    msg.To.Add(userEmail);
                    msg.From = new MailAddress(decryptedEmail);
                    msg.IsBodyHtml = true;
                    msg.Subject = emailSubject;
                    msg.Body = emailBody;
                    client.Send(msg);
                }
                emailSendStatus.SendSuccessfully = true;
            }

            catch (Exception ex)
            {
                emailSendStatus.SendSuccessfully = false;
                emailSendStatus.SendEmailException = ex;
            }

            return emailSendStatus;
        }
    }
}