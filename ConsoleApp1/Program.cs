using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            B myObject = new B("Hanna", "Checking");
            Console.WriteLine(myObject.Name + myObject.Account);
            Console.ReadKey();
        }
    }
}
