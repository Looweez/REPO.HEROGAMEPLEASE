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
    }
}
