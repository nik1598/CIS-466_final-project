using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonsterBattle_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //Setting properties for our hero
            Character hero = new Character();
            hero.Name = "Hero";
            hero.Health = 100;
            hero.DamageMaximum = 20;
            hero.AttackBonus = false;

            //Setting properties for our monster
            Character monster = new Character();
            monster.Name = "Monster";
            monster.Health = 100;
            monster.DamageMaximum = 18;
            monster.AttackBonus = false;

            Dice dice = new Dice();

            ShowStats(hero); //Shows the stats of the hero
            ShowStats(monster); //Shows the stats of the monster

            DisplayResult(hero, monster); //Shows the outcome of the battle

            Console.ReadLine();
            
        }

        //Displays the stats of the hero or monster 
        public static void ShowStats(Character character) 
        {
            Console.WriteLine($"Name: {character.Name.ToString()} - " +
                $"Health: {character.Health.ToString()} - " +
                $"DamageMaximum: {character.DamageMaximum.ToString()} - " +
                $"AttackBonus: {character.AttackBonus.ToString()}");
        }

        //Displays the outcome of the battle based upon hero and monster health
        public static void DisplayResult(Character opponent1, Character opponent2) 
        {
            if (opponent1.Health > 0 && opponent2.Health <= 0)
                Console.WriteLine($"{opponent1.Name} lived and {opponent2.Name} died.");
            else if (opponent1.Health <= 0 && opponent2.Health > 0)
                Console.WriteLine($"{opponent1.Name} died and {opponent2.Name} lived.");
            else
                Console.WriteLine($"Both {opponent1.Name} and {opponent2.Name} died.");
        }

    }
}
