using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace checkpoint3
{
    public class App
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.start();
            
        }
        public Dao dao;
        public UI ui;
        public void start()
        {
            ui.PrintMenu();
            ui.GetInput();

        }
        public App()
        {
            Dao dao = new Dao();
            ui = new UI();
        }
    }
    public class Dao //facilitates program/gets things started/ calls UI class. Tells what to do w/ logic in dao & UI
    {
        public List<Items> ToDos;
        public UI ui;

        public ToDoContext Context {get; set;}
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
        public void CreateItem(String task) // logic in app class
        { 
            Items item = new Items(task);
            Context.ToDoItems.Add(item);
            Context.SaveChanges();
        }

        public void ToDoList(){
            foreach(Items a in Context.ToDoItems) 
            {
                Console.WriteLine("{0} {1}", a.id, a.ToDo);
            }
        }

        public IQueryable<Items> SelectItem(int id)
        {
            var item = from i in Context.ToDoItems
                where i.id.Equals(id)
                select i;
            return item;
        }
        public void DeleteItem()
        {

        }

    }
    public class UI // user interaction
    {
        Dao dao = new Dao();
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
                Console.WriteLine("Enter task:");
                String NewTask = Console.ReadLine();
                dao.CreateItem(NewTask);
            }
            if (input == "Select" || input == "select")
            {
                Console.WriteLine("Which #?");
                int id = Convert.ToInt32(Console.ReadLine());
                dao.SelectItem(id);
            }
            if (input == "Show" || input == "show")
            {
                Console.WriteLine("To-do List:");
                foreach (Items item in dao.Context.ToDoItems)
                {
                   Console.WriteLine("{0} {1} {2}", item.id, item.ToDo, item.status);
                }
                Console.WriteLine();

            }
        }
        public string GetInput() // how connect to printmenu()
        {
            String input = Console.ReadLine();
            return input;
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
        public Status status {get; set;}
        public Items()
        {}
        public Items(String iToDo)
        {
            this.ToDo = iToDo;
        }  
    }
    public enum Status
    {
        done, pending
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