using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a list and add ten names to it
            List<string> names = new List<string>();
            names.Add("David"); //1
            names.Add("Sarah"); //2
            names.Add("Micah"); //3
            names.Add("Nancy"); //4
            names.Add("Linda"); //5
            names.Add("Steve"); //6
            names.Add("Kevin"); //7
            names.Add("Mark"); //8
            names.Add("John"); //9
            names.Add("Michelle"); //10

            names.Sort(); //sorts alphabetically
            names.Reverse(); //reverses sort order

            Console.WriteLine("The list of names is:");
            //takes each element of list names and prints it to the console
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
            bool answer = true;
            answer = true;
            bool found = false;

            Console.WriteLine("Would you like to delete a name?");
            while (answer == true)
            {
                found = false;
                string response = Console.ReadLine();
                if (response == "yes" || response == "Yes" || response == "YES")
                {
                        Console.WriteLine("Please select a name to delete.");
                        string choice = Console.ReadLine();
                        
                        for (int i = 0; i < names.Count(); i++)
                        {
                            if (names[i] == choice)
                            {
                                names.RemoveAt(i);
                                found = true;
                                Console.WriteLine("The list of names is:");
                                //takes each element of list names and prints it to the console
                                foreach (string n in names)
                                {
                                    Console.WriteLine(n);
                                }
                                Console.WriteLine("Would you like to delete another name?");
                            }
                        }
                        if (found == false)
                        {
                            Console.WriteLine("The name was not found. Would you like to try again?");
                        }
                 }
                else if (response == "no" || response == "NO" || response == "No")
                {
                    Console.WriteLine("Thank you. Goodbye.");
                    answer = false;
                }
                else
                {
                    Console.WriteLine("I did not understand your response. Please type Yes or No");
                }
            }
            Console.ReadKey();
        }
    }
}
