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
            Position position;

            for (int i = 0; i < Tile.GetLength(0); i++) //goes through row by row
            {
                for (int j = 0; j < Tile.GetLength(1); j++)
                {
                    position = new Position(i, j);
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

            switch (tile)
        {
                case TileType.Empty:
                     {
                        EmptyTile emptyTile = new EmptyTile(width, height); //make new empty tile and put it in the level
                     }
                     break;

                    
        }

            /*switch (tile)
            {
                case TileType.Empty:
                    {
                        // assign EmptyTile to the Tile array
                        Tile[xPosition, yPosition] = new EmptyTile(xPosition, yPosition);
                    }
                    break;

                    return;

            }*/
        }

        public override string ToString()
        {

            string Output = "huh";

            for (int i = 0; i < Tile.GetLength(0); i++)
            {
                for (int j = 0; j < Tile.GetLength(1); j++)
                {
                    if (Tile[i, j] != null)                           //this was breaking so i added in this random null thing i found and now it works so YEAAA
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
