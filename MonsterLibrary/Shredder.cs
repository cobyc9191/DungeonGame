using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

 namespace MonsterLibrary
{
    public class Shredder :Monster
    {
        public bool IsScaley { get; set; }
        public Shredder(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isScaley)
                    : base(name, maxDamage, life,maxLife , hitChance, minDamage, block, description)
        {
            IsScaley = isScaley;
        }
        public Shredder()
        {
            MaxLife = 14;
            MaxDamage = 7;
            Name = "Shredder";
            Life = 14;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "The leader of the Foot Clan....you are boned";
            IsScaley = true;
        }//end Ctor

        //end dragon
        public override string ToString()
        {
            return base.ToString() + (IsScaley ? "Dude bro has armour one you have fun with that" : "Not so scaley");
            //end override

        }
    }
}
