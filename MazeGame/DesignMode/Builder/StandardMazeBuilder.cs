using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class StandardMazeBuilder : MazeBuilder
    {
        private Maze currentMaze = null;
        public StandardMazeBuilder()
        {
            
        }
        public override void BuildDoor(int r1, int r2)
        {
            try
            {
                Room room1 = currentMaze.GetRoom(r1);
                Room room2 = currentMaze.GetRoom(r2);
                Door door = new Door(room1, room2);
                room1.SetSide(Direction.North,new Wall());
                room2.SetSide(Direction.East, new Wall());
            }
            catch
            {
                throw new Exception("build door error");
            }
        }

        public override void BuildMaze()
        {
            currentMaze = new Maze();
        }

        public override void BuildRoom(int roomid)
        {
            try
            {
                Room room = new Room(roomid);
                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.South, new Wall());
                room.SetSide(Direction.West, new Wall());
                currentMaze.AddRoom(room);
            }
            catch
            {
                throw new Exception("build room error");
            }
        }

        public override void BuildWall()
        {

        }

        public override Maze GetMaze()
        {
            return currentMaze;
        }
    }
}
