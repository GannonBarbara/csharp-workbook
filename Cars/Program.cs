using System;
using System.Collections.Generic;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot jimscars = new CarLot("Jim's Cars");
            Car mazda = new Car(/*attributes go here */);
            Car bmw = new Car(/*attributes go here */);
            Car f150 = new Truck(/*attributes go here */);

            jimscars.Add(mazda);
            jimscars.Add(bmw);
            jimscars.Add(f150);

            jimscars.PrintInventory();


        }
    }
    public class CarLot
    {
        // program driver, has main
        List<Vehicle> inventory;
        String name;
        public void Add(Vehicle vehicle)
        {
            // code goes here...
        }
        public void PrintInventory()
        {
            // code goes here...
        }

    }
    public abstract class Vehicle
    {
        // parent class that has common attributes of cars and trucks
        override
        public String ToString()
        {
            // convert vehicle into string representation
        }
      

    }
    public class Car : Vehicle
    {
        // extends vehicle
        // bed size

    }
    public class Truck : Vehicle
    {
        // extends vehicle
        //type
        // two-door/four-door

    }
}
