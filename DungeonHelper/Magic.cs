using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHelper
{
    public abstract class Magic
    {
        protected int difficult;
        protected string name;
        public int Difficult
        {
            get
            {
                return difficult;
            }
            set
            {
                difficult = value;
            }
        }
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
        public abstract int GiveDamage();
        public abstract int Check();
    }
}
