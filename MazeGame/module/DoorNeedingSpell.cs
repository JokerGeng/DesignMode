using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class DoorNeedingSpell: Door
    {
        private Room room1;
        private Room room2;
        public DoorNeedingSpell(Room room1 = null, Room room2 = null)
        {
            this.room1 = room1;
            this.room2 = room2;
        }

        public override void Enter()
        {

        }
    }
}
