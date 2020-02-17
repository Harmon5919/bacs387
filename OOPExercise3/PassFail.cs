using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise3
{
    class PassFail
    {
        public PassFail(string courseName, bool grade)
        {
            this.CourseName = courseName;
            this.Grade = grade;
        }
        public string CourseName { get; set; }
        public bool Grade { get; set; }
    }
    public bool Passed()
    {
        
    }
}
