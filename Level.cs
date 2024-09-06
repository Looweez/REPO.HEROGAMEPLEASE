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
            CreateTile();



            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
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
            return ;

        }

        public override string ToString()
        {

            //or (int row = width )

            /*foreach (char i in Tile)
            {
                Console.WriteLine(i + "\n");
            }*/

            string Output = '';

            for (int i = 0; i < Tile.GetLength(0); i++)
            {
                for (int j = 0; j < Tile.GetLength(1); j++)
                {
                    Output += Tile[i, j].Display.ToString();
                }
            }

            return Output ;
        }


    }
}
