using Microsoft.EntityFrameworkCore.Internal;
using PizzaApp.OutputMessages;
using System;
using System.Linq;
using System.Net.Mail;

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

        public (bool, string) CheckFirstName(string firstName)
        {
            var result = CheckString(firstName);
            return result == true ? (result, string.Empty) : (false, UserMessages.InvalidFirstName);
        }

        public (bool, string) CheckLastName(string lastName)
        {
            var result = CheckString(lastName);
            return CheckString(lastName) == true ? (result, string.Empty) : (false, UserMessages.InvalidLastName);
        }

        public bool CheckString(string sentence)
        {
             return sentence.All(char.IsLetter) && sentence != string.Empty;
        }

        public (bool, string) CheckAddress(string address)
        {
            if (address.Any(char.IsDigit) && address.Any(char.IsLetter))
                return (true, string.Empty);
            else
                return (false, UserMessages.InvalidAddressFormat);
        }
    }
}