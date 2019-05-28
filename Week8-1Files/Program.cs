using System;
using System.IO;

namespace Week8_1Files
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

            FileStream picReader = File.OpenRead(@"C:\Users\Owner\Desktop\bookcat.jpg");
            FileStream picWriter = File.OpenWrite(@"C:\Users\Owner\Desktop\bookcat2.jpg");
            
            int b = picReader.ReadByte();
            while(b != -1)
            {
                picWriter.WriteByte((byte)b);
                b = picReader.ReadByte();
            }

            picReader.Close();
            picWriter.Close();




            //outstream.Close();
            s.Close();
            stream.Close();




            // do 
            // {
            //     Console.WriteLine(line);
            // } while( line != null); 
            

            
        }
    }
}
