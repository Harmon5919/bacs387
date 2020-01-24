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
 
            List<string> let = new List<string>();
            let.Add("A"); let.Add("B"); let.Add("C"); let.Add("D"); let.Add("E"); let.Add("F"); let.Add("G"); let.Add("H"); let.Add("I"); let.Add("J"); let.Add("K");
            let.Add("L"); let.Add("M");,  let.Add("N");, "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"

            List<int> num = new List<int>();
            num.Add(0); num.Add(1); num.Add(1); num.Add(2); num.Add(3); num.Add(5); num.Add(8); num.Add(13); num.Add(21); num.Add(34); num.Add(55); num.Add(89);
            num.Add(144); num.Add(233); num.Add(377); num.Add(610); num.Add(987); num.Add(1597); num.Add(2584); num.Add(4181); num.Add(6765); num.Add(10946);
            num.Add(17711); num.Add(28657); num.Add(46368); num.Add(75025); num.Add(121393);
                    {
                        0, 
            Console.WriteLine("Please enter any word");
            string match = Console.ReadLine();
            int length = match.Length;
            int added = 0;
            int cross = 0;
            int next = 0;
 
            for (int z = 0; z < length; z++)
            {
                for (int x = 0; x < let.Count(); x++)
                {
                    if (match.ToUpper() == let.ElementAt<string>(x))
                    {
                        cross = num.ElementAt<int>(x);
                    }
                }
                added += cross;
            }
            Console.WriteLine("The fibonacci value of the word " + match + " is " + added);
            Console.ReadKey();
        }
    }
}
