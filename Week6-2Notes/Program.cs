using System;
using System.Collections.Generic;

namespace Week6_2Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mazda = new Car("Big Blue", 102.4);
            Car delorian = new Car("Delorian", 205.6);
            Car herby = new Car("Herby", 88);
            Car mysterymachine = new Car("Mystery Machine", 205.6);
            Person gannon = new Person("Gannon", 10.5);
            Person renee = new Person("Renee", 9.6);

            List<IRace> racers = new List<IRace>();
            racers.Add(mazda);
            racers.Add(delorian);
            racers.Add(herby);
            racers.Add(mysterymachine);
            racers.Add(gannon);
            racers.Add(renee);

            foreach(IRace racer1 in racers)         
            {
                foreach(IRace racer2 in racers)
                {
                    IRace winner = Race(racer1, racer2);
                    Console.WriteLine("{0} vs {1} = {2}",racer1, racer2, winner);
                    Console.WriteLine(winner.getcelebrationmessage());
                }
            }
        }
        public static IRace Race(IRace r1, IRace r2)
        {
            if (r1.getspeedmph() > r2.getspeedmph())
            {
                return r1;
            } else
            {
                return r2;
            }
            
        }
    }
    public interface IRace
    {
        double getspeedmph();
        String getcelebrationmessage();

    }
    public class Car : IRace
    {
        public String name{get; private set;}
        public double speedmph {get; private set;}
        public Car(String initialname, double initialspeedmph)
        {
            this.name = initialname;
            this.speedmph = initialspeedmph;
        }

        public double getspeedmph()
        {
            return this.speedmph;
        }
        public String getcelebrationmessage()
        {
            return "Congratulations "+name+", you are faster than a person.";
        }
        override
        public String ToString()
        {
            String s = String.Format("{0} ({1})", this.name, this.speedmph);
            return s;

        }

    }
    public class Person : IRace
    {
        public String name {get; private set;}
        public double speedmps {get; private set;}
        public Person(String initialname, double initialspeedmps)
        {
            this.name = initialname;
            this.speedmps = initialspeedmps;
        }

        public double getspeedmph()
        {
            // convert from meters per second to miles per hour
            return speedmps * 3600 / 1609.34;
        }
        public String getcelebrationmessage()
        {
            return "Congratulations "+name+", you are faster than a car!";
        }
        override
        public String ToString()
        {
            return this.name;
        }
    }
}
