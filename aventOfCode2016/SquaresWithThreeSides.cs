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

        public int getNumberOfValidSquaresHarder(string[] list)
        {
            int count = 0;
            for (int i = 0; i < list.Length; i += 3)
            {
                count += triangles( list.Skip(i).Take(3).ToArray());
            }
            return count;
        }

        public int getNumberOfValidSquare(string list)
        {
            int count = 0;
            int[] lengths = new int[3];
            triangle tri;
            string[] o;
            o = list.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            lengths = Array.ConvertAll(o, s => int.Parse(s));
            tri = new triangle(lengths);
            if (tri.isValidTriangle())
            {
                count++;
            }

            return count;
        }

        //I am going to try something new instead of just reading in the whole array at once  
        //i am going to IEnumerable and yield to get it to return three at a time and 

        public int triangles(string[] list)
        {
            int ans = 0;
            string s1="";

            int[,] triangles = new int[3, 3];
            int[] triangle = new int[3];
            for (int k = 0; k < 3; k++)
            {
                triangle = Array.ConvertAll(list[ k].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
                for (int j = 0; j < 3; j++)
                {
                    triangles[j, k] = triangle[j];
                }
            }

            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    s1 += triangles[k, j] + " ";
                }
              ans+= getNumberOfValidSquare(s1);
               s1 = "";
            }

            return ans;
        }




    }




}
