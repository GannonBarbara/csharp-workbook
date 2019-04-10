using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      //    //defining string
      //     string userInput;
      //     //defining variable val1
      //     int val1;
      //     //defining variable val2
      //     int val2;

      //     Console.Write("Enter integer value: ");
      //     userInput = Console.ReadLine();
      //     val1 = Convert.ToInt32(userInput);
      //     Console.WriteLine(val1);

      //     Console.Write("Enter second integer value: ");
      //     userInput = Console.ReadLine();
      //     val2 = Convert.ToInt32(userInput);
      //     Console.WriteLine(val1, "+"+val2);



      //         //Write a C# program that takes two numbers as input, adds them together, and displays the result of that operation

      Console.WriteLine("Problem 1: Choose Number ");
      String userInput = Console.ReadLine();
      int x = Convert.ToInt32(userInput);

      Console.WriteLine("Choose another number ");
      String userInput2 = Console.ReadLine();
      int y = Convert.ToInt32(userInput2);

      int sum = (x + y);
      Console.WriteLine(sum);

      // Write a C# program that converts yards to inches.
      Console.WriteLine("Problem 2: Give measurement in yards");
      String userInput3 = Console.ReadLine();
      int a = Convert.ToInt32(userInput3);
      int inches = a * 36;
      Console.WriteLine(userInput3 +" is equal to "+inches+ " inches");

      // Create and define the variable people as true.
      bool people = true;

      // Create and define the variable f as false.
      bool f = false;
      // Create and define the variable num to be a decimal.

      decimal num = 37.23M;

      // Display the product of num multiplied by itself.

      decimal product = num*num;
      Console.WriteLine("Decimal product = "+product);
    
      
      // Create the following variables with your personal information:
      // firstName
      string firstName = "Gannon";

      // lastName
      string lastName = "Berriman";
      // age
      int age = 23;
      // job
      string job = "Receptionist";

      // favoriteBand
      string favoriteArtist = "Snoh Alaegra";
      // favoriteSportsTeam
      string favoriteSportsTeam = "I oppose sports";
      // Experiment with Console.WriteLine(); to print out different pieces of your personal information.
      Console.WriteLine(firstName+"'s favorite artist is "+favoriteArtist);

      // Convert the variable num to an int.
      int convertedNum = Convert.ToInt32(num);
      Console.WriteLine(convertedNum);

      // Print to the console the sum, product, difference, and quotient of 100 and 10.
      int b = 100;
      int c = 10;

      int sum2 = b+c;
      decimal product2 = b*c;
      int difference = b-c;
      int quotient = b/c;




      Console.WriteLine("The sum is "+sum2);
      Console.WriteLine("The product is "+product2);
      Console.WriteLine("The differnece is "+difference);
      Console.WriteLine("The quotient is "+quotient);
      

      // string userInput;
      // char UserName;

      // Console.Write("Hello, what is your name?");
      // userInput = Console.ReadLine();
      // Console.WriteLine("Nice to meet you, "+userInput);







    }
  }
}
