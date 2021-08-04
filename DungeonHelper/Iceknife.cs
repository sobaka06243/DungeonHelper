using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHelper
{
    class IceKnife:Magic
    {
        public IceKnife()
        {
            difficult = 16;
            name = "Ледяной кинжал";
        }

        public override int Check()
        {
            return 5;
        }

        public override int GiveDamage()
        {
            Random rand = new Random();
            int damage = 0;
            for (int i = 0; i < 1; i++)
            {
                damage += rand.Next(1, 10);
            }
            return damage;
        }
    }
}
