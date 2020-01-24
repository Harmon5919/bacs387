using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //displays menu options on new lines
            string menu = ("Main Menu:" + "\n" + "1. About the developer" + "\n" + "2. Quit" + "\n" + "Please type the number for the option you would like to view");
            int option1 = 1;
            int option2 = 2;
            int selection = 0;

            while (selection != option2)
            {
                Console.WriteLine(menu);  //displays menu on command line
                selection = int.Parse(Console.ReadLine()); //requests input of 1 or 2
                if (selection == option1) //if user selects option 1
                {
                    Console.WriteLine("Hello! My name is Hanna." + "\n" + "Press any key to return to the menu");
                    Console.ReadKey();
                }
                else //if user types anything that is not 1 or 2
                {
                    Console.WriteLine("Invalid selection. Please enter a 1 or 2");
                }
            }
            Console.WriteLine("Thank you. Goodbye."); //if user selects option 2 the program quits
            Console.ReadKey();
        }
    }
}
