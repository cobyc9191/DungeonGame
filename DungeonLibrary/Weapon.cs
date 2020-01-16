using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //fields
        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private int _bonusDamage;
        private bool _isTwoHanded;

        //properties
        public string Name
        { get { return _name; } set { _name = value; } }
        public int MaxDamage
        { get { return _maxDamage; } set { _maxDamage = value; } }
        public int BonusDamage
        { get { return _bonusDamage; } set { _bonusDamage = value; } }
        public bool IsTwoHanded
        { get { return _isTwoHanded; } set { _isTwoHanded = value; } }
        public int MinDamage
        { get { return _minDamage; }set { if(value>0 && value <= MaxDamage)
                { _minDamage = value; }
                else
                { _minDamage = 1; }
            }
        }

        //constructors
        public Weapon() { }
        public Weapon(string name, int minDamage, int maxDamage, int bonusDamage, bool isTwoHanded)
        { name = Name;
            MaxDamage = maxDamage;
            MinDamage = maxDamage;
            BonusDamage = bonusDamage;
            IsTwoHanded = isTwoHanded;
        }//end Weapon
        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage \n Bonus Hit: {3}%\t{4}",
                Name,
                MinDamage,
                MaxDamage,
                BonusDamage,
                IsTwoHanded==true ? "Two-Handed" : "One-Handed");
        }//end ToString() override

        //methods
    }//end class
}//namespace
