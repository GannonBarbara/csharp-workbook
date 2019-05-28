using System;

namespace WordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] lines = 
            System.IO.File.ReadAllLines(@"C:\Users\Owner\Desktop\words");

            System.IO.File.WriteAllLines(@"C:\Users\Owner\Desktop\words2", lines);
            StreamReader stream = File.OpenText(@"C:\Users\Owner\Desktop\words");
            FileStream outstream = File.OpenWrite(@"C:\Users\Owner\Desktop\words3");
            StreamWriter s = new StreamWriter(outstream);
            
            String line = stream.ReadLine();

            while( line != null)
            {
                //Console.WriteLine(line);
                s.WriteLine(line);
                line = stream.ReadLine();
            }
            //outstream.Close();
            s.Close();
            stream.Close();

        }
    }
}
