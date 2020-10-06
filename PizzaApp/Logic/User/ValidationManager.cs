using PizzaApp.Output_Messages;
using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace PizzaApp.Logic.User
{
    internal class ValidationManager
    {
        internal (bool, string) CheckEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return (true, string.Empty);
            }
            catch (Exception)
            {
                return (false, UserMessages.InvalidEmailFormat);
            }
        }

        internal (bool, string) CheckString(string sentence)
        {
            if (!float.TryParse(sentence, out float _) && Regex.IsMatch(sentence, @"^[a-zA-Z]+$")) 
                return (true, string.Empty);
            else
                return (false, UserMessages.InvalidUserDataFormatInput);
        }
    }
}
