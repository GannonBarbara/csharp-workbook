using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {



            // // defined a new dictionary that has strings as the key
            // // and strings as the value

            // Dictionary<String, String> students = new Dictionary<String, String>();

            // // defines a new dictionary that has strings as the key
            // // and the value is an array of strings

            // Dictionary<String, String[]> gradebook = new Dictionary<String, String[]>();

            // int x = 2;
            // String color = "Red";

            // List<String> fruits = new List<String>();
            // fruits.Add("Apple");
            // fruits.Add("Banana");

            // Stack<String> lifo = new Stack<String>();
            // lifo.Push("A");
            // lifo.Push("B");


            for (int i = 0; i<5; i++)
            {           
            Console.WriteLine("Student name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("4 student grades? Separate with space.");
            string studentGrades = Console.ReadLine();
            string[] grades = studentGrades.Split(" ");
            Console.WriteLine(String.Join(" ", grades));
            }
        }
    }
}
