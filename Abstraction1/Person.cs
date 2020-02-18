using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction1
{
    class Person
    {
        public Person(string name, int age, string position)
        {
            this.Name = name;
            this.Age = age;
            this.Position = position;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
    }
}
