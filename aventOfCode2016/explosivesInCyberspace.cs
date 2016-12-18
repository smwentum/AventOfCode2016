using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016
{
    public class explosivesInCyberspace
    {
        public int getDecrptyedStringCount(string s)
        {
            int ans = 0;
            int jump = 0;
            string marker ="";
            string[] f;
            int a = 0, b = 0;
            for (int i = 0; i<s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    ans++;
                }
                else if (s[i].Equals('('))
                {
                    jump= s.IndexOf(')', i);
                    marker = s.Substring(i, jump - i+1);
                    f = marker.Split(new char[] { 'x', '(', ')' });
                    a = int.Parse(f[1]);
                    b = int.Parse(f[2]);
                    ans += a * b;
                    i += a+marker.Length-1;
                }
            }

            return ans;
        }
    }
}
