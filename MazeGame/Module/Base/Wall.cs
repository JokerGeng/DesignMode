using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Wall : MapSite, ICloneable
    {
        public Wall()
        {

        }

        public object Clone()
        {
            return this;
        }

        public override void Enter()
        {
            
        }
    }
}
