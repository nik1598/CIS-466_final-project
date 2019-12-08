using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonsterBattle_FinalProject
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);

            } while (result != "3");

            Console.WriteLine(" Good Bye...");
        }
        public static string DisplayMenu()
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hero Monster Battle");
            Console.WriteLine("");
            Console.WriteLine("Hit [1] to start a new battle!");
            Console.WriteLine("Hit [2] to edit stats before starting a new battle!");
            


            Console.WriteLine("");
            Console.WriteLine("Hit [3]: Exit;");
            Console.WriteLine("");
            Console.WriteLine("");

            var result = Console.ReadLine();
            return result;
        }
        private static bool Run(string exeArg)
        {

            switch (exeArg.ToLower())
            {

                case "1":
                    Battle();
                    Console.ReadLine();
                    Console.Clear();
                    return true;

                case "2":
                    BattleEditStats();
                    Console.ReadLine();
                    Console.Clear();
                    return true;


                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }

        private static void performAttack(Character hero, Character monster, Dice dice)
        {
            // Perform the battle loop to the death.
            while (hero.Health > 0 && monster.Health > 0)
            {
                int heroDamage = hero.Attack(dice);             
                int monsterDamage = monster.Attack(dice);       
                hero.Health = hero.Defend(monsterDamage);
                monster.Health = monster.Defend(heroDamage);
                showDamage(monsterDamage, heroDamage);
            }
         
        }
        public static void Battle() // Acts like a main method, that's why it is over 6 lines
        {
           // Setting properties for our hero
            Character hero = new Character();
            hero.Name = "Hero";
            hero.Health = 30;
            hero.DamageMaximum = 20;
            hero.AttackBonus = 5;

            //Setting properties for our monster
            Character monster = new Character();
            monster.Name = "Monster";
            monster.Health = 25;
            monster.DamageMaximum = 18;
            monster.AttackBonus = 5;

            Dice dice = new Dice();
            ShowStats(hero);
            ShowStats(monster);
            Console.WriteLine();
            performAttack(hero, monster, dice);
            Console.WriteLine("***************************************");
            DisplayResult(hero, monster);
            Console.WriteLine("***************************************");

        }
        public static void BattleEditStats() //Acts like a main method, that's why it is over 6 lines
        {
            Dice dice = new Dice();
            Character monster = new Character();
            monster.Name = "Monster";
            Character hero = new Character();
            hero.Name = "Hero";
            editStats(hero);
            Console.WriteLine();
            editStats(monster);
            Console.WriteLine();
            performAttack(hero, monster, dice);
            Console.WriteLine("***************************************");
            DisplayResult(hero, monster);
            Console.WriteLine("***************************************");
        } 
        public static void DisplayResult(Character opponent1, Character opponent2)
        {
            if (opponent1.Health > 0 && opponent2.Health <= 0)
                Console.WriteLine($"{opponent1.Name} lived and {opponent2.Name} died.");
            else if (opponent1.Health <= 0 && opponent2.Health > 0)
                Console.WriteLine($"{opponent1.Name} died and {opponent2.Name} lived.");
            else
                Console.WriteLine($"Both {opponent1.Name} and {opponent2.Name} died.");
        }
        public static void ShowStats(Character character)
        {
            Console.WriteLine($"Name: {character.Name.ToString()} - " +
                $"Health: {character.Health.ToString()} - " +
                $"DamageMaximum: {character.DamageMaximum.ToString()} - " +
                $"AttackBonus: {character.AttackBonus.ToString()}");
        }
        public static void showDamage(int monsterDmg, int heroDMG)
        {
            Console.WriteLine($"The monster hit the hero for {monsterDmg}  damage points");
            Console.WriteLine($"The hero hit the monster for {heroDMG} damage points");
            Console.WriteLine();
        }
        public static void editStats(Character character) 
        {
            Console.WriteLine($"Enter {character.Name}'s health: ");
            character.Health = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {character.Name}'s maximum damage: ");
            character.DamageMaximum = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {character.Name}'s attack bonus: ");
            character.AttackBonus = int.Parse(Console.ReadLine());
            

        }
    }
}
