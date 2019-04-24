using System;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a program that asks the user for 5 integers
            // handle the user giving you non-integer input.

            // Console.WriteLine("Pick a number: ");
            // String userInput = Console.WriteLine();

            
            // try{

            //     int number = Convert.ToInt32(userInput);

            // } catch{

            // } finally{

            // }

            Dictionary<String, int> dictionary = new Dictionary<String, String>();
            dictionary.Add("Texas", "Austin");
            // states are keys
            dictionary.Add("New Mexico", "Santa Fe");
            dictionary.Add("Kentucy", "Frankfort"); 



            // looping through the keys in the dictionary
            foreach (String state in dictionary.Keys){
                Console.WriteLine(state);

                // for every key, i want the value
                
                String capital = dictionary[state];
                Console.WriteLine("The capital of {0} is {1}", state, capital);

            }

        }














            
        //     Console.Write("Enter a number: ");
        //     String input = Console.ReadLine();


        //     try{
        //         int num = Convert.ToInt32(input);

        //         myFancyMethod(num);


        //         Console.WriteLine("The square of the number is "+(num*num));
        //     } catch (Exception e)
        //     {
        //         Console.WriteLine("Something went wrong...");
        //         Console.WriteLine("the message from the exception is "+e.Message);
        //     } finally
        //     {
        //         Console.WriteLine("Thanks for playing.");
        //     }
        // }
        // static void myFancyMethod(int number)
        // {
        //     if(number < 0)
        //     {
        //         throw new Exception("I really do not like negative numbers.");
        //     }
        // }
            







            // String allGrades = "200 12 50 18 20";
            // String[] stringArray = allGrades.Split(" ");
            // foreach(String stringGrade in StringArray)
            // {
            //     int numericGrade = Convert.ToInt32(stringGrade);
            // }


            // String input = "OK";
            // try{
            //     int grde = Convert.ToInt32(input);
            // } catch (Exception e)
            // {
            //     Console.WriteLine(input+" is not a number. Sorry.");
            // } finally
            // // whether or not you have an excpetion, finally always gets executed
            // {

            // }
            



            // list<String> students = new list<String>();
            // students.Add("Andy");
            // students.Add("Gannon");
            // students.Add("Chase");
            // students.Add("David");
            // students.Add("Jazon");
            // students.Add("Laura");
            // students.Add("Alysia");
            // students.Add("Jungil");

            // RandomList<String> randomOrder = randomize(students);

            // foreach(String student in randomOrder)
            // {
            //     Console.WriteLine(student);
            // }

            // for(i = 0 ; i <= 7 ; i++)
            // {
            //     int r = random(0, 1);
            //     String tmp = oL.RemoveAt(r);

            // }
                       
    // }
        // static List<String> randomize(List<String> originlLIst)
        // {
        //     return originalList;
        // }
    }
}
