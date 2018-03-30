using System;
using System.Security.Cryptography;
using System.Text;

namespace RoboticsTool.Common
{
    /// <summary>
    /// [*_*] This class helps to generate secret hash from passwords to store it in database. This used at authentication and user registration part of every application.
    /// </summary>
    public class HashHelper
    {
        /// <summary>
        /// [*_*] Create random salt for pasword hash
        /// </summary>
        /// <returns>string: salt value for current password</returns>
        public static string CreateRandomSalt()
        {
            Byte[] saltBytes = new Byte[4];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(saltBytes);

            return Convert.ToBase64String(saltBytes);
        }

        /// <summary>
        /// [*_*] Compute salted password hash
        /// </summary>
        /// <param name="password">string: user entered password</param>
        /// <param name="salt">string: generated salt</param>
        /// <returns>string: salted password hash</returns>
        public static string ComputeSaltedHash(string password, string salt)
        {
            // Create Byte array of password string
            UnicodeEncoding encoder = new UnicodeEncoding();
            Byte[] secretBytes = encoder.GetBytes(password);

            // Create a new salt
            Byte[] saltBytes = Convert.FromBase64String(salt);

            // append the two arrays
            Byte[] toHash = new Byte[secretBytes.Length + saltBytes.Length];
            Array.Copy(secretBytes, 0, toHash, 0, secretBytes.Length);
            Array.Copy(saltBytes, 0, toHash, secretBytes.Length, saltBytes.Length);

            SHA512 sha512 = SHA512.Create();
            Byte[] computedHash = sha512.ComputeHash(toHash);

            return Convert.ToBase64String(computedHash);
        }
    }
}