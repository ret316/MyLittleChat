using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleChat.Service.Implementation
{
    public class MD5Hash
    {

        public Guid GetGuid(string password)
        {
            string salt = "omaewamoushindeiru";
            Guid passwordGuid = Guid.Parse(GetHash(GetHash(password) + salt));
            return passwordGuid;
        }


        public string GetHash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
