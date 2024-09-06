using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEROGAMEPLEASE
{
    public abstract class CharacterTile : Tile
    {
        int hitPoints;
        int maximumHitPoints;
        int attackPower;
        public CharacterTile[] vision;

        public CharacterTile(Position position, int hitPoints, int attackPower) : base(Tile.xPosition,Tile.yPosition)
        {
            maximumHitPoints = hitPoints;
            this.hitPoints = hitPoints;
            this.attackPower = attackPower;
            vision = new CharacterTile[4];
        }

        public void UpdateVision(Level level)
        {

        }
    }
}
