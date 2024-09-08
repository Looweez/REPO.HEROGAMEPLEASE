using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    public class Position
    {

        private int xPosition; // x coordinate
        private int yPosition; // y coordinate

        public Position(int xPosition, int yPosition) // constructor
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }

        // property
        public int X
        {
            get { return xPosition; }
            set { xPosition = value; }
        }

        // property
        public int Y                          //i changed these to just X and Y btw because XPosition and YPosition was confusing me
        {
            get { return yPosition; }
            set { yPosition = value; }
        }

    }
}
