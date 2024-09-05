using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    internal class Level
    {
        private char[,] Tile;
        private int width;
        private int height;

        public Level(int width, int height) //Constructor
        {
            this.width = width;
            this.height = height;
            Tile = new char[width, height];
        }

        enum TileType
        {
            Empty
        }

        public void CreateTile(int Position, char tileType)
        {
            //return new Tile(Position, tileType);
            switch (tileType)
            {
                //case Empty: 
            }
        }
    }
}
