using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;//added 

namespace MonsterLibrary
{
    public class Dragon : Monster
    {
        //fields
        //properties
        public bool IsScaley { get; set; }

        //constructors
        public Dragon(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isScaley)
                    : base(name, maxDamage, life,maxLife , hitChance, minDamage, block, description)
        {
            IsScaley = isScaley;
        }
                //end FQCTOR

    //end dragon
    //methods
    public Dragon()
    {
        MaxLife = 6;
        MaxDamage = 5;
        Name = "Baby Dragon";
        Life = 6;
        HitChance = 25;
        Block = 20;
        MinDamage = 1;
        Description = "a new born winged two-legged dragon with a barbed tail";
        IsScaley = false;
    }//end Ctor

    //end dragon
    public override string ToString()
    {
        return base.ToString() + (IsScaley ? "It's scaly!" : "Not so scaley");
        //end override

    }
}  //end class
}//end namespace
