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

            Maze generalGame = generalMazeGame.CreateMaze();
            Console.WriteLine("general maze game");
            Console.WriteLine();

            Maze abstructGame = generalMazeGame.CreateMaze(new MazeFactory());
            Console.WriteLine("abstruct factory mode general maze game");
            Maze enchtedGame = generalMazeGame.CreateMaze(new EnchantedMazeFactory());
            Console.WriteLine("abstruct factory mode enchted maze game");
            Console.WriteLine();

            Maze builderMaze1= generalMazeGame.CreateMaze(new StandardMazeBuilder());
            Console.WriteLine("builder mode StandardBuilder maze game");
            Maze builderMaze2= generalMazeGame.CreateMaze(new CountMazeBuilder());
            Console.WriteLine("builder mode CountBuilder maze game");
            Console.WriteLine();

            Room r1 = new Room(1);
            Room r2 = new Room(2);
            MazePrototypeFactory mazePrototypeFactory = new MazePrototypeFactory(new Maze(), new Room(1),new Room(2), new Door(r1,r2), new Wall());
            Maze prototypeMaze = generalMazeGame.CreateMaze(mazePrototypeFactory);
            Console.WriteLine("prototype mode maze game");
            Console.WriteLine();

            Console.Read();
        }
    }
}
