using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            App.start;
            
        }
    }
    public class Controller // not sure necessary--different from app?
    {
        
    }
    public class App //facilitates program/gets things started/ calls UI class
    {
        Dao dao;
        UI ui;
        public App()
        {
            dao = new Dao();
            ui = new UI();
        }
        public void start()
        {
            PrintMenu();
            GetInput();

        }
    }
    public class Dao // what to do with items on list
    {
        public List<Items> ToDos {public get; private set;}
        private ToDoContext Context;

        public Dao()
        {
            Context = new ToDoContext();
            Context.DataBase.EnsureCreated();
        }
         
        // return the current list of ToDos
        public GetAll()
        {

        }
        public GetDone()
        {

        }
        public GetPending()
        {

        }
        public CreateItem()
        {
            if (input = "New" || "new")
            {
                ToDo = Console.ReadLine(); // need to put new?
            }

        }
        public SelectItem()
        {
            if (input = "Select" || "select")
            {
                Console.WriteLine("Which #?");
                public string selection = Console.ReadLine();

            }
        }
        public DeleteItem()
        {
            if (input = "Delete" || "delete")
            {

            }

        }
        public List<ToDo> ToDoList(){
            List<ToDo> result  = new List<ToDo>();
            foreach(ToDo a in context.ToDos) 
            {
                result.Add(a);
            }
            return result;
        }

    }
    public class UI // user interaction
    {
        public String input;
        public PrintMenu()
        {
            Console.WriteLine("List of Commands:");
            Console.Write("New = create new item");
            Console.WriteLine("Select = select item");
            Console.WriteLine("Done = mark done");
            Console.WriteLine("Delete = delete item");
            Console.WriteLine("Show = display to-do list");
            Console.WriteLine("Show done = display completed to-do items");
            Console.WriteLine("Show not done = display all to-do items pending completion");
        }
        public GetInput() // how connect to printmenu()
        {
            public String input = Console.ReadLine();

        }
        public printMessage()
        {

        }
        public PrintError()
        {
            Console.WriteLine("Invalid entry");
        }


    }
    public class Items // properties of items on list
    {
        public String ToDo{get; set;} // contains content of todo item
        public int id = 0;
        public enum status() // delete, add, replace?
        {

        }



    }
      public class  ToDoContext : DbContext
    {
        public DbSet<ToDo> ToDoItems { get; private set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename = items.db");

        }
    }
}
