using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    internal class EmptyTile : Tile
    {
        private Position position;
        

        public EmptyTile(Position position) : base(position)// constructor
        {

            this.position = position;
        }
    }
}
