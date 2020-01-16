using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
     public class Frankenstein: Monster
    {
        public bool IsScaley { get; set; }
        public Frankenstein(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isScaley)
                    : base(name, maxDamage, life,maxLife , hitChance, minDamage, block, description)
        {
            IsScaley = isScaley;
        }
        public Frankenstein()
        {
            MaxLife = 40;
            MaxDamage = 12;
            Name = "Frankenstein";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "Giant Green man has two bolt hanging out of his neck, it sounds like he is trying to say somthing";
            IsScaley = false;
        }//end Ctor

        //end dragon
        public override string ToString()
        {
            return base.ToString() + (IsScaley ? "It's scaly!" : "looks like he just has clothes on");
            //end override

        }
    }
}
