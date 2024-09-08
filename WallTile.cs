using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    internal class WallTile : Tile
    {
        int xPosition;
        int yPosition;

        public WallTile(int xPosition, int yPosition) : base(xPosition, yPosition) // constructor
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }

        public override char Display
        {
            get { return '▮'; }
        }
    }

}
