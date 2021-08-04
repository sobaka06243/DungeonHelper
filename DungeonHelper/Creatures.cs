using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHelper
{
    abstract class Creatures
    {
        protected string name;
        protected int armor;
        protected int health;
        protected int speed;
        protected int strength;     //1 сила
        protected int agility;      //2 ловкость
        protected int constitution; //3 телосложение
        protected int intelligence; //4 интелект
        protected int wisdom;       //5 мудрость
        protected int charisma;     //6 харизма
        protected double danger;
        protected int attack_bonus;
        protected int count_attack;
        protected Magic magic;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Armor
        {
            get
            {
                return armor;
            }
            set
            {
                armor = value;
            }
        }
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value;
            }
        }
        public int Agility
        {
            get
            {
                return agility;
            }
            set
            {
                agility = value;
            }
        }
        public int Constitution
        {
            get
            {
                return constitution;
            }
            set
            {
                constitution = value;
            }
        }
        public int Intelligence
        {
            get
            {
                return intelligence;
            }
            set
            {
                intelligence = value;
            }
        }
        public int Wisdom
        {
            get
            {
                return wisdom;
            }
            set
            {
                wisdom = value;
            }
        }
        public int Charisma
        {
            get
            {
                return charisma;
            }
            set
            {
                charisma = value;
            }
        }
        public double Danger
        {
            get
            {
                return danger;
            }
            set
            {
                danger = value;
            }
        }
        public int Attack_bonus
        {
            get
            {
                return attack_bonus;
            }
            set
            {
                attack_bonus = value;
            }
        }
        public int Count_attack
        {
            get
            {
                return count_attack;
            }
            set
            {
                count_attack = value;
            }
        }
        public Magic Magic
        {
            get
            {
                return magic;
            }
            set
            {
                magic = value;
            }
        }
        public void TakeDamege(int damage)
        {
            health -= damage;
            if (health < 0)
                health = 0;
        }
        public int CheckArmor(int hit)
        {
            if (hit > Armor)
                return 1;
            else
                return 0;
        }
        abstract public int GiveDamage();
        public int Attack()
        {
            Random rand = new Random();
            return rand.Next(1, 20) + attack_bonus;
        }

        private int CheckStrength(int diff)
        {
            Random rand = new Random();
            int charact = rand.Next(1, 20) + strength;
            if (diff > charact)
                return 1;
            else
                return 0;
        }
        private int CheckAgility(int diff)
        {
            Random rand = new Random();
            int charact = rand.Next(1, 20) + agility;
            if (diff > charact)
                return 1;
            else
                return 0;
        }
        private int CheckConstitution(int diff)
        {
            Random rand = new Random();
            int charact = rand.Next(1, 20) + constitution;
            if (diff > charact)
                return 1;
            else
                return 0;
        }
        private int Checkintelligence(int diff)
        {
            Random rand = new Random();
            int charact = rand.Next(1, 20) + intelligence;
            if (diff > charact)
                return 1;
            else
                return 0;
        }
        private int CheckWisdom(int diff)
        {
            Random rand = new Random();
            int charact = rand.Next(1, 20) + wisdom;
            if (diff > charact)
                return 1;
            else
                return 0;
        }
        private int CheckCharisma(int diff)
        {
            Random rand = new Random();
            int charact = rand.Next(1, 20) + charisma;
            if (diff > charact)
                return 1;
            else
                return 0;
        }

        public int CheckСharacteristic(int charact, int diff)
        {
            switch (charact)
            {
                case 1: return CheckStrength(diff);
                case 2: return CheckAgility(diff);
                case 3: return CheckConstitution(diff);
                case 4: return Checkintelligence(diff);
                case 5: return CheckWisdom(diff);
                case 6: return CheckCharisma(diff);
            }
            return 0;
        }
        public int SpellDamage()
        {
            return magic.GiveDamage();
        }

        public int SpellCharact()
        {
            return magic.Check();
        }

        public int SpellDiff()
        {
            return magic.Difficult;
        }

        public string SpellName()
        {
            return magic.Name;
        }
    }
}
