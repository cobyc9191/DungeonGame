using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player:Character
    {
        //fields
        //private int _life;

        //properties
        //public string Name { get; set; }
        //public int HitChance { get; set; }
        //public int Block { get; set; }
        //public int MaxLife { get; set; }
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        //you cannot have business rules with an automatic property
        //public int Life
        //{
        //    get { return _life; }
        //    set
        //    {
        //        if (value <= MaxLife)
        //        {
        //            _life = value;
        //        }//end if
        //        else
        //        {
        //            _life = MaxLife;
        //        }// end else

        //    }//end set
        //}//end life

        //constructores
        public Player(string name, int hitChance, int block, int Maxlife, Race characterRace, Weapon equippedWeapon, int life)
        {
            MaxLife = MaxLife;
            HitChance = hitChance;
            Name = name;
            Block = block;
            MaxLife = MaxLife;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
        }
        //methods
        public override string ToString()
        {
            string description = "";
            switch (CharacterRace)
            {
                case Race.Orc:
                    description = "";
                    break;
                case Race.Human:
                    description = "";
                    break;
                case Race.Argonian:
                    description = "";
                    break;
                case Race.Hobbits:
                    description = "";
                    break;
                case Race.Elf:
                    description = "";
                    break;
                case Race.Dwarf:
                    description = "";
                    break;
                case Race.Giant:
                    description = "";
                    break;
            }   //END swithc

            return string.Format("\n Name: {0}\n Life:{1} of {2}\nHitChance: {3}%\nWeapon:\n{4}\nDescription: {5}", Name, Life, MaxLife, HitChance, EquippedWeapon, description);
           } //tostring  
        //overriding  the CalcDamage() in player to use their EquippedWeapons properties of minDamage and maxdamage

        public override int CalcDamage()
        {
            //return base.CalcDamage();   commenting out so that we dont return 0
            Random randy = new Random();

            //determine damage
            //int damage = randy.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return (new Random()).Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);


        }//end calcDamage


        public override int CalcHitChance()
        {
            //return base.CalcHitChance();
            return HitChance + EquippedWeapon.BonusDamage;
        }//end CalcHitChance


    }
}
