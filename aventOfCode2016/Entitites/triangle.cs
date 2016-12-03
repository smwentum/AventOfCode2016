using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016.Entitites
{
    public class triangle
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public triangle(int[] lengths)
        {
            a = lengths[0];
            b = lengths[1];
            c = lengths[2];
        }

        public bool isValidTriangle()
        {
            if (this.a >= this.b + this.c)
            {
                return false;
            }
            if (this.b >= this.a + this.c)
            {
                return false;
            }
            if (this.c >= this.b + this.a)
            {
                return false;
            }
            return true;
        }
    }
}
