using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Door:MapSite
    {
        private Room room1;
        private Room room2;
        bool isOpen;
        public Door(Room room1=null,Room room2=null)
        {
            this.room1 = room1;
            this.room2 = room2;
        }

        public override void Enter()
        {
            
        }

        public Room OtherSideFrom(Room room)
        {
            return null;
        }
    }
}
