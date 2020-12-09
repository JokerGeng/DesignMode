using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class MazePrototypeFactory:MazeFactory
    {
        public Door door;
        public Maze maze;
        public Room room1;
        public Room room2;
        public Wall wall;
        public override Door MakeDoor(Room r1, Room r2)
        {
            door.Initialize(r1, r2);
            return (Door)door.Clone(); 
        }

        public override Maze MakeMaze()
        {
            maze.AddRoom(room1);
            maze.AddRoom(room2);
            return (Maze)maze.Clone();
        }

        public override Room MakeRoom(int roomid)
        {
            if(room1.RoomNumber== roomid)
            {
                return (Room)room1.Clone();
            }
            else
            {
                return (Room)room2.Clone();
            }
        }

        public override Wall MakeWall()
        {
            return (Wall)wall.Clone();
        }

        public MazePrototypeFactory( Maze maze,Room room1,Room room2,Door door,Wall wall)
        {
            this.maze = maze;
            this.room1 = room1;
            this.room2 = room2;
            this.door = door;
            this.wall = wall;
        }
    }
}
