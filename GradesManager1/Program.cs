using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesManager1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select from the options below" + "\n" + "Main Menu:" + "\n" + "1. Enter Student Info" + "\n" + "2. Display grade average" + "\n" + "3. Quit");
            bool quit = false;
            string select = Console.ReadLine();
            while (quit == false)
            {
                if (select == "1")
                {
                    StudentMenu();
                }
            }
            Console.WriteLine("Thank you. Goodbye.");
            Console.ReadKey();
        }
        static void StudentMenu()
        {
            List<string> Students = new List<string>();
            List<decimal> Grades = new List<decimal>();

            /*for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine(Students.ElementAt(i));
            }*/
            Console.WriteLine("Please type the name of a student.");
            string name = Console.ReadLine();
            bool quit = false;
            while (quit == false)
            {
                Console.WriteLine("You are viewing the file for " + name + "\n" + "1. Enter a new grade" + "\n" + "2. Quit");
                string selection = Console.ReadLine();
                if (selection == "2")
                {
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Please enter a new grade");
                    decimal grade = decimal.Parse(Console.ReadLine());
                    Grades.Add(grade);
                }
            }
            else
            {
                Students.Add(name);
            }
            }
        }
        public static void GradeMenu()
        {
           
        }
    }
}
