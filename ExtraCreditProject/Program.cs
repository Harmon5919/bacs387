using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCreditProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int studIDCount = 1;
            List<Student> studentList = new List<Student>();
            Console.WriteLine("Main Menu: " + "\n" + "1. Add/Edit Students"
                + "\n" + "2. Add/Edit Courses" + "\n" + "3. Quit");
            Console.ReadKey();
            string input = Console.ReadLine();
            if (input == "1")
            {
                if (studentList.Count == 0)
                {
                    Console.WriteLine("There are no students in the system.");
                    Console.WriteLine("Add a Student: " + "\n" + "Type the first name of the new student");
                    string first = Console.ReadLine();
                    Console.WriteLine("Type the last name of the new student");
                    string last = Console.ReadLine();
                    List<decimal> studentGrades = new List<decimal>();
                    Console.WriteLine("Please enter a grade for this student");
                    studentGrades.Add(decimal.Parse(Console.ReadLine()));
                    studentList.Add(new Student(new Name(first, last), studIDCount, studentGrades));
                    //again = false;
                }
                else
                {
                    Console.WriteLine("Current list of students:");
                    for (int i = 0; i < studentList.Count; i++)
                    {
                        Console.WriteLine(studentList[i].FullName.First + studentList[i].FullName.Last + studentList[i].StudentID);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Student Menu: " + "\n" + "1. Add new student" + "\n" + "2. Remove existing student"
                        + "\n" + "3. Enter grades for existing student" + "\n" + "4. Return to Main Menu");
                }
                string response = Console.ReadLine();
                if (response == "1")
                {
                    Console.WriteLine("Add a Student: " + "\n" + "Type the first name of the new student");
                    string first = Console.ReadLine();
                    Console.WriteLine("Type the last name of the new student");
                    string last = Console.ReadLine();
                    List<decimal> studentGrades = new List<decimal>();
                    Console.WriteLine("Please enter a grade for this student");
                    studentGrades.Add(decimal.Parse(Console.ReadLine()));
                    studentList.Add(new Student(new Name(first, last), studIDCount, studentGrades));
                }
                else if (response == "2")
                {
                    Console.WriteLine("Would you like to remove a student from the system?");
                    string askremove = Console.ReadLine();
                    if (askremove.ToLower() == "yes")
                    {
                        Console.WriteLine("Please type the ID of the student you wish to remove from the system");
                        string remove = Console.ReadLine();
                        bool check = false;

                        while (check == false)
                        {

                            for (int i = 0; i < studentList.Count; i++)
                            {
                                if (remove == studentList.ElementAt(i).ToString())
                                {
                                    studentList.RemoveAt(i);
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
                }
                else if (response == "3")
                {

                }
                else if (response == "4")
                {

                }
                else
                {
                    Console.WriteLine("Input not recognized. Try again");
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
               
                    }
                }
            }
        }
    }
}
