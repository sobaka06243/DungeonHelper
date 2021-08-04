using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHelper
{
    class Goblin:Creatures
    {
        Weapons weapon;
        public Goblin()
        {
        name = "Гоблин";
        armor = 15;
        health = 7;
        speed = 30;
        strength = -1;
        agility = 2;
        constitution = 0;
        intelligence = 0;
        wisdom = -1;
        charisma = -1;
        danger = 0.25;
        attack_bonus = 4;
        count_attack = 1;
        weapon = new Scimitar();
        magic = new MagicMissile();
        }
        public Goblin(Weapons weapon)
        {
            name = "Гоблин";
            armor = 15;
            health = 7;
            speed = 30;
            strength = -1;
            agility = 2;
            constitution = 0;
            intelligence = 0;
            wisdom = -1;
            charisma = -1;
            danger = 0.25;
            attack_bonus = 4;
            count_attack = 1;
            this.weapon = weapon;
            magic = new MagicMissile();
        }

        public override int GiveDamage()
        {
            return weapon.GiveDamage() + agility;
        }

     
    }
}
