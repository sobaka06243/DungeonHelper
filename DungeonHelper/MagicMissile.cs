using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHelper
{
    class MagicMissile:Magic
    {

        public MagicMissile()
        {
            difficult = 15;
            name = "Магические стрелы";
        }
        
        public override int  Check()
        {
            return 1;
        }

        public override int GiveDamage()
        {
            Random rand = new Random();
            int damage = 3;
            for (int i = 0; i < 3; i++)
            {
                damage += rand.Next(1, 4);
            }
            return damage;
        }
    }
}
