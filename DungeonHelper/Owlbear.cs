using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHelper
{
    class Owlbear:Creatures
    {
        Weapons weapon;
        public Owlbear()
        {
            name = "Совомед";
            armor = 13;
            health = 59;
            speed = 30;
            strength = 5;
            agility = 1;
            constitution = 3;
            intelligence = -4;
            wisdom = 1;
            charisma = -2;
            danger = 3;
            attack_bonus = 7;
            count_attack = 2;
            weapon = new Сlaws();
            magic = new IceKnife();
        }
        public Owlbear(Weapons weapon)
        {
            name = "Совомед";
            armor = 13;
            health = 59;
            speed = 30;
            strength = 5;
            agility = 1;
            constitution = 3;
            intelligence = -4;
            wisdom = 1;
            charisma = -2;
            danger = 3;
            attack_bonus = 7;
            count_attack = 2;
            this.weapon = weapon;
            magic = new IceKnife();
        }

        public override int GiveDamage()
        {
            return weapon.GiveDamage() + strength;
        }



    }
}
