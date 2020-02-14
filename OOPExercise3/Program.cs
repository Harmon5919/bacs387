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
            List<Student> myList = new List<Student>();
            myList.Add(new Student("Hanna", "Harmon", 70));
            myList.Add(new Student("David", "Harmon", 60));
            PassFail bacs387 = new PassFail("bacs387", , myList);
            Console.WriteLine(bacs387.Pass);
            Console.ReadKey();
        }
      
    }
}
