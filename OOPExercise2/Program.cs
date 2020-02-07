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
            Student myself = new Student("Hanna", "Harmon", 90);
            List<Student> spring = new List<Student>();
            spring.Add(new Student("Hannah", "Harmon", 90));
            spring.Add(new Student("Moe", "Manshad", 100));
            spring.Add(new Student("John", "Smith", 0));
            decimal average = 0;
            for (int i = 0; i < spring.Count; i++)
            {
                Console.WriteLine(spring[i].FirstName + " " + spring[i].LastName + " " + spring[i].Grade);
                average += spring[i].Grade;
            }
            average = average / spring.Count;
            Console.WriteLine("Class average is " + average);
            Console.ReadKey();
        }
    }
}
