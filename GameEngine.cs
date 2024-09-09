using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    public class GameEngine
    {
        private int numLevels;
        private Random random = new Random();
        private const int MIN_SIZE = 10;
        private const int MAX_SIZE = 20;
        private Level currentLevel;

        public GameEngine(int numLevels)
        {
            this.numLevels = numLevels;
            currentLevel = new Level(random.Next(MIN_SIZE, MAX_SIZE + 1), random.Next(MIN_SIZE, MAX_SIZE + 1));
        }

        public override string ToString()
        {
            return currentLevel.ToString();
        }

        private bool MoveHero(Direction direction)
        {
            Tile targetTile = null;

            if (direction == Direction.Up)
            {
                //this == this
                //if vision[1] == emptytile then
                //return true
                //else
                //return false
                targetTile = currentLevel.Hero.Vision[(int)direction];
                if (targetTile is EmptyTile)
                {
                    //swopTiles
                    //Updatevision
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (direction == Direction.Down)
            {
                targetTile = currentLevel.Hero.Vision[(int)direction];
            }
            else if (direction == Direction.Left)
            {
                targetTile = currentLevel.Hero.Vision[(int)direction];
            }
            else if (direction == Direction.Right)
            {
                targetTile = currentLevel.Hero.Vision[(int)direction];
            }

           
        }

        public void TriggeMovement(Direction direction)
        {
            MoveHero(direction);
        }
    }
}
