using System.Security.Cryptography;
using System.Text;

namespace Data.Utils
{
    internal class Cryptography
    {
        public static string Cryptograph(string originalPassword)
        {
            MD5 md5 = MD5.Create();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(originalPassword);
            byte[] hash = md5.ComputeHash(passwordBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
