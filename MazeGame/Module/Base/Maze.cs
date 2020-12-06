using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Maze
    {
        List<Room> rooms = new List<Room>();
        public Maze()
        {

        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public Room GetRoom(int roomId)
        {
            return rooms?.Find(t => t.RoomNumber == roomId);
        }
    }
}
