using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello");
            Console.WriteLine("My name is Gannon");
            Console.WriteLine("What is your name? ");
            String yourName = Console.ReadLine();
            // Console.WriteLine("Nice to meet you "+yourName);
            if(yourName == "Bob"){
                Console.WriteLine("Really, that's the best you could come up with?");
            } else {
                Console.WriteLine("Hello "+yourName);
            }



        }
    }
}
