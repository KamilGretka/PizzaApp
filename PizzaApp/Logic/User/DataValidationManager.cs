using Microsoft.EntityFrameworkCore.Internal;
using PizzaApp.OutputMessages;
using System;
using System.Linq;
using System.Net.Mail;

namespace PizzaApp.Logic.User
{
    public static class DataValidationManager
    {
        public static (bool, string) CheckEmail(string email)
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

        public static (bool, string) CheckFirstName(string firstName)
        {
            var result = CheckString(firstName);
            return result == true ? (result, string.Empty) : (false, UserMessages.InvalidFirstName);
        }

        public static (bool, string) CheckLastName(string lastName)
        {
            var result = CheckString(lastName);
            return CheckString(lastName) == true ? (result, string.Empty) : (false, UserMessages.InvalidLastName);
        }

        public static bool CheckString(string sentence)
        {
             return sentence.All(char.IsLetter) && sentence != string.Empty;
        }

        public static (bool, string) CheckAddress(string address)
        {
            if (address.Any(char.IsDigit) && address.Any(char.IsLetter))
            {
                return (true, string.Empty);
            }
            else
            {
                return (false, UserMessages.InvalidAddressFormat);
            }
        }
    }
}