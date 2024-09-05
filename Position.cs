using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    internal class Position
    {
        private int xPosition; // x coordinate
        private int yPosition; // y coordinate

        public Position(int xPosition, int yPosition) // constructor
        {

            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }


        public int XPosition // property
        {
            get { return xPosition; }
            set { xPosition = value; }
        }

        public int YPosition // property
        {
            get { return yPosition; }
            set { yPosition = value; }
        }
    }
}
