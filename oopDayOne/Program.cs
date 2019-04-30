using System;
using System.Collections.Generic;

namespace oopDayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Person dad = new Person();
            dad.firstName = "Mike";
            dad.lastName = "Smith";

            Person mom = new Person();
            mom.firstName = "Jane";
            mom.lastName = "Smith";

            Person bob = new Person();
            bob.firstName = "Bob";
            bob.lastName = "Smith";

            Family Smiths = new Family();
            smiths.mainAddress = "5124 Main Street";
            smiths.adults.Add(mom);
            smiths.adults.Add(dad);

            smiths.matriarch = mom;
            smiths.children.Add(bob);


            Console.WriteLine("matriarch is {0}", Smiths.matriarch.nonStaticFullName());


            // List<Person> people = new List<Person>();

            // for(int i =0;i<3;i++)
            // {
            //     Person x = new Person();
            //      // ask user for firstname, lastname, and date of birth
            //     Console.Write("First name: ");
            //     x.firstName = Console.ReadLine();
            //     Console.Write("Last name: ");
            //     x.lastName = Console.ReadLine();
            //     Console.Write("Date of birth? (DDMMYYYY format): ");
            //     x.dob = Console.ReadLine();
            //     people.Add(x);                  
            // }
            // for (int i=0;i<people.Count;i++)
            // {
            //     Person w = people[i];
            //     String fullName = staticFullName(w.firstName, w.lastName);
            //     Console.WriteLine("Name: "+fullName);
            //     Console.WriteLine("DOB: "+w.dob);

            // }
            
        }

    }


    class Family
    {
        public String mainAddress;
        public List<Person> adults;
        public List<Person> children;
        public Person matriarch;

    }

    class Person
    {
        public String firstName;
        public String lastName;
        public String dob;

        public static String staticFullName(String f, String l)
        {
            String full = f + " " + l;
            return full;
        }

        public String nonStaticFullName()
        {
            return this.firstName+" "+this.lastName;
            
        }

        

    }
}
