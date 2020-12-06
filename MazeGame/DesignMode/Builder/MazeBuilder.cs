using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public abstract class MazeBuilder
    {
        public abstract void BuildMaze();

        public abstract void BuildRoom(int roomid);

        public abstract void BuildDoor(int r1, int r2);

        public abstract void BuildWall();

        public abstract Maze GetMaze();
    }
}
