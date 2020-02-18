using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            PassFailCourse pfCourseA = new PassFailCourse("pfCourseA", true);
            PassFailCourse pfCourseB = new PassFailCourse("pfCourseB", false);
            GradedCourse gCourseA = new GradedCourse("gCourseA", 90);
            GradedCourse gCourseB = new GradedCourse("gCourseB", 65);
            Degree myDegree = new Degree(pfCourseA, pfCourseB, gCourseA, gCourseB);
            if (myDegree.Passed())
            {
                Console.WriteLine("The degree is fulfilled");
            }
            else
            {
                Console.WriteLine("The degree has not been fulfilled");
            }
            Console.ReadKey();
        }
      
    }
}
