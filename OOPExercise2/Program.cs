using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> myList = new List<Student>();
            myList.Add(new Student("Hanna", "Harmon", 70));
            myList.Add(new Student("David", "Harmon", 100));
            Course bacs387 = new Course("bacs387", 123, myList);
            Console.WriteLine("Average: " + bacs387.GetAverageGrade());
            Console.WriteLine("Min: " + bacs387.GetMin());
            Console.WriteLine("Max: " + bacs387.GetMax());
            Console.WriteLine("Percent A's: " + bacs387.GetPercent('A') + "%");
            Console.WriteLine("Percent B's: " + bacs387.GetPercent('B') + "%");
            Console.WriteLine("Percent C's: " + bacs387.GetPercent('C') + "%");
            Console.WriteLine("Percent D's: " + bacs387.GetPercent('D') + "%");
            Console.WriteLine("Percent F's: " + bacs387.GetPercent('F') + "%");
            Console.ReadKey();
        }

    }
}
