using System;
using System.Security.Cryptography;
using System.Text;

namespace PizzaApp.Cryptography
{
    internal class Crypto
    {
        internal string Encrypt(string plainText)
        {
            if (plainText == null) throw new ArgumentNullException("plainText");

            var data = Encoding.Unicode.GetBytes(plainText);
            byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);

            return Convert.ToBase64String(encrypted);
        }

        internal string Decrypt(string cipher)
        {
            if (cipher == null) throw new ArgumentNullException("cipher");

            byte[] data = Convert.FromBase64String(cipher);

            byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            return Encoding.Unicode.GetString(decrypted);
        }
    }
}