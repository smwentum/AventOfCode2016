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
    public class EasterBunnyHeadquartersPartOneTests
    {
        [TestMethod()]
        public void getShortestPathTest()
        {
            //arrange
            EasterBunnyHeadquartersPartOne directions = new EasterBunnyHeadquartersPartOne();
            int ans = directions.getShortestPath("");
            Assert.AreEqual(0, ans);
        }

        [TestMethod()]
        public void getShortestPathTest1()
        {
            EasterBunnyHeadquartersPartOne directions = new EasterBunnyHeadquartersPartOne();
            int ans = directions.getShortestPath("R1");
            Assert.AreEqual(1, ans);
        }

        [TestMethod()]
        public void getShortestPathTest2()
        {
            EasterBunnyHeadquartersPartOne directions = new EasterBunnyHeadquartersPartOne();
            int ans = directions.getShortestPath("L2");
            Assert.AreEqual(2, ans);
        }

        //sample from problem
        [TestMethod()]
        public void getShortestPathTestSample1()
        {
            EasterBunnyHeadquartersPartOne directions = new EasterBunnyHeadquartersPartOne();
            int ans = directions.getShortestPath("R2, L3");
            Assert.AreEqual(5, ans);
        }

        //other sample from problem 
        [TestMethod()]
        public void getShortestPathTestSample2()
        {
            EasterBunnyHeadquartersPartOne directions = new EasterBunnyHeadquartersPartOne();
            int ans = directions.getShortestPath("R2, R2, R2");
            Assert.AreEqual(2, ans);
        }

        //other sample from problem 
        [TestMethod()]
        public void getShortestPathTestSample3()
        {
            EasterBunnyHeadquartersPartOne directions = new EasterBunnyHeadquartersPartOne();
            int ans = directions.getShortestPath("R5, L5, R5, R3");
            Assert.AreEqual(12, ans);
        }

    }
}