using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    class Person
    {
        public Person(Location xy)
        {
            this.XY = xy;
        }
        public Location XY { get; set; }
    }
}
