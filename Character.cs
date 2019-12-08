using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonsterBattle_FinalProject
{
    class Character 
    {
        // adding properties
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public int AttackBonus { get; set; }

        public Character() //Default constructer
        {
        } 

        public Character(string name, int health, int damageMaximum,  int attackBonus)
        {
            Name = name;
            Health = health;
            DamageMaximum = damageMaximum;
            AttackBonus = attackBonus;
        }

        public int Attack(Dice dice)
        {
            dice.Sides = DamageMaximum;     // Setting the Sides property to the maximum amount of damage.
            int damageAmount = dice.Roll(); // Getting the damage amount based on a random number. 1 - damage max.
            return damageAmount;
        }

        public int Defend(int damage )
        {
            // Use a 10 sided die
            Dice dice = new Dice();
            dice.Sides = 10;
            int bonusAttack = dice.Roll();

            // Both the hero and monster have a 20% chance to hit a bonus attack
            if (bonusAttack > 8) 
                return this.Health - (damage + AttackBonus);
            else
                return this.Health - damage;
        }

        
    }
}
