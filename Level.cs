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

        

        public Level(int width, int height, HeroTile heroTile = null) //Constructor
        {
            this.width = width;
            this.height = height;
            Tile = new Tile[width, height];
            InitialiseTiles();
            GetRandomEmptyPosition();

            if (heroTile == null)
            {
                Position randomPosition = GetRandomEmptyPosition();

                CreateTile(randomPosition, TileType.Hero);

            }
            else
            {          
                CreateTile(new Position(heroTile.XPosition, heroTile.YPosition), TileType.Hero);
            }
        }

        //****pg 19 - need to store HeroTile object as field of level class (???)

        public HeroTile heroTile { get; } //read only property of hero tile

        //--------------------------------------------------------------------------

        private void InitialiseTiles()
        {

            for (int i = 0; i < Tile.GetLength(0); i++) //goes through row by row
            {
                for (int j = 0; j < Tile.GetLength(1); j++) //column by column
                {
                    Position position = new Position(i, j);
                    if (i == 0 || i == Tile.GetLength(0) - 1 || j == 0 || j == Tile.GetLength(1) - 1)
                    {
                        // create a wall tile
                        CreateTile(position, TileType.Wall);
                    }
                    else
                    {
                        // create empty tile if its not
                        CreateTile(position, TileType.Empty);
                    }
                }
            }
        }

        //--------------------------------------------------------------------------

        public enum TileType
        {
            Empty,
            Wall,
            Hero,

        }

        //--------------------------------------------------------------------------

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
                case TileType.Wall:
                    {
                        WallTile wallTile = new WallTile(Position.X, Position.Y); //wall tile
                        Tile[Position.X, Position.Y] = wallTile;
                    }
                    break;
                case TileType.Hero:
                    {
                        HeroTile heroTile = new HeroTile(Position.X, Position.Y); //hero tile
                        Tile[Position.X, Position.Y] = heroTile;
                    }
                    break;

            }
           
        }
        //--------------------------------------------------------------------------

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

        //--------------------------------------------------------------------------

        private Position GetRandomEmptyPosition()
        {
            Random random = new Random();

            int randomX = random.Next(Tile.GetLength(0));
            int randomY = random.Next(Tile.GetLength(1));

            return new Position(randomX, randomY);
        }

        //--------------------------------------------------------------------------

        public void SwopTiles(Tile tile1, Tile tile2)
        {
            //get the positions and store them in position1 and position2
            Position pos1 = new Position(tile1.XPosition, tile1.YPosition);
            Position pos2 = new Position(tile2.XPosition, tile2.YPosition);

            //swap
            Tile temp = Tile[pos1.X, pos1.Y];                           //temp = tile1
            Tile[pos1.X, pos1.Y] = Tile[pos2.X, pos2.Y];                //tile 1 = tile 2
            Tile[pos2.X, pos2.Y] = temp;                                //tile2 = temp

        }

        //--------------------------------------------------------------------------

    }
}
