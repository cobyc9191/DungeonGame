using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class HeWhoShallNotBeNamed: Monster
    {
        public bool IsScaley { get; set; }
        public HeWhoShallNotBeNamed(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isScaley)
                    : base(name, maxDamage, life,maxLife , hitChance, minDamage, block, description)
        {
            IsScaley = isScaley;
        }
        public HeWhoShallNotBeNamed()
        {
            MaxLife = 68;
            MaxDamage = 1000;
            Name = "He Who Shall Not Be Named";
            Life = 67;
            HitChance = 1;
            Block = 20;
            MinDamage = 1;
            Description = "The leader or the Deatheaters, get ready for a long winded speech";
            IsScaley = false;
        }//end Ctor

        //end dragon
        public override string ToString()
        {
            return base.ToString() + (IsScaley ? "It's scaly!" : "he is pale and very fleshy no");
            //end override

        }
    }
}
