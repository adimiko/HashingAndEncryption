using System;
using System.Security.Cryptography;
using NETCore.Encrypt.Extensions;

namespace HashingAndEncryption
{
    //Algorithm HMAC-SHA256
    public static class Hasher
    {
        public static string GenerateSalt()
        {
            int SaltSize = 40;
            var saltBytes = new byte[SaltSize];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(saltBytes);

            return Convert.ToBase64String(saltBytes);
        }

        public static string Hashing(string value, string salt)
            => value.HMACSHA256(salt);
    }
}