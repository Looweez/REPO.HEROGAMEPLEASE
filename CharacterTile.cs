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

        /*public Tile[]             //idk how to expose
        {
            vision { get; }
        }*/


        public void TakeDamage(int damageTaken)
        {
            hitPoints -= damageTaken;
            if (hitPoints < 0) 
            {
                hitPoints = 0;
            }
        }

        public void Attack(char targetCharacter)
        {
            //targetCharacter                            //to do
            TakeDamage(attackPower);
        }

        public bool IsDead
        {
            get
            {
                if (hitPoints == 0)
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
            vision[0] = level.Tile[position.XPosition, position.YPosition - 1]; //North
            vision[1] = level.Tile[position.XPosition + 1, position.YPosition]; //East
            vision[2] = level.Tile[position.XPosition, position.YPosition + 1]; //South
            vision[3] = level.Tile[position.XPosition - 1, position.YPosition]; //West
        }

    }
}
