using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _387Week1Wed
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 13;
            Console.WriteLine("I'm thinking of a number between 1 and 100. Guess my number. You have 5 tries");
            int count = 5;
            while (count > 0)
            {
                int guess = int.Parse(Console.ReadLine());
                if (guess > 100)
                {
                    Console.WriteLine("Please enter a number between 1 and 100");
                }
                else
                {
                    if (guess == answer)
                    {
                        Console.WriteLine("Congratulations! You guessed right! The number was " + answer);
                        break;
                    }
                    else
                    {
                        if (guess > answer)
                        {
                            count--;
                            if (count > 0)
                            {
                                Console.WriteLine("Incorrect. Your number was too high. Please try again. You have " + count + " tries left");
                            }
                            else
                            {
                                Console.WriteLine("Out of tries. The answer was " + answer);
                            }
                        }
                        if (guess < answer)
                        {
                            count--;
                            if (count > 0)
                            {
                                Console.WriteLine("Incorrect. Your number was too low. Please try again. You have " + count + " tries left");
                            }
                            else
                            {
                                Console.WriteLine("Out of tries. The answer was " + answer);
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
