using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace aventOfCode2016
{
    public class HowAboutANiceGameOfChess
    {
        //this seems simple enough that  will just do the computation in here

        public string getCode(string input)
        {
            // MD5 h;
            string hash;
            string password = "";
            using (MD5 md5Hash = MD5.Create())
            {
                for (int i = 0; i < int.MaxValue && password.Length <8; i++)
                {
                    hash = GetMd5Hash(md5Hash, input + i.ToString());
                    if (hash.StartsWith("00000"))
                    {
                        //Console.WriteLine(hash);
                        password += hash[5];
                    }
               } 
            }

            return password;
        }

        public string getCodeHarder(string input)
        {
            // MD5 h;
            string hash;
            char[] p = new char[] { '*', '*', '*', '*', '*', '*', '*', '*' };
            string password = "";
            int num=9;
            using (MD5 md5Hash = MD5.Create())
            {
                for (int i = 0; i < int.MaxValue && p.Contains('*'); i++)
                {
                    hash = GetMd5Hash(md5Hash, input + i.ToString());
                    if (hash.StartsWith("00000"))
                    {
                        //Console.WriteLine(hash);
                        if (char.IsDigit(hash[5]) && int.TryParse(hash[5].ToString(), out num) && num < 8 && p[num] == '*')
                        {
                            p[num] = (char)hash[6];
                        }
                        
                    }
                }
            }

            return new string(p);
        }

        //from the msdn website
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }


    }
}
