using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint2
{
    class Program
    {
        static void Main(string[] args)
        {
           Game thisGame = new Game();
            
        }
    }
    public class Checker
    {
        public String symbol {get;}
        public int[] position {get; set;}
        public String color {get;}

        public Checker (int[] position, String color)
        {
            this.position = position;
            this.color = color;
            if(color == "○") 
            {
                symbol = "&#10686";
            } else if(color == "black")
            {
                symbol = "•";
            }
        }

    }
    public class Board
    {
        public String [][] grid {get; set;}
        public List<Checker> checkers {get; set;}
        
        public Board ()
        {
            checkers = new List<Checker>();
            return;
            
        }
        public void MoveChecker()
        {
            Console.WriteLine("Enter pickup row");
            int PickupRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter pickup column");
            int PickupColumn = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Select row to place checker");
            int PlaceRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select column to place checker");
            int PlaceColumn = Convert.ToInt32(Console.ReadLine());

            Checker select;
            select = SelectChecker(PickupRow, PickupColumn);

            int whiteorblack = 0;
            if(select.color == "white")
            {
                whiteorblack = 1;
            } else if(select.color == "black")
            {
                whiteorblack = -1;
            }

            if((PickupRow <= 7) && (PickupRow >= 0) && (PickupColumn <= 7) && (PickupColumn >= 0)
                    && (PlaceRow <= 7) && (PlaceRow >= 0) && (PlaceColumn <= 7) && (PlaceColumn >= 0))
                    //has to be in parameters of our board
            {
                if((PlaceColumn == PickupColumn + 1) || (PlaceColumn == PickupColumn - 1) && (PlaceRow == PickupRow +whiteorblack))
                {
                    select.position[0] = PlaceRow;
                    select.position[1] = PlaceColumn;
                    DrawBoard();
                } else
                {
                    Console.WriteLine("Invalid Move");
                }
            }
            
            DrawBoard();   
        }

        public Checker SelectChecker(int row, int column)
        {
            return checkers.Find(x=>x.position.SequenceEqual(new List<int>{row, column}));
        }

        public void DrawBoard()
        {
            String[,] grid = new String [8,8];
            Console.WriteLine("\t0\t1\t2\t3\t4\t5\t6\t7");  


            foreach(Checker a in checkers)
            {
                int x = a.position[0];
                int y = a.position[1];
                grid[x,y] = a.symbol;
                
            }
            for(int i=0; i <= 7; i++)
            {
                Console.Write("{0}\t", i);
                for(int j=0; j<=7;j++)
                {
                    System.Console.Write("{0}\t", grid[i,j]);
                }
            System.Console.Write("\n");
            }
        }

        public void GenerateCheckers()
        {
            for(int i = 1; i <8; i+=2)
            {
                Checker c1 = new Checker(new int[] {0,i}, "white");
                checkers.Add(c1);
                Checker c3 = new Checker(new int[] {2,i}, "white");
                checkers.Add(c3);
            }
            for(int i = 0; i <7; i+=2)
            {
                Checker c2 = new Checker(new int[] {1,i}, "white");
                checkers.Add(c2);
            }
            for(int i = 0; i <8; i+=2)
            {
                Checker c4 = new Checker(new int[] {7, i}, "black");
                checkers.Add(c4);
                Checker c6 = new Checker(new int[] {5, i}, "black");
                checkers.Add(c6);
            }
            for(int i = 1; i <8; i+=2)
            {
                Checker c5 = new Checker(new int[] {6, i}, "black");
                checkers.Add(c5);
            }   
        }
        public bool CheckForWin()
        {
            int numblack = 0;
            int numwhite = 0;
            foreach(Checker c in checkers)
            {
                if(c.color == "white")
                {
                    numwhite += 1;
                }
                if(c.color == "black")
                {
                    numblack += 1;
                }
            } 
            if(numwhite > 0 && numblack >0)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
    public class Game
    {
        public Game()
        {
            Board brd = new Board();

            brd.GenerateCheckers();
            brd.DrawBoard();
            
            
            while(!brd.CheckForWin())
            {
                brd.MoveChecker();
            }
        }
    }
}
