using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Gargoyles :Monster
    {
        public bool IsScaley { get; set; }
        public Gargoyles(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isScaley)
                    : base(name, maxDamage, life,maxLife , hitChance, minDamage, block, description)
        {
            IsScaley = isScaley;
        }
        public Gargoyles()
        {
            MaxLife = 25;
            MaxDamage = 5;
            Name = "Gargoyles";
            Life = 25;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "a Stone statue it looks like its head is moving";
            IsScaley = true;
        }//end Ctor

        //end dragon
        public override string ToString()
        {
            return base.ToString() + (IsScaley ? "Made of rock have fun!" : "Not so scaley");
            //end override

        }
    }
}
