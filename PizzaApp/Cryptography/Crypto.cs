using System;
using System.Security.Cryptography;
using System.Text;

namespace PizzaApp.Cryptography
{
    internal class Crypto
    {
        internal string DecryptSentence(string sentence)
        {
            byte[] data = Convert.FromBase64String(sentence);

            byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            return Encoding.Unicode.GetString(decrypted);
        }
    }
}