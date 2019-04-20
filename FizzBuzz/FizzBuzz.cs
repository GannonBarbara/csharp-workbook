using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            // i loops through incriments of 1 integer
            // i loops up to 1000
            // i is increasing
            {
                if (i % 3 == 0 && i % 5 == 0)
                // if the remainder if i divided by 3 is zero
                // and the remainder of i divided by 5 is zero
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (i % 3 == 0)
                // if i is not divisible by 3 and five with the remainder of zero
                // but it is divisible by 3 with the remainder of zero
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 ==0)
                // if i is not divisible by 3 and 5 with the remainder of zero
                // but it is divisible by 5 with the remainder of zero
                {
                    Console.WriteLine("Buzz");
                }
                else 
                // if none of the conditions above apply
                {
                    Console.WriteLine(i);
                    // display the integer value of i
                }
            }
        }
    }
}
