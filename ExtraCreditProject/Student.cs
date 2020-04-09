using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCreditProject
{
    class Student
    {
        public Student(Name fullname, int studentID, List<decimal> grade)
        {
            this.FullName = fullname;
            this.StudentID = studentID;
            this.Grade = grade;
        }
        public Name FullName { get; set; }
        public int StudentID { get; set; }
        public List<decimal> Grade { get; set; }
        public void CreateStudent()
        {
            Console.WriteLine("Add a Student: " + "\n" + "Type the first name of the new student");
            
        }
        public decimal GetStudentAverage()
        {
            decimal avg = 0;
            for (int i = 0; i < Grade.Count; i++)
            {
                avg += Grade[i];
            }
            avg = avg / Grade.Count;
            return avg;
        }
    }
}
