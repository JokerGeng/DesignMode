using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class EnchantedRoom : Room
    {
        public EnchantedRoom(int roomId):base(roomId)
        {
            RoomNumber = roomId;
        }
    }
}
