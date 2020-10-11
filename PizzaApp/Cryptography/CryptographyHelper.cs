using System;
using System.Security.Cryptography;
using System.Text;

namespace PizzaApp.Cryptography
{
    internal static class CryptographyHelper
    {
        internal static string DecryptSentence(string sentence)
        {
            byte[] data = Convert.FromBase64String(sentence);

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(Properties.Settings.Default.Hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}