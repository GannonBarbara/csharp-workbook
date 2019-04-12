using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            Console.WriteLine("Enter word: ");
            String userInput = Console.ReadLine();

            String firstLetter;
            String restOfWord;


            char[] vowels = new char[] {'a','A','E','i','I','o','O','u','U'};
            // char[] otherLetters = {'b','B','c'CdDfFgGhHjJkKlLmMnNpPqQrRsStTuUvV};

            int vowelPosition = userInput.IndexOfAny(vowels);

            if (vowelPosition == 0)
            {
               Console.WriteLine(userInput + "ay");

            // } else if (vowelPosition == 1)
            // {
            // //     Console.WriteLine

            // }


            



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
