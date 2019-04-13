using System;
using System.Linq;

namespace PigLatin
{
  class Program
  {
    public static void Main()
    {
      // your code goes here
      Console.WriteLine("Enter word: ");
      String userInput = Console.ReadLine();

      String firstLetter = userInput.Substring(0, 1);
      String restOfWord = userInput.Substring(1);


      char[] vowels = new char[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
      char[] otherLetters = {'b','B','c','C','d','D','f','F','g','G','h','H','j','J','k','K','l','L','m','M','n','N','p','P',
                                    'q','Q','r','R','s','S','t','T','u','U','v','V','x','X','y','Y','z','Z'};

      int vowelPosition = userInput.IndexOfAny(vowels);
      int consonantPosition = userInput.IndexOfAny(otherLetters);
    //   string vowelString = new string(vowels);




      // int lastConsonant = userInput.LastIndexOfAny(otherLetters);

      char last = userInput[userInput.Length - 1];


        if (vowelPosition == -1)
        {
          Console.WriteLine(userInput + "ay");
        }
        else if (vowelPosition != 0 && vowelPosition != 1)
        {
            String firstPart = userInput.Substring(0, vowelPosition);
            String secondPart = userInput.Substring(vowelPosition);
            Console.WriteLine(secondPart + firstPart+ "ay");
        }
        else if (vowelPosition == 0 && otherLetters.Contains(last))
        {
          Console.WriteLine(userInput + "ay");
        }
        else if (vowelPosition == 0 && vowels.Contains(last))
        {
          Console.WriteLine(userInput + "yay");
        }
        else if (consonantPosition == 0 && otherLetters.Contains(last))
        {
          Console.WriteLine(restOfWord + firstLetter + "ay");
        }
        else if (consonantPosition == 0 && vowels.Contains(last))
        {
          Console.WriteLine(restOfWord + firstLetter + "ay");
        }
    

      


      // System.Console.WriteLine("{0}", lastConsonant);
      // System.Console.WriteLine("{0}", last);








      // leave this command at the end so your program does not close automatically
      Console.ReadLine();
    }

    public static string TranslateWord(string word)
    {
      // your code goes here
      return word;
    }
  }
}

