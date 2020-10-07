using System;

namespace PizzaApp.Models
{
    public class EmailSendStatus
    {
        public bool SendSuccessfully { get; set; }

        public Exception SendEmailException { get; set; }
    }
}