using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCreditProject
{
    class Name
    {
        public Name(string first, string last)
        {
            this.First = first;
            this.Last = last;
        }
        public string First { get; set; }
        public string Last { get; set; }
    }
}
