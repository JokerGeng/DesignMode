using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Door:MapSite,ICloneable
    {
        private Room room1;
        private Room room2;
        public Door(Room room1=null,Room room2=null)
        {
            this.room1 = room1;
            this.room2 = room2;
        }

        public object Clone()
        {
            return this;
        }

        public override void Enter()
        {
            
        }

        public Room OtherSideFrom(Room room)
        {
            return null;
        }

        public void Initialize(Room room1, Room room2)
        {
            this.room1 = room1;
            this.room2 = room2;
        }
    }
}
