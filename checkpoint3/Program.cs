using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            App.start();
            
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
            ui.PrintMenu();
            string UInput = Console.ReadLine();
            ui.GetInput(UInput);
        }
    }
    public class Dao // what to do with items on list
    {
        public List<Items> ToDos { get; private set;}
        private ToDoContext Context;

        public UI ui;
        public Dao()
        {
            Context = new ToDoContext();
            Context.ToDoItems.EnsureCreated();
        }
         
        // return the current list of ToDos
        public void GetAll()
        {

        }
        public void GetDone()
        {

        }
        public void GetPending()
        {

        }
        public void CreateItem(String ToDo, int id) // enum here?
        {
            if (ui.input == "New" || ui.input == "new") 
            {
                ToDo = Console.ReadLine(); // need to put new?
            }
            Items item = new Items("doing stuff");
            context.ToDoItems.Add(newToDo);
            context.SaveChanges();
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
        public String input {get; set;}
        public void PrintMenu()
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
        public string GetInput(string input) // how connect to printmenu()
        {
            input = Console.ReadLine();
            return input;
        }
        public void printMessage()
        {

        }
        public void PrintError()
        {
            Console.WriteLine("Invalid entry");
        }
    }
    public class Items // properties of items on list
    {
        
        public int id  {get; set;}
        public String ToDo {get; set;} // contains content of todo item
        public Items(String iToDo)
        {
            this.ToDo = iToDo;
        }
        public enum Status
        {
           done, pending 
        }
    }
    public class  ToDoContext : DbContext
    {
        public DbSet<Items> ToDoItems { get; private set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename = items.db");
        }
    }
}