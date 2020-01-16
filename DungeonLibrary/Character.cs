using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {//the abstract modifier indicates that the thing being modified has an incomplete implenmentation. the abstract modifier
        //can be used with classes, methods, and properties. use the abstract modifier in a class declarationto indicate that the
        //class is only intended to be a base (parent) class of other classes

        private int _life;
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }//end if
                else
                {
                    _life = MaxLife;
                }// end else

            }  //end set

        }//endlife
                //constructors 
                //since we don't inherit constructors and we already did a lof of work defining the player FQCTOR, we will not create a CTOR here
                //we still get the free default one, but we will be unable to use it since this calss is abstract.

            //methods

            //there is no need to override the tostring here since we will never create a character object. it will always be a player or monster.

        public virtual int CalcBlock()
        { return Block; }//end CalcBlock()
                         //mini lab make the CalcHitChance() and return HitChance
                         //make it overridable
        public virtual int CalcHitChance()
        { return HitChance; }//end calchitchance()

        public virtual int CalcDamage()
        { return 0; }//end calcDamage()
        //starting this with returnign 0 becuase we will override the method in moster and player.




   
    }//end class
}//end namespace
