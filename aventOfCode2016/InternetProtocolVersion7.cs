using aventOfCode2016.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016
{
    public class InternetProtocolVersion7
    {

        public int getCountOfValidStrings(string[] s)
        {
            int ans = 0;

            IP7Address address;

            foreach (string possibleIp7 in s)
            {
                address = new IP7Address(possibleIp7);
                if (address.isIP7())
                {
                    ans++;
                }
            }

            return ans; 
        }

    }
}
