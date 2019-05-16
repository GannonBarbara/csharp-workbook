using System;

namespace Week7_1ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
           Person p1 = new Person("Bobby", "Hill", "Male");
           Console.WriteLine(p1.FirstName);
        }
    }
    public class Address
    {
        public String Street1;
        public String Street2;
        public String City;
        public String State;
        public String Zip;
    }
    public class Person
    {
        public String FirstName;
        public String LastName;
        public String Gender;
        public Person(String s1, String s2, String s3)
        {
            this.FirstName = s1;
            this.LastName = s2;
            this.Gender = s3;
        }
    }   
    public class DriversLicense
    {
        public String FirstName {get; private set;}
        public String LastName {get; private set;}
        public Address HomeAddress;
        public String Gender {get; private set;}
        public String LicenseType {get; private set;}
    }
}
