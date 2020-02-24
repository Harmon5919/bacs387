using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    class Ball
    {
        public Ball(Location locateBall)
        {
            this.LocateBall = locateBall;
        }
        public Location LocateBall { get; set; }
    }
}
