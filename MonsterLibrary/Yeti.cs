using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
namespace MonsterLibrary
{
    public class Yeti : Monster
    {
        public bool IsScaley { get; set; }
        public Yeti(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isScaley)
                    : base(name, maxDamage, life,maxLife , hitChance, minDamage, block, description)
        {
            IsScaley = isScaley;
        }
        public Yeti()
        {
            MaxLife = 46;
            MaxDamage = 5;
            Name = "Yeti";
            Life = 46;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "Big furry white monster, also has a snowcone maker";
            IsScaley = false;
        }//end Ctor

        //end dragon
        public override string ToString()
        {
            return base.ToString() + (IsScaley ? "It's scaly!" : "lots and lots of fur");
            //end override

        }
    }
}
