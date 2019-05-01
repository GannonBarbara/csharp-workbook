using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingGarage parkingGarage = null;
            while (ParkingGarage == null)
            { try
            {
                Console.WriteLine("Enter the size of your parkign garage");
                String UserInput = Console.ReadLine();
                int SizeOfGarage = Convert.ToInt32(UserInput);

            }
                

            }


        //     Car c1 = new Car("Black", "VW", "Jetta");
        //     Console.WriteLine("c1 = {0}", c1.ToString());
           
        //    Car c2 = new Car("Blue", "Mazda", "3");
        //    Console.WriteLine("c2 = {0}", c2.ToString());

        //    ParkingGarage p1 = new ParkingGarage(7);
        //    for(int i=0; i<p1.NumSpaces; i++)
        //    {
        //        if(p1.IsSlotAvailible(i))
        //        {
        //            p1.ParkCar(c1, i);
        //            break;
        //        }
        //    }
        //    p1.ParkCar(c1, 1);   // pass in car you are parking, and the position to park it in
        //    p1.TowCar(1);
        //    p1.ParkCar(c2, 1);
        //    Console.WriteLine("Is slot 1 empty? {0}", p1.IsSlotAvailible(1));

        // //    Console.WriteLine("is slot 1 empty? {0}", p1.IsSlotAvailible(1));

        }
    }

    // represent a car as a class
    // represent a parking grage as a class
    // we want to use our parking garage class to manage our inventory
    public class Car
    {
        public String make {get; private set; }
        public String model {get; private set; }
        public String color;
        public String LicensePlate;
        public int year;

        public Car(String InitialColor, String InitialMake, String InitialModel)
        {
            this.color = InitialColor;
            this.make = InitialMake;
            this.model = InitialModel;
        }
        
        public String ToString()
        {
            String StringRepresentation = String.Format("{0} {1} {2}", this.color, this.make, this.model);
            return StringRepresentation;

        }

    }

   

    public class ParkingGarage
    {
        public int NumSpaces {get; private set;}
        private Car[] ParkingSlots;

        public ParkingGarage(int DesiredNumSpaces)
        {
            ParkingSlots = new Car[DesiredNumSpaces];
        }

        // this method should return true if slot is availible
        // & otherwise return false
        public bool IsSlotAvailible(int SlotNumber)
        {
            Car TheCarInTheSlot = ParkingSlots[SlotNumber];
            if (ParkingSlots[SlotNumber] == null)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void ParkCar(Car TheCar, int TheSlot)
        {
            bool IsSlotEmpty = IsSlotAvailible(TheSlot);
            if (IsSlotEmpty == true)
            {
                this.ParkingSlots[TheSlot] = TheCar;
            } else
            {
                throw new Exception("Slot "+TheSlot+" is taken!");
            }
            // bad parking garage did not actually park my car ....
            this.ParkingSlots[TheSlot] = TheCar;
            
        }
        public Car TowCar(int TheSlot)
        {
            Car c = ParkingSlots[TheSlot];
            ParkingSlots[TheSlot]= null;


            return c;

        }
    }
}
