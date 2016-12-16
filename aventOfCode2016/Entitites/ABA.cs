using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aventOfCode2016.Entitites
{
    public class ABA
    {
        public string aba { get; set; }
        public ABA(string s)
        {
            aba =s;
        }

        public override bool Equals(object obj)
        {
            ABA other = (ABA)obj;
            return this.aba.Equals(other.aba);
        }

        public override int GetHashCode()
        {
            return aba.GetHashCode();
        }

    }
}
