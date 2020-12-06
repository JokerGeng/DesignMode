using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Room:MapSite
    {
        public Room(int roomId)
        {
            RoomNumber = roomId;
        }
        public Dictionary<Direction, MapSite> Sides = new Dictionary<Direction, MapSite>();

        public int RoomNumber { get; set; }

        public MapSite GetSide(Direction direction)
        {
            if(Sides.ContainsKey(direction))
            {
                return Sides[direction];
            }
            return null;
        }

        public void SetSide(Direction direction,MapSite mapSite)
        {
            if(!Sides.ContainsKey(direction))
            {
                Sides.Add(direction, mapSite);
            }
            else
            {
                Sides[direction] = mapSite;
            }
        }
        public override void Enter()
        {
            
        }
    }
}
