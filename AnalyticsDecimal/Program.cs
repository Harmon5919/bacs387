using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticsDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> calc = new List<decimal>();
            calc.Add(13); //1
            calc.Add(22); //2
            calc.Add(73); //3
            calc.Add(98); //4
            calc.Add(1); //5
            calc.Add(34); //5
            calc.Add(55); //6
            calc.Add(47); //7
            calc.Add(66); //8
            calc.Add(81); //9
            calc.Add(111); //10

            Console.WriteLine("The current list is ");
            for (int n = 0; n < calc.Count; n++)
            {
                Console.WriteLine(calc[n]);
            }
            decimal average = 0;

            for (int i = 0; i < calc.Count; i++)
            {
                average += calc[i];
            }
            average = average / calc.Count;

            Console.WriteLine("The list of numbers is: ");
            Console.WriteLine("The average of this list of numbers is " + average);
            Console.WriteLine("The smallest number in this list is " + calc.Min());
            Console.WriteLine("The largest number in this list is " + calc.Max());
            Console.ReadKey();


        }
    }
}
