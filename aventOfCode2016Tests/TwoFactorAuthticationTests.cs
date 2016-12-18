using Microsoft.VisualStudio.TestTools.UnitTesting;
using aventOfCode2016;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016.Tests
{
    //all of these test are really brittle i am not sure how to make them better 
    [TestClass()]
    public class TwoFactorAuthticationTests
    {
        [TestMethod()]
        public void rectTest()
        {
            TwoFactorAuthtication test = new TwoFactorAuthtication();

            //initialization code
            char[,] screen = test.createBlankScreen(3, 7);

            screen = test.rect(screen, 3, 2);
            Assert.AreEqual(3, screen.GetLength(0));
            Assert.AreEqual(7, screen.GetLength(1));
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    if (i < 2 && j < 3)
                    {
                        Assert.AreEqual(screen[i, j], '#');
                    }
                    else
                    {
                        Assert.AreEqual(screen[i, j], '.');
                    }
                }
            }
        }




        //this one is kind of dumb i woudln't know how to make it better
        [TestMethod()]
        public void createBlankScreenTest()
        {
            TwoFactorAuthtication test = new TwoFactorAuthtication();

            //intialzation code
            char[,] screen = test.createBlankScreen(3, 7);
            Assert.AreEqual(3, screen.GetLength(0));
            Assert.AreEqual(7, screen.GetLength(1));
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Assert.AreEqual(screen[i, j], '.');
                }
            }
        }

        [TestMethod()]
        public void rotateColumnTest()
        {
            TwoFactorAuthtication test = new TwoFactorAuthtication();

            char[,] screen = test.createBlankScreen(3, 7);

            screen = test.rect(screen, 3, 2);

            screen = test.rotateColumn(screen, 1, 1);

            char[,] ans = new char[,] { { '#', '.', '#', '.', '.', '.', '.' }, { '#', '#', '#', '.', '.', '.', '.' }, { '.', '#', '.', '.', '.', '.', '.' } };

            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Assert.AreEqual(ans[i, j], screen[i, j]);


                }
            }

        }

        [TestMethod()]
        public void rotateRowTest()
        {
            TwoFactorAuthtication test = new TwoFactorAuthtication();

            char[,] screen = test.createBlankScreen(3, 7);

            screen = test.rect(screen, 3, 2);

            screen = test.rotateColumn(screen, 1, 1);
            screen = test.rotateRow(screen, 0, 4);

            char[,] ans = new char[,] { { '.', '.', '.', '.', '#', '.', '#' }, { '#', '#', '#', '.', '.', '.', '.' }, { '.', '#', '.', '.', '.', '.', '.' } };


            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Assert.AreEqual(ans[i, j], screen[i, j]);


                }
            }

        }

        [TestMethod()]
        public void doTheTesslisationTest1()
        {
            //arrange 
            TwoFactorAuthtication test = new TwoFactorAuthtication();

            char[,] screen = test.createBlankScreen(3, 7);

            screen = test.doTheTesslisation(new string[] { "rect 3x2", "rotate column x=1 by 1", "rotate row y=0 by 4" }, 3, 7);


            char[,] ans = new char[,] { { '.', '.', '.', '.', '#', '.', '#' }, { '#', '#', '#', '.', '.', '.', '.' }, { '.', '#', '.', '.', '.', '.', '.' } };

            //assert
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Assert.AreEqual(ans[i, j], screen[i, j]);


                }
            }
        }

        [TestMethod()]
        public void doTheTesslisationTest2()
        {
            //arrange 
            TwoFactorAuthtication test = new TwoFactorAuthtication();

            char[,] screen = test.createBlankScreen(3, 7);

            screen = test.doTheTesslisation(new string[] { "rect 3x2"
                , "rotate column x=1 by 1"
                , "rotate row y=0 by 4"
                , "rotate column x=1 by 1" }, 3, 7);


            char[,] ans = new char[,] { { '.', '#', '.', '.', '#', '.', '#' },
                { '#', '.', '#', '.', '.', '.', '.' },
                { '.', '#', '.', '.', '.', '.', '.' } };

            //assert
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Assert.AreEqual(ans[i, j], screen[i, j]);


                }
            }
        }

        [TestMethod()]
        public void countPixlesTest1()
        {
            TwoFactorAuthtication test = new TwoFactorAuthtication();

            //intialzation code
            char[,] screen = test.createBlankScreen(3, 7);

            int ans =test.coutPixles(screen);

            Assert.AreEqual(0, ans);
        }

        [TestMethod()]
        public void countPixlesTest2()
        {
            TwoFactorAuthtication test = new TwoFactorAuthtication();

            //intialzation code
            char[,] screen = test.createBlankScreen(3, 7);



            screen = test.rect(screen, 3, 2);

            screen = test.rotateColumn(screen, 1, 1);

            int ans = test.coutPixles(screen);

            Assert.AreEqual(6, ans);
        }
    }


}