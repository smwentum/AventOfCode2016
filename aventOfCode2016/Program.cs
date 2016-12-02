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

            string path = @"C:\Users\Sai\Documents\Visual Studio 2015\Projects\aventOfCode2016\aventOfCode2016\p1a.txt";

            string readText = File.ReadAllText(path);
            //Console.WriteLine(readText);

            EasterBunnyHeadquartersPartOne q1a = new EasterBunnyHeadquartersPartOne();

          //  Console.WriteLine(q1a.getShortestPath("R2, L3"));
            Console.WriteLine(q1a.getShortestPath(readText));
        }


    }
}
