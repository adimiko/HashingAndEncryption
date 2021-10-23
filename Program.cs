using System;
using System.Security.Cryptography;
using NETCore.Encrypt.Extensions;

namespace HashingAndEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Hashing ====");

            var plainPassword = "SuperPassword!@#";
            var salt = Hasher.GenerateSalt();
            var hashedPassword = Hasher.Hashing(plainPassword, salt);

            Console.WriteLine($"Plain password: {plainPassword}");
            Console.WriteLine($"Salt: {salt}");
            Console.WriteLine($"Hash: {hashedPassword}");

            Console.WriteLine();
            
            Console.WriteLine("==== Encryption ====");

            var plainPassword2 = "SuperPassword!@#2";
            var key = Encrypter.GenerateKey();
            var encryptedPassword = Encrypter.Encrypt(plainPassword2, key);
            var decryptedPassword = Encrypter.Decrypt(encryptedPassword,key);

            Console.WriteLine($"Plain password: {plainPassword2}");
            Console.WriteLine($"Key: {key.ToString()}");
            Console.WriteLine($"Encrypted password: {encryptedPassword}");
            Console.WriteLine($"Decrypted password: {decryptedPassword}");
        }
    }
}