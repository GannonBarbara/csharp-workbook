using System;
using System.Collections.Generic;

namespace checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Controller // user interaction 
    {

    }
    public class DataAccess // what to do with items on list
    {
        public List<Items> ToDos {public get; private set;}

    }
    public class Items // properties of items on list
    {
        public int id = 0;      


    }
}
