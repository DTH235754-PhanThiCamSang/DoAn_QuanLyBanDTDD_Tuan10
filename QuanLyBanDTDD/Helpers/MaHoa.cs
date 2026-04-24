using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.Helpers
{
   
        public static class MaHoa
        {
            // Hàm này biến "123" thành "202cb962ac59075b964b07152d234b70"
            public static string ToMD5(string str)
            {
                if (string.IsNullOrEmpty(str)) return "";

                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = Encoding.ASCII.GetBytes(str);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    // Chuyển byte thành chuỗi Hex
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                    }
                    return sb.ToString();
                }
            }
        }
    }

