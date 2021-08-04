using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHelper
{
    class Bugbear:Creatures
    {
        Weapons weapon;
        public Bugbear()
        {
            name = "Медвежатник";
            armor = 16;
            health = 27;
            speed = 30;
            strength = 2;
            agility = 2;
            constitution = -1;
            intelligence = -1;
            wisdom = 0;
            charisma = -1;
            danger = 1;
            attack_bonus = 4;
            count_attack = 1;
            weapon = new LongSword();
            magic = new FireBall();
        }
        public Bugbear(Weapons weapon)
        {
            name = "Медвежатник";
            armor = 16;
            health = 27;
            speed = 30;
            strength = 2;
            agility = 2;
            constitution = -1;
            intelligence = -1;
            wisdom = 0;
            charisma = -1;
            danger = 1;
            attack_bonus = 4;
            count_attack = 1;
            this.weapon = weapon;
            magic = new FireBall();
        }

        public override int GiveDamage()
        {
            return weapon.GiveDamage() + strength;
        }


    }
}
