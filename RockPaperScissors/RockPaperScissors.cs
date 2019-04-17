using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Player 1 enter hand:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine("Player 2 enter hand:");
            string hand2 = Console.ReadLine().ToLower();
      // Console.WriteLine(CompareHands(hand1, hand2));

      if (hand1 == hand2)
      {
        Console.WriteLine("It's a tie!");
      }
        if (hand1 == "paper" && hand2 == "rock")
        {
          Console.WriteLine("Paper covers rock. Player 1 wins!");
        }
        else if (hand2 == "scissors" && hand1 == "paper") 
        {
          Console.WriteLine("Scissors cuts paper. Player 2 wins!");
        }
        if (hand1 == "scissors" && hand2 == "paper")
        {
          Console.WriteLine("Scissors cuts paper. Player 1 wins!");
        }
        else if (hand2 == "rock" && hand1 == "scissors")
        {
          Console.WriteLine("Rock beats scissors. Player 2 wins!");
        }
        if (hand1 == "rock" && hand2 == "paper")
        {
           Console.WriteLine("Paper covers rock. Player 2 wins!"); 
        }
        else if (hand1 == "rock" && hand2 == "scissors")
        {
          Console.WriteLine("Rock beats scissors. Player 1 wins!");  
        }
        




      






      // leave this command at the end so your program does not close automatically
      // Console.ReadLine();
    }
        
        // public static string CompareHands(string hand1, string hand2)
        // {
        //     // Your code here
        //     return hand1 + ' ' + hand2;
        // }
    }
}
