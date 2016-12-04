using Microsoft.VisualStudio.TestTools.UnitTesting;
using aventOfCode2016.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016.Entitites.Tests
{
    [TestClass()]
    public class roomNameTests
    {
        [TestMethod()]
        public void roomNameTest()
        {
            roomName test = new roomName("aaaaa-bbb-z-y-x-123[abxyz]");

            Assert.AreEqual(123, test.sectorId);
            Assert.AreEqual("abxyz", test.checkSum);
            Assert.AreEqual("aaaaabbbzyx", test.eName);
        }

        //from the test description
        [TestMethod()]
        public void roomNameTest1()
        {
            roomName test = new roomName("aaaaa-bbb-z-y-x-123[abxyz]");

            Assert.IsTrue(test.isValidRoom());
        }

        //from the test description
        //a invaild room
        [TestMethod()]
        public void roomNameTest2()
        {
            roomName test = new roomName("totally-real-room-200[decoy]");

            Assert.IsFalse(test.isValidRoom());
        }

        [TestMethod()]
        public void shiftOnceTest()
        {
            roomName test = new roomName("totally-real-room-200[decoy]");

            string s = test.shiftOnce("abc");

            Assert.AreEqual(s, "bcd");
        }

        [TestMethod()]
        public void shiftOnceTestz()
        {
            roomName test = new roomName("totally-real-room-200[decoy]");

            string s = test.shiftOnce("abcz");

            Assert.AreEqual(s, "bcda");
        }

        [TestMethod()]
        public void decodeTest()
        {
            roomName test = new roomName("qzmt-zixmtkozy-ivhz-343]");

            string s = test.decode();

            Assert.AreEqual(s, "very encrypted name");
        }
    }
}