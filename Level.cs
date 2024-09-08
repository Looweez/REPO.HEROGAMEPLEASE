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
        private Tile[,] Tile; //2d array
        private int width;
        private int height;

        public Level(int width, int height) //Constructor
        {
            this.width = width;
            this.height = height;
            Tile = new Tile[width, height];
            InitialiseTiles();
        }

        private void InitialiseTiles()
        {

            for (int i = 0; i < Tile.GetLength(0); i++) //goes through row by row
            {
                for (int j = 0; j < Tile.GetLength(1); j++) //column by column
                {
                    Position position = new Position(i, j);
                    CreateTile(position, TileType.Empty);
                }
            }
        }

        public enum TileType
        {
            Empty,
        }

        private void CreateTile(Position Position, TileType tile)
        {
            if (Position.X < 0 || Position.X >= width || Position.Y < 0 || Position.Y >= height)
            {
                throw new ArgumentOutOfRangeException("Position is out of bounds.");
            }

            switch (tile)
            {
                case TileType.Empty:
                     {
                        EmptyTile emptyTile = new EmptyTile(Position.X, Position.Y); //make new empty tile and put it in the level
                        Tile[Position.X, Position.Y] = emptyTile;
                    }
                     break;
   
            }
           
        }

        public override string ToString()
        {

            string Output = "";

            for (int i = 0; i < Tile.GetLength(0); i++)
            {
                for (int j = 0; j < Tile.GetLength(1); j++)
                {
                    if (Tile[i, j] != null)                              //help
                    {
                        Output += Tile[i, j].Display.ToString();
                    }
                    else
                    {
                        Output += "null";                
                    }
                }

                Output += "\n"; //make new line
            }

            return Output ;
        }


    }
}
