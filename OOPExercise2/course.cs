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

        public decimal GetAverageGrade()
        {
            decimal total = 0;
            decimal average = 0;

            foreach(Student x in StudentList)
            {
                total += x.Grade;
            }
            average = total / StudentList.Count;
            return average;
        }

        public decimal GetMin()
        {
            decimal min = 100;
            foreach (Student x in StudentList)
            {
                if (min > x.Grade)
                {
                    min = x.Grade;
                }
            }
            return min;
        }

        public decimal GetMax()
        {
            decimal max = 0;
            foreach (Student x in StudentList)
            {
                if (max < x.Grade)
                {
                    max = x.Grade;
                }
            }
            return max;
        }

        public decimal GetPercent(char lettergrade)
        {
            decimal pera = 0;
            decimal perb = 0;
            decimal perc = 0;
            decimal perd = 0;
            decimal perf = 0;

            foreach (Student x in StudentList)
            {
                if (x.Grade >= 90)
                {
                    pera++;
                }
                else if (x.Grade >= 80)
                {
                    perb++;
                }
                else if (x.Grade >= 70)
                {
                    perc++;
                }
                else if (x.Grade >= 60)
                {
                    perd++;
                }
                else
                {
                    perf++;
                }
            }
            pera = (pera / StudentList.Count) * 100;
            perb = (perb / StudentList.Count) * 100;
            perc = (perc / StudentList.Count) * 100;
            perd = (perd / StudentList.Count) * 100;
            perf = (perf / StudentList.Count) * 100;
            
            if (lettergrade == 'A')
            {
                return pera;
            }
            else if (lettergrade == 'B')
            {
                return perb;
            }
            else if (lettergrade == 'C')
            {
                return perc;
            }
            else if (lettergrade == 'D')
            {
                return perd;
            }
            else
            {
                return perf;
            }
        }
    }
}
