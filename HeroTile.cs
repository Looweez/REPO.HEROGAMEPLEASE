using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROGAMEPLEASE
{
    public class HeroTile : CharacterTile
    {
        int hitPoints;
        int maximumHitPoints;
        int attackPower;

        public HeroTile(Position position): base (position)
        {
            maximumHitPoints = 40;
            attackPower = 5;
        }

        public override char Display
        {
            get
            {
                if (IsDead == true)
                {
                    return 'X';
                }
                else
                {
                    return '▼'; // Return a different character based on the condition
                }
            }
        }
    }
}
