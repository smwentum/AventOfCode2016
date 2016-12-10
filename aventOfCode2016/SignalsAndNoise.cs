using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016
{
    public class SignalsAndNoise
    {
        public string getWordCount(string[] s)
        {
            char[] word = new char[s[0].Length];

            int[,] letterCounts = new int[26,s[0].Length];

            for (int i = 0; i < letterCounts.GetLength(0); i++)
            {
                for (int j = 0; j < letterCounts.GetLength(1); j++)
                {
                    letterCounts[i,j] = 0;
                }
            }
            foreach (string t in s)
            {
                for (int i = 0; i < t.Length; i++)
                {
                    letterCounts[t[i]-'a'  , i]++;
                }
            }

            int max;
            for (int i = 0; i < letterCounts.GetLength(1); i++)
            {
                max =  int.MinValue;
                for (int j = 0; j < letterCounts.GetLength(0); j++)
                {
                    if (max < letterCounts[j,i])
                    {
                        max = letterCounts[j,i];
                        word[i] = (char)('a' + j);
                    }                        
                }
            }

            return new string(word);
        }
    }
}
