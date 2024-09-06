using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    internal class Tile
    {

            private Position position;
            private char Display;

            public Position Position
            {
                get { return position; }
            }

            public Tile(Position position) // constructor
            {

                this.position = position;
            }
            public char display
            {
                get { return Display; }
            }
        
    }
}
