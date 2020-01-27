using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesManager1
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool quit = false; //if false, program keeps cycling, if true, program ends
            List<string> Students = new List<string>(); //string list to store names of students
            List<decimal> Grades = new List<decimal>(); //decimal list to store grades of students
            decimal average = 0;

            while (quit == false) //keeps iterating until user selects option 3
            {
                Console.WriteLine("Please select from the options below" + "\n" + "Main Menu:" + "\n" + "1. Enter Student Info" + "\n" + "2. Display grade average" + "\n" + "3. Quit");
                string select = Console.ReadLine(); //variable to store user input for menu options 1, 2, or 3
                if (select == "1") //if the user selects "1. Enter Student Info"
                {
                    Console.WriteLine("Please type the name of a student.");
                    string name = Console.ReadLine(); //user types a name to add it to the Students list
                    Students.Add(name); //^
                    bool selection = true;
                    Console.WriteLine(name + " has been added to the list. Please enter a grade.");
                    decimal grade = decimal.Parse(Console.ReadLine());
                    int count = 0;
                    average += grade;
                    count++;
                    while (selection == true)
                    {
 
                        Console.WriteLine("Would you like to add another grade?");
                        string response = Console.ReadLine();
                        if (response.ToLower() == "yes")
                        {
                            Console.WriteLine("Please enter the next grade.");
                            grade = decimal.Parse(Console.ReadLine());
                            average += grade;
                            count++;
                        }
                        else
                        {
                            selection = false;
                        }
                    }
                    average = average / count;
                    Grades.Add(average);
                }
                else if (select =="2") //if user selects option 2. Display Grade Average
                {
                    if (Students.Count == 0)
                    {
                        Console.WriteLine("There are no students in this list.");
                    }
                    else
                    {
                        //displays contents of Students list
                        Console.WriteLine("The current students are:");
                        for (int i = 0; i < Students.Count; i++)
                        {
                            Console.WriteLine(Students.ElementAt(i));
                        }
                        Console.WriteLine("Please type the name of a student above to calculate their average grade.");
                        string match = Console.ReadLine(); //user types name of any student displayed above
                        for (int i = 0; i < Students.Count; i++)
                        {
                            if (match == Students.ElementAt(i))
                            {
                                Console.WriteLine(Students.ElementAt(i) + "'s average grade is " + Grades.ElementAt(i));
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine(match + "was not found. Please enter a name from the list above"); //if typed name does not match name in list
                            }
                        }
                    }
                }
                else if (select == "3")
                {
                    quit = true;
                }
            }
            Console.WriteLine("Thank you. Goodbye.");
            Console.ReadKey();
        }
    }
}
