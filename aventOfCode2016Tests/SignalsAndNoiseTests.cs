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
    public class SignalsAndNoiseTests
    {
        [TestMethod()]
        public void getWordCountTest()
        {
            SignalsAndNoise test = new SignalsAndNoise();

            string[] words = new string[] {

                "eedadn",
                "drvtee",
                "eandsr",
                "raavrd",
                "atevrs",
                "tsrnev",
                "sdttsa",
                "rasrtv",
                "nssdts",
                "ntnada",
                "svetve",
                "tesnvt",
                "vntsnd",
                "vrdear",
                "dvrsen",
                "enarar",

            };
            string mostPopWord = test.getWordCount(words);

            Assert.AreEqual("easter", mostPopWord);
        }

        [TestMethod()]
        public void getWordCountHarderTest()
        {
            SignalsAndNoise test = new SignalsAndNoise();

            string[] words = new string[] {

                "eedadn",
                "drvtee",
                "eandsr",
                "raavrd",
                "atevrs",
                "tsrnev",
                "sdttsa",
                "rasrtv",
                "nssdts",
                "ntnada",
                "svetve",
                "tesnvt",
                "vntsnd",
                "vrdear",
                "dvrsen",
                "enarar",

            };
            string mostPopWord = test.getWordCountHarder(words);

            Assert.AreEqual("advent", mostPopWord);
        }
    }
}