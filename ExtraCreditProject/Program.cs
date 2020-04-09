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
            bool continueprogram = true;

            while (continueprogram == true)
            {
                int studIDCount = 1;
                int courseIDCount = 1;

                List<Student> studentList = new List<Student>();
                List<Course> courseList = new List<Course>();


                Console.WriteLine("Main Menu: " + "\n" + "1. Add/Edit Students"
                    + "\n" + "2. Add/Edit Courses" + "\n" + "3. Grade Analytics" + "\n" + "4. Quit");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    bool continuestudent = true;
                    while (continuestudent == true)
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
                            Console.WriteLine(first + " " + last + " has been added.");
                            Console.WriteLine("Student Menu: " + "\n" + "1. Add new student" + "\n" + "2. Remove existing student"
                                + "\n" + "3. Enter grades for existing student" + "\n" + "4. Return to Main Menu");
                        }
                        else
                        {
                            Console.WriteLine("Current list of students:");
                            for (int i = 0; i < studentList.Count; i++)
                            {
                                Console.WriteLine(studentList[i].StudentID + " " + studentList[i].FullName.First + " " + studentList[i].FullName.Last);
                            }
                            Console.WriteLine("Student Menu: " + "\n" + "1. Add new student" + "\n" + "2. Remove existing student"
                                + "\n" + "3. Enter grades for existing student" + "\n" + "4. Return to Main Menu");
                        }
                        string studentresponse = Console.ReadLine();
                        if (studentresponse == "1")
                        {
                            Console.WriteLine("Add a Student: " + "\n" + "Type the first name of the new student");
                            string first = Console.ReadLine();
                            Console.WriteLine("Type the last name of the new student");
                            string last = Console.ReadLine();
                            List<decimal> studentGrades = new List<decimal>();
                            Console.WriteLine("Please enter a grade for this student");
                            studentGrades.Add(decimal.Parse(Console.ReadLine()));
                            studentList.Add(new Student(new Name(first, last), studIDCount, studentGrades));
                            studIDCount++;
                        }
                        else if (studentresponse == "2")
                        {
                            Console.WriteLine("Would you like to remove a student from the system?");
                            string askremove = Console.ReadLine();
                            if (askremove.ToLower() == "yes")
                            {
                                Console.WriteLine("Current list of students:");
                                for (int i = 0; i < studentList.Count; i++)
                                {
                                    Console.WriteLine(studentList[i].StudentID + " " + studentList[i].FullName.First + " " + studentList[i].FullName.Last);
                                }
                                Console.WriteLine("Please type the ID of the student you wish to remove from the system");
                                string remove = Console.ReadLine();
                                bool check = false;

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
                        else if (studentresponse == "3")
                        {
                            Console.WriteLine("Current list of students:");
                            for (int i = 0; i < studentList.Count; i++)
                            {
                                Console.WriteLine(studentList[i].StudentID + " " + studentList[i].FullName.First + " " + studentList[i].FullName.Last);
                            }
                            Console.WriteLine("To add/edit grades, please enter the student's ID");
                            int selectstudent = int.Parse(Console.ReadLine());
                            for (int i = 0; i < studentList.Count; i++)
                            {
                                if (selectstudent == studentList[i].StudentID)
                                {
                                    Console.WriteLine(studentList[i].FullName + "'s grades are:");
                                    for (int j = 0; j < studentList[i].Grade.Count; j++)
                                    {
                                        Console.WriteLine(studentList[i].Grade[j]);
                                    }
                                    Console.WriteLine("\n" + "Please enter a grade");
                                    decimal newgrade = decimal.Parse(Console.ReadLine());
                                    studentList[i].Grade.Add(newgrade);
                                }
                            }
                        }
                        else if (studentresponse == "4")
                        {
                            continuestudent = false;
                        }
                        else
                        {
                            Console.WriteLine("Input not recognized. Try again");
                        }
                    }
                }
                else if (input == "2")
                {
                    bool coursecontinue = true;
                    while (coursecontinue == true)
                    {
                        if (courseList.Count == 0)
                        {
                            Console.WriteLine("There are no courses in the system.");
                            Console.WriteLine("Add a Course: " + "\n" + "Type the name of the new course");
                            string course = Console.ReadLine();
                            List<Student> studInClass = new List<Student>();
                            courseList.Add(new Course(course, courseIDCount, studInClass));
                            Console.WriteLine(course + " has been added.");
                            courseIDCount++;
                        }
                        else
                        {
                            Console.WriteLine("Courses Menu: " + "\n" + "1. Add new course" + "\n" + "2. Remove existing course"
                                + "\n" + "3. Enter students in a course" + "\n" + "4. Return to Main Menu");
                            string courseresponse = Console.ReadLine();
                            if (courseresponse == "1")
                            {
                                Console.WriteLine("Enter the name of the course you would like to add.");
                                string course = Console.ReadLine();
                                List<Student> studInClass = new List<Student>();
                                courseList.Add(new Course(course, courseIDCount, studInClass));
                                Console.WriteLine(course + " has been added.");
                                courseIDCount++;
                            }
                            else if (courseresponse == "2")
                            {
                                Console.WriteLine("Would you like to remove a course from the system? (Type Yes/No)");
                                string askremove = Console.ReadLine();
                                if (askremove.ToLower() == "yes")
                                {
                                    Console.WriteLine("Current course list:");
                                    for (int i = 0; i < courseList.Count; i++)
                                    {
                                        Console.WriteLine(courseList[i].CourseID + " " + courseList[i].CourseName);
                                    }
                                    Console.WriteLine("Please type the ID of the course you wish to remove from the system");
                                    string remove = Console.ReadLine();
                                    bool check = false;

                                    for (int i = 0; i < courseList.Count; i++)
                                    {
                                        if (remove == courseList[i].CourseID.ToString())
                                        {
                                            courseList.RemoveAt(i);
                                            check = true;
                                            Console.WriteLine("Course Removed.");
                                        }
                                    }
                                    if (check == false)
                                    {
                                        Console.WriteLine("Course not found.");
                                    }
                                }
                            }
                            else if (courseresponse == "3")
                            {
                                Console.WriteLine("Current course list:");
                                for (int i = 0; i < courseList.Count; i++)
                                {
                                    Console.WriteLine(courseList[i].CourseID + " " + courseList[i].CourseName);
                                }
                                Console.WriteLine("Type the course ID of the course you would like to add students to");
                                int selectcourse = int.Parse(Console.ReadLine());
                                for (int i = 0; i < courseList.Count; i++)
                                {
                                    if (selectcourse == courseList[i].CourseID)
                                    {
                                        Console.WriteLine(courseList[i].CourseName + " has the following students:");
                                        for (int j = 0; j < courseList[i].StudentsInClass.Count; j++)
                                        {
                                            Console.WriteLine(courseList[i].StudentsInClass[j]);
                                        }
                                        Console.WriteLine("\n" + "Please enter a student ID to add");
                                        int newstudent = int.Parse(Console.ReadLine());

                                        bool idmatch = true;

                                        for (int n = 0; n < studentList.Count; n++)
                                        {

                                            if (newstudent == studentList[n].StudentID)
                                            {
                                                courseList[i].StudentsInClass.Add(studentList[n]);
                                                Console.WriteLine(studentList[n].FullName.First + studentList[n].FullName.Last
                                                    + " has been added to " + courseList[i].CourseName);
                                                idmatch = true;
                                            }
                                        }
                                        if (idmatch == false)
                                        {
                                            Console.WriteLine("Student not found.");
                                        }
                                    }
                                }
                            }
                            else if (courseresponse == "4")
                            {
                                coursecontinue = false;
                            }
                            else
                            {
                                Console.WriteLine("Input not recognized. Try again");
                            }
                        }
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Current course list:");
                    for (int i = 0; i < courseList.Count; i++)
                    {
                        Console.WriteLine(courseList[i].CourseID + " " + courseList[i].CourseName);
                    }
                    Console.WriteLine("Please enter the course ID for the course you would like to analyze");
                    int courseselect = int.Parse(Console.ReadLine());
                    for (int i = 0; i < courseList.Count; i++)
                    {
                        if (courseselect == courseList[i].CourseID)
                        {
                            Console.WriteLine("List of Students and Their Average Grade:");
                            for (int j = 0; j < courseList[i].StudentsInClass.Count; j++)
                            {
                                decimal individualavg = courseList[i].StudentsInClass[j].GetStudentAverage();
                                Console.WriteLine(courseList[i].StudentsInClass[j].FullName + ": " + individualavg);
                                courseList[i].GetCourseMin(individualavg);
                                
                            }
                        }
                    }
                }
                else if (input == "4")
                {
                    Console.WriteLine("Thank you. Goodbye.");
                    continueprogram = false;
                }
                else
                {
                    Console.WriteLine("Input not recognized. Try again");
                }
            }
            Console.ReadKey();
        }
    }
}
                            /*for (int j = 0; j < StudID.Count; j++)
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
                                                PerF.Insert(j, Fcount); */
