using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tạo_Bảng_Biểu
{
    class Hash
    {
        public static string HashPass(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sub = new StringBuilder(hash.Length * 2);

                foreach(byte b in hash)
                {
                    sub.Append(b.ToString("X2"));
                }

                return sub.ToString();
            }
        }
    }
}
