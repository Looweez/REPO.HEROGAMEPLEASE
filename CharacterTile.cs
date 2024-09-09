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
        private Position position;
        int hitPoints;
        int maximumHitPoints;
        int attackPower;
        public Tile[] vision;

        public Tile[] Vision
        { 
            get { return vision; } 
            set { vision = value; }
        }

        public CharacterTile(Position position, int hitPoints, int attackPower) : base(position.XPosition, position.YPosition)
        {
            maximumHitPoints = hitPoints;
            this.position = position;
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
            vision[0] = level.Tile[position.XPosition, position.YPosition-1]; //North
            vision[1] = level.Tile[position.XPosition+1, position.YPosition]; //East
            vision[2] = level.Tile[position.XPosition, position.YPosition+1]; //South
            vision[3] = level.Tile[position.XPosition-1, position.YPosition]; //West
        }
    }
}
