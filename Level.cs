using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    public class Level
    {
        public Tile[,] Tile; //2d array
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

            for (int i = 0; i < width; i++) //rows
            {
                for (int j = 0; j < height; j++)//columns
                {
                    position = new Position(i, j);
                    if (i == 0 || j == 0 || i == width || j == height)
                    {
                        CreateTile(position, TileType.Wall);
                    }
                    else
                    {
                        CreateTile(position, TileType.Empty);
                    }
                }
            }
        }

        public enum TileType
        {
            Empty,
            Wall,
            Hero,
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

                case TileType.Wall:
                    {
                        WallTile wallTile = new WallTile(width, height);
                    }
                    break;
            }
            return;

        }

        public override string ToString()
        {

            //or (int row = width )

            /*foreach (char i in Tile)
            {
                Console.WriteLine(i + "\n");
            }*/

            string Output = "huh";

            for (int i = 0; i < Tile.GetLength(0); i++)
            {
                for (int j = 0; j < Tile.GetLength(1); j++)
                {
                    Output += Tile[i, j].Display.ToString();
                }
            }

            return Output;
        }

        public void SwopTiles(Tile tile1, Tile tile2)
        {
            int tempX;
            int tempY;
            //tile1(Position.XPosition)
            tile1[Position.XPosition]

        }
    }
}