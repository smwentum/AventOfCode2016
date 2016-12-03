using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016
{
    public class EasterBunnyHeadquartersPartOne
    {
        public int getShortestPath(string directions)
        {
            if (string.IsNullOrEmpty(directions))
            {
                return 0;
            }

            int path = 0;
            string t1;
            int[] direction = new int[4];
            for (int i = 0; i < 4; i++)
            {
                direction[i] = i; 
            }
            //since we always start north start that
            int currentDirection = 0;
            int right = 0; //keep track of horizontal direction
            int up = 0; // keep track of vertical direction
            int steps = 0;

            char[] delimiterChars = { ',' };
            var turns =directions.Split(delimiterChars ).Select(p => p.Trim()).ToList(); ;
            foreach (string t in turns)
            {
                //Console.WriteLine(t);
                //t.Trim();
                if (t[0] == 'R')
                {
                    currentDirection = (currentDirection + 1) % 4;
                }
                else if (t[0] == 'L')
                {
                    currentDirection = mod((currentDirection - 1), 4);
                }
                else
                {

                    Console.WriteLine("something is very wrong");
                    return -1;
                }

                t1 = t.Substring(1);
                //Console.WriteLine(t1);
                if (int.TryParse(t1, out steps))
                {
                    //Console.WriteLine(steps);
                    //Console.WriteLine(currentDirection);
                    switch (currentDirection)
                    {
                        case 0:
                            up += steps;
                            break;
                        case 1:
                            right += steps;
                            break;
                        case 2:
                            up -= steps;
                            break;
                        case 3:
                            right -= steps;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Number didn't parse ");
                    return -40;
                }

            }

            path = Math.Abs(up) + Math.Abs(right);
            return path;
        }

        public int howFarAwayAreYouWhenYouRepeatYouOldPoint(string directions)
        {
            if (string.IsNullOrEmpty(directions))
            {
                return 0;
            }

            int path = 0;
            string t1;
            List<point> points = new List<point>();
            points.Add(new point() { x = 0, y = 0 });
            int[] direction = new int[4];
            for (int i = 0; i < 4; i++)
            {
                direction[i] = i;
            }
            //since we always start north start that
            int currentDirection = 0;
            int right = 0; //keep track of horizontal direction
            int up = 0; // keep track of vertical direction
            int steps = 0;

            char[] delimiterChars = { ',' };
            var turns = directions.Split(delimiterChars).Select(p => p.Trim()).ToList(); ;
            foreach (string t in turns)
            {
                //Console.WriteLine(t);
                //t.Trim();
                if (t[0] == 'R')
                {
                    currentDirection = mod((currentDirection + 1), 4);
                }
                else if (t[0] == 'L')
                {
                    currentDirection = mod((currentDirection - 1), 4);
                }
                else
                {

                    Console.WriteLine("something is very wrong");
                    return -1;
                }

                t1 = t.Substring(1);
                //Console.WriteLine(t1);
                point p;
                if (int.TryParse(t1, out steps))
                {
                    //Console.WriteLine(steps);
                    //Console.WriteLine(currentDirection);

                   // point p;

                    switch (currentDirection)
                    {
                        case 0:
                           //up += steps;
                            for (int i = 1; i <= steps; i++)
                            {
                                    p =  new point() { x = right, y = up+i };
                                    if (!points.Contains(p))
                                    {
                                        points.Add(p);
                                    }
                                     else
                                    {
                                    return Math.Abs(p.x) + Math.Abs(p.y);
                                }
                            }
                            up += steps;
                            break;
                        case 1:
                            
                            for (int i = 1; i <= steps; i++)
                            {
                                p = new point() { x = right+i, y = up };
                                if (!points.Contains(p))
                                {
                                    points.Add(p);
                                }
                                else
                                {
                                    return Math.Abs(p.x) + Math.Abs(p.y);
                                }
                            }
                            right += steps;
                            break;
                        case 2:
                              
                            for (int i = 1; i <= steps; i++)
                            {
                                p = new point() { x = right, y = up-i };
                                if (!points.Contains(p))
                                {
                                    points.Add(p);
                                }
                                else
                                {
                                    return Math.Abs(p.x) + Math.Abs(p.y);
                                }
                            }
                            up -= steps;
                            break;
                        case 3:
                            
                            for (int i = 1; i <= steps; i++)
                            {
                                p = new point() { x = right-i, y = up  };
                                if (!points.Contains(p))
                                {
                                    points.Add(p);
                                }
                                else
                                {
                                    return Math.Abs(p.x) + Math.Abs(p.y);
                                }
                            }
                            right -= steps;
                            break;
                    }
                   
                   
                }
                else
                {
                    Console.WriteLine("Number didn't parse ");
                    return -40;
                }

            }

            path = Math.Abs(up) + Math.Abs(right);
            return path;
        }




        //got this from stack overflow but it looks right
        int mod(int x, int m)
        {
            int r = x % m;
            return r < 0 ? r + m : r;
        }
    }
}
