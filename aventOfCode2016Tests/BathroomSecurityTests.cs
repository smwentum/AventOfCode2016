﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using aventOfCode2016;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016.Tests
{
    [TestClass()]
    public class BathroomSecurityTests
    {

        //this is from the test description 
        [TestMethod()]
        public void getDigitTest()
        {
            BathroomSecurity test = new BathroomSecurity();

            int key = test.getDigit("ULL", 5);
            Assert.AreEqual(key, 1);
        }

        //this is from the test description 
        [TestMethod()]
        public void getDigitTest1()
        {
            BathroomSecurity test = new BathroomSecurity();

            int key = test.getDigit("RRDDD", 1);
            Assert.AreEqual(key, 9);
        }

        //this is from the test description 
        [TestMethod()]
        public void getDigitTest2()
        {
            BathroomSecurity test = new BathroomSecurity();

            int key = test.getDigit("LURDL", 9);
            Assert.AreEqual(key, 8);
        }
        //this is from the test description 
        [TestMethod()]
        public void getDigitTest3()
        {
            BathroomSecurity test = new BathroomSecurity();

            int key = test.getDigit("UUUUD", 8);
            Assert.AreEqual(key, 5);
        }

        //this is from the test description 
         [TestMethod()]
        public void getKeyTest()
        {
            BathroomSecurity test = new BathroomSecurity();
            char key = test.getKey("ULL", '5');
            Assert.AreEqual(key, '5');
        }


        //this is from the test description 
        [TestMethod()]
        public void getKeyTest1()
        {
            BathroomSecurity test = new BathroomSecurity();
            char key = test.getKey("RRDDD", '5');
            Assert.AreEqual(key, 'D');
        }

        //this is from the test description 
        [TestMethod()]
        public void getKeyTest2()
        {
            BathroomSecurity test = new BathroomSecurity();
            char key = test.getKey("LURDL", 'D');
            Assert.AreEqual(key, 'B');
        }

        //this is from the test description 
        [TestMethod()]
        public void getKeyTest3()
        {
            BathroomSecurity test = new BathroomSecurity();
            char key = test.getKey("UUUUD", 'D');
            Assert.AreEqual(key, '3');
        }
    }
}