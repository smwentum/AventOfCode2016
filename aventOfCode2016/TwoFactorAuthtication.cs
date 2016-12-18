using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016
{
    public class TwoFactorAuthtication
    {
        public char[,] doTheTesslisation(string[] s, int row, int col)
        {
            char[,] screen = createBlankScreen(row, col);
            string[] bitsOfCommand;
            string[] rectSplit;
            string[] colSplit;
            string[] rowSplit;
            foreach (string command in s)
            {
                bitsOfCommand = command.Split();
                if (bitsOfCommand[0].Equals("rect"))
                {
                    rectSplit = bitsOfCommand[1].Split('x');
                    screen = rect(screen, int.Parse(rectSplit[0]), int.Parse(rectSplit[1]));
                }
                else if (bitsOfCommand[1].Equals("column"))
                {
                    colSplit = bitsOfCommand[2].Split('=');
                    screen = rotateColumn(screen, int.Parse(colSplit[1]), int.Parse(bitsOfCommand[4]));
                }
                else if (bitsOfCommand[1].Equals("row"))
                {
                    colSplit = bitsOfCommand[2].Split('=');
                    screen = rotateRow(screen, int.Parse(colSplit[1]), int.Parse(bitsOfCommand[4]));
                }
                else
                {
                    throw new Exception();
                }
            }

            return screen;
        }

        public int coutPixles(char[,] screen)
        {
            int ans = 0;

            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    if (screen[i, j] == '#')
                    {
                        ans++;
                    }
                }
            }


            return ans;
        }

        public string printScreen(char[,] screen)
        {
            string s = "\n\n\n";
            for (int k = 0; k < 10; k++)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        s += screen[i, j+k*5] + "    ";


                    }
                    s += "\n";
                }

                s += "\n\n";
            }

            s += "\n\n\n\n";

            return s;

        }

        public char[,] rect(char[,] screen, int col, int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    screen[i, j] = '#';
                }
            }
            return screen;
        }

        public char[,] createBlankScreen(int row, int col)
        {
            char[,] screen = new char[row, col];
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    screen[i, j] = '.';
                }
            }

            return screen;
        }

        public char[,] rotateColumn(char[,] screen, int col, int pixles)
        {

            //my idea just copy the column do the transform then past it back in

            string s = "";
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                s += screen[i, col];
            }
            pixles = pixles % screen.GetLength(1);
            for (int i = 0; i < pixles; i++)
            {
                s = s.Substring(s.Length - 1) + s.Substring(0, s.Length - 1);
            }

            for (int i = 0; i < screen.GetLength(0); i++)
            {
                screen[i, col] = s[i];
            }

            return screen;
        }


        public char[,] rotateRow(char[,] screen, int row, int pixles)
        {

            //my idea just copy the column do the transform then past it back in

            string s = "";
            for (int i = 0; i < screen.GetLength(1); i++)
            {
                s += screen[row, i];
            }
            pixles = pixles % screen.GetLength(1);
            for (int i = 0; i < pixles; i++)
            {
                s = s.Substring(s.Length - 1) + s.Substring(0, s.Length - 1);
            }

            for (int i = 0; i < screen.GetLength(1); i++)
            {
                screen[row, i] = s[i];
            }

            return screen;
        }
    }
}
