using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCreditProject
{
    class Course
    {
        public Course(string courseName, int courseID, List<Student> courseList)
        {
            this.CourseName = courseName;
            this.CourseID = courseID;
            this.CourseList = courseList;
        }
        public string CourseName { get; set; }
        public int CourseID { get; set; }
        public List<Student> CourseList {get; set; }
        public void CreateCourse()
        {
            Console.WriteLine("Create a course:" + "\n" + "Please enter a new course name.");
            string courseName = Console.ReadLine();
            Console.WriteLine("Please enter the course ID");
            int courseID = int.Parse(Console.ReadLine());
            Course newcourse = new Course(courseName, courseID, this.CourseList);

        }
    }
    
}
