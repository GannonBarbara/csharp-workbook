using System;
using System.Collections.Generic;
using System.Linq;


namespace week7_2ClassNotes
{
    class Student
    {
        public String name;
        public int age;
        public Student(String iname, int iage)
        {
            this.name = iname;
            this.age = iage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Mark", 6));
            students.Add(new Student("Mary", 3));
            students.Add(new Student("Roberta", 4));
            students.Add(new Student("Martha", 3));


            IEnumerable<Student> lessthansix = students
                .Where(s => s.age <5)
                .Where(x => x.name.StartsWith("M")); 

            IEnumerable<String> lessthansixnamesonly = students
                .Where(s => s.age <5)
                .Where(x => x.name.StartsWith("M"))
                .Select(s => s.name);

            IEnumerable<String> lessthansixnamesonly2 = students
                .Where(s => s.age <5) // student goes in, student comes out
                .Select(s => s.name) // student goes in, string comes out
                .Where(x => x.StartsWith("M")) // string goes in, string comes out
                .Select(x => {
                    if(x.EndsWith("y")){
                        return x+"ay";
                    } else {
                        return x;
                    }
                });
                  
            foreach(Student s in lessthansix)
            {
                Console.WriteLine(s.name);
            }
        }


    }















    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         // String msg = "This is a string";
    //         // String error = "This is an error";

    //         Utils console = new Utils(">");
    //         int sum = 0;
    //         for(int i=0; i<20; i++)
    //         {
    //             console.debug("i am at position "+i);
    //             sum += i;
    //         }
    //         console.PrintMessage("the sum of 0 to 20 is "+sum);  
            
    //     }
    // }









    // public class Utils
    // {
    //     String msgprefix = ">";
    //     public Utils(String customprefix)
    //     {
    //         this.msgprefix = customprefix;
    //     }
    //     public void PrintMessage(String msg)
    //     {
    //         Console.WriteLine("{0} {1}", this.msgprefix, msg);
    //     }
    //     public void Error(String error)
    //     {
    //         Console.WriteLine("Error: {0}", error); 
    //     }
    //     public void debug(String msg)
    //     {
    //         // Console.WriteLine("debug log msg: {0}", msg);
    //     }
    // }
}
