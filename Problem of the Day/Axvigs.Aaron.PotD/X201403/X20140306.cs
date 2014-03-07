using System;
using System.Text;

[assembly: CLSCompliant(true)]
namespace Axvigs.Aaron.PotD.X201403
{
    public class X20140306
    {
        private string key;
        private static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public X20140306(string key)
        {
            this.key = key;
        }

        public string Decrypt(string encryptedMessage)
        {
            if (encryptedMessage == null)
            {
                throw new ArgumentNullException("encryptedMessage");
            }

            StringBuilder decryptedMessage = new StringBuilder();

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                int messageValue = chars.IndexOf(encryptedMessage[i]);
                int keyValue = chars.IndexOf(key[i % key.Length]);
                int index = (messageValue - keyValue) % 26;

                if (index < 0) { index += 26; }

                decryptedMessage.Append(chars[index]);
            }
            return decryptedMessage.ToString();
        }

        public string Encrypt(string messageToEncrypt)
        {
            if (messageToEncrypt == null)
            {
                throw new ArgumentNullException("messageToEncrypt");
            }

            StringBuilder encryptedMessage = new StringBuilder();

            for (int i = 0; i < messageToEncrypt.Length; i++)
            {
                int messageValue = chars.IndexOf(messageToEncrypt[i]);
                int keyValue = chars.IndexOf(key[i % key.Length]);
                int index = (messageValue + keyValue) % 26;

                encryptedMessage.Append(chars[index]);
            }

            return encryptedMessage.ToString();
        }
    }
}