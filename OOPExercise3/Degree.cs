using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise3
{
    class Degree
    {
        public Degree(bool pfCourseA, bool pfCourseB, decimal gCourseA, decimal gCourseB)
        {
            this.PFCourseA = pfCourseA;
            this.PFCourseB = pfCourseB;
            this.GCourseA = gCourseA;
            this.GCourseB = gCourseB;
        }
        bool PFCourseA { get; set; }
        bool PFCourseB { get; set; }
        decimal GCourseA { get; set; }
        decimal GCourseB { get; set; }
    }
}
