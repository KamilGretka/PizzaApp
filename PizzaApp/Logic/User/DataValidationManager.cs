using Microsoft.EntityFrameworkCore.Internal;
using PizzaApp.OutputMessages;
using System;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace PizzaApp.Logic.User
{
    public class DataValidationManager
    {
        public (bool, string) CheckEmail(string email)
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

        public (bool, string) CheckString(string sentence)
        {
            if (!float.TryParse(sentence, out float _) && Regex.IsMatch(sentence, @"^[a-zA-Z]+$")) 
                return (true, string.Empty);
            else
                return (false, UserMessages.InvalidUserDataFormatInput);
        }

        public (bool, string) CheckAdress(string adress)
        {
            if (adress.Any(char.IsDigit) && adress.Any(char.IsLetter))
                return (true, string.Empty);
            else
                return (false, UserMessages.InvalidUserDataFormatInput);
        }
    }
}
