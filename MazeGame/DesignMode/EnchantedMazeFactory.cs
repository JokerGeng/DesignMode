using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class EnchantedMazeFactory:MazeFactory
    {
        public EnchantedMazeFactory()
        {

        }

        public override Room MakeRoom(int roomid)
        {
            return new EnchantedRoom(roomid);
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            return new DoorNeedingSpell(r1, r2);
        }
    }
}
