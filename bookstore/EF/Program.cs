using System;
using System.Collections.Generic;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dao dao = new Dao();
            dao.create("Cat in the Hat", Type.Kids);
            dao.create("The Hobbit", Type.Fiction);

            Console.WriteLine("Book title:");
            String UserInputTitle = Console.ReadLine();
            Console.WriteLine("Book type:");
            String UserInputType = Console.ReadLine();

            dao.create(UserInputTitle, UserInputType);

            
            foreach(Book b in dao.listBooks())
            {
                Console.WriteLine(b.title+" is a "+b.type+" book");
            }
        }
    }
    
}
