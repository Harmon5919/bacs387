using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise3
{
    class Degree
    {
        public Degree(PassFailCourse pfCourseA, PassFailCourse pfCourseB, GradedCourse gCourseA, GradedCourse gCourseB)
        {
            this.PFCourseA = pfCourseA;
            this.PFCourseB = pfCourseB;
            this.GCourseA = gCourseA;
            this.GCourseB = gCourseB;
        }
        public PassFailCourse PFCourseA { get; set; }
        public PassFailCourse PFCourseB { get; set; }
        public GradedCourse GCourseA { get; set; }
        public GradedCourse GCourseB { get; set; }
        public bool Passed()
        {
            int count = 0;
            if (this.GCourseA.Passed() == true)
            {
                count++;
            }
            if (this.GCourseB.Passed())
            {
                count++;
            }
            if (this.PFCourseA.Passed())
            {
                count++;
            }
            if (this.PFCourseB.Passed())
            {
                count++;
            }
            if (count >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
    }
    }

}
