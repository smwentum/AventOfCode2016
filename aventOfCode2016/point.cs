using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016
{
    class point:IEquatable<point>
    {
        public int x { get; set; }
        public int y { get; set; }

        bool IEquatable<point>.Equals(point other)
        {
                if (this.x == other.x && this.y == other.y)
               {
                 return true;
               }
            return false;
        }

        //public int CompareTo(point p1)
        //{
        //    if (this.x == p1.x && this.y == p2.y)
        //    {
        //        return 0;
        //    }

        //}
    }

  
}
