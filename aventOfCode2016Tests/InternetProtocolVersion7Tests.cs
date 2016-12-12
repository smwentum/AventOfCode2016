using Microsoft.VisualStudio.TestTools.UnitTesting;
using aventOfCode2016;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016.Tests
{
    [TestClass()]
    public class InternetProtocolVersion7Tests
    {
        [TestMethod()]
        public void getCountOfValidStringsTest()
        {
    
           string[] s = new string[] {
                "abba[mnop]qrst",
                "abcd[bddb]xyyx",
                "aaaa[qwer]tyui",
                "ioxxoj[asdfgh]zxcvbn"
           };

            InternetProtocolVersion7 test = new InternetProtocolVersion7();
            int count = test.getCountOfValidStrings(s);

            Assert.AreEqual(2, count);

        }
    }
}