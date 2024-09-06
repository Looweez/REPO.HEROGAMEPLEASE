using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    public abstract class CharacterTile : Tile
    {
        int hitPoints;
        int maximumHitPoints;
        int attackPower;
        public CharacterTile[] vision;

        public CharacterTile(Position position, int hitPoints, int attackPower)
        {

        }
    }
}
