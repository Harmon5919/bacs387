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
            bool response = true;

            while (quit == false)
            {
                Console.WriteLine("Main Menu:" + "\n" + "1. Enter Student Info" + "\n" + "2. Enter Grades" + "\n" + "3. Remove Students" + "\n" + "4. Grade Analytics" + "\n" + "5. Quit");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    response = true;
                    while (response == true)
                    {
                        Console.WriteLine("Please enter a student ID");
                        string ID = Console.ReadLine();
                        bool match = false;
                        for (int i = 0; i < StudID.Count; i++)
                        {
                            if (ID == StudID.ElementAt(i))
                            {
                                match = true;
                                Console.WriteLine("This student ID already exists.");
                            }
                        }
                        if (match == false)
                        {
                            StudID.Add(ID);
                            Console.WriteLine("Please enter the student's first name");
                            string fname = Console.ReadLine();
                            First.Add(fname);
                            Console.WriteLine("Please enter the student's last name");
                            string lname = Console.ReadLine();
                            Last.Add(lname);
                            Console.WriteLine("Would you like to enter another student's information?");
                            string choose = Console.ReadLine();
                            Min.Add(101);
                            Max.Add(101);
                            average.Add(101);
                            PerA.Add(101);
                            PerB.Add(101);
                            PerC.Add(101);
                            PerD.Add(101);
                            PerF.Add(101);

                            if (choose.ToLower() == "yes")
                            {
                                response = true;
                            }
                            else
                            {
                                response = false;
                            }
                        }
                    }
                }
                else if (input == "2")
                {
                    if (StudID.Count == 0)
                    {
                        Console.WriteLine("There are no students in the system.");
                    }
                    else
                    {
                        Console.WriteLine("The current student list is:" + "\n" + "ID:" + "\t" + "Firstname: " + " Lastname:");
                        for (int i = 0; i < StudID.Count; i++)
                        {
                            Console.WriteLine(StudID.ElementAt(i) + "\t" + First.ElementAt(i) + "\t" + "   " + Last.ElementAt(i));
                        }
                        Console.WriteLine("Please type the ID of the student that you wish to enter grades for");
                        string select = Console.ReadLine();
                        bool idfound = false;
                        int count = 0;
                        decimal avg = 0;
                        decimal minval = 100;
                        decimal maxval = 0;
                        decimal Acount = 0;
                        decimal Bcount = 0;
                        decimal Ccount = 0;
                        decimal Dcount = 0;
                        decimal Fcount = 0;


                        for (int j = 0; j < StudID.Count; j++)
                        {
                            if (select == StudID.ElementAt(j))
                            {
                                bool rerun = true;
                                while (rerun == true)
                                {
                                    idfound = true;
                                    Console.WriteLine("Please enter a grade 0-100");
                                    decimal grade = decimal.Parse(Console.ReadLine());
                                    if (grade <= 100 && grade >= 0)
                                    {
                                        if (grade < minval)
                                        {
                                            minval = grade;
                                        }
                                        if (grade > maxval)
                                        {
                                            maxval = grade;
                                        }
                                        if (grade >= 90)
                                        {
                                            Acount++;
                                        }
                                        else if (grade >= 80 && grade < 90)
                                        {
                                            Bcount++;
                                        }
                                        else if (grade >= 70 && grade < 80)
                                        {
                                            Ccount++;
                                        }
                                        else if (grade >= 60 && grade < 70)
                                        {
                                            Dcount++;
                                        }
                                        else
                                        {
                                            Fcount++;
                                        }
                                        avg += grade;
                                        count++;
                                        Console.WriteLine("Would you like to enter another grade?");
                                        string graderesponse = Console.ReadLine();
                                        if (graderesponse.ToLower() != "yes")
                                        {
                                            rerun = false;
                                            avg = avg / count;
                                            average.Insert(j, avg);
                                            Min.Insert(j, minval);
                                            Max.Insert(j, maxval);
                                            Acount = Acount / count;
                                            Bcount = Bcount / count;
                                            Ccount = Ccount / count;
                                            Dcount = Dcount / count;
                                            Fcount = Fcount / count;

                                            PerA.Insert(j, Acount);
                                            PerB.Insert(j, Bcount);
                                            PerC.Insert(j, Ccount);
                                            PerD.Insert(j, Dcount);
                                            PerF.Insert(j, Fcount);
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid grade. Please try again.");
                                    }
                                }
                            }
                        }
                        if (idfound == false)
                        {
                            Console.WriteLine("Student not found.");
                        }
                    }
                }
                else if (input == "3")
                {
                    bool again = true;
                    while (again == true)
                    {
                        if (StudID.Count == 0)
                        {
                            Console.WriteLine("There are no students in the system.");
                            again = false;
                        }
                        else
                        {
                            Console.WriteLine("The current list of students is:" + "\n" + "ID:      First:      Last:");
                            for (int i = 0; i < StudID.Count; i++)
                            {
                                Console.WriteLine(StudID.ElementAt(i) + First.ElementAt(i) + Last.ElementAt(i));
                            }
                            Console.WriteLine("Would you like to remove a student from the system?");
                            string askremove = Console.ReadLine();
                            if (askremove.ToLower() == "yes")
                            {
                                Console.WriteLine("Please type the ID of the student you wish to remove from the system");
                                string remove = Console.ReadLine();
                                bool check = false;

                                while (check == false)
                                {

                                    for (int i = 0; i < StudID.Count; i++)
                                    {
                                        if (remove == StudID.ElementAt(i))
                                        {
                                            StudID.RemoveAt(i); First.RemoveAt(i); Last.RemoveAt(i);
                                            check = true;
                                            Console.WriteLine("Student Removed.");
                                        }
                                    }
                                    if (check == false)
                                    {
                                        Console.WriteLine("Student not found. Please try again");
                                    }
                                }
                            }
                            else
                            {
                                again = false;
                            }
                        }
                    }
                }
                else if (input == "4")
                {
                    if (StudID.Count == 0)
                    {
                        Console.WriteLine("There are no students in the system");
                    }
                    else
                    {
                        Console.WriteLine("The current list of students is:");
                        for (int n = 0; n < StudID.Count; n++)
                        {
                            Console.WriteLine(StudID.ElementAt(n) + "\t" + First.ElementAt(n) + "\t" + Last.ElementAt(n));
                        }
                        Console.WriteLine("Please type the student ID for which you would like to analyze grades");
                        string analyze = Console.ReadLine();
                        bool idmatch = false;
                        for (int j = 0; j < StudID.Count; j++)
                        {
                            if (analyze == StudID.ElementAt(j))
                            {
                                idmatch = true;
                                if (average.ElementAt(j) == 101)
                                {
                                    Console.WriteLine("No grades have been added for this student.");
                                }
                                else
                                {
                                    Console.WriteLine(First.ElementAt(j) + "'s grade analysis:");
                                    Console.WriteLine("Average: " + average.ElementAt(j) + "\n" + "Min: " + Min.ElementAt(j) + "\n" + "Max: " + Max.ElementAt(j) +
                                        "\n" + "Percent A's: " + PerA.ElementAt(j) + "\n" + "Percent B's: " + PerB.ElementAt(j) + "\n" + "Percent C's: " + PerC.ElementAt(j)
                                        + "\n" + "Percent D's: " + PerD.ElementAt(j) + "\n" + "Percent F's: " + PerF.ElementAt(j));
                                }
                            }
                            if (idmatch == false)
                            {
                                Console.WriteLine("Student not found. Please try again.");
                            }
                        }
                    }
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
