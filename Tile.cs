using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    abstract class Tile
    {
        
            private int xPosition;
            private int yPosition;
            //private char Display;

            public int XPosition
            {
                get { return xPosition; }
            }

            public int YPosition
            {
                get { return yPosition; }
            }

            public Tile(int xPosition, int yPosition) // constructor
            {

                this.xPosition = xPosition;
                this.yPosition = yPosition;
            }
            public abstract char Display
            {
                get;
            }
        
    }
}
