using aventOfCode2016.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016
{
    public class SquaresWithThreeSides
    {
        public int getNumberOfValidSquares(string[] list)
        {
            int count = 0;
            int[] lengths = new int[3];
            triangle tri;
            string[] o;
            foreach (string triangle in list)
            {
                o = triangle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                lengths = Array.ConvertAll(o, s => int.Parse(s));
                tri = new triangle(lengths);
                if (tri.isValidTriangle())
                {
                    count++;
                }
            }
            return count;
        }
    }
}
