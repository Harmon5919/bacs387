using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    class Basket
    {
        public Basket(Location location1, Location location2, Location location3, Location location4, Location location5, Location location6)
        {
            this.Location1 = location1;
            this.Location2 = location2;
            this.Location3 = location3;
            this.Location4 = location4;
            this.Location5 = location5;
            this.Location6 = location6;

        }
        public Location Location1 { get; set; }
        public Location Location2 { get; set; }
        public Location Location3 { get; set; }
        public Location Location4 { get; set; }
        public Location Location5 { get; set; }
        public Location Location6 {get; set; }
    }
}
