using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    internal class GameEngine
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
                targetTile = vision[0];
                if (targetTile == EmptyTile)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (direction == Direction.Down)
            {
                targetTile = vision[2];
            }
            else if (direction == Direction.Left)
            {
                targetTile = vision[3];
            }
            else if (direction == Direction.Right)
            {
                targetTile = vision[1];
            }

           
        }

        public void TriggeMovement(Direction direction)
        {
            MoveHero(direction);
        }
    }
}
