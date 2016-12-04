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
    public class SecurityThroughObscurityTests
    {
        [TestMethod()]
        public void getSumOfVaildRoomsSectorIdsTest()
        {
            SecurityThroughObscurity test = new SecurityThroughObscurity();

            int sum = test.getSumOfVaildRoomsSectorIds(new string[] { "aaaaa-bbb-z-y-x-123[abxyz]" });

            Assert.AreEqual(123, sum);
        }

        [TestMethod()]
        public void getSumOfVaildRoomsSectorIdsTest1()
        {
            SecurityThroughObscurity test = new SecurityThroughObscurity();

            int sum = test.getSumOfVaildRoomsSectorIds(new string[] { "a-b-c-d-e-f-g-h-987[abcde] " });

            Assert.AreEqual(987, sum);
        }

        [TestMethod()]
        public void getSumOfVaildRoomsSectorIdsTest2()
        {
            SecurityThroughObscurity test = new SecurityThroughObscurity();

            int sum = test.getSumOfVaildRoomsSectorIds(new string[] { "not-a-real-room-404[oarel]" });

            Assert.AreEqual(404, sum);
        }

        [TestMethod()]
        public void getSumOfVaildRoomsSectorIdsTest3()
        {
            SecurityThroughObscurity test = new SecurityThroughObscurity();

            int sum = test.getSumOfVaildRoomsSectorIds(new string[] { "totally-real-room-200[decoy]" }); //not a valid room

            Assert.AreEqual(0, sum);
        }

        //this the hardest one because it is a mix of valid and invalid rooms
        [TestMethod()]
        public void getSumOfVaildRoomsSectorIdsTest4()
        {
            SecurityThroughObscurity test = new SecurityThroughObscurity();

            int sum = test.getSumOfVaildRoomsSectorIds(new string[] { "aaaaa-bbb-z-y-x-123[abxyz]",
                                                                                                        "a-b-c-d-e-f-g-h-987[abcde]",
                                                                                                        "not-a-real-room-404[oarel]",
                                                                                                      "totally-real-room-200[decoy]" }); 

            Assert.AreEqual(1514, sum);
        }
    }

}