using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    internal class EmptyTile : Tile
    {
        int xPosition;
        int yPosition;
        char display;

        public EmptyTile(int xPosition, int yPosition) : base(xPosition, yPosition) // constructor
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }

        public override char Display
        {
            get { return '.'; }
        }
    }
}
