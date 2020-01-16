using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
namespace MonsterLibrary
{
    public class Kraken : Monster
    {
        public bool IsScaley { get; set; }
        public Kraken(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isScaley)
                    : base(name, maxDamage, life,maxLife , hitChance, minDamage, block, description)
        {
            IsScaley = isScaley;
        }
        public Kraken()
        {
            MaxLife = 220;
            MaxDamage = 5;
            Name = "Kraken";
            Life = 220;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "quick he has been released time to put him back from where he came.";
            IsScaley = false;
        }//end Ctor

        //end dragon
        public override string ToString()
        {
            return base.ToString() + (IsScaley ? "It's scaly!" : "HE IS MADE OF MEAT quick attack");
            //end override

        }
    }
}
