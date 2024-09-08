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
        public Tile[] vision;

        public CharacterTile(Position position, int hitPoints, int attackPower) : base(position.XPosition, position.YPosition)
        {
            maximumHitPoints = hitPoints;
            this.hitPoints = hitPoints;
            this.attackPower = attackPower;
            vision = new Tile[4];
        }

        public bool IsDead
        {
            get
            {
                if (hitPoints <= 0)
                {
                    return true;
                }
                else
                {
                    return false; // Return a different character based on the condition
                }
            }
        }

        public void UpdateVision(Level level)
        {
            int x = position.Xposition; //row
            int y = position.Yposition; //column

            vision[0] = new Tile(x-1, y); //North
            vision[1] = new Tile(x, y+1); //East
            vision[2] = new Tile(x+1, y); //South
            vision[3] = new Tile(x, y-1); //West
        }
    }
}
