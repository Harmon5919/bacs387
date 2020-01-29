using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManager2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> StudID = new List<string>();
            List<string> First = new List<string>();
            List<string> Last = new List<string>();
            List<decimal> Min = new List<decimal>();
            List<decimal> Max = new List<decimal>();
            List<decimal> average = new List<decimal>();
            List<decimal> PerA = new List<decimal>();
            List<decimal> PerB = new List<decimal>();
            List<decimal> PerC = new List<decimal>();
            List<decimal> PerD = new List<decimal>();
            List<decimal> PerF = new List<decimal>();

            bool quit = false;
            bool response = false;

            while (quit == false)
            {
                while (response == true)
                {
                Console.WriteLine("Main Menu:" + "\n" + "1. Enter Student Info" + "\n" + "2. Enter Grades" + "\n" + "3. Remove Students" + "\n" + "4. Grade Analytics" + "\n" + "5. Quit");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Please enter a student ID");
                    string ID = Console.ReadLine();
                    bool match = false;
                    while (match == true)
                    {
                        for (int i = 0; i < StudID.Count; i++)
                        {
                            if (ID == StudID.ElementAt(i))
                            {
                                match = true;
                                Console.WriteLine("This student ID already exists, please enter a new student ID");
                            }
                        }
                        if (match == false)
                        {
                            StudID.Add(ID);
                        }
                    }
                    Console.WriteLine("Please enter the student's first name");
                    string fname = Console.ReadLine();
                    First.Add(fname);
                    Console.WriteLine("Please enter the student's last name");
                    string lname = Console.ReadLine();
                    Last.Add(lname);
                    Console.WriteLine("Would you like to enter another student's information?");
                    string choose = Console.ReadLine();
                    if (choose.ToLower() == "yes")
                    {
                        response = true;
                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine("The current student list is:" + "\n" + "ID:      Firstname:      Lastname:");
                    for (int i = 0; i < StudID.Count; i++)
                    {
                            Console.WriteLine(StudID.ElementAt(i) + First.ElementAt(i) + Last.ElementAt(i));
                    }
                    Console.WriteLine("Please type the ID of the student that you wish to enter grades for");
                    string select = Console.ReadLine();
                    bool idfound = false;
                    while (idfound == false)
                    {
                        for (int j = 0; j < StudID.Count; j++)
                        {
                            if (select == StudID.ElementAt(j))
                            {
                                idfound = true;
                            }
                        }
                        if (idfound == false)
                        {
                            Console.WriteLine("Student not found. Please try again");
                        }
                    }
                    Console.WriteLine("Please enter a grade");
                    int grade = int.Parse(Console.ReadLine());

                }
                else if (input == "3")
                {

                }
                else if (input == "4")
                {

                }
                else if (input == "5")
                {
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number 1-5");
                }
            }
            Console.WriteLine("Thank you. Goodbye.");
            Console.ReadKey();
        }
    }
}
