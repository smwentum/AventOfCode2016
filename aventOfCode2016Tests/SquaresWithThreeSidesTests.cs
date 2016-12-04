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
    public class SquaresWithThreeSidesTests
    {
        [TestMethod()]
        public void getNumberOfValidSquaresTest()
        {
            SquaresWithThreeSides test = new SquaresWithThreeSides();

            int count = test.getNumberOfValidSquares(new string[] { "5 10 25" });

            Assert.AreEqual(count, 0);
        }

        [TestMethod()]
        public void getNumberOfValidSquaresTest1()
        {
            SquaresWithThreeSides test = new SquaresWithThreeSides();

            int count = test.getNumberOfValidSquares(new string[] { "3 4 5" });

            Assert.AreEqual(count, 1);
        }

        [TestMethod()]
        public void getNumberOfValidSquaresHarderTest()
        {
            SquaresWithThreeSides test = new SquaresWithThreeSides();

            int count = test.getNumberOfValidSquaresHarder(new string[] {  "101 301 501" ,
                                                                                                 " 102 302 502",
                                                                                                " 103 303 503",
                                                                                                 "201 401 601",
                                                                                                  "202 402 602",
                                                                                                    "203 403 603"  });

            Assert.AreEqual( 6,count);
        }
    }
}