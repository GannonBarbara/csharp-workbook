using System;
using System.Collections.Generic;
using System.Linq; // needed this to use Max() method & I'm not sure why.

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
                // Display the count on the console.


            int count = 0;
            //defines integer count
            for (int i = 1 ; i <= 100; i++) // for each integer i, loops 1 integer at a time, less than or equal to 100, goes up
            {
                if (i % 3 == 0) // integer i divisible by 3 with no remainder
                {
                    count++; //count increases
                }
            }
            Console.WriteLine("There are {0} numbers between 1 & 100 divisible by 3 with no remainder.", count);










             // 2- Write a program and continuously ask the user to enter a number or "ok" to exit.
                // Calculate the sum of all the previously entered numbers and display it on the console.
           

            int sum = 0; // int sum starts at 0
            while (true) //while sum = 0
            {
                Console.WriteLine("Enter a number or 'ok' to exit.");
                var userinput = Console.ReadLine(); // collects user input and makes it string
                if (userinput == "ok")
                {
                    break; // exits loop
                }
                sum += Convert.ToInt32(userinput); // sum = sum + (userinput converted into an integer)
            }
            Console.WriteLine("Sum = {0}", sum); // display sum now that it has gone through the loop









            // 3- Write a program and ask the user to enter a number. Compute the factorial of the 
                // number and print it on the console. For example, if the user enters 5, the program should
                // calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine()); // converts user input into integer
            int factorial = 1;
            for (int i = 1; i <= num; i++) // i increases by 1, i is less than or equal to num, goes up
            {
                factorial *= i; // factorial = factorial * i
            }
            Console.WriteLine("{0}! = {1}", num, factorial);









            // 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to 
                //guess the number. If the user guesses the number, display “You won"; otherwise, display 
                // “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
            

            int rand = new Random().Next(1, 10); // integer rand = random number between 1 and 10
            // Console.WriteLine("{0}", rand);
            for (var i = 0; i < 4; i++) // i loops through 0 integers at a time, only loops 3 times, goes up
            {
                Console.WriteLine("Guess an integer between 1 & 10.");
                int guess = Convert.ToInt32(Console.ReadLine()); // stores guess
                if (guess == rand)
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect!"); // will happen after 4 incorrect guesses
                }
            }









            // 5- Write a program and ask the user to enter a series of numbers separated by comma.
                // Find the maximum of the numbers and display it on the console. For example, if the user
                    // enters “5, 3, 8, 1, 4", the program should display 8.
            

            Console.WriteLine("Enter a series of numbers separated by a comma.");
            string series = Console.ReadLine();
            var nums = series.Split(","); // creates variable nums by splitting variable series each time ther is a comma
            int[] numsseries = new int[]{Convert.ToInt32(nums[0])};
            // creates integer array by converting nums string into integers starting at index 0
            int max = numsseries.Max(); // assumes max is 1st number in series
            foreach (var x in nums) // will loop through all varibles x in nums
            {
                var y = Convert.ToInt32(x); // defines variable y & converts it into integer from x
                if (y > max)
                {
                    max = y; // redefines max as largest number in series
                }
            }
            Console.WriteLine("The Max number in your series is {0}", max);


        }
                
    }      

}
    
           
            
            


            

            

        

            



