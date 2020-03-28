using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    class Player: Person
    {
        public Player(string position, int id, Location xy) :base(id, xy)
        {
            this.Position = position;
        }
        public string Position { get; set; }
    }

}
