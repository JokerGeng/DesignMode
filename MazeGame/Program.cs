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

            Maze abstructGame = generalMazeGame.CreatMaze(new MazeFactory());
            Maze enchtedGame = generalMazeGame.CreatMaze(new EnchantedMazeFactory());
            Console.Read();
        }
    }
}
