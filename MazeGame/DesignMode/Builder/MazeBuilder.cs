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

        /*********构造细节不对外公布，只需获取产品即可************/
        //protected abstract void BuildMaze();

        //protected abstract void BuildRoom(int roomid);

        //protected abstract void BuildDoor(int r1, int r2);

        //protected abstract void BuildWall();

        /// <summary>
        /// 获取产品的函数必须实现构造产品的细节
        /// </summary>
        /// <returns></returns>
        //public abstract Maze GetMaze();

        /*********构造细节不对外公布，只需获取产品即可************/

        public abstract Maze GetMaze();
    }
}
