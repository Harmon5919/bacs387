using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise3
{
    class GradedCourse
    {
        public GradedCourse(string gradedName, decimal grade)
        {
            this.GradedName = gradedName;
            this.Grade = grade;
        }
        public string GradedName { get; set; }
        public decimal Grade { get; set; }

        public bool Passed()
        {
            if (this.Grade >= 70)
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
