using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHelper
{
    class Person:Creatures
    {
        Weapons weapon;

        public Person(string name, int armor, int health, int speed, int strength, int agility, int constitution,int intelligence,int wisdom, int charisma, int attack_bonus,int count_attack, Weapons weapon, Magic magic)
        {
            this.name = name;
            this.armor = armor;
            this.health = health;
            this.speed = speed;
            this.strength = -strength;
            this.agility = agility;
            this.constitution = constitution;
            this.intelligence = intelligence;
            this.wisdom = wisdom;
            this.charisma = charisma;
            this.attack_bonus = attack_bonus;
            this.count_attack = count_attack;
            this.weapon = weapon;
            this.magic = magic;
        }

        public override int GiveDamage()
        {
            return weapon.GiveDamage() + agility;
        }

    }
}
