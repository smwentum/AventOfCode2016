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
    public class IP7AddressTests
    {

        //[TestMethod()]
        //public void ToStringTest()
        //{
        //    IP7Address test = new IP7Address("abba[mnop]qrst");

        //    string outside = test.ToString();

        //    Assert.AreEqual("outside hypernet: abbaqrst hypernet: mnop", outside);
        //}

        //[TestMethod()]
        //public void ToStringTest2()
        //{
        //    IP7Address test = new IP7Address("aaaa[qwer]tyui");

        //    string outside = test.ToString();

        //    Assert.AreEqual("outside hypernet: aaaatyui hypernet: qwer", outside);
        //}

        //[TestMethod()]
        //public void ToStringTest3()
        //{
        //    IP7Address test = new IP7Address("ioxxoj[asdfgh]zxcvbn");

        //    string outside = test.ToString();

        //    Assert.AreEqual("outside hypernet: ioxxojzxcvbn hypernet: asdfgh", outside);
        //}

        [TestMethod()]
        public void hasAutonomousBridgeBypassAnnotationTest()
        {
            IP7Address test = new IP7Address("ioxxoj[asdfgh]zxcvbn");
            Assert.IsTrue(test.hasAutonomousBridgeBypassAnnotation(test.outsideHypernet));
        }
        [TestMethod()]
        public void hasAutonomousBridgeBypassAnnotationTest2()
        {
            IP7Address test = new IP7Address("ioxxoj[asdfgh]zxcvbn");
            Assert.IsFalse(test.hasAutonomousBridgeBypassAnnotation(test.hypernet));
        }
        [TestMethod()]
        public void hasAutonomousBridgeBypassAnnotationTest3()
        {
            IP7Address test = new IP7Address("aaaa[qwer]tyui");
            Assert.IsFalse(test.hasAutonomousBridgeBypassAnnotation(test.outsideHypernet));
        }
        [TestMethod()]
        public void hasAutonomousBridgeBypassAnnotationTest4()
        {
            IP7Address test = new IP7Address("aaaa[qwer]tyui");
            Assert.IsFalse(test.hasAutonomousBridgeBypassAnnotation(test.hypernet));
        }

        [TestMethod()]
        public void hasAutonomousBridgeBypassAnnotationTest5()
        {
            IP7Address test = new IP7Address("abcd[bddb]xyyx");
            Assert.IsTrue(test.hasAutonomousBridgeBypassAnnotation(test.outsideHypernet));
        }
        [TestMethod()]
        public void hasAutonomousBridgeBypassAnnotationTest6()
        {
            IP7Address test = new IP7Address("abcd[bddb]xyyx");
            Assert.IsTrue(test.hasAutonomousBridgeBypassAnnotation(test.hypernet));
        }

        [TestMethod()]
        public void isIP7Test()
        {
            IP7Address test = new IP7Address("abcd[bddb]xyyx");

            Assert.IsFalse(test.isIP7());

        }


        [TestMethod()]
        public void isIP7Test2()
        {
            IP7Address test = new IP7Address("ioxxoj[asdfgh]zxcvbn");

            Assert.IsTrue(test.isIP7());

        }

        [TestMethod()]
        public void isIP7Test3()
        {
            IP7Address test = new IP7Address("abba[mnop]qrst");

            Assert.IsTrue(test.isIP7());

        }

        [TestMethod()]
        public void isIP7Test4()
        {
            IP7Address test = new IP7Address("qekvcpqbkmqjvwrttyn[ltmnlgsnnvnkrhduu] yvvjbjtyjqkmhwblpbq[zjocywooquhkdtk]hlnqhqxibbehvsy");

            Assert.IsFalse(test.isIP7());

        }


        [TestMethod()]
        public void isIP7Test5()
        {
            IP7Address test = new IP7Address("pqkbbpimwqfiqsbu[phfukwjrvhgirbghexi]fxbxanzvshlyfrcipa[ixpkqzmjrfbmgset]jgttnhuxlvprkno[mddqrjjgfqcqjscoepk]wkoddoqrfyfgslnz");

            Assert.IsTrue(test.isIP7());

        }

        [TestMethod()]
        public void isSSLTest()
        {
            IP7Address test = new IP7Address("aba[bab]xyz");

            Assert.IsTrue(test.isSSL());
        }
        [TestMethod()]
        public void isSSLTest1()
        {
            IP7Address test = new IP7Address("xyx[xyx]xyx");

            Assert.IsFalse(test.isSSL());
        }

        [TestMethod()]
        public void isSSLTest3()
        {
            IP7Address test = new IP7Address("aaa[kek]eke");

            Assert.IsTrue(test.isSSL());
        }

        [TestMethod()]
        public void isSSLTest4()
        {
            IP7Address test = new IP7Address("zazbz[bzb]cdb");

            Assert.IsTrue(test.isSSL());
        }
    }
}