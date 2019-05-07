using System;
using System.Collections.Generic;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
                // Display the count on the console.
                
            List<int> div_list = new List<int>();
            for (int i = 1; i < 101; i++)
            {
                
                if ( i % 3 == 0)
                {   
                   div_list.Add(i);
                } else 
                {
                    break;
                }
                int count = div_list.Count; 
                Console.WriteLine("There are {0} numbers between 1 & 100 divisible by 3 with no remainder.", count);

            }
        }
                
    }      

}
    
            // 2- Write a program and continuously ask the user to enter a number or "ok" to exit.
                // Calculate the sum of all the previously entered numbers and display it on the console.

            // Console.WriteLine("Enter a number or type 'ok' to exit.");
            // String UserInput = Console.ReadLine();

            // int n = Convert.ToInt32(UserInput);


            // if ()
            
            


            

            // 3- Write a program and ask the user to enter a number. Compute the factorial of the 
                // number and print it on the console. For example, if the user enters 5, the program should
                // calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

        

            // 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to 
                //guess the number. If the user guesses the number, display “You won"; otherwise, display 
                // “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

            // for (int i; i <=10; i++)
            // {
            //     Random generator= new Random();
            //     int num4 = generator.Next(1,11);


//             }

//             // 5- Write a program and ask the user to enter a series of numbers separated by comma.
//                 // Find the maximum of the numbers and display it on the console. For example, if the user
//                     // enters “5, 3, 8, 1, 4", the program should display 8.
//         }
//     }
// }
