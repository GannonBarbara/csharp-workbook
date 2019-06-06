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
            app.start();
            
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

        }
    }
    public class Dao // what to do with items on list
    {
        public List<Items> ToDos { get; private set;}
        public ToDoContext Context {get; set;}

        public UI ui{get; set;}
        public Dao()
        {
            Context = new ToDoContext();
            Context.Database.EnsureCreated();
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
        public void CreateItem() // enum here?
        { 
            Console.WriteLine("Enter new to-do item:");
            string UInput = Console.ReadLine();
            ui.GetInput(UInput);
            Items item = new Items(ui.input);
            Context.ToDoItems.Add(item);
            Context.SaveChanges();
        }

        public void ToDoList(){
            foreach(Items a in Context.ToDoItems) 
            {
                Console.WriteLine("{0} {1}", a.id, a.ToDo);
            }
        }

        public void SelectItem()
        {
            if (ui.input == "Select" || ui.input =="select")
            {
                Console.WriteLine("Which #?");
                string selection = Console.ReadLine();

            }
        }
        public void DeleteItem()
        {

        }

    }
    public class UI // user interaction
    {
        public String input {get; set;}
        public Dao dao;
        public void PrintMenu()
        {
            Console.WriteLine("List of Commands:");
            Console.WriteLine("New = create new item");
            Console.WriteLine("Select = select item");
            Console.WriteLine("Done = mark done");
            Console.WriteLine("Delete = delete item");
            Console.WriteLine("Show = display to-do list");
            Console.WriteLine("Show done = display completed to-do items");
            Console.WriteLine("Show not done = display all to-do items pending completion");
            string input = Console.ReadLine();
            if (input == "New" || input == "new")
            {
                dao.CreateItem();
            }
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
        public Items()
        {

        }
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