using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    public class ExitTile : Tile
    {

        int xPosition;
        int yPosition;
        char display;

        public ExitTile(int xPosition, int yPosition) : base(xPosition, yPosition) // constructor
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }

        public override char Display
        {
            get { return '▒'; }
        }
    }
}
