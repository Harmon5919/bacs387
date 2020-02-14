using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise3
{
    class PassFail
    {
        public PassFail(string courseName, bool pass)
        {
            this.CourseName = courseName;
            this.Pass = pass;
        }
        public string CourseName { get; set; }
        public bool Pass { get; set; }
        public bool Passed(bool pass)
        {
            foreach ()
            {
                if ( >= 70)
                {
                    pass = true;
                }
                else
                {
                    pass = false;
                }
            }
            return pass;
        }
    }
}
