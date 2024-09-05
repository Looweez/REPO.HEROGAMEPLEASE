using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HEROGAMEPLEASE.Level;

namespace HEROGAMEPLEASE
{
    internal class Level
    {
        private char[,] Tile; //2d array
        private int width;
        private int height;

        public Level(int width, int height) //Constructor
        {
            this.width = width;
            this.height = height;
            Tile = new char[width, height];
        }

        private void InitialiseTiles()
        {
            CreateTile();
        }

        public enum TileType
        {
            Empty,
        }

        private void CreateTile(int Position, char TileType)
        {

                switch (TileType)
            {
                    case '•':
                         {
                            EmptyTile emptyTile = new EmptyTile(width, height); //make new empty tile and put it in the level
                         }
                         break;
            }
            return ;

        }

        
    }
}
