using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before any games are constructed {0}", Game.NumberGamesMessage());
            Game g1 = new Game("Standard");
            Console.WriteLine("After the standard game is connstructed {0}", Game.NumberGamesMessage());
            Game g2 = new Game("League");
            Console.WriteLine("After the League game is constructed {0}", Game.NumberGamesMessage());


            List<String> list = new List<String>;
            int size = list.Count;
            list.Count = 3; // cannot update count of list here because it is a private set
            




            // Block b1 = new Block(1);
            // Block b2 = new Block(2);

            // Tower towerA = new Tower();
            // towerA.blocks.Push(b2);
            // towerA.blocks.Push(b1);

            // Console.WriteLine("A {0}", towerA);





            // Motorcycle m1 = new Motorcycle("Black", "Honda");
            // Motorcycle m2 = new Motorcycle("Yellow", "Harley");

            // Stack<Motorcycle> myStack = new Stack<Motorcycle>();
            // myStack.Push(m1);
            // myStack.Push(m2);

            // Motorcycle top = myStack.Pop();
            // Motorcycle bottom = myStack.Pop();

            // Console.WriteLine("Top of stack is {0}", myStack.Peek().ToString());
            
        }
    }
    // class Tower
    // {
    //     Stack<Block> blocks;
    //     public Tower()
    //     {
    //         blocks = new Stack<Block>();
    //     }
    //     public String toString()
    //     {
    //         String s = "";
    //         foreach(Block b in blocks)
    //         {
    //             s = s+""+b.weight;
    //         }
    //         return s;

    //     }
    // }
    class Person
    {
        String name;
        Person()
        {
            name = "Jane Doe";
        }
        public Person(String InitialName)
        {
            this.name = InitialName;
        }
    }
    class Game
    {
        public static int NumberOfGames = 0;
        public String RuleType{get; private set;} // standard, league, professional
        // privatr set means can only be changes from this class
        public Game(String InitialType)
        {
            NumberOfGames ++;
            this.RuleType = InitialType;
        }
        public static String NumberGamesMessage()
        {
            return NumberOfGames+" games have been constructed.";
        }

    }
    // class Block
    // {
    //     public int weight;
    //     public Block(int initialWeight)
    //     {
    //         this.weight = initialWeight;

    //     }
    // }
    // class Motorcycle
    // {
    //     public String brand;
    //     public String color;
    //     public Motorcycle(String initialBrand, String initialColor)
    //     {
    //         this.brand = initialBrand;
    //         this.color = initialColor;
    //     }
    //     public String ToString()
    //     {
    //         String s = String.Format("{0} {1}", this.color, this.brand);
    //         return s;
    //     }
    // }
}
