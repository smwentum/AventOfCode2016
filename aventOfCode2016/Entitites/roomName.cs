using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016.Entitites
{
    public class roomName
    {
        public int sectorId { get; set; }
        public string eName { get; set; }
        public string checkSum { get; set; }
        public string fullEname { get; set; }


        public roomName(string encrpytedCodeName)
        {
            string[] splitString = encrpytedCodeName.Split(new char[] { '-' });
            string sectorString = "";
            for (int i = 0; i < splitString.Length - 1; i++)
            {
                eName += splitString[i];
                fullEname += splitString[i] + '-';
            }
           fullEname= fullEname.Substring(0, fullEname.Length - 1);
            foreach (char c in splitString.Last())
            {
                if (char.IsDigit(c))
                {
                    sectorString += c;
                }
                else if (char.IsLetter(c))
                {
                    checkSum += c;
                }


            }

            sectorId = int.Parse(sectorString);

        }


        public bool isValidRoom()
        {
            //given the room name what i want to do is get a checksum and then compare it to the the checksum i have 
            List<letterCounts> counts = new List<letterCounts>();

            for (int i = 0; i < 26; i++)
            {
                counts.Add(new letterCounts((char)(i+(int)'a'), eName.Count(s=> s== (char)(i + (int)'a'))));
            }

            counts.Sort();
            string genCheckSum = "";
            for (int i = 0; i < 5; i++)
            {
                genCheckSum += counts[i].letter;
            }
            if (genCheckSum == checkSum)
            {
                return true;
            }
            return false;
        }

           public string decode()
           {
            string ans = fullEname;
            for (int i = 0; i < sectorId % 26; i++)
            {
                ans = shiftOnce(ans);
            }
            return ans;
           }

        public string shiftOnce(string s)
        {
            string ans = "";
            foreach (char c in s)
            {
                if (c != 'z' && char.IsLetter(c))
                {
                    ans += (char)((int)c + 1);
                }
                else if(c == 'z')
                {
                    ans += 'a';
                }
                else
                {
                    ans += ' ';
                }

            }
            return ans;
        }



    }


    //going to do  nested class.
    // i am going to do this because i dont want this class used outside of this class 

    public class letterCounts : IComparable<letterCounts>
    {
        public char letter { get; set; }
        public int count { get; set; }

        public letterCounts(char c, int count)
        {
            letter = c;
            this.count = count;
        }

        int IComparable<letterCounts>.CompareTo(letterCounts other)
        {
            if (this.count < other.count)
            {
                return 1;
            }
            else if (this.count > other.count)
            {
                return -1;
            }
            if (this.letter > other.letter)
            {
                return 1;
            }
            else if (this.letter < other.letter)
            {
                return -1;
            }
            return 0;
        }

        
    }
}
