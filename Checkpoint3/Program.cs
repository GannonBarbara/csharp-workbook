using System;
using System.Collections.Generic;

namespace Checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
        
        }
    }
    public class Controller
    {
        


    }
    public class DAO // data access object--does not contain items, dictstes what to do with items
    {
        public List<items> ToDoItems; // separate database needed?
        // assign item #s (id) so that user can call on them when completed
        


    }
    public class UI // user interaction
    {
        public string userinput {get; set;}

        public string command{get; private set;}

    }
    public class Item // plain old c# objects
    {
        public string todo{get; set;}

    }

}
