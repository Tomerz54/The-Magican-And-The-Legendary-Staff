using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tutorial
{

    class Wizard
    {
        
        string playOrNot;
        //player stats
        public int Level;
        public string name;
        public string favspell;
        public int spellsSlots;
        public float experiance;
        public int PotionsUsed;
        //enemy stats
        public float health;

        public static int Count;

        public Wizard(string _name, string _favspell)
        {
            Level = 1;
            name = _name;
            favspell = _favspell;
            spellsSlots = 10;
            experiance = 12.5f;
            health = 100;
            Count++;
            PotionsUsed = 8;
        }

        

        public void Continue()
        {
            Console.WriteLine("please type y to start or anything else to close");
            playOrNot = Console.ReadLine();
            if(playOrNot == "y")
            {
                Console.WriteLine("Start");
            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        public void UsePotion()
        {
            if (health <= 50)
            {
                health = health + 40;
                Console.WriteLine(name + "Has used a healing potion"+" And gained" + health+" HP");
                PotionsUsed--;
            }
            if(PotionsUsed < 0)
            {
                Console.WriteLine(name + "Has used all healing potions" + " And Has" + health + "HP");
                
            }
        }

        public void castSpell()
        {
            
            if (spellsSlots > 0)
            {
                Console.WriteLine(name + " casts " + favspell);
                spellsSlots--;
                experiance += 1;
            }
            if(spellsSlots<0)
            {
                Console.WriteLine(name + "couldnt cast the spell");
            }
            
        }

        public void medidate()
        {
            if (spellsSlots <= 4)
            {
                Console.WriteLine(name + " medidates");
                spellsSlots = 2;
            }
            
        }

        public void Ch2()
        {
            Console.WriteLine("the Wizard Continued is adventure \nto the castle" +
                " of mordor but it appears that he is in a forest ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("He continued venturing in the woods until suddenly");
            Console.WriteLine("------------------------------");
            Console.WriteLine("3 Goblins appeard from the bushes to ambush him");
            Console.WriteLine("the Wizard had no choice but to fight them");
        }
        public void Ch3()
        {
            Console.WriteLine("after the wizard defeated the 3 goblins");
            Console.WriteLine("he finally arrived to the castle gate");
            Console.WriteLine("------------------------------");
            Console.WriteLine("but there he encouterd a foe unlike anyone before");
            Console.WriteLine("The Dragon Lord Gurdian The Archlongion!");
            Console.WriteLine("------------------------------");
            Console.WriteLine("The wizard decided to fight it! ,becuase he new If he defeat's him he'll be able to enter the Castle of mordor!");
        }
    }
    
    class Enemy
    {
        public int attack;
        public string name;
        public int HP=100;
        public Enemy(string _name, int health)
        {
            
            name = _name;
            HP = health;
            attack = 10;
            
        }

        

    }

    class Gurdian
    {
        public string Swing_Attack = "Swing-Attack";
        public string FireBall_Attack = "Fire-Ball";
        public int Charges;
        public int attack;
        public string name;
        public int HP = 100;
        public Gurdian(string _name, int health)
        {

            name = _name;
            HP = health;
            attack = 10;
            Charges = 5;
            
        }

      

        
    }

    class THE_ROCK
    {
        public string Rock_Basic_Attack = "Rocking-Barrage";
        public string Special_Attack = "Eye Brow Raise";
        public string SpecialPlus_Attack = "ITS ABOUT DRIVE ITS ABOUT POWER";
        public string Rock_Interdimate_Attack = "Rocking SLAM";
        public int Charges;
        public int attack;
        public string name;
        public int HP = 100;

        public THE_ROCK(string _name, int health)
        {

            name = _name;
            HP = health;
            attack = 10;
            Charges = 5;

        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            int Deaths;
            bool AttackEnemyis;
            string AttackOrNot;
            Wizard wizard01 = new Wizard("Parry Hopper","4th dimension cast");
            Enemy enemy01 = new Enemy("Orc Axinus", 100);
            Enemy enemy02 = new Enemy("goblin sharmlok", 50);
            Enemy enemy03 = new Enemy("goblin shasmlok", 54);
            Enemy enemy04 = new Enemy("goblin shoshlok", 75);
            Gurdian boss = new Gurdian("DragonLord Gurdian", 250);
            THE_ROCK Rock = new THE_ROCK("THE ROCK", 500);
            Console.WriteLine("Your warrior stats");
            Console.WriteLine("Name = "+wizard01.name);
            Console.WriteLine("Level = " + wizard01.Level);
            Console.WriteLine("Health = " + wizard01.health);
            Console.WriteLine("exp = " + wizard01.experiance);
            Console.WriteLine("spells slots = " + wizard01.spellsSlots);
            Console.WriteLine("HPpotions=" + wizard01.PotionsUsed);
            //Play or exit

            wizard01.Continue();
            if (wizard01.health < 0)
            {
                Console.WriteLine(wizard01.name + "Has Lost");
            }

            //wizard01.castSpell();

            Console.WriteLine(wizard01.name + " is level " + wizard01.Level + " and " + "has gained " + wizard01.experiance + " exp " + "\nand has " + wizard01.spellsSlots + " spells slots and has " + wizard01.health + " Hp");
            Console.WriteLine("------------------------------");
            Console.WriteLine(enemy01.name + " will be your first enemy" + "\nhe has " + enemy01.HP+"HP");

            Console.WriteLine("------------------------------");
            //Attack Action from player
            while (enemy01.HP > 0)
            {
                if (wizard01.health < 0)
                {
                    Console.WriteLine("GAME OVER");
                    System.Environment.Exit(0);
                }

                wizard01.medidate();
                wizard01.UsePotion();
                Console.WriteLine("type 'a' to attack");
                AttackEnemyis = false;
                AttackOrNot = Console.ReadLine();
                if (AttackOrNot == "a")
                {
                    enemy01.HP = enemy01.HP - 25;
                    AttackEnemyis = true;
                    wizard01.spellsSlots--;

                }
                if (AttackEnemyis == true)
                {
                    wizard01.health = wizard01.health - 15;
                }
                Console.WriteLine("------------------------------");
                Console.WriteLine(wizard01.name + " has casted " + wizard01.favspell + " on " + enemy01.name + " he currently has " + enemy01.HP + "HP");
                Console.WriteLine("----------------");
                Console.WriteLine(wizard01.name + " got attacked by " + enemy01.name + " and currently has " + wizard01.health + " HP " + "\nand has " + wizard01.spellsSlots + " spells slots");
            }


            wizard01.experiance = wizard01.experiance + 50;
            if (wizard01.experiance > 60)
            {
                wizard01.Level = 3;
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("You won the battle and defeated: " + enemy01.name); 
            Console.WriteLine("------------------------------");
            Console.WriteLine(wizard01.name +" is level "+wizard01.Level+" and " + "has gained " + wizard01.experiance + " exp " + "\nand has " + wizard01.spellsSlots + " spells slots and has " + wizard01.health + " Hp");
            wizard01.Ch2();
            Console.WriteLine("FIGHT BEGINS");
            Console.WriteLine("------------------------------");
            Console.WriteLine(enemy02.name + "," + enemy03.name + "&" + enemy04.name + " will be your enemys");

            Deaths = enemy01.HP = 0;
            while (Deaths < 3)
            {
                if (wizard01.health < 0)
                {
                    Console.WriteLine("GAME OVER");
                    System.Environment.Exit(0);
                }

                wizard01.medidate();
                wizard01.UsePotion();
                Console.WriteLine("type 'a' to attack " + enemy02.name + "\ntype 'b' to attack " + enemy03.name + "\ntype 'c' to attack " + enemy04.name);
                Console.WriteLine("------------------------------");
                AttackEnemyis = false;
                AttackOrNot = Console.ReadLine();
                if (AttackOrNot == "a")
                {
                    enemy02.HP = enemy02.HP - 25;
                    if (enemy02.HP <= 0)
                    {
                        Console.WriteLine("------------------------------");
                        Console.WriteLine(enemy02.name + "Has been defeated");
                        AttackEnemyis = false;
                    }
                    AttackEnemyis = true;
                    wizard01.spellsSlots--;
                }
                if (AttackOrNot == "b")
                {
                    enemy03.HP = enemy03.HP - 27;
                    AttackEnemyis = true;

                    wizard01.spellsSlots--;
                    if (enemy03.HP <= 0)
                    {
                        Console.WriteLine("------------------------------");
                        Console.WriteLine(enemy03.name + "Has been defeated");
                        AttackEnemyis = false;
                    }
                }
                if (AttackOrNot == "c")
                {
                    enemy04.HP = enemy04.HP - 25;
                    AttackEnemyis = true;
                    wizard01.spellsSlots--;
                    if (enemy04.HP <= 0)
                    {
                        Console.WriteLine("------------------------------");
                        Console.WriteLine(enemy04.name + "Has been defeated");
                        AttackEnemyis = false;
                    }
                }
                if (AttackEnemyis == true)
                {
                    wizard01.health = wizard01.health - 20;
                }
                Console.WriteLine(wizard01.name + " has casted " + wizard01.favspell + " on " + enemy02.name + "," + enemy03.name + "&" + enemy04.name);
                if (enemy02.HP > 0)
                {
                    Console.WriteLine(enemy02.name + " Has " + enemy02.HP + " HP");
                }
                else
                {
                    Console.WriteLine(enemy02.name + "Has been defeated");
                }
                if (enemy03.HP > 0)
                {
                    Console.WriteLine(enemy03.name + " Has " + enemy03.HP + " HP");
                }
                else
                {
                    Console.WriteLine(enemy03.name + "Has been defeated");
                }
                if (enemy04.HP > 0)
                {
                    Console.WriteLine(enemy04.name + " Has " + enemy04.HP + " HP");
                }
                else
                {
                    Console.WriteLine(enemy04.name + "Has been defeated");
                }

                if (enemy02.HP <= 0 & enemy03.HP <= 0 & enemy04.HP <= 0)
                {
                    Deaths = Deaths + 3;

                }

            }

            wizard01.experiance = wizard01.experiance + 150;
            if (wizard01.experiance > 150)
            {
                wizard01.Level = 7;
            }
            wizard01.spellsSlots = wizard01.spellsSlots + 8;
            wizard01.PotionsUsed = wizard01.PotionsUsed + 8;
            wizard01.health = wizard01.health + 50;

            Console.WriteLine("--------------------------");
            Console.WriteLine("YOU WON THE BATTLE");
            Console.WriteLine(wizard01.name +" is level "+ wizard01.Level +" has gained " + wizard01.experiance + " exp " + "\nalso has " + wizard01.spellsSlots +
                " spells slots left and has " + wizard01.health + " Hp "+"and has "+wizard01.PotionsUsed+" Heal Potions Left");
            Console.WriteLine("--------------------------");
            wizard01.Ch3();
            Console.WriteLine("Mini Boss - FIGHT BEGINS");
            Console.WriteLine("The " + boss.name + " stats:");
            Console.WriteLine("HP:" + boss.HP);

            while (boss.HP > 0)
            {
                Console.WriteLine("------------------------------");
                if (wizard01.health < 0)
                {
                    Console.WriteLine("GAME OVER");
                    System.Environment.Exit(0);
                }

                wizard01.medidate();
                wizard01.UsePotion();

                Console.WriteLine("type 'a' to attack");
                AttackEnemyis = false;
                AttackOrNot = Console.ReadLine();
                if (AttackOrNot == "a")
                {
                    boss.HP = boss.HP - 30;
                    AttackEnemyis = true;
                    wizard01.spellsSlots--;

                }

                if (AttackEnemyis == true)
                {
                    wizard01.health = wizard01.health - 10;
                }
                if (boss.HP < 130 & boss.HP > 100)
                {
                    Console.WriteLine(boss.name + " Has Just Used " + boss.Swing_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    boss.Charges--;
                    wizard01.health = wizard01.health - 20;
                }
                if (boss.HP < 250 & boss.HP >= 220)
                {
                    Console.WriteLine(boss.name + " Has Just Used " + boss.Swing_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    boss.Charges--;
                    wizard01.health = wizard01.health - 20;
                }

                if (boss.HP <= 185 & boss.HP >= 150)
                {
                    Console.WriteLine(boss.name + " Has Just Used " + boss.FireBall_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    boss.Charges--;
                    wizard01.health = wizard01.health - 50;
                }
                if (boss.HP <= 100 & boss.HP >= 70)
                {
                    Console.WriteLine(boss.name + " Has Just Used " + boss.FireBall_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    boss.Charges--;
                    wizard01.health = wizard01.health - 20;
                }
                if (boss.HP <= 50 & boss.HP > 0)
                {
                    Console.WriteLine(boss.name + " Has Just Used " + boss.FireBall_Attack+" and damaged "+wizard01.name+" he has "+wizard01.health+" Hp");
                    boss.Charges--;
                    wizard01.health = wizard01.health - 30;
                }

                if (boss.Charges< 0)
                {
                    Console.WriteLine(boss.name + " Couldn't use " + boss.FireBall_Attack);
                }

                Console.WriteLine("------------------------------");
                Console.WriteLine(wizard01.name + " has casted " + wizard01.favspell + " on " + boss.name);
                if (boss.HP > 0)
                {
                    Console.WriteLine(boss.name + " Has " + boss.HP + " HP");
                }
                else
                {
                    Console.WriteLine(boss.name + "Has been defeated");
                }
                Console.WriteLine("----------------");
                Console.WriteLine(wizard01.name + " got attacked by " + boss.name + " and currently has " + wizard01.health + " HP " + "\nand has " + wizard01.spellsSlots + " spells slots");

            }

            wizard01.experiance = wizard01.experiance + 400;
            if (wizard01.experiance > 480)
            {
                wizard01.Level = 21;
            }
            wizard01.spellsSlots = wizard01.spellsSlots + 8;
            wizard01.PotionsUsed = wizard01.PotionsUsed + 5;
            wizard01.health = 350; 

            Console.WriteLine("------------------------------");
            Console.WriteLine("YOU WON THE BATTLE AND DEFEATED: " + boss.name);
            Console.WriteLine("------------------------------");
            Console.WriteLine(wizard01.name + " is level " + wizard01.Level + " and " + " has gained " + wizard01.experiance + " exp " + "\nand has " + wizard01.spellsSlots + " spells slots and has " + wizard01.health + " Hp");
            Console.WriteLine("You shall now Enter the gates of mordor");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Type 'c' to continue");
            AttackOrNot = Console.ReadLine();
            if (AttackOrNot == "c")
            {
                Console.WriteLine("The magican has finally reached the Legendary Staff");
                Console.WriteLine("Until suddenly he heard a loud Roar");
                Console.WriteLine("wait what is it there...");
                Console.WriteLine("IS THAT THE ROCK??!!");
            }
            else
            {
                System.Environment.Exit(0);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Type 'c' to continue");
            AttackOrNot = Console.ReadLine();
            if(AttackOrNot == "c")
            {
                Console.WriteLine("Yes it is THE ROCK");
                Console.WriteLine("And It seems he's protecting the Legendary sword");
                Console.WriteLine("What would our magican do?");
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Type 'c' to continue");
            AttackOrNot = Console.ReadLine();
            if (AttackOrNot == "c")
            {
                Console.WriteLine(wizard01.name + " Has decided...");
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Type 'c' to continue");
            AttackOrNot = Console.ReadLine();
            if (AttackOrNot == "c")
            {
                Console.WriteLine("To fight THE ROCK");
                Console.WriteLine("LETS GO - FIGHT BEGINS");
            }

            Console.WriteLine("BOSS - FIGHT BEGINS");
            Console.WriteLine("The " + Rock.name + " stats:");
            Console.WriteLine("HP:" + Rock.HP);

    
            while (Rock.HP > 0)
            {
               
                if (wizard01.health < 0)
                {
                    Console.WriteLine("GAME OVER");
                    System.Environment.Exit(0);
                }

                wizard01.medidate();
                wizard01.UsePotion();
                Console.WriteLine("type 'a' to attack");
                AttackEnemyis = false;
                AttackOrNot = Console.ReadLine();
                if (AttackOrNot == "a")
                {
                    Rock.HP = Rock.HP - 50;
                    AttackEnemyis = true;
                    wizard01.spellsSlots--;

                }


                //While Loop

                
                if (Rock.HP<500 & Rock.HP>=470)
                {
                    Console.WriteLine(Rock.name + " Has Just Used " + Rock.Rock_Basic_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    Rock.Charges--;
                    wizard01.health = wizard01.health - 20;
                    Console.Write("----------------------------");
                }
                if (Rock.HP <= 450 & Rock.HP >=300)
                {
                    Console.WriteLine(Rock.name + " Has Just Used " + Rock.Rock_Interdimate_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    Rock.Charges--;
                    wizard01.health = wizard01.health - 50;
                    Console.Write("----------------------------");
                }
                if (Rock.HP <= 300 & Rock.HP >=370)
                {
                    Console.WriteLine(Rock.name + " Has Just Used " + Rock.SpecialPlus_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    boss.Charges--;
                    wizard01.health = wizard01.health - 30;
                    Console.Write("----------------------------");
                }
                if (Rock.HP <= 360 & Rock.HP >=310)
                {
                    Console.WriteLine(Rock.name + " Has Just Used " + Rock.Special_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    Rock.Charges--;
                    wizard01.health = wizard01.health - 30;
                    Console.Write("----------------------------");
                }
                if (Rock.HP <= 300 & Rock.HP >=270)
                {
                    Console.WriteLine(Rock.name + " Has Just Used " + Rock.Rock_Basic_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    Rock.Charges--;
                    wizard01.health = wizard01.health - 30;
                    Console.Write("----------------------------");
                }
                if (Rock.HP <= 250 & Rock.HP >=210)
                {
                    Console.WriteLine(Rock.name + " Has Just Used " + Rock.Special_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    Rock.Charges--;
                    wizard01.health = wizard01.health - 30;
                    Console.Write("----------------------------");
                }
                if (Rock.HP <= 175 & Rock.HP >=140)
                {
                    Console.WriteLine(Rock.name + " Has Just Used " + Rock.SpecialPlus_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    Rock.Charges--;
                    wizard01.health = wizard01.health - 30;
                    Console.Write("----------------------------");
                }
                if (Rock.HP <= 135 & Rock.HP >= 100)
                {
                    Console.WriteLine(Rock.name + " Has Just Used " + Rock.Rock_Interdimate_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    Rock.Charges--;
                    wizard01.health = wizard01.health - 30;
                    Console.Write("----------------------------");
                }
                if (Rock.HP <= 80 & Rock.HP >= 40)
                {
                    Console.WriteLine(Rock.name + " Has Just Used " + Rock.Rock_Basic_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    Rock.Charges--;
                    wizard01.health = wizard01.health - 30;
                    Console.Write("----------------------------");
                }
                if (Rock.HP <= 35 & Rock.HP > 0)
                {
                    Console.WriteLine(Rock.name + " Has Just Used " + Rock.Special_Attack + " and damaged " + wizard01.name + " he has " + wizard01.health + " Hp");
                    Rock.Charges--;
                    wizard01.health = wizard01.health - 30;
                    Console.Write("----------------------------");
                }


                
                Console.WriteLine("------------------------------");
                Console.WriteLine(wizard01.name + " has casted " + wizard01.favspell + " on " + Rock.name);
                if (Rock.HP > 0)
                {
                    Console.WriteLine(Rock.name + " Has " + Rock.HP + " HP");
                }
                else
                {
                    Console.WriteLine(Rock.name + " HAS BEEN DEFEATED!!!");
                }
                
            }
            Console.WriteLine(wizard01.name + "is level " + wizard01.Level + " and " + " has gained " + wizard01.experiance + " exp " + "\nand has " + wizard01.spellsSlots + " spells slots and has " + wizard01.health + " Hp");
            wizard01.experiance = wizard01.experiance + 1000;
            if (wizard01.experiance > 1000)
            {
                wizard01.Level = 100;
            }
            wizard01.spellsSlots = wizard01.spellsSlots + 10;
            wizard01.PotionsUsed = wizard01.PotionsUsed + 10;
            wizard01.health = 1000;
            Console.WriteLine("GAME COMPLETED");



            //Story ENDING
            Console.WriteLine("Type 'c' to continue");
            AttackOrNot = Console.ReadLine();
            if (AttackOrNot == "c")
            {
                Console.WriteLine("Oh Shit I cant believe it " + wizard01.name + " actually defeated THE ROCK ");
                Console.WriteLine("And so...");
                Console.WriteLine(wizard01.name + " Has Gotten The Legendary Magic Staff");

            }
            Console.WriteLine("Type 'c' to continue");
            AttackOrNot = Console.ReadLine();
            if (AttackOrNot == "c")
            {
                Console.WriteLine(wizard01.name + ":" + " So Thats how the story ends Huh?");
                Console.WriteLine(wizard01.name + ":" + " With This staff I would be able to rule THE WORLD!!");
                Console.WriteLine("And Thats how " + wizard01.name + " has come to be The True Villan of this word");
                Console.WriteLine("After Taking Out " + Rock.name+"......");

            }
            Console.WriteLine("Type 'c' to continue");
            AttackOrNot = Console.ReadLine();
            if (AttackOrNot == "c")
            {
                Console.WriteLine("T H E");
                Console.WriteLine("E N D");
            }
            Console.ReadKey();

        }

        

    }
}


