using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster:Character
    {
        //fields
        //since we will have a business rule on minDamage, we must create a full field and full property
        private int _minDamage;
        //properties
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                { _minDamage = 1; }
            }
        }

        public Monster() { }
        //mini lab build the FQCTOR





        //constructors
        public Monster(string name, int life, int maxLife, int hitChance,
            int block, int minDamage, int maxDamage, string description)
        {  MaxLife = maxLife;
            MaxDamage = maxDamage;
            Life = life;
            Name = name;
            HitChance = hitChance;
            MinDamage = minDamage;
            Description = description;
            Block = block;
        }

        //methods
        public override string ToString()
        {
            return string.Format("\n ********Monster********\n{0}\nLife:\t{1} of"
                +" {2}\nDamage:{3} to {4}\nBlock:\t {5}\nDescription::\n{6}\n",
                Name, Life, MaxLife, MinDamage, MaxDamage, Block, Description);

        }//end tostring
        public override int CalcBlock()
        {
            Random randy = new Random();
            return randy.Next(MinDamage, MaxDamage + 1);
        }

    }
}
