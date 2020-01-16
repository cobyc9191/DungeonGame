using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            //ger a random number from 1-100 for our dice roll

            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(30);
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //calculate damage
                int damageDealt = attacker.CalcDamage();
                //write the result to the screen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name,
                    defender.Name, damageDealt);
                Console.ResetColor();

            }//end if
            else{ Console.WriteLine("Attacker Missed (sad Trombone)", attacker.Name);
            }//end else


        }//end Main()
        public static void DoBattle(Player player, Monster monster)
        { DoAttack(player, monster);
            if (monster.Life>0)
            { DoAttack(monster, player);
            }
        }

    }//end class
}//end namespace
