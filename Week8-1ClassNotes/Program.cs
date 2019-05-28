using System;
using System.Linq;
using System.Collections.Generic;

namespace Week8_1ClassNotes
{




    
    class Program
    {
        static void Main(string[] args)
        {
            Person fred = new Person("Fred", 8);
            Person roberta = new Person("Roberta", 12);
            Person maggie = new Person("Maggie", 3);
            Person lisette = new Person("Lisette", 26);
            Person mindy = new Person("Mindy", 25);
            Person john = new Person("John", 31);

            List<Person> children = new List<Person>();
            children.Add(fred);
            children.Add(roberta);
            children.Add(maggie);

            IEnumerable<String> results =
                children // starting point, person(s) come out
                .Where(p => p.age<10) // person(s) go in, person(s) come out 
                .OrderBy(p => p.age * p.name.Length - 2018 * p.age) // person goes in, person comes out
                .Select(p => p.name); // person goes in, string comes out
            
            foreach(String s in results)
            {
                Console.WriteLine(s);
            }
        }
    }
    public class Person
    {
        public String name;
        public int age;

        public Person(String initialname, int initialage)
        {
            this.age = initialage;
            this.name = initialname;

        }
    }
}
