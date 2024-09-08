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
        

        public CharacterTile(Position position, int hitPoints, int attackPower) : base(position.X, position.Y)
        {

            this.hitPoints = hitPoints;
            this.maximumHitPoints = hitPoints;
            this.attackPower = attackPower;
            vision = new Tile[4];
        }

        /*public Tile[]             //idk how to expose
        {
            get { return vision; }
            set { vision = value; }
        }*/

        /*private void UpdateVision(Level level)        //need to do
        {
            Tile[,] = 
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

    }
}
