using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetandNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any word");
            string input = Console.ReadLine().ToLower();
            List<char> let = new List<char>();
            foreach (char n in input)
            {
                let.Add(n);
            }
            
            int length = input.Length;
            int fib = 0;
            int add = 0;

            for (int z = 0; z < length; z++)
            {
                char match = let.ElementAt(z);
                if (match == 'a')
                {
                    fib = 0;
                }
                else if (match == 'b')
                {
                    fib = 1;
                }
                else if (match == 'c')
                {
                    fib = 1;
                }
                else if (match == 'd')
                {

                    fib = 2;
                }
                else if (match == 'e')
                {
                    fib = 3;
                }
                else if (match == 'f')
                {
                    fib = 5;
                }
                else if (match == 'g')
                {
                    fib = 8;
                }
                else if (match == 'h')
                {
                    fib = 13;
                }
                else if (match == 'i')
                {
                    fib = 21;
                }
                else if (match == 'j')
                {
                    fib = 34;
                }
                else if (match == 'k')
                {
                    fib = 55;
                }
                else if (match == 'l')
                {
                    fib = 89;
                }
                else if (match == 'm')
                {
                    fib = 144;
                }
                else if (match == 'n')
                {
                    fib = 233;
                }
                else if (match == 'o')
                {
                    fib = 377;
                }
                else if (match == 'p')
                {
                    fib = 610;
                }
                else if (match == 'q')
                {
                    fib = 987;
                }
                else if (match == 'r')
                {
                    fib = 1597;
                }
                else if (match == 's')
                {
                    fib = 2584;
                }
                else if (match == 't')
                {
                    fib = 4181;
                }
                else if (match == 'u')
                {
                    fib = 6765;
                }
                else if (match == 'v')
                {
                    fib = 10946;
                }
                else if (match == 'w')
                {
                    fib = 17711;
                }
                else if (match == 'x')
                {
                    fib = 28657;
                }
                else if (match == 'y')
                {
                    fib = 46368;
                }
                else if (match == 'z')
                {
                    fib = 75025;
                }
                add += fib;
            }
            Console.WriteLine("The fibonacci value of the word " + input + " is " + add);
            Console.ReadKey();
        }
    }
}
