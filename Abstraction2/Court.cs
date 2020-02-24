using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    class Court
    {
        public Court(Location referee, Location ball)
        {
            this.Referee = referee;
            this.Ball = referee;
        }
        public Location Referee { get; set; }
        public Location Ball { get; set; }
    }
}
