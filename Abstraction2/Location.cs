using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    class Location
    {
        public Location(int xlocation, int ylocation)
        {
            this.Xlocation = xlocation;
            this.Ylocation = ylocation;
        }
        public int Xlocation { get; set; }
        public int Ylocation { get; set; }
    }
}
