using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHelper
{
    class FireBall:Magic
    {
        public FireBall()
        {
            difficult = 13;
            name = "Огненный шар";
        }

        public override int Check()
        {
            return 2;
        }

        public override int GiveDamage()
        {
            Random rand = new Random();
            int damage = 0;
            for (int i = 0; i < 8; i++)
            {
                damage += rand.Next(1, 6);
            }
            return damage;
        }
    }
}
