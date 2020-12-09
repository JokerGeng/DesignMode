using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class MazeGame
    {
        /// <summary>
        /// 常规方法
        /// </summary>
        /// <returns></returns>
        public Maze CreateMaze()
        {
            Maze maze = new Maze();
            Room r1 = new Room(1);
            Room r2 = new Room(2);
            Door door = new Door(r1, r2);
            maze.AddRoom(r1);
            maze.AddRoom(r2);


            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.East, door);
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.West, new Wall());

            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.West, door);
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.East, new Wall());
            return maze;
        }

        /// <summary>
        /// 抽象工厂
        /// </summary>
        /// <param name="factory"></param>
        /// <returns></returns>
        public Maze CreateMaze(MazeFactory factory)
        {
            Maze maze = factory.MakeMaze();
            Room r1 = factory.MakeRoom(1);
            Room r2 = factory.MakeRoom(2);
            Door door = factory.MakeDoor(r1, r2);
            maze.AddRoom(r1);
            maze.AddRoom(r2);


            r1.SetSide(Direction.North, factory.MakeWall());
            r1.SetSide(Direction.East, door);
            r1.SetSide(Direction.South, factory.MakeWall());
            r1.SetSide(Direction.West, factory.MakeWall());

            r2.SetSide(Direction.North, factory.MakeWall());
            r2.SetSide(Direction.West, door);
            r2.SetSide(Direction.South, factory.MakeWall());
            r2.SetSide(Direction.East, factory.MakeWall());
            return maze;
        }


        /// <summary>
        /// builder模式
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public Maze CreateMaze(MazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);
            return builder.GetMaze();
        }

        /// <summary>
        /// prototype模式
        /// </summary>
        /// <param name="prototypeFactory"></param>
        /// <returns></returns>
        public Maze CreateMaze(MazePrototypeFactory prototypeFactory)
        {
            prototypeFactory.MakeWall();
            prototypeFactory.MakeDoor(prototypeFactory.MakeRoom(1), prototypeFactory.MakeRoom(2));
            return prototypeFactory.MakeMaze();
        }
    }
}
