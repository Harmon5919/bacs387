using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise1
{
    class Course
    {
        public Course(string courseName, int courseId)
        {
            this.CourseName = courseName;
            this.CourseId = courseId;
        }
        public string CourseName { get; set; }
        public int CourseId { get; set; }

    }
}
