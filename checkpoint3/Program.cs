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
        public void MarkDone(Items selection)
        {
            selection.status = Status.done;
            Context.SaveChanges();   
            App app2 = new App();
            app2.start();
        }
        public void CreateItem(String task) // logic in app class
        { 
            Items item = new Items(task);
            Context.ToDoItems.Add(item);
            Context.SaveChanges();
            App app2 = new App();
            app2.start();
        }
        public void DeleteItem(int id)
        {
            Items ite = SelectItem(id);
            Context.ToDoItems.Remove(ite);
            Context.SaveChanges();
            App app2 = new App();
            app2.start();
        }
        public void ToDoList(){
            foreach(Items a in Context.ToDoItems) 
            {
                Console.WriteLine("{0} {1}", a.id, a.ToDo);
                App app2 = new App();
                app2.start();
            }
        }
        public Items SelectItem(int id)
        {
            var item = from i in Context.ToDoItems
                where i.id.Equals(id)
                select i;
            return item.First();
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
            Console.WriteLine("Show = display to-do list");
            Console.WriteLine("Show done = display completed to-do items");
            Console.WriteLine("Show not done = display all to-do items pending completion");
            Console.WriteLine("Quit = exit app");              
        }
        public void GetInput() // how connect to printmenu()
        {
            string input = Console.ReadLine();
            while(input != "quit" || input != "Quit")
            {
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
                    Items i = dao.SelectItem(id);
                    Console.WriteLine(i.ToDo);
                    Console.WriteLine("What do you want to do with this item?");
                    Console.WriteLine("Done = mark done");
                    Console.WriteLine("Delete = delete item");
                    var input2 = Console.ReadLine();
                    if (input2 == "Done" || input2 == "done")
                    {
                        dao.MarkDone(i);

                    }
                    if (input2 == "Delete" || input2 == "delete")
                    {
                        dao.DeleteItem(id);
                    }
                }
                if (input == "Show" || input == "show")
                {
                    Console.WriteLine("To-do List:");
                    foreach (Items item in dao.Context.ToDoItems)
                    {
                    Console.WriteLine("{0} {1} {2}", item.id, item.ToDo, item.status);
                    }
                    App app2 = new App();
                    app2.start();

                }
                if (input == "Show done" || input == "Show Done" || input == "show done")
                {
                    Console.WriteLine("Done items:");
                    foreach (Items Item in dao.Context.ToDoItems)
                    {
                        if (Item.status == Status.done)
                        {
                            Console.WriteLine("{0} {1} {2}", Item.id, Item.ToDo, Item.status);
                            App app2 = new App();
                            app2.start();
                        }
                                        
                    }
                }
                if (input == "show not done" || input == "Show Not Done" || input == "Show not done")
                {
                    Console.WriteLine("Pending items:");
                    foreach (Items Item in dao.Context.ToDoItems)
                    {
                        if (Item.status == Status.pending)
                        {
                            Console.WriteLine("{0} {1} {2}", Item.id, Item.ToDo, Item.status);
                            App app2 = new App();
                            app2.start();
                        }
                                        
                    }

                }
            }

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
        pending, done
    }
    public class  ToDoContext : DbContext
    {
        public DbSet<Items> ToDoItems { get; private set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename = items1.db");
        }
    }
}