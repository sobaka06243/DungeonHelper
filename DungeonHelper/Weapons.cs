using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHelper
{
    public abstract class Weapons
    {
        protected int dice;
        protected int number;
        public int Dice
        {
            get
            {
                return dice;
            }
            set
            {
                dice = value;
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }


        public int GiveDamage()
        {
            Random rand = new Random();
            int damage = 0;
            for (int i = 0; i < number; i++)
            {
                damage += rand.Next(1, dice);
            }
            return damage;
        }
    }
}
