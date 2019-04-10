using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Rock, Paper, Scissors!");
            string userInput = Console.ReadLine();

            Random generator = new Random();
          
            int randomNumber = generator.Next(0,2);
    
            String RockPaperScissors = numToWords(randomNumber);
        }

            static String numToWords(int randomNumber){
                if(randomNumber == 0){
                    return "Rock"; 
                } else if(randomNumber == 1){
                    return "Paper";
                } else(randomNumber == 2){
                    return "Scissors";
                }   
            } 

            Console.WriteLine(userInput+" vs. "+randomNumber);


        


            
            Console.WriteLine("");
            // string hand2 = Console.ReadLine().ToLower(); // Part of Yousif's orginal notes, not correct
            // Console.WriteLine(CompareHands(hand1, hand2));

            // hand 2 needs to be randomly generated, it is not a user input

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            // Your code here
            return hand1 + ' ' + hand2;
        }
    }
}
