using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016
{
    public class BathroomSecurity
    {
        public string getCode(string[] lines)
        {
            int key = 5; // given by the problem statement
            int newKey;
            string ans = "";
            foreach (string s in lines)
            {
                newKey = getDigit(s, key);
                ans += newKey.ToString();
                key = newKey;
            }
            return ans;
        }
        public int getDigit(string code, int startKey)
        {
            //I think i going to just use a matrix 

            int[,] keypad = new int[3,3];
            point startingPosition = new point();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    keypad[i, j-1] = i * 3 + j;
                    if (i * 3 + j == startKey)
                    {
                        startingPosition = new point() {
                            x = i,
                            y = j-1
                        };
                    }
                }
            }

            foreach (char c in code.ToCharArray())
            {
                switch (c)
                {
                    case 'U':
                        if (startingPosition.x > 0)
                        {
                            startingPosition.x--;
                        }
                        break;
                    case 'D':
                        if (startingPosition.x < 2)
                        {
                            startingPosition.x++;
                        }
                        break;
                    case 'L':
                        if (startingPosition.y > 0)
                        {
                            startingPosition.y--;
                        }
                        break;
                    case 'R':
                        if (startingPosition.y < 2)
                        {
                            startingPosition.y++;
                        }
                        break;
                }


                
            }

            //now i will get the starting position
            return keypad[startingPosition.x, startingPosition.y];

        }
    }
}
