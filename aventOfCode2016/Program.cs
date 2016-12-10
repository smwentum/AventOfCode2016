using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a sample project for the 2016 Avent of code challenge that runs from Dec 1st to Dec 25");
            Console.WriteLine("I will try to do as many of these as i can and i will post all of my answers on the 26th");


            //I wonder if there is away to do this so i haven't hard coded in my own path it would just find all the text files relatively

            string path;

            path = @"C:\Users\Sai\Documents\Visual Studio 2015\Projects\aventOfCode2016\aventOfCode2016\realInputForProblem\p1a.txt";
            string readTextP1 = File.ReadAllText(path);
            path = @"C:\Users\Sai\Documents\Visual Studio 2015\Projects\aventOfCode2016\aventOfCode2016\realInputForProblem\p2.txt";
            string[] readTextP2 = File.ReadAllLines(path);
            path = @"C:\Users\Sai\Documents\Visual Studio 2015\Projects\aventOfCode2016\aventOfCode2016\realInputForProblem\p3.txt";
            string[] readTextP3 = File.ReadAllLines(path);
            path = @"C:\Users\Sai\Documents\Visual Studio 2015\Projects\aventOfCode2016\aventOfCode2016\realInputForProblem\p4.txt";
            string[] readTextP4 = File.ReadAllLines(path);
            path = @"C:\Users\Sai\Documents\Visual Studio 2015\Projects\aventOfCode2016\aventOfCode2016\realInputForProblem\p5.txt";
            string readTextP5 = File.ReadAllText(path);
            path = @"C:\Users\Sai\Documents\Visual Studio 2015\Projects\aventOfCode2016\aventOfCode2016\realInputForProblem\p6.txt";
            string[] readTextP6 = File.ReadAllLines(path);

            EasterBunnyHeadquarters q1 = new EasterBunnyHeadquarters();
             BathroomSecurity q2 = new BathroomSecurity();
            SquaresWithThreeSides q3 = new SquaresWithThreeSides();
            SecurityThroughObscurity q4 = new SecurityThroughObscurity();
            HowAboutANiceGameOfChess q5 = new HowAboutANiceGameOfChess();
            SignalsAndNoise q6 = new SignalsAndNoise();
           // q4.decodeAllText();

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Sai\Documents\Visual Studio 2015\Projects\aventOfCode2016\aventOfCode2016\output.txt", true))
            {
                file.WriteLine("Author: Sai Wentum");
                file.WriteLine("Date: {0}",DateTime.Now);
                 file.WriteLine("The answer for problem 1a is: {0} ", q1.getShortestPath(readTextP1));
                file.WriteLine("The answer for problem 1b is: {0} ", q1.howFarAwayAreYouWhenYouRepeatYouOldPoint(readTextP1));
                file.WriteLine("The answer for problem 2a is: {0}", q2.getCode(readTextP2));
                file.WriteLine("The answer for problem 2b is: {0}", q2.getCodeHarder(readTextP2));
                file.WriteLine("The answer for problem 3a is: {0}", q3.getNumberOfValidSquares(readTextP3));
                file.WriteLine("The answer for problem 3b is: {0}", q3.getNumberOfValidSquaresHarder(readTextP3));
                file.WriteLine("The answer for problem 4a is: {0}", q4.getSumOfVaildRoomsSectorIds(readTextP4));
                file.WriteLine("The answer for problem 4b is: 548" ); //look in the proper file for the word north that is the only one that comes up and they tell me it is correct
                //file.WriteLine("The answer for problem 5a is: {0}",q5.getCode(readTextP5));
                //file.WriteLine("The answer for problem 5b is: {0}", q5.getCodeHarder(readTextP5));
                file.WriteLine("The answer for problem 6a a is: {0}", q6.getWordCount(readTextP6));


                file.WriteLine("\n\n");
            }

        }


    }
}
