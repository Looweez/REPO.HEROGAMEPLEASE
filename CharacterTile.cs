using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    public abstract class CharacterTile : Tile
    {
        private Position position;
        int hitPoints;
        int maximumHitPoints;
        int attackPower;
        int damageTaken;
        char targetCharacter;
        public Tile[] vision;
        public Tile[] Vision
        {
            get { return vision; }
            set { vision = value; }
        }


        public CharacterTile(int xPosition, int yPosition, int hitPoints, int attackPower) : base(xPosition, yPosition)
        {

            this.hitPoints = hitPoints;
            this.maximumHitPoints = hitPoints;
            this.attackPower = attackPower;
            vision = new Tile[4];
        }


        public void TakeDamage(int damageTaken)
        {
            hitPoints -= damageTaken;
            if (this.hitPoints < 0) 
            {
                this.hitPoints = 0;
            }
        }

        public void Attack(CharacterTile targetCharacter)
        {
            targetCharacter.TakeDamage(this.attackPower);
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
            vision[0] = level.Tile[position.X, position.Y - 1]; //North
            vision[1] = level.Tile[position.X + 1, position.Y]; //East
            vision[2] = level.Tile[position.X, position.Y + 1]; //South
            vision[3] = level.Tile[position.X - 1, position.Y]; //West
        }

    }
}
