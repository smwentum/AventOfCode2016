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
    public class explosivesInCyberspaceTests
    {
        [TestMethod()]
        public void getDecrptyedStringCountTest1()
        {
            explosivesInCyberspace test = new explosivesInCyberspace();

            int ans = test.getDecrptyedStringCount("ADVENT");

            Assert.AreEqual(6, ans);
        }

        [TestMethod()]
        public void getDecrptyedStringCountTest2()
        {
            explosivesInCyberspace test = new explosivesInCyberspace();

            int ans = test.getDecrptyedStringCount("A(1x5)BC");

            Assert.AreEqual(7, ans);
        }

        [TestMethod()]
        public void getDecrptyedStringCountTest2a()
        {
            explosivesInCyberspace test = new explosivesInCyberspace();

            int ans = test.getDecrptyedStringCount("A(1x5)BC ");

            Assert.AreEqual(7, ans);
        }

        [TestMethod()]
        public void getDecrptyedStringCountTest3()
        {
            explosivesInCyberspace test = new explosivesInCyberspace();

            int ans = test.getDecrptyedStringCount("(3x3)XYZ");

            Assert.AreEqual(9, ans);
        }

        [TestMethod()]
        public void getDecrptyedStringCountTest4()
        {
            explosivesInCyberspace test = new explosivesInCyberspace();

            int ans = test.getDecrptyedStringCount("A(2x2)BCD(2x2)EFG");

            Assert.AreEqual(11, ans);
        }

        [TestMethod()]
        public void getDecrptyedStringCountTest5()
        {
            explosivesInCyberspace test = new explosivesInCyberspace();

            int ans = test.getDecrptyedStringCount("(6x1)(1x3)A");

            Assert.AreEqual(6, ans);
        }

        [TestMethod()]
        public void getDecrptyedStringCountTest6()
        {
            explosivesInCyberspace test = new explosivesInCyberspace();

            int ans = test.getDecrptyedStringCount("X(8x2)(3x3)ABCY ");

            Assert.AreEqual(18, ans);
        }
    }
}