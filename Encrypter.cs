using NETCore.Encrypt;
using NETCore.Encrypt.Internal;

namespace HashingAndEncryption
{
    //Algorithm AES
    public class Encrypter
    {
        public static string GenerateKey()
            => EncryptProvider.CreateAesKey().Key;
        
        public static string Encrypt(string data, string key)
            => EncryptProvider.AESEncrypt(data, key);

        public static string Decrypt(string data, string key)
            => EncryptProvider.AESDecrypt(data, key);
    }
}