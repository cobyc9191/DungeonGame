using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
namespace MonsterLibrary
{
    public class CookieMonster :Monster
    {
        public bool IsScaley { get; set; }
        public CookieMonster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isScaley)
                    : base(name, maxDamage, life,maxLife , hitChance, minDamage, block, description)
        {
            IsScaley = isScaley;
        }
        public CookieMonster()
        {
            MaxLife = 15;
            MaxDamage =13 ;
            Name = "CookieMonster";
            Life = 15;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "A Blue loud mouth monster demanding cookie...maybe we should give him what he wants";
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
