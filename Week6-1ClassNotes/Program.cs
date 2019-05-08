using System;
using System.Collections.Generic;

namespace week6ClassNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Willhelmina","Will") ;
            SuperHuman h2 = new SuperHuman("Bruce", "Bruce Wayne", "Super Rich");
            Human h3 = new SuperHuman("SuperMan", "Clark Kent", "Everything");
            Human h4 = (Human)h3;


            Console.WriteLine(h1.GetGreeting());
            greetback(h1);
            Console.WriteLine(h2.GetGreeting());
            greetback(h2);
            Console.WriteLine(h3.GetGreeting());
            greetback(h3);
            Console.WriteLine(h4.GetGreeting());   
            greetback(h4);

        }
        public static void greetback(Human human)
        {
            Console.WriteLine("Hi, {0}, nice to meet you.",  human.name);
            if(human.GetType() == typeof(SuperHuman))
            {
                Console.WriteLine("I see you are a super human.");
                SuperHuman real = (SuperHuman) human;
            }
        }
    }
   
    public class Human
    {
        public String name {get; private set;}
        public String nickname;
        public Human(String initialname, String initialnickname)
        {
            this.name = initialname;
            this.nickname = initialnickname;
        }
        virtual
        public String GetGreeting()
        {
            String greeting = String.Format("Hi, my name is {0}, you may call me {1}", this.name, this.nickname);
            return greeting;
        }
    }

    public class SuperHuman : Human
    {
        public String superpower {get; private set;}
        public String realname {get; private set;}
        public SuperHuman(String initialname, String initialrealname, String initialSuperPower)
        : base(initialname, null)
        // passes these variables up to base class
        {
            this.superpower = initialSuperPower;
            this.realname = initialrealname;
        }
        override
        public String GetGreeting()
        {
            String greeting = String.Format("Hi, I am {0}, and I can {1}", this.name, this.superpower);
            return greeting;
        }
    }

}
