using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise2
{
    class Course
    {
        public Course(string courseName, int courseId, List<Student> studentList)
        {
            this.CourseName = courseName;
            this.CourseId = courseId;
            this.StudentList = studentList;
        }
        public string CourseName { get; set; }
        public int CourseId { get; set; }
        public List<Student> StudentList { get; set; }

        public void GetAverageGrade()
        {
            decimal average = 0;

        }

        public void GetMin()
        {
            int min = 100;
        }

        public void GetMax()
        {

        }

        public void GetPercent()
        {

        }
    }
}
