using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame generalMazeGame = new MazeGame();
            Maze generalGame = generalMazeGame.CreatMaze();
            Console.WriteLine("general maze game");

            Maze abstructGame = generalMazeGame.CreatMaze(new MazeFactory());
            Console.WriteLine("abstruct factory mode general maze game");
            Maze enchtedGame = generalMazeGame.CreatMaze(new EnchantedMazeFactory());
            Console.WriteLine("abstruct factory mode enchted maze game");

            generalMazeGame.CreatMaze(new StandardMazeBuilder());

            Console.WriteLine("builder mode maze game");

            Console.Read();
        }
    }
}
