﻿namespace PizzaApp.OutputMessages
{
    public static class UserMessages
    {
        public const string HugeOrder = "Please contact us by phone in case of huge orders.";

        public const string NoOrder = "Before you confirm order, please select something.";

        public const string EmailSended = "Email has been sended! Thanks you for using your application.";

        public const string EmailFailedToSend = "Oops! Something went wrong. Your order will not be processed, please try again later.";

        public const string InvalidFirstName = "First name is empty or contains not allowed characters.";

        public const string InvalidLastName = "Last name is empty or contains not allowed characters.";

        public const string InvalidAddressFormat = "Address must contains street with house number.";

        public const string InvalidEmailFormat = "Email address has invalid format.";

        public const string DatabaseConnectionProblem = "This function is temporarily inaccessible, please try again later.";

        public const string DatabaseRecordNotAdded = "While processing your order a small problem occurs, please try again later.";
    }
}