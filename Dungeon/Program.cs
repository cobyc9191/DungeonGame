using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using MonsterLibrary;

namespace Dungeon
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dungeon of Tommorrow";
            Console.WriteLine("WELCOME TO THE DUNGEON OF TOMORROOOWWW!!!");
            //todo create player
            Weapon sword = new Weapon("Sword of Poop", 35, 45, 75, false);
            Player player = new Player("Neil", 80,40, 75, Race.Elf, sword, 75);
            //todo create do While
            bool exit = false;

            do
            {
                //todo create a room
                Console.WriteLine(GetRoom());
                //todo create monster
                Dragon d1 = new Dragon();
                Dragon d2 = new Dragon("Undead Dragon", 25, 25, 25, 50, 20, 2, " its bones are melting away", true);
                Yeti y1 = new Yeti();
                HeWhoShallNotBeNamed h1 = new HeWhoShallNotBeNamed();
                Gargoyles g1 = new Gargoyles();
                Shredder s1 = new Shredder();
                Kraken k1 = new Kraken();
                Frankenstein f1 = new Frankenstein();
                CookieMonster c1 = new CookieMonster();
                bool reload = false;
                Monster[] monsters =
                    {
                    d2,s1,d1,d1,y1,g1,g1,g1,g1,c1,c1,c1,c1,f1,f1,f1,k1,k1,h1,h1,y1,y1,d1,d1,d2,d1
                      };

                Random rand = new Random();
                Monster monster = monsters[rand.Next(monsters.Length)];

                Console.WriteLine("\n in this room: " + monster.Name);
                do
                {
                    //todo menu of choice
                    #region MENU

                    Console.WriteLine(
"PLEASE CHOOSE AN ACTION:\n\n" +

"\nA) Attack" +
"\nR) RUN AWAY" +
"\nC) Character Info" +
"\nM) monster Info" +
"\nX) Exit" +
"\nEnter your choice: ");
                    //todo catch the unser input
                    string userChoice = Console.ReadLine().ToUpper();


                    //todo switch for user choice
                    switch (userChoice)
                    {
                        case "A":
                            // Console.WriteLine("Attack method goes here");
                            //todo handle if player wins
                            //todo handle if player loses
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {

                                Console.WriteLine("\n you defrated a {0}", monster.Name);
                                reload = true;
                            }
                            break;
                        case "R":
                            Console.WriteLine("RUN AWAY!!!");
                            //todo monster gers a free attack
                            //todo load a new room
                            Combat.DoAttack(monster, player); //free attack
                            reload = true;

                            break;
                        case "C":
                            Console.WriteLine("Character info");
                            //todo add players info to the screen
                            Console.WriteLine(player);
                            break;
                        case "M":
                            Console.WriteLine("monster info");
                            Console.WriteLine(monster);
                            break;
                        case "X":
                        case "E":
                            Console.WriteLine("ya ninny");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("invalid choice. ya ninny!! try again");
                            break;
                    }//end switch

                    #endregion
                    //todo:address players life
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("uhhh I got some bad news for you...you died\a");
                        exit = true;
                    }

                } while (!reload && !exit);
            } while (!exit);




        }//end Main()
  








private static string GetRoom()
        {
            string[] rooms =
            {@"you are in a darkly lit room with a small puddle in the corner, the smell resembles urine and fecle matter",
            @"Thick cobwebs fill the corners of the room, and wisps of webbing hang from the ceiling and waver in a 
wind you can barely feel. One corner of the ceiling has a particularly large clot of webbing within 
which a goblin'sbones are tangled.",
            @" you see a small room lined with dusty shelves, crates, and barrels. It looks like someone once used 
this place as a larder, but it has been a long time since anyone came to retrieve food from it.","The walls bear scratch marks and lines of soot that form crude pictures and what looks like words in some language "," A huge stewpot hangs from a thick iron tripod over a crackling fire in the center of this chamber. A hole in the ceiling allows some of the smoke from the fire to escape, but much of it expands across the ceiling and rolls down to fill the room in a dark fog.",


            };
            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;


        }
    }//end Class
}//end namespace
