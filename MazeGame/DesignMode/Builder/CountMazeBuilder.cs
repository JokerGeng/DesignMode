using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class CountMazeBuilder : MazeBuilder
    {
        int rooms, doors;
        public CountMazeBuilder()
        {

        }
        public override void BuildDoor(int r1, int r2)
        {
            doors++;
        }

        public override void BuildMaze()
        {
            //throw new NotImplementedException();
        }

        public override void BuildRoom(int roomid)
        {
            rooms++;
        }

        public override void BuildWall()
        {
            //throw new NotImplementedException();
        }

        public override Maze GetMaze()
        {
            return null;
        }

        public void GetCounts(out int roomCount,out int doorCount)
        {
            roomCount = rooms;
            doorCount = doors;
        }
    }
}
