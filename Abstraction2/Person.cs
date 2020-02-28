using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    class Person
    {
        public Person(int id, Location xy)
        {
            this.ID = id;
            this.XY = xy;
        }
        public int ID { get; set; }
        public Location XY { get; set; }
    }
}
